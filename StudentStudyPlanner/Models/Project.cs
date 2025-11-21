using StudentStudyPlanner.Enums;

namespace StudentStudyPlanner.Models
{
    /// <summary>
    /// Клас за проект (наследява StudyTask)
    /// Class for project (inherits from StudyTask)
    /// </summary>
    public class Project : StudyTask
    {
        /// <summary>
        /// Предмет, за който е проектът
        /// Subject for which the project is assigned
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Членове на екипа
        /// Team members
        /// </summary>
        public string TeamMembers { get; set; }

        /// <summary>
        /// Технологии, използвани в проекта
        /// Technologies used in the project
        /// </summary>
        public string Technologies { get; set; }

        /// <summary>
        /// Конструктор
        /// Constructor
        /// </summary>
        public Project()
        {
            Type = TaskType.Project; // Задаваме типа на задачата
            Subject = string.Empty;
            TeamMembers = string.Empty;
            Technologies = string.Empty;
        }

        /// <summary>
        /// Презаписан метод за показване на детайли
        /// Overridden method to display details
        /// </summary>
        /// <returns>Детайли за проекта</returns>
        public override string GetDetails()
        {
            return $"Проект: {Name} - Предмет: {Subject}, Екип: {TeamMembers}, Технологии: {Technologies}, Краен срок: {Deadline:dd.MM.yyyy}";
        }
    }
}
