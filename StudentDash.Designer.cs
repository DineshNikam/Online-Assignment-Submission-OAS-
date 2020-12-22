namespace oas
{
    partial class StudentDash
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
            System.Windows.Forms.Label download;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.profileLabel = new System.Windows.Forms.Label();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.AssignmentbuttonStudentPanel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Downloadbtnassignment = new System.Windows.Forms.Button();
            this.assignmentLabel = new System.Windows.Forms.Label();
            this.assignmentLabel1 = new System.Windows.Forms.Label();
            this.panelAssignment = new System.Windows.Forms.Panel();
            this.SubmissionPanel = new System.Windows.Forms.Panel();
            this.submissionStudentdataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteUpload = new System.Windows.Forms.Button();
            this.uploadTextBox = new System.Windows.Forms.TextBox();
            this.UploadAssignment = new System.Windows.Forms.Button();
            this.Unsubmitted = new System.Windows.Forms.RadioButton();
            this.submitted = new System.Windows.Forms.RadioButton();
            this.ShowAll = new System.Windows.Forms.RadioButton();
            download = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAssignment.SuspendLayout();
            this.SubmissionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submissionStudentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // download
            // 
            download.AutoSize = true;
            download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            download.ForeColor = System.Drawing.Color.Chocolate;
            download.Location = new System.Drawing.Point(2, 342);
            download.Name = "download";
            download.Size = new System.Drawing.Size(378, 20);
            download.TabIndex = 98;
            download.Text = "Download Assignment Quetions file from Here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Chocolate;
            label1.Location = new System.Drawing.Point(3, 478);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 20);
            label1.TabIndex = 98;
            label1.Text = "Upload your Work";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.Chocolate;
            label2.Location = new System.Drawing.Point(13, 569);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(147, 20);
            label2.TabIndex = 98;
            label2.Text = "Delete your Work";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.profileLabel);
            this.panel2.Controls.Add(this.sidepanel);
            this.panel2.Controls.Add(this.AssignmentbuttonStudentPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(220, 581);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 649);
            this.panel2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(12, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(12, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submissions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("News706 BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.Color.DarkKhaki;
            this.profileLabel.Location = new System.Drawing.Point(12, 18);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(135, 22);
            this.profileLabel.TabIndex = 9;
            this.profileLabel.Text = "studentPanel";
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 162);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(12, 60);
            this.sidepanel.TabIndex = 3;
            // 
            // AssignmentbuttonStudentPanel
            // 
            this.AssignmentbuttonStudentPanel.FlatAppearance.BorderSize = 0;
            this.AssignmentbuttonStudentPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignmentbuttonStudentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentbuttonStudentPanel.ForeColor = System.Drawing.Color.Cornsilk;
            this.AssignmentbuttonStudentPanel.Location = new System.Drawing.Point(12, 162);
            this.AssignmentbuttonStudentPanel.Name = "AssignmentbuttonStudentPanel";
            this.AssignmentbuttonStudentPanel.Size = new System.Drawing.Size(208, 60);
            this.AssignmentbuttonStudentPanel.TabIndex = 0;
            this.AssignmentbuttonStudentPanel.Text = "Assignment";
            this.AssignmentbuttonStudentPanel.UseVisualStyleBackColor = true;
            this.AssignmentbuttonStudentPanel.Click += new System.EventHandler(this.AssignmentbuttonStudentPanel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(480, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 551);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Downloadbtnassignment
            // 
            this.Downloadbtnassignment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Downloadbtnassignment.FlatAppearance.BorderSize = 0;
            this.Downloadbtnassignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Downloadbtnassignment.Location = new System.Drawing.Point(143, 365);
            this.Downloadbtnassignment.Name = "Downloadbtnassignment";
            this.Downloadbtnassignment.Size = new System.Drawing.Size(101, 29);
            this.Downloadbtnassignment.TabIndex = 99;
            this.Downloadbtnassignment.Text = "Download";
            this.Downloadbtnassignment.UseVisualStyleBackColor = false;
            this.Downloadbtnassignment.Click += new System.EventHandler(this.Downloadbtnassignment_Click);
            // 
            // assignmentLabel
            // 
            this.assignmentLabel.AutoSize = true;
            this.assignmentLabel.Location = new System.Drawing.Point(284, 103);
            this.assignmentLabel.Name = "assignmentLabel";
            this.assignmentLabel.Size = new System.Drawing.Size(87, 17);
            this.assignmentLabel.TabIndex = 100;
            this.assignmentLabel.Text = "assignments";
            // 
            // assignmentLabel1
            // 
            this.assignmentLabel1.AutoSize = true;
            this.assignmentLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.assignmentLabel1.Font = new System.Drawing.Font("Modern No. 20", 11F);
            this.assignmentLabel1.ForeColor = System.Drawing.Color.Chocolate;
            this.assignmentLabel1.Location = new System.Drawing.Point(35, 75);
            this.assignmentLabel1.Name = "assignmentLabel1";
            this.assignmentLabel1.Size = new System.Drawing.Size(18, 21);
            this.assignmentLabel1.TabIndex = 100;
            this.assignmentLabel1.Text = "..";
            // 
            // panelAssignment
            // 
            this.panelAssignment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelAssignment.Controls.Add(this.SubmissionPanel);
            this.panelAssignment.Controls.Add(this.DeleteUpload);
            this.panelAssignment.Controls.Add(this.uploadTextBox);
            this.panelAssignment.Controls.Add(this.UploadAssignment);
            this.panelAssignment.Controls.Add(this.Unsubmitted);
            this.panelAssignment.Controls.Add(this.submitted);
            this.panelAssignment.Controls.Add(this.ShowAll);
            this.panelAssignment.Controls.Add(this.assignmentLabel1);
            this.panelAssignment.Controls.Add(label2);
            this.panelAssignment.Controls.Add(label1);
            this.panelAssignment.Controls.Add(download);
            this.panelAssignment.Controls.Add(this.dataGridView1);
            this.panelAssignment.Controls.Add(this.Downloadbtnassignment);
            this.panelAssignment.Location = new System.Drawing.Point(226, 0);
            this.panelAssignment.Name = "panelAssignment";
            this.panelAssignment.Size = new System.Drawing.Size(1058, 637);
            this.panelAssignment.TabIndex = 101;
            this.panelAssignment.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAssignment_Paint);
            // 
            // SubmissionPanel
            // 
            this.SubmissionPanel.Controls.Add(this.submissionStudentdataGridView);
            this.SubmissionPanel.Location = new System.Drawing.Point(3, 0);
            this.SubmissionPanel.Name = "SubmissionPanel";
            this.SubmissionPanel.Size = new System.Drawing.Size(1058, 637);
            this.SubmissionPanel.TabIndex = 105;
            this.SubmissionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SubmissionPanel_Paint);
            // 
            // submissionStudentdataGridView
            // 
            this.submissionStudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.submissionStudentdataGridView.Location = new System.Drawing.Point(3, 12);
            this.submissionStudentdataGridView.Name = "submissionStudentdataGridView";
            this.submissionStudentdataGridView.RowHeadersWidth = 51;
            this.submissionStudentdataGridView.RowTemplate.Height = 24;
            this.submissionStudentdataGridView.Size = new System.Drawing.Size(1049, 607);
            this.submissionStudentdataGridView.TabIndex = 0;
            // 
            // DeleteUpload
            // 
            this.DeleteUpload.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteUpload.FlatAppearance.BorderSize = 0;
            this.DeleteUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUpload.Location = new System.Drawing.Point(188, 563);
            this.DeleteUpload.Name = "DeleteUpload";
            this.DeleteUpload.Size = new System.Drawing.Size(103, 33);
            this.DeleteUpload.TabIndex = 105;
            this.DeleteUpload.Text = "Delete";
            this.DeleteUpload.UseVisualStyleBackColor = false;
            this.DeleteUpload.Click += new System.EventHandler(this.DeleteUpload_Click);
            // 
            // uploadTextBox
            // 
            this.uploadTextBox.Enabled = false;
            this.uploadTextBox.Location = new System.Drawing.Point(188, 478);
            this.uploadTextBox.Name = "uploadTextBox";
            this.uploadTextBox.Size = new System.Drawing.Size(211, 22);
            this.uploadTextBox.TabIndex = 103;
            // 
            // UploadAssignment
            // 
            this.UploadAssignment.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UploadAssignment.FlatAppearance.BorderSize = 0;
            this.UploadAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadAssignment.ForeColor = System.Drawing.Color.Chocolate;
            this.UploadAssignment.Location = new System.Drawing.Point(188, 506);
            this.UploadAssignment.Name = "UploadAssignment";
            this.UploadAssignment.Size = new System.Drawing.Size(94, 27);
            this.UploadAssignment.TabIndex = 102;
            this.UploadAssignment.Text = "Upload";
            this.UploadAssignment.UseVisualStyleBackColor = false;
            this.UploadAssignment.Click += new System.EventHandler(this.UploadAssignment_Click);
            // 
            // Unsubmitted
            // 
            this.Unsubmitted.AutoSize = true;
            this.Unsubmitted.Location = new System.Drawing.Point(771, 14);
            this.Unsubmitted.Name = "Unsubmitted";
            this.Unsubmitted.Size = new System.Drawing.Size(108, 21);
            this.Unsubmitted.TabIndex = 101;
            this.Unsubmitted.TabStop = true;
            this.Unsubmitted.Text = "Unsubmitted";
            this.Unsubmitted.UseVisualStyleBackColor = true;
            this.Unsubmitted.CheckedChanged += new System.EventHandler(this.Unsubmitted_CheckedChanged);
            // 
            // submitted
            // 
            this.submitted.AutoSize = true;
            this.submitted.Location = new System.Drawing.Point(653, 14);
            this.submitted.Name = "submitted";
            this.submitted.Size = new System.Drawing.Size(92, 21);
            this.submitted.TabIndex = 101;
            this.submitted.TabStop = true;
            this.submitted.Text = "Submitted";
            this.submitted.UseVisualStyleBackColor = true;
            this.submitted.CheckedChanged += new System.EventHandler(this.submitted_CheckedChanged);
            // 
            // ShowAll
            // 
            this.ShowAll.AutoSize = true;
            this.ShowAll.Location = new System.Drawing.Point(549, 14);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(81, 21);
            this.ShowAll.TabIndex = 101;
            this.ShowAll.TabStop = true;
            this.ShowAll.Text = "Show all";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.CheckedChanged += new System.EventHandler(this.ShowAll_CheckedChanged);
            // 
            // StudentDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 649);
            this.Controls.Add(this.panelAssignment);
            this.Controls.Add(this.assignmentLabel);
            this.Controls.Add(this.panel2);
            this.Name = "StudentDash";
            this.Text = "StudentDash";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentDash_FormClosed);
            this.Load += new System.EventHandler(this.StudentDash_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAssignment.ResumeLayout(false);
            this.panelAssignment.PerformLayout();
            this.SubmissionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.submissionStudentdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button AssignmentbuttonStudentPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Downloadbtnassignment;
        private System.Windows.Forms.Label assignmentLabel;
        private System.Windows.Forms.Label assignmentLabel1;
        private System.Windows.Forms.Panel panelAssignment;
        private System.Windows.Forms.RadioButton Unsubmitted;
        private System.Windows.Forms.RadioButton submitted;
        private System.Windows.Forms.RadioButton ShowAll;
        private System.Windows.Forms.Button UploadAssignment;
        private System.Windows.Forms.TextBox uploadTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteUpload;
        private System.Windows.Forms.Panel SubmissionPanel;
        private System.Windows.Forms.DataGridView submissionStudentdataGridView;
    }
}