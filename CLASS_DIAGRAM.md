# Class Diagram / Диаграма на класовете

## Йерархия на класовете / Class Hierarchy

```
┌─────────────────────────────────────────────────────────────┐
│                      ITaskManager                            │
│                      (Interface)                             │
├─────────────────────────────────────────────────────────────┤
│ + AddTask(task: StudyTask): void                            │
│ + RemoveTask(task: StudyTask): void                         │
│ + GetAllTasks(): List<StudyTask>                            │
│ + UpdateTask(task: StudyTask): void                         │
└─────────────────────────────────────────────────────────────┘
                            △
                            │ implements
                            │
┌───────────────────────────┴─────────────────────────────────┐
│                         Course                               │
├─────────────────────────────────────────────────────────────┤
│ + Id: int                                                    │
│ + Name: string                                               │
│ + Code: string                                               │
│ + Instructor: string                                         │
│ + Semester: string                                           │
│ - tasks: List<StudyTask>                                     │
├─────────────────────────────────────────────────────────────┤
│ + AddTask(task: StudyTask): void                            │
│ + RemoveTask(task: StudyTask): void                         │
│ + GetAllTasks(): List<StudyTask>                            │
│ + UpdateTask(task: StudyTask): void                         │
│ + ToString(): string                                         │
└─────────────────────────────────────────────────────────────┘
                            ◆ contains
                            │
                            │ 1 to many
                            ▼
┌─────────────────────────────────────────────────────────────┐
│                      StudyTask                               │
│                   (Abstract Class)                           │
├─────────────────────────────────────────────────────────────┤
│ + Id: int                                                    │
│ + Name: string                                               │
│ + Description: string                                        │
│ + Deadline: DateTime                                         │
│ + Priority: Priority                                         │
│ + Status: TaskStatus                                         │
│ + Type: TaskType                                             │
├─────────────────────────────────────────────────────────────┤
│ # StudyTask()                                                │
│ + GetDetails(): string (virtual)                            │
│ + MarkAsCompleted(): void                                   │
│ + ToString(): string                                         │
└─────────────────────────────────────────────────────────────┘
              △                    △                    △
              │                    │                    │
              │ inherits           │ inherits           │ inherits
              │                    │                    │
    ┌─────────┴──────┐   ┌────────┴────────┐  ┌────────┴────────┐
    │    Homework     │   │      Exam       │  │     Project      │
    ├─────────────────┤   ├─────────────────┤  ├──────────────────┤
    │ + Subject: str  │   │ + Subject: str  │  │ + Subject: str   │
    │ + ExerciseNum   │   │ + ExamTime: str │  │ + TeamMembers    │
    │   : string      │   │ + Location: str │  │   : string       │
    ├─────────────────┤   ├─────────────────┤  │ + Technologies   │
    │ + Homework()    │   │ + Exam()        │  │   : string       │
    │ + GetDetails()  │   │ + GetDetails()  │  ├──────────────────┤
    │   : string      │   │   : string      │  │ + Project()      │
    └─────────────────┘   └─────────────────┘  │ + GetDetails()   │
                                                │   : string       │
                                                └──────────────────┘

┌─────────────────────────────────────────────────────────────┐
│                    DataManager                               │
│                  (Singleton Pattern)                         │
├─────────────────────────────────────────────────────────────┤
│ - lazyInstance: Lazy<DataManager> (static)                   │
│ - courses: List<Course>                                      │
├─────────────────────────────────────────────────────────────┤
│ - DataManager()                                              │
│ + Instance: DataManager (static property)                   │
│ + AddCourse(course: Course): void                           │
│ + RemoveCourse(course: Course): void                        │
│ + GetAllCourses(): List<Course>                             │
│ + UpdateCourse(course: Course): void                        │
│ + GetCourseById(id: int): Course?                           │
└─────────────────────────────────────────────────────────────┘
                            ◆ manages
                            │
                            │ 1 to many
                            ▼
                         Course
```

## Енумерации / Enumerations

