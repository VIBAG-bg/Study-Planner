using StudentStudyPlanner.Models;

namespace StudentStudyPlanner.Forms
{
    /// <summary>
    /// Главна форма на приложението
    /// Main application form
    /// </summary>
    public partial class MainForm : Form
    {
        private DataManager dataManager;
        private Course? selectedCourse;

        /// <summary>
        /// Конструктор
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            dataManager = DataManager.Instance;
            LoadCourses();
        }

        /// <summary>
        /// Зарежда списъка с курсове в ListBox
        /// Loads the course list into the ListBox
        /// </summary>
        private void LoadCourses()
        {
            lstCourses.Items.Clear();
            var courses = dataManager.GetAllCourses();
            foreach (var course in courses)
            {
                lstCourses.Items.Add(course);
            }
        }

        /// <summary>
        /// Зарежда задачите за избрания курс
        /// Loads tasks for the selected course
        /// </summary>
        private void LoadTasks()
        {
            lstTasks.Items.Clear();
            if (selectedCourse != null)
            {
                var tasks = selectedCourse.GetAllTasks();
                foreach (var task in tasks)
                {
                    lstTasks.Items.Add(task);
                }
                lblCourseInfo.Text = $"Курс: {selectedCourse.Name} ({selectedCourse.Code})";
            }
            else
            {
                lblCourseInfo.Text = "Изберете курс";
            }
        }

        /// <summary>
        /// Събитие при избор на курс от списъка
        /// Event when a course is selected from the list
        /// </summary>
        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedItem != null)
            {
                selectedCourse = (Course)lstCourses.SelectedItem;
                LoadTasks();
            }
        }

        /// <summary>
        /// Събитие при натискане на бутон за добавяне на курс
        /// Event when add course button is clicked
        /// </summary>
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var form = new CourseForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        /// <summary>
        /// Събитие при натискане на бутон за редактиране на курс
        /// Event when edit course button is clicked
        /// </summary>
        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null)
            {
                var form = new CourseForm(selectedCourse);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadCourses();
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете курс за редактиране.", "Внимание", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Събитие при натискане на бутон за изтриване на курс
        /// Event when delete course button is clicked
        /// </summary>
        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null)
            {
                var result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете курса '{selectedCourse.Name}'?",
                    "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    dataManager.RemoveCourse(selectedCourse);
                    selectedCourse = null;
                    LoadCourses();
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете курс за изтриване.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Събитие при натискане на бутон за добавяне на задача
        /// Event when add task button is clicked
        /// </summary>
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null)
            {
                var form = new TaskForm(selectedCourse);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете курс първо.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Събитие при натискане на бутон за редактиране на задача
        /// Event when edit task button is clicked
        /// </summary>
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null && lstTasks.SelectedItem != null)
            {
                var task = (StudyTask)lstTasks.SelectedItem;
                var form = new TaskForm(selectedCourse, task);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете задача за редактиране.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Събитие при натискане на бутон за изтриване на задача
        /// Event when delete task button is clicked
        /// </summary>
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (selectedCourse != null && lstTasks.SelectedItem != null)
            {
                var task = (StudyTask)lstTasks.SelectedItem;
                var result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете задачата '{task.Name}'?",
                    "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    selectedCourse.RemoveTask(task);
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Моля, изберете задача за изтриване.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Събитие при двоен клик на задача за да се покажат детайлите
        /// Event when double-clicking a task to show details
        /// </summary>
        private void lstTasks_DoubleClick(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                var task = (StudyTask)lstTasks.SelectedItem;
                MessageBox.Show(task.GetDetails(), "Детайли за задачата",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
