using StudentStudyPlanner.Models;

namespace StudentStudyPlanner.Interfaces
{
    /// <summary>
    /// Интерфейс за управление на учебни задачи
    /// Interface for managing study tasks
    /// </summary>
    public interface ITaskManager
    {
        /// <summary>
        /// Добавя нова задача
        /// Adds a new task
        /// </summary>
        /// <param name="task">Задачата за добавяне</param>
        void AddTask(StudyTask task);

        /// <summary>
        /// Премахва задача
        /// Removes a task
        /// </summary>
        /// <param name="task">Задачата за премахване</param>
        void RemoveTask(StudyTask task);

        /// <summary>
        /// Взима всички задачи
        /// Gets all tasks
        /// </summary>
        /// <returns>Списък със задачи</returns>
        List<StudyTask> GetAllTasks();

        /// <summary>
        /// Актуализира съществуваща задача
        /// Updates an existing task
        /// </summary>
        /// <param name="task">Задачата за актуализиране</param>
        void UpdateTask(StudyTask task);
    }
}
