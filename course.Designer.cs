namespace oas
{
    partial class course
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseDataGrid = new System.Windows.Forms.DataGridView();
            this.CourseNametextBox = new System.Windows.Forms.TextBox();
            this.txtlabel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDataGrid
            // 
            this.courseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGrid.Location = new System.Drawing.Point(411, 27);
            this.courseDataGrid.Name = "courseDataGrid";
            this.courseDataGrid.RowHeadersWidth = 51;
            this.courseDataGrid.RowTemplate.Height = 24;
            this.courseDataGrid.Size = new System.Drawing.Size(329, 352);
            this.courseDataGrid.TabIndex = 0;
            this.courseDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGrid_CellClick);
            this.courseDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseDataGrid_CellContentClick);
            // 
            // CourseNametextBox
            // 
            this.CourseNametextBox.Location = new System.Drawing.Point(140, 83);
            this.CourseNametextBox.Name = "CourseNametextBox";
            this.CourseNametextBox.Size = new System.Drawing.Size(264, 22);
            this.CourseNametextBox.TabIndex = 1;
            // 
            // txtlabel
            // 
            this.txtlabel.AutoSize = true;
            this.txtlabel.Location = new System.Drawing.Point(24, 86);
            this.txtlabel.Name = "txtlabel";
            this.txtlabel.Size = new System.Drawing.Size(96, 17);
            this.txtlabel.TabIndex = 2;
            this.txtlabel.Text = "Course_name";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.YellowGreen;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Snow;
            this.add.Location = new System.Drawing.Point(1, 125);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 39);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.SkyBlue;
            this.update.FlatAppearance.BorderSize = 0;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Snow;
            this.update.Location = new System.Drawing.Point(140, 125);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(125, 39);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Crimson;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Snow;
            this.Delete.Location = new System.Drawing.Point(279, 125);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 39);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(740, 409);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtlabel);
            this.Controls.Add(this.CourseNametextBox);
            this.Controls.Add(this.courseDataGrid);
            this.Name = "course";
            this.Text = "course";
            this.Load += new System.EventHandler(this.course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView courseDataGrid;
        private System.Windows.Forms.TextBox CourseNametextBox;
        private System.Windows.Forms.Label txtlabel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
    }
}