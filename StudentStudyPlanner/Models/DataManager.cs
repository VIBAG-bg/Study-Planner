namespace StudentStudyPlanner.Models
{
    /// <summary>
    /// Клас за управление на данните в паметта (без база данни)
    /// Class for managing data in memory (without database)
    /// </summary>
    public class DataManager
    {
        /// <summary>
        /// Thread-safe Lazy инстанция на DataManager
        /// Thread-safe Lazy instance of DataManager
        /// </summary>
        private static readonly Lazy<DataManager> lazyInstance = 
            new Lazy<DataManager>(() => new DataManager());

        /// <summary>
        /// Списък с всички курсове (използваме List<T> вместо база данни)
        /// List of all courses (using List<T> instead of database)
        /// </summary>
        private List<Course> courses;

        /// <summary>
        /// Приватен конструктор за Singleton pattern
        /// Private constructor for Singleton pattern
        /// </summary>
        private DataManager()
        {
            courses = new List<Course>();
        }

        /// <summary>
        /// Свойство за достъп до единствената инстанция (thread-safe)
        /// Property for accessing the single instance (thread-safe)
        /// </summary>
        public static DataManager Instance => lazyInstance.Value;

        /// <summary>
        /// Добавя нов курс
        /// Adds a new course
        /// </summary>
        /// <param name="course">Курсът за добавяне</param>
        public void AddCourse(Course course)
        {
            if (course != null)
            {
                // Генерираме ID за курса
                course.Id = courses.Count > 0 ? courses.Max(c => c.Id) + 1 : 1;
                courses.Add(course);
            }
        }

        /// <summary>
        /// Премахва курс
        /// Removes a course
        /// </summary>
        /// <param name="course">Курсът за премахване</param>
        public void RemoveCourse(Course course)
        {
            if (course != null)
            {
                courses.Remove(course);
            }
        }

        /// <summary>
        /// Връща всички курсове
        /// Returns all courses
        /// </summary>
        /// <returns>Списък с курсове</returns>
        public List<Course> GetAllCourses()
        {
            return new List<Course>(courses); // Връщаме копие на списъка
        }

        /// <summary>
        /// Актуализира съществуващ курс
        /// Updates an existing course
        /// </summary>
        /// <param name="course">Курсът за актуализиране</param>
        public void UpdateCourse(Course course)
        {
            if (course != null)
            {
                // Намираме курса в списъка и го актуализираме
                var existingCourse = courses.FirstOrDefault(c => c.Id == course.Id);
                if (existingCourse != null)
                {
                    int index = courses.IndexOf(existingCourse);
                    courses[index] = course;
                }
            }
        }

        /// <summary>
        /// Намира курс по ID
        /// Finds a course by ID
        /// </summary>
        /// <param name="id">ID на курса</param>
        /// <returns>Намереният курс или null</returns>
        public Course? GetCourseById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
