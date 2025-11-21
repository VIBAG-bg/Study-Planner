using StudentStudyPlanner.Forms;

namespace StudentStudyPlanner;

/// <summary>
/// Главен клас на приложението
/// Main application class
/// </summary>
static class Program
{
    /// <summary>
    /// Входна точка на приложението
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // Конфигурираме приложението
        // Configure the application
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }    
}