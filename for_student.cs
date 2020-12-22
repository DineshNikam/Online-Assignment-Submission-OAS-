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

namespace oas
{
    public partial class forstudent : UserControl
    {
        public forstudent()
        {
            
            InitializeComponent();
        }


        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oasDataSet1);

        }

        private void forstudent_Load(object sender, EventArgs e)
        {

        }

        private void student_has_courseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

       

      

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oasDataSet1);

        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


           
        }
    }
}
