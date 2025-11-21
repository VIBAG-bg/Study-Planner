namespace StudentStudyPlanner.Forms
{
    partial class TaskForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.cmbTaskType = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlHomework = new System.Windows.Forms.Panel();
            this.txtExerciseNumber = new System.Windows.Forms.TextBox();
            this.lblExerciseNumber = new System.Windows.Forms.Label();
            this.txtHomeworkSubject = new System.Windows.Forms.TextBox();
            this.lblHomeworkSubject = new System.Windows.Forms.Label();
            this.pnlExam = new System.Windows.Forms.Panel();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtExamTime = new System.Windows.Forms.TextBox();
            this.lblExamTime = new System.Windows.Forms.Label();
            this.txtExamSubject = new System.Windows.Forms.TextBox();
            this.lblExamSubject = new System.Windows.Forms.Label();
            this.pnlProject = new System.Windows.Forms.Panel();
            this.txtTechnologies = new System.Windows.Forms.TextBox();
            this.lblTechnologies = new System.Windows.Forms.Label();
            this.txtTeamMembers = new System.Windows.Forms.TextBox();
            this.lblTeamMembers = new System.Windows.Forms.Label();
            this.txtProjectSubject = new System.Windows.Forms.TextBox();
            this.lblProjectSubject = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHomework.SuspendLayout();
            this.pnlExam.SuspendLayout();
            this.pnlProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Име:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(68, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(120, 47);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 60);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(12, 120);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(77, 15);
            this.lblDeadline.TabIndex = 4;
            this.lblDeadline.Text = "Краен срок:";
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeadline.Location = new System.Drawing.Point(120, 117);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(150, 23);
            this.dtpDeadline.TabIndex = 5;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(12, 155);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(80, 15);
            this.lblTaskType.TabIndex = 6;
            this.lblTaskType.Text = "Тип задача:";
            // 
            // cmbTaskType
            // 
            this.cmbTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTaskType.FormattingEnabled = true;
            this.cmbTaskType.Location = new System.Drawing.Point(120, 152);
            this.cmbTaskType.Name = "cmbTaskType";
            this.cmbTaskType.Size = new System.Drawing.Size(150, 23);
            this.cmbTaskType.TabIndex = 7;
            this.cmbTaskType.SelectedIndexChanged += new System.EventHandler(this.cmbTaskType_SelectedIndexChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(290, 155);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(71, 15);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Приоритет:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(370, 152);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(150, 23);
            this.cmbPriority.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(290, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 15);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Статус:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(370, 117);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(150, 23);
            this.cmbStatus.TabIndex = 11;
            // 
            // pnlHomework
            // 
            this.pnlHomework.Controls.Add(this.txtExerciseNumber);
            this.pnlHomework.Controls.Add(this.lblExerciseNumber);
            this.pnlHomework.Controls.Add(this.txtHomeworkSubject);
            this.pnlHomework.Controls.Add(this.lblHomeworkSubject);
            this.pnlHomework.Location = new System.Drawing.Point(12, 190);
            this.pnlHomework.Name = "pnlHomework";
            this.pnlHomework.Size = new System.Drawing.Size(508, 80);
            this.pnlHomework.TabIndex = 12;
            // 
            // txtExerciseNumber
            // 
            this.txtExerciseNumber.Location = new System.Drawing.Point(108, 42);
            this.txtExerciseNumber.Name = "txtExerciseNumber";
            this.txtExerciseNumber.Size = new System.Drawing.Size(388, 23);
            this.txtExerciseNumber.TabIndex = 3;
            // 
            // lblExerciseNumber
            // 
            this.lblExerciseNumber.AutoSize = true;
            this.lblExerciseNumber.Location = new System.Drawing.Point(3, 45);
            this.lblExerciseNumber.Name = "lblExerciseNumber";
            this.lblExerciseNumber.Size = new System.Drawing.Size(88, 15);
            this.lblExerciseNumber.TabIndex = 2;
            this.lblExerciseNumber.Text = "Упражнение №:";
            // 
            // txtHomeworkSubject
            // 
            this.txtHomeworkSubject.Location = new System.Drawing.Point(108, 7);
            this.txtHomeworkSubject.Name = "txtHomeworkSubject";
            this.txtHomeworkSubject.Size = new System.Drawing.Size(388, 23);
            this.txtHomeworkSubject.TabIndex = 1;
            // 
            // lblHomeworkSubject
            // 
            this.lblHomeworkSubject.AutoSize = true;
            this.lblHomeworkSubject.Location = new System.Drawing.Point(3, 10);
            this.lblHomeworkSubject.Name = "lblHomeworkSubject";
            this.lblHomeworkSubject.Size = new System.Drawing.Size(60, 15);
            this.lblHomeworkSubject.TabIndex = 0;
            this.lblHomeworkSubject.Text = "Предмет:";
            // 
            // pnlExam
            // 
            this.pnlExam.Controls.Add(this.txtLocation);
            this.pnlExam.Controls.Add(this.lblLocation);
            this.pnlExam.Controls.Add(this.txtExamTime);
            this.pnlExam.Controls.Add(this.lblExamTime);
            this.pnlExam.Controls.Add(this.txtExamSubject);
            this.pnlExam.Controls.Add(this.lblExamSubject);
            this.pnlExam.Location = new System.Drawing.Point(12, 190);
            this.pnlExam.Name = "pnlExam";
            this.pnlExam.Size = new System.Drawing.Size(508, 110);
            this.pnlExam.TabIndex = 13;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(108, 77);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(388, 23);
            this.txtLocation.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(3, 80);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(61, 15);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Локация:";
            // 
            // txtExamTime
            // 
            this.txtExamTime.Location = new System.Drawing.Point(108, 42);
            this.txtExamTime.Name = "txtExamTime";
            this.txtExamTime.Size = new System.Drawing.Size(388, 23);
            this.txtExamTime.TabIndex = 3;
            // 
            // lblExamTime
            // 
            this.lblExamTime.AutoSize = true;
            this.lblExamTime.Location = new System.Drawing.Point(3, 45);
            this.lblExamTime.Name = "lblExamTime";
            this.lblExamTime.Size = new System.Drawing.Size(31, 15);
            this.lblExamTime.TabIndex = 2;
            this.lblExamTime.Text = "Час:";
            // 
            // txtExamSubject
            // 
            this.txtExamSubject.Location = new System.Drawing.Point(108, 7);
            this.txtExamSubject.Name = "txtExamSubject";
            this.txtExamSubject.Size = new System.Drawing.Size(388, 23);
            this.txtExamSubject.TabIndex = 1;
            // 
            // lblExamSubject
            // 
            this.lblExamSubject.AutoSize = true;
            this.lblExamSubject.Location = new System.Drawing.Point(3, 10);
            this.lblExamSubject.Name = "lblExamSubject";
            this.lblExamSubject.Size = new System.Drawing.Size(60, 15);
            this.lblExamSubject.TabIndex = 0;
            this.lblExamSubject.Text = "Предмет:";
            // 
            // pnlProject
            // 
            this.pnlProject.Controls.Add(this.txtTechnologies);
            this.pnlProject.Controls.Add(this.lblTechnologies);
            this.pnlProject.Controls.Add(this.txtTeamMembers);
            this.pnlProject.Controls.Add(this.lblTeamMembers);
            this.pnlProject.Controls.Add(this.txtProjectSubject);
            this.pnlProject.Controls.Add(this.lblProjectSubject);
            this.pnlProject.Location = new System.Drawing.Point(12, 190);
            this.pnlProject.Name = "pnlProject";
            this.pnlProject.Size = new System.Drawing.Size(508, 110);
            this.pnlProject.TabIndex = 14;
            // 
            // txtTechnologies
            // 
            this.txtTechnologies.Location = new System.Drawing.Point(108, 77);
            this.txtTechnologies.Name = "txtTechnologies";
            this.txtTechnologies.Size = new System.Drawing.Size(388, 23);
            this.txtTechnologies.TabIndex = 5;
            // 
            // lblTechnologies
            // 
            this.lblTechnologies.AutoSize = true;
            this.lblTechnologies.Location = new System.Drawing.Point(3, 80);
            this.lblTechnologies.Name = "lblTechnologies";
            this.lblTechnologies.Size = new System.Drawing.Size(82, 15);
            this.lblTechnologies.TabIndex = 4;
            this.lblTechnologies.Text = "Технологии:";
            // 
            // txtTeamMembers
            // 
            this.txtTeamMembers.Location = new System.Drawing.Point(108, 42);
            this.txtTeamMembers.Name = "txtTeamMembers";
            this.txtTeamMembers.Size = new System.Drawing.Size(388, 23);
            this.txtTeamMembers.TabIndex = 3;
            // 
            // lblTeamMembers
            // 
            this.lblTeamMembers.AutoSize = true;
            this.lblTeamMembers.Location = new System.Drawing.Point(3, 45);
            this.lblTeamMembers.Name = "lblTeamMembers";
            this.lblTeamMembers.Size = new System.Drawing.Size(87, 15);
            this.lblTeamMembers.TabIndex = 2;
            this.lblTeamMembers.Text = "Членове на екип:";
            // 
            // txtProjectSubject
            // 
            this.txtProjectSubject.Location = new System.Drawing.Point(108, 7);
            this.txtProjectSubject.Name = "txtProjectSubject";
            this.txtProjectSubject.Size = new System.Drawing.Size(388, 23);
            this.txtProjectSubject.TabIndex = 1;
            // 
            // lblProjectSubject
            // 
            this.lblProjectSubject.AutoSize = true;
            this.lblProjectSubject.Location = new System.Drawing.Point(3, 10);
            this.lblProjectSubject.Name = "lblProjectSubject";
            this.lblProjectSubject.Size = new System.Drawing.Size(60, 15);
            this.lblProjectSubject.TabIndex = 0;
            this.lblProjectSubject.Text = "Предмет:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(316, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 351);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlProject);
            this.Controls.Add(this.pnlExam);
            this.Controls.Add(this.pnlHomework);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cmbTaskType);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задача";
            this.pnlHomework.ResumeLayout(false);
            this.pnlHomework.PerformLayout();
            this.pnlExam.ResumeLayout(false);
            this.pnlExam.PerformLayout();
            this.pnlProject.ResumeLayout(false);
            this.pnlProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.ComboBox cmbTaskType;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel pnlHomework;
        private System.Windows.Forms.TextBox txtExerciseNumber;
        private System.Windows.Forms.Label lblExerciseNumber;
        private System.Windows.Forms.TextBox txtHomeworkSubject;
        private System.Windows.Forms.Label lblHomeworkSubject;
        private System.Windows.Forms.Panel pnlExam;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtExamTime;
        private System.Windows.Forms.Label lblExamTime;
        private System.Windows.Forms.TextBox txtExamSubject;
        private System.Windows.Forms.Label lblExamSubject;
        private System.Windows.Forms.Panel pnlProject;
        private System.Windows.Forms.TextBox txtTechnologies;
        private System.Windows.Forms.Label lblTechnologies;
        private System.Windows.Forms.TextBox txtTeamMembers;
        private System.Windows.Forms.Label lblTeamMembers;
        private System.Windows.Forms.TextBox txtProjectSubject;
        private System.Windows.Forms.Label lblProjectSubject;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
