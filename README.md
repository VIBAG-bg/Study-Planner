# Study-Planner / Планировчик за учене
HW1 Study Planner CSCB579

## Описание / Description

StudentStudyPlanner е Windows Forms приложение на C# за управление на курсове и учебни задачи.
Приложението използва основни принципи на обектно-ориентираното програмиране (ООП).

StudentStudyPlanner is a C# Windows Forms application for managing courses and study tasks.
The application uses basic object-oriented programming (OOP) principles.

## Характеристики / Features

- **Управление на курсове** - добавяне, редактиране и изтриване на курсове
- **Управление на задачи** - три типа задачи: Домашна работа, Изпит, Проект
- **Използвани ООП концепции**:
  - Класове и обекти (Course, StudyTask)
  - Наследяване (Homework, Exam, Project наследяват StudyTask)
  - Интерфейс (ITaskManager)
  - Енумерации (TaskType, TaskStatus, Priority)
  - Полиморфизъм (virtual/override методи)
- **In-memory съхранение** с List<T> (без база данни)
- **Singleton pattern** за DataManager

## Структура на проекта / Project Structure

```
StudentStudyPlanner/
├── Enums/              # Енумерации
│   ├── Priority.cs
│   ├── TaskStatus.cs
│   └── TaskType.cs
├── Interfaces/         # Интерфейси
│   └── ITaskManager.cs
├── Models/             # Модели/Класове
│   ├── Course.cs
│   ├── DataManager.cs
│   ├── StudyTask.cs   # Базов клас
│   ├── Homework.cs    # Наследява StudyTask
│   ├── Exam.cs        # Наследява StudyTask
│   └── Project.cs     # Наследява StudyTask
└── Forms/              # Windows Forms
    ├── MainForm.cs
    ├── CourseForm.cs
    └── TaskForm.cs
```

## Технологии / Technologies

- C# 12.0
- .NET 8.0
- Windows Forms
- Visual Studio / Visual Studio Code

## Изграждане / Building

```bash
cd StudentStudyPlanner
dotnet build
```

## Стартиране / Running

```bash
cd StudentStudyPlanner
dotnet run
```

Или директно стартирайте изпълнимия файл:
```
StudentStudyPlanner/bin/Debug/net8.0-windows/StudentStudyPlanner.exe
```

## Използване / Usage

1. При стартиране се зареждат примерни данни
2. **Курсове панел** (ляво):
   - Изберете курс от списъка
   - Добавете нов курс с бутон "Добави"
   - Редактирайте курс с бутон "Редактирай"
   - Изтрийте курс с бутон "Изтрий"

3. **Задачи панел** (дясно):
   - След избор на курс, вижте неговите задачи
   - Добавете нова задача с бутон "Добави"
   - Редактирайте задача с бутон "Редактирай"
   - Изтрийте задача с бутон "Изтрий"
   - Двоен клик на задача показва детайли

## ООП Концепции / OOP Concepts

### Наследяване / Inheritance
```csharp
public abstract class StudyTask { ... }
public class Homework : StudyTask { ... }
public class Exam : StudyTask { ... }
public class Project : StudyTask { ... }
```

### Интерфейс / Interface
```csharp
public interface ITaskManager
{
    void AddTask(StudyTask task);
    void RemoveTask(StudyTask task);
    List<StudyTask> GetAllTasks();
    void UpdateTask(StudyTask task);
}

public class Course : ITaskManager { ... }
```

### Енумерации / Enums
```csharp
public enum TaskType { Homework, Exam, Project }
public enum Priority { Low, Medium, High }
public enum TaskStatus { NotStarted, InProgress, Completed }
```

### Полиморфизъм / Polymorphism
```csharp
// Виртуален метод в базовия клас
public virtual string GetDetails() { ... }

// Презаписан в производните класове
public override string GetDetails() { ... }
```

## Автор / Author

VIBAG-bg

## Лиценз / License

Учебен проект за курс CSCB579
