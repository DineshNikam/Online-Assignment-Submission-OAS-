using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace oas
{
    public partial class TeacherPanel : Form
    {
        login_fm lg = new login_fm();
        string selectassignment = "SELECT assignment_id, course_id, title, instruction, start_date, end_date, marks_out_of FROM oas.assignment where teacher_id ='" + login_fm.ID + "';";
        public string mainfile = "";
        public string Ass = "";
        MySqlDataReader reader;
        public TeacherPanel()
        {
            InitializeComponent();
        }
        private void TeacherPanel_Load(object sender, EventArgs e)
        {
           


            profileLabel.Text = "Hello, " + login_fm.NAME + " ";
            this.Loaddata(selectassignment);

            sidepanel.Height = AssignmentbuttonTeacherPanel.Height;
            sidepanel.Top = AssignmentbuttonTeacherPanel.Top;
            assignmentPanel.Visible = true;
            submissionpanel.Visible = false;
            assignmentPanel.BringToFront();
        }

        public void TeacherPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            login_fm.ID = "";
            login_fm.NAME = "";

            Application.Exit();
        }

        private void buttonAssignmentTeacherPanel_Click(object sender, EventArgs e)
        {

            sidepanel.Height = AssignmentbuttonTeacherPanel.Height;
            sidepanel.Top = AssignmentbuttonTeacherPanel.Top;
            assignmentPanel.Visible = true;
            submissionpanel.Visible = false;
            assignmentPanel.BringToFront();
        }

        private void submissionbtn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = submissionbtn.Height;
            sidepanel.Top = submissionbtn.Top;
            assignmentPanel.Visible = true;
            submissionpanel.Visible = true;
            submissionpanel.BringToFront();
          string sub = "select course_id, course_name from course natural join teacher_has_course where"+ 
                     "  teacher_has_course.teacher_id = " + Convert.ToInt32(login_fm.ID)+"";
            LoaddataSubject(sub);
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            sidepanel.Height = LogOut.Height;
            sidepanel.Top = LogOut.Top;
            login_fm.ID = "";
            login_fm.NAME = "";
            login_fm lg = new login_fm();
            lg.Show();
            this.Hide();
        }
        public string getAssignmentId()
        {
            string query = "SELECT assignment_id FROM oas.assignment order by assignment_id desc limit 1; ";
            string assignment_id = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();


                    MySqlDataAdapter ad = new MySqlDataAdapter(query, connection);

                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {

                        assignment_id = dt.Rows[0][0].ToString();

                        return assignment_id;


                    }
                    else if (dt.Rows.Count == 0)
                    {
                        return "401";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "NotWorking";

        }

        public byte[] UploadFile(string file)
        {
            

                    FileStream fstream = File.OpenRead(file);
                    byte[] contents = new byte[fstream.Length];
                    fstream.Read(contents, 0, (int)fstream.Length);
                    fstream.Close();
                return contents;
                    

            
        }

        private void uploadbtnassignment_Click(object sender, EventArgs e)
        {
          
        }

 

        private void Loaddata(string que)
        {
            using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                var query = que;
                MySqlDataAdapter adap = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                //DataTable dt = new DataTable();
                adap.Fill(ds);

                assignmentDataGridView.DataSource = ds.Tables[0].DefaultView;

            }
        }



   

        private void assignmentDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = assignmentDataGridView.Rows[e.RowIndex];
                assignment_idTextbox.Text= dgvRow.Cells[0].Value.ToString();
                course_idTextBox.Text = dgvRow.Cells[1].Value.ToString();
                titleTextBox.Text = dgvRow.Cells[2].Value.ToString();
                instructionTextBox.Text = dgvRow.Cells[3].Value.ToString();
                start_dateDateTimePicker.Text = dgvRow.Cells[4].Value.ToString();
                end_dateDateTimePicker.Text = dgvRow.Cells[5].Value.ToString();
                marks_out_ofTextBox.Text = dgvRow.Cells[6].Value.ToString();


                // string que = "SELECT course_name  FROM oas.course where course_id in (select course_id from oas.student_has_course" +
                //   " where student_id = '" + dgvRow.Cells[0].Value.ToString() + "' ); ";
                // LoadCourseStudent(que);



            }
        }

        private void InsertBtnAdmin_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                if (mainfile != string.Empty)
                {
                    connection.Open();
                    FileStream fstream = File.OpenRead(mainfile);
                    byte[] contents = new byte[fstream.Length];
                    fstream.Read(contents, 0, (int)fstream.Length);
                    fstream.Close();
                    //MessageBox.Show(contents.ToString());
                    string assignment = "";
                    assignment=getAssignmentId();

                    string query = "INSERT INTO `oas`.`assignment` (`assignment_id`, `teacher_id`, `course_id`," +
                        " `title`, `instruction`, `start_date`, `end_date`, `marks_out_of`, `files`) VALUES " +
                        "( '" + (Convert.ToInt32(assignment)+1) + "','" + Convert.ToInt32(login_fm.ID) + "', '" + course_idTextBox.Text + "'," +
                        " '"+titleTextBox.Text+"', '"+instructionTextBox.Text+"', '"+start_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                        " '"+end_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss") +"', '"+marks_out_ofTextBox.Text+"',@files);";

                    
                 



                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@files", contents);

                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        label1.Text = "successful";
                    }

                }
                else
                {
                    MessageBox.Show("upload a file");
                }
                mainfile = "";
                Loaddata(selectassignment);
            }
        }

        private void UpdateBtnAdmin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                if (mainfile != string.Empty)
                {
                    connection.Open();
                    FileStream fstream = File.OpenRead(mainfile);
                    byte[] contents = new byte[fstream.Length];
                    fstream.Read(contents, 0, (int)fstream.Length);
                    fstream.Close();

                    //UPDATE `oas`.`assignment` SET `course_id` = '302', `title` = 'vijay', `instruction` = 'sa', `start_date` = '2020-11-23 14:35:03', `end_date` = '2020-11-23 14:35:03', `marks_out_of` = '33', `files` = ? WHERE (`assignment_id` = '403') and (`teacher_id` = '101') and (`course_id` = '301');

                    string query = "UPDATE `oas`.`assignment` SET `course_id` = '" + course_idTextBox.Text + "', `title` = '" + titleTextBox.Text + "', " +
                        "`instruction` = '" + instructionTextBox.Text + "', `start_date` = '" + start_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', `end_date` = '" + end_dateDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                        " `marks_out_of` = '" + marks_out_ofTextBox.Text + "', `files` = @files WHERE (`assignment_id` = '" + assignment_idTextbox.Text + "') and (`teacher_id` = '" + Convert.ToInt32(login_fm.ID) + "') and" +
                        " (`course_id` = '" + course_idTextBox.Text + "');";







                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@files", contents);


                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        label1.Text = "successful";
                    }

                }
                else
                {
                    MessageBox.Show("upload a file");
                }
                mainfile = "";
                Loaddata(selectassignment);
            }
        }

        
        private void DeleteBtnAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    string query = "delete from submission where teacher_id ="+Convert.ToInt32(login_fm.ID)+" and assignment_id = " + assignment_idTextbox.Text+";";
                    cmd.CommandText = query;
                    var d =cmd.ExecuteNonQuery();
                    MessageBox.Show("complete with d= "+d+"");


                    query = "delete from assignment where teacher_id =" + Convert.ToInt32(login_fm.ID) + " and assignment_id = " + assignment_idTextbox.Text + "; ";
                    cmd.CommandText = query;
                    var result = cmd.ExecuteNonQuery();

       
                 

                    if (result == 1)
                    {
                        label1.Text = "successful";
                    }

                }
             
            }
            catch
            {

            }
                mainfile = "";
                Loaddata(selectassignment);
            }

        private void uploadbtnassignment_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "text file (*.pdf) | *.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // DialogResult dialog=MessageBox.Show("Do you want to upload")
                    string filename = dlg.FileName;
                    uploadTextbox.Text = filename;
                    mainfile = filename;
                    MessageBox.Show(mainfile);
                }
            }
        }

        #region avyai
        private void start_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void assignment_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void course_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void course_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void marks_out_ofLabel_Click(object sender, EventArgs e)
        {

        }

        private void marks_out_ofTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructionLabel_Click(object sender, EventArgs e)
        {

        }

        private void instructionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uploadTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void assignment_idTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region submission
        #endregion

        private void SubjectdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = SubjectdataGridView.Rows[e.RowIndex];
                string s = dgvRow.Cells[0].Value.ToString();

        
                string que = "select  assignment_id,title,instruction,start_date,end_date,marks_out_of from assignment where" +
                    " course_id =  "+Convert.ToInt32(s)+ " and teacher_id = " + Convert.ToInt32(login_fm.ID) + ";";
                LoaddataAssignment(que);



            }
        }
        private void LoaddataSubject(string que)
        {
            using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                var query = que;
                MySqlDataAdapter adap = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                //DataTable dt = new DataTable();
                adap.Fill(ds);

                SubjectdataGridView.DataSource = ds.Tables[0].DefaultView;

            }
        }

        private void AssignmentdataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = AssignmentdataGridView2.Rows[e.RowIndex];
                string s = dgvRow.Cells[0].Value.ToString();
                Ass = dgvRow.Cells[0].Value.ToString();
                //MessageBox.Show(s);
                ShowAll.Checked = true;
                string que = "select   student_id, status,  submission_date, feedback, marks, assignment_id  from submission " +
                    "where assignment_id = "+Convert.ToInt32(s)+" ;";
                LoaddataSubmission(que);



            }
        }

       

        private void LoaddataAssignment(string que)
        {
            using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                var query = que;
                MySqlDataAdapter adap = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                //DataTable dt = new DataTable();
                adap.Fill(ds);

                AssignmentdataGridView2.DataSource = ds.Tables[0].DefaultView;

            }
        }

        private void SubmissionsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = SubmissionsdataGridView.Rows[e.RowIndex];
           
                student_idTextBox.Text =     dgvRow.Cells[0].Value.ToString();
                submission_dateDateTimePicker.Text =         dgvRow.Cells[2].Value.ToString();
                marksTextBox.Text =             dgvRow.Cells[4].Value.ToString();
                feedbackTextBox.Text =       dgvRow.Cells[3].Value.ToString();
                StatuscomboBox.Text = dgvRow.Cells[1].Value.ToString();
                assignment_idTextBox1.Text= dgvRow.Cells[5].Value.ToString();


            }
        }
        private void LoaddataSubmission(string que)
        {
            using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                var query = que;
                MySqlDataAdapter adap = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                //DataTable dt = new DataTable();
                adap.Fill(ds);

                SubmissionsdataGridView.DataSource = ds.Tables[0].DefaultView;

            }
        }


        private void DownloadFile(string file)
        {
            //   MySqlConnection conn = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas");
            // MySqlCommand cmd;

            bool em = false;
            MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas");
            connection.Open();

            using (MySqlCommand cmd = new MySqlCommand("SELECT submittedFiles FROM oas.submission where assignment_id = "+Convert.ToInt32(assignment_idTextBox1.Text)+" and student_id= "+Convert.ToInt32(student_idTextBox.Text)+";", connection))
            {

                using (MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default))
                {
                    if (reader.Read())
                    {
                        em = true;
                        byte[] fileData = (byte[])reader.GetValue(0);
                        using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter bw = new BinaryWriter(fs))
                            {
                                bw.Write(fileData);
                                bw.Close();
                            }
                        }
                        MessageBox.Show("download finished");
                    }
                    if (em == false)
                    {
                        MessageBox.Show("no data found");
                    }
                    reader.Close();
                }
            }
        }

        private void downloadAssSub_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Document (.pdf)|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("are u shure want ro download ", "VINSMOKE MJ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string filename = sfd.FileName;
                        DownloadFile(filename);
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        connection.Open();
                    //label1.Text = student_idTextBox.Text.ToString();


                    string query = "UPDATE `oas`.`submission` SET `feedback` = '"+feedbackTextBox.Text+"', `status` = '"+StatuscomboBox.Text+"', " +
                        "`marks` = '"+marksTextBox.Text+"' WHERE (`assignment_id` = '"+Convert.ToInt32(assignment_idTextBox1.Text)+"')  " +
                        " and (`student_id` = '"+ Convert.ToInt32(student_idTextBox.Text)+"');";

                        cmd.CommandText = query;


                        var result = cmd.ExecuteNonQuery();

                        if (result == 1)
                        {
                            MessageBox.Show( "successful");
                        }


                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            
        }

        private void ShowAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                string que = "select   student_id, status,  submission_date, feedback, marks, assignment_id  from submission " +
                        "where assignment_id = " + Convert.ToInt32(Ass) + " ;";
                LoaddataSubmission(que);
            }
            catch
            {
                MessageBox.Show("Select Subject and Assignment");
            }
        }

        private void chacked_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                string que = "select   student_id, status,  submission_date, feedback, marks, assignment_id  from submission " +
                  "where assignment_id = " + Convert.ToInt32(Ass) + " and status = 'checked';";
                LoaddataSubmission(que);
            }
            catch
            {
                MessageBox.Show("Select Subject and Assignment");
            }
   
        }

        private void unChacked_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string que = "select   student_id, status,  submission_date, feedback, marks, assignment_id  from submission " +
             "where assignment_id = " + Convert.ToInt32(Ass) + " and status != 'checked';";
                LoaddataSubmission(que);
            }
            catch
            {
                MessageBox.Show("Select Subject and Assignment");
            }
         
        }

        private void StatuscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
