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

namespace oas
{
    public partial class course : Form
    {
        public string courseID = "";
        public string selectCourse = "SELECT course_id,course_name FROM oas.course;";
        public course()
        {
            InitializeComponent();
        }

        private void course_Load(object sender, EventArgs e)
        {
            Loaddata(selectCourse);
            update.Enabled = false;
            Delete.Enabled = false;
        }

        private void Loaddata(string que)
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

                    courseDataGrid.DataSource = ds.Tables[0].DefaultView;

                }
            }
            catch( Exception ee)
            {
                MessageBox.Show("Unable to load data-grid, "+ee.ToString());
            }
        }
        private void sqlcommand(string query)
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
                       // MessageBox.Show("success");
                    }


                }
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

      
        public string getCourseId()
        {
            string query = "SELECT course_id FROM oas.course order by course_id desc limit 1; ";
            string course = "";
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

                        course = dt.Rows[0][0].ToString();

                        return course;


                    }
                    else if (dt.Rows.Count == 0)
                    {
                        return "301";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";

        }
        private void add_Click(object sender, EventArgs e)
        {
            if (CourseNametextBox.Text== "") { MessageBox.Show("input feild cannot be empty"); return; }
            string course = getCourseId();
            string query = "INSERT INTO `oas`.`course` (`course_id`, `course_name`) VALUES ('"+(Convert.ToInt32(course)+1)+"', '"+CourseNametextBox.Text+"');";
            sqlcommand(query);
            MessageBox.Show("Successfully added");
            Loaddata(selectCourse);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string query;
            try
            {
                if (courseID == "") { MessageBox.Show("Course_id is Empty"); return; }
                query = "UPDATE `oas`.`course` SET `course_name` = '"+CourseNametextBox.Text+"' WHERE (`course_id` = '" + Convert.ToInt32(courseID) + "') ;";
                sqlcommand(query);
                courseID = "";
              

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                Loaddata(selectCourse);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query;
            try
            {   if(courseID == "") { MessageBox.Show("Course_id is Empty"); return; }
                query = " DELETE FROM `oas`.`submission` WHERE(`course_id` = '"+ Convert.ToInt32(courseID) + "');";
                sqlcommand(query);
                query = "  DELETE FROM `oas`.`assignment` where course_id = '" + Convert.ToInt32(courseID) + "';";
                sqlcommand(query);
                query = " DELETE FROM `oas`.`teacher_has_course` where course_id = '" + Convert.ToInt32(courseID) + "';";
                sqlcommand(query);
                query = "DELETE FROM `oas`.`student_has_course` where course_id = '" + Convert.ToInt32(courseID) + "';";
                sqlcommand(query);
                query = "DELETE FROM `oas`.`course` where course_id = '" + Convert.ToInt32(courseID) + "';";
                sqlcommand(query);
                MessageBox.Show("Deleted successfully");
                courseID = "";
              
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                Loaddata(selectCourse);
            }

        }

        private void courseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void courseDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = courseDataGrid.Rows[e.RowIndex];
                courseID = dgvRow.Cells[0].Value.ToString();
                CourseNametextBox.Text = dgvRow.Cells[1].Value.ToString();

                if(courseID != "")
                {
                    update.Enabled = true;
                    Delete.Enabled = true;

                }
            }
        }
    }
}
