using StudentStudyPlanner.Enums;

namespace StudentStudyPlanner.Models
{
    /// <summary>
    /// Базов клас за учебна задача
    /// Base class for study task
    /// </summary>
    public abstract class StudyTask
    {
        /// <summary>
        /// Уникален идентификатор на задачата
        /// Unique identifier of the task
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Име на задачата
        /// Name of the task
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание на задачата
        /// Description of the task
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Краен срок за изпълнение
        /// Deadline for completion
        /// </summary>
        public DateTime Deadline { get; set; }

        /// <summary>
        /// Приоритет на задачата
        /// Priority of the task
        /// </summary>
        public Priority Priority { get; set; }

        /// <summary>
        /// Статус на задачата
        /// Status of the task
        /// </summary>
        public Enums.TaskStatus Status { get; set; }

        /// <summary>
        /// Тип на задачата
        /// Type of the task
        /// </summary>
        public TaskType Type { get; set; }

        /// <summary>
        /// Конструктор
        /// Constructor
        /// </summary>
        protected StudyTask()
        {
            Name = string.Empty;
            Description = string.Empty;
            Deadline = DateTime.Now;
            Priority = Priority.Medium;
            Status = Enums.TaskStatus.NotStarted;
        }

        /// <summary>
        /// Виртуален метод за показване на детайли за задачата
        /// Virtual method to display task details
        /// </summary>
        /// <returns>Детайли за задачата</returns>
        public virtual string GetDetails()
        {
            return $"{Name} - Краен срок: {Deadline:dd.MM.yyyy}, Приоритет: {Priority}, Статус: {Status}";
        }

        /// <summary>
        /// Маркира задачата като завършена
        /// Marks the task as completed
        /// </summary>
        public void MarkAsCompleted()
        {
            Status = Enums.TaskStatus.Completed;
        }

        /// <summary>
        /// Връща текстово представяне на задачата
        /// Returns string representation of the task
        /// </summary>
        /// <returns>Текстово представяне</returns>
        public override string ToString()
        {
            return $"[{Type}] {Name} - {Deadline:dd.MM.yyyy} ({Status})";
        }
    }
}
