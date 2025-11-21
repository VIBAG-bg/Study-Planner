using StudentStudyPlanner.Interfaces;

namespace StudentStudyPlanner.Models
{
    /// <summary>
    /// Клас за учебен курс, имплементира интерфейса ITaskManager
    /// Class for academic course, implements ITaskManager interface
    /// </summary>
    public class Course : ITaskManager
    {
        /// <summary>
        /// Уникален идентификатор на курса
        /// Unique identifier of the course
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Име на курса
        /// Course name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код на курса
        /// Course code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Преподавател
        /// Instructor
        /// </summary>
        public string Instructor { get; set; }

        /// <summary>
        /// Семестър
        /// Semester
        /// </summary>
        public string Semester { get; set; }

        /// <summary>
        /// Списък с учебни задачи за курса (използваме List<T> вместо база данни)
        /// List of study tasks for the course (using List<T> instead of database)
        /// </summary>
        private List<StudyTask> tasks;

        /// <summary>
        /// Конструктор
        /// Constructor
        /// </summary>
        public Course()
        {
            Name = string.Empty;
            Code = string.Empty;
            Instructor = string.Empty;
            Semester = string.Empty;
            tasks = new List<StudyTask>(); // Инициализираме списъка
        }

        /// <summary>
        /// Добавя нова задача към курса
        /// Adds a new task to the course
        /// </summary>
        /// <param name="task">Задачата за добавяне</param>
        public void AddTask(StudyTask task)
        {
            // Проверяваме дали задачата не е null
            if (task != null)
            {
                // Генерираме ID за задачата
                task.Id = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;
                tasks.Add(task);
            }
        }

        /// <summary>
        /// Премахва задача от курса
        /// Removes a task from the course
        /// </summary>
        /// <param name="task">Задачата за премахване</param>
        public void RemoveTask(StudyTask task)
        {
            if (task != null)
            {
                tasks.Remove(task);
            }
        }

        /// <summary>
        /// Връща всички задачи за курса
        /// Returns all tasks for the course
        /// </summary>
        /// <returns>Списък със задачи</returns>
        public List<StudyTask> GetAllTasks()
        {
            return new List<StudyTask>(tasks); // Връщаме копие на списъка
        }

        /// <summary>
        /// Актуализира съществуваща задача
        /// Updates an existing task
        /// </summary>
        /// <param name="task">Задачата за актуализиране</param>
        public void UpdateTask(StudyTask task)
        {
            if (task != null)
            {
                // Намираме задачата в списъка и я актуализираме
                var existingTask = tasks.FirstOrDefault(t => t.Id == task.Id);
                if (existingTask != null)
                {
                    int index = tasks.IndexOf(existingTask);
                    tasks[index] = task;
                }
            }
        }

        /// <summary>
        /// Връща информация за курса
        /// Returns course information
        /// </summary>
        /// <returns>Информация за курса</returns>
        public override string ToString()
        {
            return $"{Code} - {Name} ({Instructor})";
        }
    }
}
