using StudentStudyPlanner.Enums;
using StudentStudyPlanner.Models;

namespace StudentStudyPlanner.Forms
{
    /// <summary>
    /// Форма за добавяне и редактиране на учебни задачи
    /// Form for adding and editing study tasks
    /// </summary>
    public partial class TaskForm : Form
    {
        private Course course;
        private StudyTask? task;
        private bool isEditMode;

        /// <summary>
        /// Конструктор за добавяне на нова задача
        /// Constructor for adding a new task
        /// </summary>
        /// <param name="targetCourse">Курсът, към който се добавя задачата</param>
        public TaskForm(Course targetCourse)
        {
            InitializeComponent();
            course = targetCourse;
            isEditMode = false;
            this.Text = "Добави задача";
            InitializeControls();
        }

        /// <summary>
        /// Конструктор за редактиране на съществуваща задача
        /// Constructor for editing an existing task
        /// </summary>
        /// <param name="targetCourse">Курсът, към който принадлежи задачата</param>
        /// <param name="taskToEdit">Задачата за редактиране</param>
        public TaskForm(Course targetCourse, StudyTask taskToEdit)
        {
            InitializeComponent();
            course = targetCourse;
            task = taskToEdit;
            isEditMode = true;
            this.Text = "Редактирай задача";
            InitializeControls();
            LoadTaskData();
        }

        /// <summary>
        /// Инициализира контролите на формата
        /// Initializes the form controls
        /// </summary>
        private void InitializeControls()
        {
            // Зареждаме типовете задачи
            cmbTaskType.Items.AddRange(new object[] { TaskType.Homework, TaskType.Exam, TaskType.Project });
            cmbTaskType.SelectedIndex = 0;

            // Зареждаме приоритетите
            cmbPriority.Items.AddRange(new object[] { Priority.Low, Priority.Medium, Priority.High });
            cmbPriority.SelectedIndex = 1;

            // Зареждаме статусите
            cmbStatus.Items.AddRange(new object[] { 
                Enums.TaskStatus.NotStarted, 
                Enums.TaskStatus.InProgress, 
                Enums.TaskStatus.Completed 
            });
            cmbStatus.SelectedIndex = 0;

            // Задаваме минимална дата за крайния срок
            dtpDeadline.MinDate = DateTime.Now;
            dtpDeadline.Value = DateTime.Now.AddDays(7);

            // Скриваме специфичните панели за типовете задачи
            pnlHomework.Visible = false;
            pnlExam.Visible = false;
            pnlProject.Visible = false;
        }

        /// <summary>
        /// Зарежда данните за задачата в полетата на формата
        /// Loads the task data into the form fields
        /// </summary>
        private void LoadTaskData()
        {
            if (task != null)
            {
                txtName.Text = task.Name;
                txtDescription.Text = task.Description;
                dtpDeadline.Value = task.Deadline;
                cmbPriority.SelectedItem = task.Priority;
                cmbStatus.SelectedItem = task.Status;
                cmbTaskType.SelectedItem = task.Type;

                // Зареждаме специфичните данни според типа задача
                switch (task.Type)
                {
                    case TaskType.Homework:
                        var homework = task as Homework;
                        if (homework != null)
                        {
                            txtHomeworkSubject.Text = homework.Subject;
                            txtExerciseNumber.Text = homework.ExerciseNumber;
                        }
                        break;
                    case TaskType.Exam:
                        var exam = task as Exam;
                        if (exam != null)
                        {
                            txtExamSubject.Text = exam.Subject;
                            txtExamTime.Text = exam.ExamTime;
                            txtLocation.Text = exam.Location;
                        }
                        break;
                    case TaskType.Project:
                        var project = task as Project;
                        if (project != null)
                        {
                            txtProjectSubject.Text = project.Subject;
                            txtTeamMembers.Text = project.TeamMembers;
                            txtTechnologies.Text = project.Technologies;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Събитие при промяна на типа задача
        /// Event when task type changes
        /// </summary>
        private void cmbTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Скриваме всички панели
            pnlHomework.Visible = false;
            pnlExam.Visible = false;
            pnlProject.Visible = false;

            // Показваме съответния панел според избрания тип
            if (cmbTaskType.SelectedItem is TaskType selectedType)
            {
                switch (selectedType)
                {
                    case TaskType.Homework:
                        pnlHomework.Visible = true;
                        break;
                    case TaskType.Exam:
                        pnlExam.Visible = true;
                        break;
                    case TaskType.Project:
                        pnlProject.Visible = true;
                        break;
                }
            }
        }

        /// <summary>
        /// Събитие при натискане на бутон Запази
        /// Event when Save button is clicked
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Валидираме входните данни
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Моля, въведете име на задачата.", "Грешка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (cmbTaskType.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете тип на задачата.", "Грешка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TaskType taskType = (TaskType)cmbTaskType.SelectedItem;
            StudyTask newTask;

            // Създаваме нова задача според типа
            switch (taskType)
            {
                case TaskType.Homework:
                    newTask = new Homework
                    {
                        Subject = txtHomeworkSubject.Text.Trim(),
                        ExerciseNumber = txtExerciseNumber.Text.Trim()
                    };
                    break;
                case TaskType.Exam:
                    newTask = new Exam
                    {
                        Subject = txtExamSubject.Text.Trim(),
                        ExamTime = txtExamTime.Text.Trim(),
                        Location = txtLocation.Text.Trim()
                    };
                    break;
                case TaskType.Project:
                    newTask = new Project
                    {
                        Subject = txtProjectSubject.Text.Trim(),
                        TeamMembers = txtTeamMembers.Text.Trim(),
                        Technologies = txtTechnologies.Text.Trim()
                    };
                    break;
                default:
                    newTask = new Homework();
                    break;
            }

            // Запълваме общите полета
            if (isEditMode && task != null)
            {
                newTask.Id = task.Id;
            }
            newTask.Name = txtName.Text.Trim();
            newTask.Description = txtDescription.Text.Trim();
            newTask.Deadline = dtpDeadline.Value;
            newTask.Priority = (Priority)cmbPriority.SelectedItem!;
            newTask.Status = (Enums.TaskStatus)cmbStatus.SelectedItem!;

            // Актуализираме или добавяме задачата
            if (isEditMode && task != null)
            {
                course.UpdateTask(newTask);
            }
            else
            {
                course.AddTask(newTask);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Събитие при натискане на бутон Отказ
        /// Event when Cancel button is clicked
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
