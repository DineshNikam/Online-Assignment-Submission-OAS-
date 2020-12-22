using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace oas
{
    public partial class StudentDash : Form
    { public string assignment_ID = "";
        
        string selectAssignment = "SELECT  assignment_id,teacher_id, course_id, title, instruction, start_date, end_date, marks_out_of FROM oas.assignment where course_id  in (select course_id from student_has_course where student_id ='" + login_fm.ID+"') ; ";


        string SubmittedAss= " SELECT  assignment_id,teacher_id, course_id, title, instruction, start_date, end_date, marks_out_of FROM oas.assignment" +
            " where course_id  in (select course_id from student_has_course where student_id ='" + login_fm.ID + "')" +
            " and  assignment_id   in (select assignment_id from submission where student_id = '" + login_fm.ID + "') ; ";


        string NotSubmittedAss = " SELECT  assignment_id,teacher_id, course_id, title, instruction, start_date, end_date, marks_out_of FROM oas.assignment" +
    " where course_id  in (select course_id from student_has_course where student_id ='" + login_fm.ID + "')" +
    " and  assignment_id  not in (select assignment_id from submission where student_id = '" + login_fm.ID + "') ; ";

        public string AssignmentID ="";
        public string TeacherID    ="";
        public string CourseId     ="";
        public string Title        ="";
        public string Instruction  =""; 
        public string StartDate    ="";
        public string DueDate      ="";
        public string Marks        = ""; 

        public StudentDash()
        {
            InitializeComponent();
        }

        private void StudentDash_Load(object sender, EventArgs e)
        {
            profileLabel.Text = "Hii, '"+login_fm.NAME+"";
            ShowAll.Checked=true;
            Loaddata(selectAssignment);
            sidepanel.Height = AssignmentbuttonStudentPanel.Height;
            sidepanel.Top = AssignmentbuttonStudentPanel.Top;
            panelAssignment.Visible = true;
            SubmissionPanel.Visible = false;
            panelAssignment.BringToFront();
        }

        private void StudentDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            login_fm.ID = "";
            login_fm.NAME = "";

            Application.Exit();
        }

        private void AssignmentbuttonStudentPanel_Click(object sender, EventArgs e)
        {
           
            sidepanel.Height = AssignmentbuttonStudentPanel.Height;
            sidepanel.Top = AssignmentbuttonStudentPanel.Top;
            panelAssignment.Visible = true;
            SubmissionPanel.Visible = false;
            panelAssignment.BringToFront();
            ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            panelAssignment.Visible = true;
            SubmissionPanel.Visible = true;
            SubmissionPanel.BringToFront();
            string query = "";

            query = "select assignment_id, teacher_id, course_id,title,submission_date,feedback,status, marks ,marks_out_of as outOf" +
                " from Assignment natural join submission where student_id = " + Convert.ToInt32(login_fm.ID) + " " +
                "and assignment.assignment_id = submission.assignment_id;  ";

            LoaddataSubm(query);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = AssignmentbuttonStudentPanel.Height;
            sidepanel.Top = AssignmentbuttonStudentPanel.Top;
            login_fm.ID = "";
            login_fm.NAME = "";
            login_fm lg = new login_fm();
            lg.Show();
            this.Hide();
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

                dataGridView1.DataSource = ds.Tables[0].DefaultView;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
assignmentLabel1.Text="Assignment ID : "+  dgvRow.Cells[0].Value.ToString().Trim()+ "\n" +
                      "Teacher ID :     " + dgvRow.Cells[1].Value.ToString().Trim() + "\n" +
                      "Course Id :     " + dgvRow.Cells[2].Value.ToString().Trim() + "\n" +
                      "Title :         " + dgvRow.Cells[3].Value.ToString().Trim() + "\n" +
                      "Instruction :   " + dgvRow.Cells[4].Value.ToString().Trim() + "\n" +
                      "Start Date :    " + dgvRow.Cells[5].Value.ToString().Trim() + "\n" +
                      "Due Date :      " + dgvRow.Cells[6].Value.ToString().Trim() + "\n" +
                      "Marks :         " + dgvRow.Cells[7].Value.ToString().Trim() + "";
               AssignmentID= dgvRow.Cells[0].Value.ToString().Trim();
               TeacherID = dgvRow.Cells[1].Value.ToString().Trim();
               CourseId    = dgvRow.Cells[2].Value.ToString().Trim();
               Title       = dgvRow.Cells[3].Value.ToString().Trim();
               Instruction = dgvRow.Cells[4].Value.ToString().Trim();
               StartDate   = dgvRow.Cells[5].Value.ToString().Trim();
               DueDate     = dgvRow.Cells[6].Value.ToString().Trim();
                Marks      = dgvRow.Cells[7].Value.ToString().Trim();


                assignment_ID = dgvRow.Cells[0].Value.ToString();
                // string que = "SELECT course_name  FROM oas.course where course_id in (select course_id from oas.student_has_course" +
                //   " where student_id = '" + dgvRow.Cells[0].Value.ToString() + "' ); ";
                // LoadCourseStudent(que);



            }
        }
        private void DownloadFile(string file)
        {
         //   MySqlConnection conn = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas");
           // MySqlCommand cmd;
         
            bool em = false;
            MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas");
            connection.Open();
            
            using (MySqlCommand cmd = new MySqlCommand("select files from oas.assignment where assignment_id ='" + Convert.ToInt32(assignment_ID) + "'",connection))
            {
                
                using(MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default))
                {
                    if (reader.Read())
                    {
                        em = true;
                        byte[] fileData = (byte[])reader.GetValue(0);
                        using(FileStream fs = new FileStream(file,FileMode.Create,FileAccess.ReadWrite))
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

        private void Downloadbtnassignment_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() {Filter ="Text Document (.pdf)|*.pdf", ValidateNames=true })
            {
                if (sfd.ShowDialog()==DialogResult.OK)
                {
                    DialogResult dialog = MessageBox.Show("are u shure want ro download ", "VINSMOKE MJ", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(dialog==DialogResult.Yes)
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

        private void ShowAll_CheckedChanged(object sender, EventArgs e)
        {
            Loaddata(selectAssignment);
        }

        private void submitted_CheckedChanged(object sender, EventArgs e)
        {
            Loaddata(SubmittedAss);
        }

        private void Unsubmitted_CheckedChanged(object sender, EventArgs e)
        {
            Loaddata(NotSubmittedAss);
        }

        private void UploadAssignment_Click(object sender, EventArgs e)
        {
            string mainfile = "";
            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "text file (*.pdf) | *.pdf", ValidateNames = true })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // DialogResult dialog=MessageBox.Show("Do you want to upload")
                    string filename = dlg.FileName;
                    uploadTextBox.Text = filename;
                    mainfile = filename;
                  //  MessageBox.Show(mainfile);
                }
            }
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
                   // MessageBox.Show(contents.ToString());
                   


                    string query = "INSERT INTO `oas`.`submission` (`assignment_id`, `teacher_id`, `course_id`, `student_id`, `submission_date`,`submittedFiles`)" +
                        " VALUES ('"+AssignmentID+"', '"+TeacherID+"', '"+ CourseId + "', '"+login_fm.ID.ToString()+"', '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',  @files);";

                   // MessageBox.Show("'" +Convert.ToInt32( AssignmentID) + "', '" +Convert.ToInt32( TeacherID) + "', '" +Convert.ToInt32( CourseId) + "', '" +Convert.ToInt32( login_fm.ID) + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'");

                    string que = "INSERT INTO `oas`.`submission` (`assignment_id`, `teacher_id`, `course_id`, `student_id`, `submission_date`, `submittedFiles`)" +
                        " VALUES (@assi, @teach, @course, @stud, @timeNow, @files);";

                  
                    cmd.Parameters.AddWithValue("@assi", Convert.ToInt32(AssignmentID));
                    cmd.Parameters.AddWithValue("@teach", Convert.ToInt32(TeacherID));
                    cmd.Parameters.AddWithValue("@course", Convert.ToInt32(CourseId));
                    cmd.Parameters.AddWithValue("@stud", Convert.ToInt32(login_fm.ID));
                    cmd.Parameters.AddWithValue("@timeNow", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@files",   contents);

                 
                    cmd.CommandText = que;
                    try 
                    {
                         var result = cmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("successful");
                        }
                    }
                    catch(Exception ee)
                    {
                         DialogResult dialog =  MessageBox.Show("File already present do you want to update ", "VINSMOKE MJ", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            string q = "UPDATE `oas`.`submission` SET `submission_date` = @timeNown,  `status` = 'unchacked',  `submittedFiles` = @filesn " +
                                "WHERE (`assignment_id` =   @assin ) and (`teacher_id` = @teachn) and (`course_id` = @coursen) and (`student_id` = @studn);";
                            cmd.Parameters.AddWithValue("@assin", Convert.ToInt32(AssignmentID));
                            cmd.Parameters.AddWithValue("@teachn", Convert.ToInt32(TeacherID));
                            cmd.Parameters.AddWithValue("@coursen", Convert.ToInt32(CourseId));
                            cmd.Parameters.AddWithValue("@studn", Convert.ToInt32(login_fm.ID));
                            cmd.Parameters.AddWithValue("@timeNown", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@filesn", contents);
                            cmd.CommandText = q;
                            var result = cmd.ExecuteNonQuery();
                            if (result == 1)
                            {
                                MessageBox.Show("successful");
                            }

                        }
                        else
                        {
                            return;
                        }
                    }
                  
                  
                 

                }
                else
                {
                    MessageBox.Show("upload a file");
                }
                mainfile = "";
                //Loaddata(selectassignment);
            }
        }

        private void DeleteUpload_Click(object sender, EventArgs e)
        {
            string query = "";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        connection.Open();
                        //label1.Text = student_idTextBox.Text.ToString();


                        query = "UPDATE `oas`.`submission` SET `submittedFiles` = @files WHERE (`assignment_id` = '" + Convert.ToInt32(AssignmentID) + "') and" +
                  " (`teacher_id` = '" + Convert.ToInt32(TeacherID) + "') and (`course_id` = '" + Convert.ToInt32(CourseId) + "') and (`student_id` = '" +Convert.ToInt32(login_fm.ID)+"');";
                    cmd.Parameters.AddWithValue("@files",null);
                        cmd.CommandText = query;


                        var result = cmd.ExecuteNonQuery();
                   
                    if (result == 1)
                        {
                        MessageBox.Show("Successful");
                    }


                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        private void sqlcommandsteacher(string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    //label1.Text = student_idTextBox.Text.ToString();



                    cmd.CommandText = query;


                    var result = cmd.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("Successful");
                    }


                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void panelAssignment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubmissionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchSubmisssion_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void LoaddataSubm(string que)
        {
            try
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

                    submissionStudentdataGridView.DataSource = ds.Tables[0].DefaultView;

                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Nothing found");
            }
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    string query = "";

        //    query = "select assignment_id, teacher_id, course_id,title,submission_date,feedback,status, marks" +
        //        " from Assignment natural join submission where student_id = " + Convert.ToInt32(login_fm.ID) + ", " +
        //        " assignment.assignment_id = submission.assignment_id , course_id = "+SearchSubmisssion.Text+" or title = "+SearchSubmisssion.Text+" ;  ";

        //    LoaddataSubm(query);
        //}
    }
}
