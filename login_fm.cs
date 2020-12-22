using MySql.Data.MySqlClient;
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
using System.Security.Policy;

namespace oas
{
    public partial class login_fm : Form
    {   
        List<Panel> listPanel = new List<Panel>();
        public static string MyConnectionString = "server=localhost;user id=root;password=19111999;persistsecurityinfo=True;database=oas";
        MySqlConnection MyConn2 = new MySqlConnection("server=localhost;user id=root;password=19111999;persistsecurityinfo=True;database=oas");
        int i;
        public static string ID="";
        public static string NAME = "";

        private void login_fm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ID = "";
            Application.Exit();
        }


        public login_fm()
        {
            InitializeComponent();
            //this.panel1.Visible = tr  ue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AdminPanel ap = new AdminPanel();
            //this.Hide();
            //ap.Show();
            
            sidepanel.Height = buttonstudentlogin.Height;
            sidepanel.Top = buttonstudentlogin.Top;
            
            panel1student.BringToFront();
            panel1student.Visible = true;
            panel2teacher.Visible = false;
            panel3admin.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "select * from oas.student where email='" + this.txtstudentemail.Text + "'and password = '" + this.txtstudentpassword.Text + "';";
            if (Login(Query) == "1")
            {
                MessageBox.Show("hii");
                StudentDash sd = new StudentDash(); 
                sd.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Email | Password");
            }


        }

        private void buttonstudentlogin_Click(object sender, EventArgs e)
        {
            sidepanel.Height = buttonstudentlogin.Height;
            sidepanel.Top = buttonstudentlogin.Top;

            
            panel1student.Visible = true;
            panel2teacher.Visible = false;
            panel3admin.Visible = false;
            panel1student.BringToFront();
        }

        private void buttonteacherlogin_Click(object sender, EventArgs e)
        {
            sidepanel.Height = buttonteacherlogin.Height;
            sidepanel.Top = buttonteacherlogin.Top;
            panel2teacher.BringToFront();

            panel1student.Visible = true;
            panel2teacher.Visible = true;
            panel3admin.Visible = false;

        }

        private void buttonadminlogin_Click(object sender, EventArgs e)
        {
           
            sidepanel.Height = buttonadminlogin.Height;
            sidepanel.Top = buttonadminlogin.Top;
            
            panel1student.Visible = false;
            panel2teacher.Visible = true;
            panel3admin.Visible = true;
            panel3admin.BringToFront();




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonadminlog_Click(object sender, EventArgs e)
        {
            string Query = "select * from oas.admin where email='" + this.txtadminemail.Text + "'and password = '" + this.txtadminpass.Text + "';";
            if (Login(Query)=="1")
            {
                MessageBox.Show("hii");
                AdminPanel ap = new AdminPanel();
                ap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Email | Password");
            }
        }

        private string Login(string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(@"server = localhost; user id = root; password = 19111999; persistsecurityinfo = True; database = oas"))
                using (MySqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    
                   
                    MySqlDataAdapter ad = new MySqlDataAdapter(query, connection);
                    //MySqlCommand cmd = new MySqlCommand(Query, MyConn2);
                    //int a = cmd.ExecuteNonQuery();
                    //label8.Text = a.ToString();
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        //AdminDashboard admina = new AdminDashboard();
                        //admina.Show();
                        //this.Hide();
                        ID = dt.Rows[0][0].ToString();
                        NAME = dt.Rows[0]["first_name"].ToString();
                        return "1";


                    }
                    else
                    {
                        return "0";
                    }
                    //MyConn2.Close();

                }

                

              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "0";
        }
       
        private void buttonteacherlog_Click(object sender, EventArgs e)
        {
            string Query = "select * from oas.teacher where email='" + this.txtteacheremail.Text + "'and password = '" + this.txtteacherpass.Text + "';";
            if (Login(Query)=="1")
            {
                MessageBox.Show("hii");
                TeacherPanel tp = new TeacherPanel();
                tp.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Email | Password");
            }
        }

       
    }
}
