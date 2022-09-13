namespace assemblyLineApp.Interfaces;

/// <summary>
/// Сборочный конвейер
/// </summary>
public interface IAssemblyLine
{
    /// <summary>
    /// Запуск конвейера
    /// </summary>
    public Task StartLine();
}