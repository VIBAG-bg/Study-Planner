using StudentStudyPlanner.Enums;

namespace StudentStudyPlanner.Models
{
    /// <summary>
    /// Клас за домашна работа (наследява StudyTask)
    /// Class for homework (inherits from StudyTask)
    /// </summary>
    public class Homework : StudyTask
    {
        /// <summary>
        /// Предмет, за който е домашната работа
        /// Subject for which the homework is assigned
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Номер на упражнението/задачата
        /// Exercise/task number
        /// </summary>
        public string ExerciseNumber { get; set; }

        /// <summary>
        /// Конструктор
        /// Constructor
        /// </summary>
        public Homework()
        {
            Type = TaskType.Homework; // Задаваме типа на задачата
            Subject = string.Empty;
            ExerciseNumber = string.Empty;
        }

        /// <summary>
        /// Презаписан метод за показване на детайли
        /// Overridden method to display details
        /// </summary>
        /// <returns>Детайли за домашната работа</returns>
        public override string GetDetails()
        {
            return $"Домашна: {Name} - Предмет: {Subject}, Упражнение: {ExerciseNumber}, Краен срок: {Deadline:dd.MM.yyyy}";
        }
    }
}
