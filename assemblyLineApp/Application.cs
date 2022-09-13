using assemblyLineApp.Interfaces;

namespace assemblyLineApp;

/// <summary>
/// Класс приложения для создания реального объекта с внедрением зависимостей
/// </summary>
public class Application
{
    /// <summary>
    /// Сборочный конвейер
    /// </summary>
    private readonly IAssemblyLine _assemblyLine;

    public Application(IAssemblyLine assemblyLine)
    {
        _assemblyLine = assemblyLine;
    }

    /// <summary>
    /// Запуск приложения
    /// </summary>
    public async Task Run()
    {
        await _assemblyLine.StartLine();
    }
}