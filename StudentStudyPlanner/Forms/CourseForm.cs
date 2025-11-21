using StudentStudyPlanner.Models;

namespace StudentStudyPlanner.Forms
{
    /// <summary>
    /// Форма за добавяне и редактиране на курсове
    /// Form for adding and editing courses
    /// </summary>
    public partial class CourseForm : Form
    {
        private Course? course;
        private bool isEditMode;
        private DataManager dataManager;

        /// <summary>
        /// Конструктор за добавяне на нов курс
        /// Constructor for adding a new course
        /// </summary>
        public CourseForm()
        {
            InitializeComponent();
            isEditMode = false;
            dataManager = DataManager.Instance;
            this.Text = "Добави курс";
        }

        /// <summary>
        /// Конструктор за редактиране на съществуващ курс
        /// Constructor for editing an existing course
        /// </summary>
        /// <param name="courseToEdit">Курсът за редактиране</param>
        public CourseForm(Course courseToEdit)
        {
            InitializeComponent();
            isEditMode = true;
            course = courseToEdit;
            dataManager = DataManager.Instance;
            this.Text = "Редактирай курс";
            
            // Зареждаме данните за курса в полетата
            LoadCourseData();
        }

        /// <summary>
        /// Зарежда данните за курса в полетата на формата
        /// Loads the course data into the form fields
        /// </summary>
        private void LoadCourseData()
        {
            if (course != null)
            {
                txtName.Text = course.Name;
                txtCode.Text = course.Code;
                txtInstructor.Text = course.Instructor;
                txtSemester.Text = course.Semester;
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
                MessageBox.Show("Моля, въведете име на курса.", "Грешка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Моля, въведете код на курса.", "Грешка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCode.Focus();
                return;
            }

            if (isEditMode && course != null)
            {
                // Редактираме съществуващ курс
                course.Name = txtName.Text.Trim();
                course.Code = txtCode.Text.Trim();
                course.Instructor = txtInstructor.Text.Trim();
                course.Semester = txtSemester.Text.Trim();
                dataManager.UpdateCourse(course);
            }
            else
            {
                // Създаваме нов курс
                var newCourse = new Course
                {
                    Name = txtName.Text.Trim(),
                    Code = txtCode.Text.Trim(),
                    Instructor = txtInstructor.Text.Trim(),
                    Semester = txtSemester.Text.Trim()
                };
                dataManager.AddCourse(newCourse);
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
