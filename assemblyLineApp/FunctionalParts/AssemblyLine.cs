using System.Drawing;
using assemblyLineApp.Interfaces;
using Colorful;
using Console = Colorful.Console;

namespace assemblyLineApp.FunctionalParts;

/// <inheritdoc />
public class AssemblyLine: IAssemblyLine
{
    /// <summary>
    /// Исполнительный механизм №1
    /// </summary>
    private readonly IActuatingMechanism1 _actuatingMechanism1;

    /// <summary>
    /// Исполнительный механизм №2
    /// </summary>
    private readonly IActuatingMechanism2 _actuatingMechanism2;
    
    /// <summary>
    /// Исполнительный механизм №3
    /// </summary>
    private readonly IActuatingMechanism3 _actuatingMechanism3;
    
    /// <summary>
    /// Исполнительный механизм №4
    /// </summary>
    private readonly IActuatingMechanism4 _actuatingMechanism4;

    // Стилизация консоли
    private readonly StyleSheet _styleWhite;
    private readonly StyleSheet _styleGold;

    public AssemblyLine(IActuatingMechanism1 actuatingMechanism1,
        IActuatingMechanism2 actuatingMechanism2,
        IActuatingMechanism3 actuatingMechanism3,
        IActuatingMechanism4 actuatingMechanism4)
    {
        _actuatingMechanism1 = actuatingMechanism1;
        _actuatingMechanism2 = actuatingMechanism2;
        _actuatingMechanism3 = actuatingMechanism3;
        _actuatingMechanism4 = actuatingMechanism4;
        _styleWhite = new StyleSheet(Color.White);
        _styleGold = new StyleSheet(Color.Gold);
    }

    /// <inheritdoc />
    public async Task StartLine()
    {
        Console.WriteLineStyled($"   Конвейер запущен", _styleGold);
        int i = 1;
        do
        {
            Console.WriteLineStyled($"   Начало цикла №{i}", _styleWhite);
            await _actuatingMechanism1.DetailProcessing();
            await Task.Delay(2000);
            await _actuatingMechanism2.DetailProcessing();
            await Task.Delay(2000);
            await _actuatingMechanism3.DetailProcessing();
            await Task.Delay(2000);
            await _actuatingMechanism4.DetailProcessing();
            await Task.Delay(2000);

            Console.WriteLineStyled($"   Конец цикла №{i}", _styleWhite);
            Console.WriteLine();
            await Task.Delay(2000);
            i++;
        } while (true);
    }
}