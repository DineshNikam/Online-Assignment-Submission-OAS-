using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace oas
{
    public partial class Teacher_assignmentUserControl : UserControl
    { string selectassignment = "select * from oas.assignment where teacher_id ='"+login_fm.ID+"';";
        MySqlDataReader reader;
        public Teacher_assignmentUserControl()
        {
            InitializeComponent();
        }

        private void assignmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.assignmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oasDataSet1);

        }

        private void Teacher_assignmentUserControl_Load(object sender, EventArgs e)
        {
           getAssignmentId();
            Loaddata(selectassignment);
        }
        public string getAssignmentId()
        { string query = "SELECT assignment_id FROM oas.assignment order by assignment_id desc limit 1; ";
            string assignment_id="";
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
                        
                       assignment_id= dt.Rows[0][0].ToString();
                       
                        return assignment_id;


                    }
                    else if(dt.Rows.Count==0)
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

        public void uploadFile(string file)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
              
                {
                    connection.Open();

                    FileStream fstream = File.OpenRead(file);
                    byte[] contents = new byte[fstream.Length];
                    fstream.Read(contents, 0, (int)fstream.Length);
                    fstream.Close();
                    string query = "insert into oas.assignment where ";
                   MySqlCommand cmd = new MySqlCommand(query,connection);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void uploadbtnassignment_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog() { Filter="text file (*.pdf) | *.pdf",ValidateNames=true})
            {
                if(dlg.ShowDialog()== DialogResult.OK)
                {
                    // DialogResult dialog=MessageBox.Show("Do you want to upload")
                    string filename = dlg.FileName;
                    uploadTextbox.Text = filename;
                    uploadFile(filename);
                }
            }
        }

        private void InsertBtnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtnAdmin_Click(object sender, EventArgs e)
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

    

        private void assignmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = assignmentDataGridView.Rows[e.RowIndex];
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
    }
}