```
┌───────────────┐     ┌─────────────────┐     ┌────────────┐
│   TaskType    │     │   TaskStatus    │     │  Priority  │
├───────────────┤     ├─────────────────┤     ├────────────┤
│ • Homework    │     │ • NotStarted    │     │ • Low      │
│ • Exam        │     │ • InProgress    │     │ • Medium   │
│ • Project     │     │ • Completed     │     │ • High     │
└───────────────┘     └─────────────────┘     └────────────┘
```

## Windows Forms Структура / Windows Forms Structure

```
┌────────────────────────────────────────────────────────────┐
│                        MainForm                             │
│                   (Main Application)                        │
├────────────────────────────────────────────────────────────┤
│ - dataManager: DataManager                                  │
│ - selectedCourse: Course?                                   │
│ - lstCourses: ListBox                                       │
│ - lstTasks: ListBox                                         │
│ - btnAddCourse, btnEditCourse, btnDeleteCourse: Button     │
│ - btnAddTask, btnEditTask, btnDeleteTask: Button           │
├────────────────────────────────────────────────────────────┤
│ + MainForm()                                                │
│ - InitializeSampleData(): void                             │
│ - LoadCourses(): void                                       │
│ - LoadTasks(): void                                         │
│ - lstCourses_SelectedIndexChanged(...)                     │
│ - btnAddCourse_Click(...)                                   │
│ - btnEditCourse_Click(...)                                  │
│ - btnDeleteCourse_Click(...)                                │
│ - btnAddTask_Click(...)                                     │
│ - btnEditTask_Click(...)                                    │
│ - btnDeleteTask_Click(...)                                  │
│ - lstTasks_DoubleClick(...)                                │
└────────────────────────────────────────────────────────────┘
         │ opens                    │ opens
         ▼                          ▼
┌──────────────────┐      ┌──────────────────────┐
│   CourseForm     │      │      TaskForm        │
├──────────────────┤      ├──────────────────────┤
│ - course: Course?│      │ - course: Course     │
│ - isEditMode     │      │ - task: StudyTask?   │
│ - dataManager    │      │ - isEditMode         │
├──────────────────┤      ├──────────────────────┤
│ + CourseForm()   │      │ + TaskForm(...)      │
│ + CourseForm(...) │      │ - InitControls()    │
│ - LoadCourseData()│      │ - LoadTaskData()    │
│ - btnSave_Click() │      │ - cmbTaskType_      │
│ - btnCancel_Click()│      │   Changed(...)     │
└──────────────────┘      │ - btnSave_Click()   │
                          │ - btnCancel_Click() │
                          └──────────────────────┘
```

## Връзки между класовете / Relationships Between Classes

### Наследяване (Inheritance) - △
- `Homework`, `Exam`, `Project` наследяват `StudyTask`

### Имплементация (Implementation) - △
- `Course` имплементира `ITaskManager`

### Съдържание/Композиция (Composition) - ◆
- `Course` съдържа `List<StudyTask>`
- `DataManager` съдържа `List<Course>`

### Използване (Usage) - - - >
- `MainForm` използва `DataManager`
- `CourseForm` използва `DataManager`
- `TaskForm` използва `Course` и `StudyTask`

## Поток на данни / Data Flow

```
User Interaction
       │
       ▼
┌──────────────┐
│   MainForm   │ ◄──────── Sample Data on Startup
└──────┬───────┘
       │ uses
       ▼
┌──────────────────┐
│  DataManager     │
│  (Singleton)     │
└──────┬───────────┘
       │ manages
       ▼
┌──────────────────┐
│  List<Course>    │
└──────┬───────────┘
       │ each contains
       ▼
┌──────────────────┐
│ List<StudyTask>  │
│  - Homework      │
│  - Exam          │
│  - Project       │
└──────────────────┘
```

## Legend / Легенда

- **△** - Наследяване или Имплементация (Inheritance or Implementation)
- **◆** - Съдържание/Композиция (Composition)
- **▼** - Насока на връзката (Direction of relationship)
- **+** - Public член (Public member)
- **-** - Private член (Private member)
- **#** - Protected член (Protected member)
