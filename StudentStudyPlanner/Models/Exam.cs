using StudentStudyPlanner.Enums;

namespace StudentStudyPlanner.Models
{
    /// <summary>
    /// Клас за изпит (наследява StudyTask)
    /// Class for exam (inherits from StudyTask)
    /// </summary>
    public class Exam : StudyTask
    {
        /// <summary>
        /// Предмет на изпита
        /// Exam subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Час на изпита
        /// Exam time
        /// </summary>
        public string ExamTime { get; set; }

        /// <summary>
        /// Локация на изпита
        /// Exam location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Конструктор
        /// Constructor
        /// </summary>
        public Exam()
        {
            Type = TaskType.Exam; // Задаваме типа на задачата
            Subject = string.Empty;
            ExamTime = string.Empty;
            Location = string.Empty;
        }

        /// <summary>
        /// Презаписан метод за показване на детайли
        /// Overridden method to display details
        /// </summary>
        /// <returns>Детайли за изпита</returns>
        public override string GetDetails()
        {
            return $"Изпит: {Name} - Предмет: {Subject}, Час: {ExamTime}, Локация: {Location}, Дата: {Deadline:dd.MM.yyyy}";
        }
    }
}
