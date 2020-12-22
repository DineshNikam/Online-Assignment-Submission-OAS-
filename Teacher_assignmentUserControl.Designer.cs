namespace oas
{
    partial class Teacher_assignmentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label course_idLabel;
            System.Windows.Forms.Label marks_out_ofLabel;
            System.Windows.Forms.Label start_dateLabel;
            System.Windows.Forms.Label end_dateLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label instructionLabel;
            System.Windows.Forms.Label label2;
            this.oasDataSet1 = new oas.oasDataSet1();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentTableAdapter = new oas.oasDataSet1TableAdapters.assignmentTableAdapter();
            this.tableAdapterManager = new oas.oasDataSet1TableAdapters.TableAdapterManager();
            this.assignmentDataGridView = new System.Windows.Forms.DataGridView();
            this.course_idTextBox = new System.Windows.Forms.TextBox();
            this.marks_out_ofTextBox = new System.Windows.Forms.TextBox();
            this.start_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadTextbox = new System.Windows.Forms.TextBox();
            this.uploadbtnassignment = new System.Windows.Forms.Button();
            this.DeleteBtnAdmin = new System.Windows.Forms.Button();
            this.UpdateBtnAdmin = new System.Windows.Forms.Button();
            this.InsertBtnAdmin = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            course_idLabel = new System.Windows.Forms.Label();
            marks_out_ofLabel = new System.Windows.Forms.Label();
            start_dateLabel = new System.Windows.Forms.Label();
            end_dateLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            instructionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // course_idLabel
            // 
            course_idLabel.AutoSize = true;
            course_idLabel.Location = new System.Drawing.Point(18, 152);
            course_idLabel.Name = "course_idLabel";
            course_idLabel.Size = new System.Drawing.Size(70, 17);
            course_idLabel.TabIndex = 5;
            course_idLabel.Text = "course id:";
            // 
            // marks_out_ofLabel
            // 
            marks_out_ofLabel.AutoSize = true;
            marks_out_ofLabel.Location = new System.Drawing.Point(18, 180);
            marks_out_ofLabel.Name = "marks_out_ofLabel";
            marks_out_ofLabel.Size = new System.Drawing.Size(90, 17);
            marks_out_ofLabel.TabIndex = 7;
            marks_out_ofLabel.Text = "marks out of:";
            // 
            // start_dateLabel
            // 
            start_dateLabel.AutoSize = true;
            start_dateLabel.Location = new System.Drawing.Point(18, 209);
            start_dateLabel.Name = "start_dateLabel";
            start_dateLabel.Size = new System.Drawing.Size(72, 17);
            start_dateLabel.TabIndex = 9;
            start_dateLabel.Text = "start date:";
            // 
            // end_dateLabel
            // 
            end_dateLabel.AutoSize = true;
            end_dateLabel.Location = new System.Drawing.Point(18, 237);
            end_dateLabel.Name = "end_dateLabel";
            end_dateLabel.Size = new System.Drawing.Size(68, 17);
            end_dateLabel.TabIndex = 11;
            end_dateLabel.Text = "end date:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(18, 264);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(34, 17);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "title:";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new System.Drawing.Point(18, 292);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new System.Drawing.Size(77, 17);
            instructionLabel.TabIndex = 15;
            instructionLabel.Text = "instruction:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 395);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 17);
            label2.TabIndex = 19;
            label2.Text = "File:";
            // 
            // oasDataSet1
            // 
            this.oasDataSet1.DataSetName = "oasDataSet1";
            this.oasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataMember = "assignment";
            this.assignmentBindingSource.DataSource = this.oasDataSet1;
            // 
            // assignmentTableAdapter
            // 
            this.assignmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adminTableAdapter = null;
            this.tableAdapterManager.assignmentTableAdapter = this.assignmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.courseTableAdapter = null;
            this.tableAdapterManager.student_has_courseTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.submissionTableAdapter = null;
            this.tableAdapterManager.teacher_has_courseTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = oas.oasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // assignmentDataGridView
            // 
            this.assignmentDataGridView.AutoGenerateColumns = false;
            this.assignmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewImageColumn1});
            this.assignmentDataGridView.DataSource = this.assignmentBindingSource;
            this.assignmentDataGridView.Location = new System.Drawing.Point(479, 0);
            this.assignmentDataGridView.Name = "assignmentDataGridView";
            this.assignmentDataGridView.RowHeadersWidth = 51;
            this.assignmentDataGridView.RowTemplate.Height = 24;
            this.assignmentDataGridView.Size = new System.Drawing.Size(628, 595);
            this.assignmentDataGridView.TabIndex = 1;
            this.assignmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignmentDataGridView_CellClick);
            // 
            // course_idTextBox
            // 
            this.course_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignmentBindingSource, "course_id", true));
            this.course_idTextBox.Location = new System.Drawing.Point(123, 149);
            this.course_idTextBox.Name = "course_idTextBox";
            this.course_idTextBox.Size = new System.Drawing.Size(332, 22);
            this.course_idTextBox.TabIndex = 6;
            // 
            // marks_out_ofTextBox
            // 
            this.marks_out_ofTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignmentBindingSource, "marks_out_of", true));
            this.marks_out_ofTextBox.Location = new System.Drawing.Point(123, 177);
            this.marks_out_ofTextBox.Name = "marks_out_ofTextBox";
            this.marks_out_ofTextBox.Size = new System.Drawing.Size(332, 22);
            this.marks_out_ofTextBox.TabIndex = 8;
            // 
            // start_dateDateTimePicker
            // 
            this.start_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.assignmentBindingSource, "start_date", true));
            this.start_dateDateTimePicker.Location = new System.Drawing.Point(123, 205);
            this.start_dateDateTimePicker.Name = "start_dateDateTimePicker";
            this.start_dateDateTimePicker.Size = new System.Drawing.Size(332, 22);
            this.start_dateDateTimePicker.TabIndex = 10;
            // 
            // end_dateDateTimePicker
            // 
            this.end_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.assignmentBindingSource, "end_date", true));
            this.end_dateDateTimePicker.Location = new System.Drawing.Point(123, 233);
            this.end_dateDateTimePicker.Name = "end_dateDateTimePicker";
            this.end_dateDateTimePicker.Size = new System.Drawing.Size(332, 22);
            this.end_dateDateTimePicker.TabIndex = 12;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignmentBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(123, 261);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(332, 22);
            this.titleTextBox.TabIndex = 14;
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assignmentBindingSource, "instruction", true));
            this.instructionTextBox.Location = new System.Drawing.Point(123, 289);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.Size = new System.Drawing.Size(332, 95);
            this.instructionTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // uploadTextbox
            // 
            this.uploadTextbox.Location = new System.Drawing.Point(123, 390);
            this.uploadTextbox.Name = "uploadTextbox";
            this.uploadTextbox.Size = new System.Drawing.Size(332, 22);
            this.uploadTextbox.TabIndex = 18;
            // 
            // uploadbtnassignment
            // 
            this.uploadbtnassignment.Location = new System.Drawing.Point(354, 418);
            this.uploadbtnassignment.Name = "uploadbtnassignment";
            this.uploadbtnassignment.Size = new System.Drawing.Size(101, 29);
            this.uploadbtnassignment.TabIndex = 20;
            this.uploadbtnassignment.Text = "Upload File";
            this.uploadbtnassignment.UseVisualStyleBackColor = true;
            this.uploadbtnassignment.Click += new System.EventHandler(this.uploadbtnassignment_Click);
            // 
            // DeleteBtnAdmin
            // 
            this.DeleteBtnAdmin.BackColor = System.Drawing.Color.Red;
            this.DeleteBtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtnAdmin.Location = new System.Drawing.Point(343, 513);
            this.DeleteBtnAdmin.Name = "DeleteBtnAdmin";
            this.DeleteBtnAdmin.Size = new System.Drawing.Size(110, 47);
            this.DeleteBtnAdmin.TabIndex = 65;
            this.DeleteBtnAdmin.Text = "Delete";
            this.DeleteBtnAdmin.UseVisualStyleBackColor = false;
            this.DeleteBtnAdmin.Click += new System.EventHandler(this.DeleteBtnAdmin_Click);
            // 
            // UpdateBtnAdmin
            // 
            this.UpdateBtnAdmin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateBtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtnAdmin.Location = new System.Drawing.Point(239, 513);
            this.UpdateBtnAdmin.Name = "UpdateBtnAdmin";
            this.UpdateBtnAdmin.Size = new System.Drawing.Size(110, 47);
            this.UpdateBtnAdmin.TabIndex = 64;
            this.UpdateBtnAdmin.Text = "Update";
            this.UpdateBtnAdmin.UseVisualStyleBackColor = false;
            this.UpdateBtnAdmin.Click += new System.EventHandler(this.UpdateBtnAdmin_Click);
            // 
            // InsertBtnAdmin
            // 
            this.InsertBtnAdmin.BackColor = System.Drawing.Color.SpringGreen;
            this.InsertBtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertBtnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtnAdmin.Location = new System.Drawing.Point(123, 513);
            this.InsertBtnAdmin.Name = "InsertBtnAdmin";
            this.InsertBtnAdmin.Size = new System.Drawing.Size(110, 47);
            this.InsertBtnAdmin.TabIndex = 63;
            this.InsertBtnAdmin.Text = "Insert";
            this.InsertBtnAdmin.UseVisualStyleBackColor = false;
            this.InsertBtnAdmin.Click += new System.EventHandler(this.InsertBtnAdmin_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "assignment_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "assignment_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "course_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "course_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "marks_out_of";
            this.dataGridViewTextBoxColumn4.HeaderText = "marks_out_of";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "start_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "start_date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "end_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "end_date";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn7.HeaderText = "title";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "instruction";
            this.dataGridViewTextBoxColumn8.HeaderText = "instruction";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "files";
            this.dataGridViewImageColumn1.HeaderText = "files";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // Teacher_assignmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.DeleteBtnAdmin);
            this.Controls.Add(this.UpdateBtnAdmin);
            this.Controls.Add(this.InsertBtnAdmin);
            this.Controls.Add(this.uploadbtnassignment);
            this.Controls.Add(label2);
            this.Controls.Add(this.uploadTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(course_idLabel);
            this.Controls.Add(this.course_idTextBox);
            this.Controls.Add(marks_out_ofLabel);
            this.Controls.Add(this.marks_out_ofTextBox);
            this.Controls.Add(start_dateLabel);
            this.Controls.Add(this.start_dateDateTimePicker);
            this.Controls.Add(end_dateLabel);
            this.Controls.Add(this.end_dateDateTimePicker);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(instructionLabel);
            this.Controls.Add(this.instructionTextBox);
            this.Controls.Add(this.assignmentDataGridView);
            this.Name = "Teacher_assignmentUserControl";
            this.Size = new System.Drawing.Size(1127, 667);
            this.Load += new System.EventHandler(this.Teacher_assignmentUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private oasDataSet1 oasDataSet1;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private oasDataSet1TableAdapters.assignmentTableAdapter assignmentTableAdapter;
        private oasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView assignmentDataGridView;
        private System.Windows.Forms.TextBox course_idTextBox;
        private System.Windows.Forms.TextBox marks_out_ofTextBox;
        private System.Windows.Forms.DateTimePicker start_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker end_dateDateTimePicker;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox instructionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uploadTextbox;
        private System.Windows.Forms.Button uploadbtnassignment;
        private System.Windows.Forms.Button DeleteBtnAdmin;
        private System.Windows.Forms.Button UpdateBtnAdmin;
        private System.Windows.Forms.Button InsertBtnAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
