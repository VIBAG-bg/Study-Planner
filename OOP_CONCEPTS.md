# OOP Concepts Used in StudentStudyPlanner / ООП Концепции в StudentStudyPlanner

## 1. Класове и Обекти / Classes and Objects

### Course (Models/Course.cs)
Представя учебен курс с имплементация на интерфейса `ITaskManager`.
```csharp
public class Course : ITaskManager
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Instructor { get; set; }
    public string Semester { get; set; }
    private List<StudyTask> tasks;
}
```

### DataManager (Models/DataManager.cs)
Singleton клас за управление на данните в паметта.
```csharp
public class DataManager
{
    private static readonly Lazy<DataManager> lazyInstance;
    public static DataManager Instance => lazyInstance.Value;
    private List<Course> courses;
}
```

## 2. Наследяване / Inheritance

### Базов клас StudyTask
```csharp
public abstract class StudyTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public Priority Priority { get; set; }
    public TaskStatus Status { get; set; }
    public TaskType Type { get; set; }
    
    public virtual string GetDetails() { ... }
}
```

### Производни класове / Derived Classes

#### Homework (Models/Homework.cs)
Наследява `StudyTask` и добавя специфични полета за домашна работа:
```csharp
public class Homework : StudyTask
{
    public string Subject { get; set; }
    public string ExerciseNumber { get; set; }
    
    public override string GetDetails() { ... }
}
```

#### Exam (Models/Exam.cs)
Наследява `StudyTask` и добавя специфични полета за изпит:
```csharp
public class Exam : StudyTask
{
    public string Subject { get; set; }
    public string ExamTime { get; set; }
    public string Location { get; set; }
    
    public override string GetDetails() { ... }
}
```

#### Project (Models/Project.cs)
Наследява `StudyTask` и добавя специфични полета за проект:
```csharp
public class Project : StudyTask
{
    public string Subject { get; set; }
    public string TeamMembers { get; set; }
    public string Technologies { get; set; }
    
    public override string GetDetails() { ... }
}
```

## 3. Интерфейс / Interface

### ITaskManager (Interfaces/ITaskManager.cs)
Дефинира контракт за управление на задачи:
```csharp
public interface ITaskManager
{
    void AddTask(StudyTask task);
    void RemoveTask(StudyTask task);
    List<StudyTask> GetAllTasks();
    void UpdateTask(StudyTask task);
}
```

Имплементиран от класа `Course`:
```csharp
public class Course : ITaskManager
{
    public void AddTask(StudyTask task) { ... }
    public void RemoveTask(StudyTask task) { ... }
    public List<StudyTask> GetAllTasks() { ... }
    public void UpdateTask(StudyTask task) { ... }
}
```

## 4. Енумерации / Enumerations

### TaskType (Enums/TaskType.cs)
Типове учебни задачи:
```csharp
public enum TaskType
{
    Homework,    // Домашна работа
    Exam,        // Изпит
    Project      // Проект
}
```

### TaskStatus (Enums/TaskStatus.cs)
Статус на задача:
```csharp
public enum TaskStatus
{
    NotStarted,   // Незапочната
    InProgress,   // В процес на изпълнение
    Completed     // Завършена
}
```

### Priority (Enums/Priority.cs)
Приоритет на задача:
```csharp
public enum Priority
{
    Low,      // Нисък приоритет
    Medium,   // Среден приоритет
    High      // Висок приоритет
}
```

## 5. Полиморфизъм / Polymorphism

### Виртуални методи / Virtual Methods
Базовият клас `StudyTask` дефинира виртуален метод:
```csharp
public virtual string GetDetails()
{
    return $"{Name} - Краен срок: {Deadline:dd.MM.yyyy}, Приоритет: {Priority}, Статус: {Status}";
}
```

### Презаписани методи / Overridden Methods
Всеки производен клас презаписва метода със своя имплементация:

**Homework:**
```csharp
public override string GetDetails()
{
    return $"Домашна: {Name} - Предмет: {Subject}, Упражнение: {ExerciseNumber}, Краен срок: {Deadline:dd.MM.yyyy}";
}
```

**Exam:**
```csharp
public override string GetDetails()
{
    return $"Изпит: {Name} - Предмет: {Subject}, Час: {ExamTime}, Локация: {Location}, Дата: {Deadline:dd.MM.yyyy}";
}
```

**Project:**
```csharp
public override string GetDetails()
{
    return $"Проект: {Name} - Предмет: {Subject}, Екип: {TeamMembers}, Технологии: {Technologies}, Краен срок: {Deadline:dd.MM.yyyy}";
}
```

## 6. Енкапсулация / Encapsulation

### Private полета с Public методи
```csharp
public class Course : ITaskManager
{
    // Приватно поле
    private List<StudyTask> tasks;
    
    // Публични методи за достъп
    public void AddTask(StudyTask task) { ... }
    public List<StudyTask> GetAllTasks() { ... }
}
```

### Properties със setter и getter
```csharp
public class StudyTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    // ... други properties
}
```

## 7. Абстракция / Abstraction

### Абстрактен клас
```csharp
public abstract class StudyTask
{
    // Общи полета за всички задачи
    public int Id { get; set; }
    public string Name { get; set; }
    // ...
    
    // Виртуален метод с базова имплементация
    public virtual string GetDetails() { ... }
    
    // Конкретен метод
    public void MarkAsCompleted() { ... }
}
```

Абстрактният клас не може да се инстанцира директно - само чрез производните класове.

## 8. Design Patterns

### Singleton Pattern
`DataManager` използва Singleton pattern със thread-safe Lazy инициализация:
```csharp
public class DataManager
{
    private static readonly Lazy<DataManager> lazyInstance = 
        new Lazy<DataManager>(() => new DataManager());
    
    private DataManager() { }
    
    public static DataManager Instance => lazyInstance.Value;
}
```

## 9. Колекции / Collections

### Използване на List<T>
Вместо база данни, използваме `List<T>` за съхранение в паметта:
```csharp
// В DataManager
private List<Course> courses;

// В Course
private List<StudyTask> tasks;
```

## 10. Обобщени типове / Generics

Използване на generic типа `List<T>`:
```csharp
List<Course> courses = new List<Course>();
List<StudyTask> tasks = new List<StudyTask>();
```

---

## Резюме / Summary

Приложението демонстрира всички основни концепции на ООП:
- ✅ **Класове и обекти** - Course, StudyTask, DataManager
- ✅ **Наследяване** - Homework, Exam, Project наследяват StudyTask
- ✅ **Полиморфизъм** - override на GetDetails()
- ✅ **Енкапсулация** - private полета, public properties/methods
- ✅ **Абстракция** - abstract class StudyTask
- ✅ **Интерфейси** - ITaskManager
- ✅ **Енумерации** - TaskType, TaskStatus, Priority
- ✅ **Design Patterns** - Singleton (DataManager)
- ✅ **Колекции** - List<T> за in-memory storage

Кодът е написан с ясни XML коментари на английски и inline коментари на български за да бъде лесен за разбиране и обяснение от студент.
