namespace StudentStudyPlanner.Forms
{
    partial class MainForm
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
            this.grpCourses = new System.Windows.Forms.GroupBox();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.grpTasks = new System.Windows.Forms.GroupBox();
            this.lblCourseInfo = new System.Windows.Forms.Label();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.grpCourses.SuspendLayout();
            this.grpTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourses
            // 
            this.grpCourses.Controls.Add(this.btnDeleteCourse);
            this.grpCourses.Controls.Add(this.btnEditCourse);
            this.grpCourses.Controls.Add(this.btnAddCourse);
            this.grpCourses.Controls.Add(this.lstCourses);
            this.grpCourses.Location = new System.Drawing.Point(12, 12);
            this.grpCourses.Name = "grpCourses";
            this.grpCourses.Size = new System.Drawing.Size(350, 500);
            this.grpCourses.TabIndex = 0;
            this.grpCourses.TabStop = false;
            this.grpCourses.Text = "Курсове";
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(240, 460);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteCourse.TabIndex = 3;
            this.btnDeleteCourse.Text = "Изтрий";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Location = new System.Drawing.Point(125, 460);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(100, 30);
            this.btnEditCourse.TabIndex = 2;
            this.btnEditCourse.Text = "Редактирай";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(10, 460);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(100, 30);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Добави";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 15;
            this.lstCourses.Location = new System.Drawing.Point(10, 25);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(330, 424);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // grpTasks
            // 
            this.grpTasks.Controls.Add(this.lblCourseInfo);
            this.grpTasks.Controls.Add(this.btnDeleteTask);
            this.grpTasks.Controls.Add(this.btnEditTask);
            this.grpTasks.Controls.Add(this.btnAddTask);
            this.grpTasks.Controls.Add(this.lstTasks);
            this.grpTasks.Location = new System.Drawing.Point(368, 12);
            this.grpTasks.Name = "grpTasks";
            this.grpTasks.Size = new System.Drawing.Size(500, 500);
            this.grpTasks.TabIndex = 1;
            this.grpTasks.TabStop = false;
            this.grpTasks.Text = "Учебни задачи";
            // 
            // lblCourseInfo
            // 
            this.lblCourseInfo.AutoSize = true;
            this.lblCourseInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCourseInfo.Location = new System.Drawing.Point(10, 25);
            this.lblCourseInfo.Name = "lblCourseInfo";
            this.lblCourseInfo.Size = new System.Drawing.Size(95, 15);
            this.lblCourseInfo.TabIndex = 4;
            this.lblCourseInfo.Text = "Изберете курс";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(380, 460);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Изтрий";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(265, 460);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(100, 30);
            this.btnEditTask.TabIndex = 2;
            this.btnEditTask.Text = "Редактирай";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(150, 460);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 30);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Добави";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 15;
            this.lstTasks.Location = new System.Drawing.Point(10, 50);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(480, 394);
            this.lstTasks.TabIndex = 0;
            this.lstTasks.DoubleClick += new System.EventHandler(this.lstTasks_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 524);
            this.Controls.Add(this.grpTasks);
            this.Controls.Add(this.grpCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Study Planner - Планировчик за учене";
            this.grpCourses.ResumeLayout(false);
            this.grpTasks.ResumeLayout(false);
            this.grpTasks.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourses;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.GroupBox grpTasks;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Label lblCourseInfo;
    }
}
