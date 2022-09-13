namespace assemblyLineApp.Interfaces;

/// <summary>
/// Базовый интерфейс исполнительного механизма
/// </summary>
public interface IActuatingMechanismBase
{
    /// <summary>
    /// Обработка деталей
    /// </summary>
    public Task DetailProcessing();
}