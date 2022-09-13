using System.Drawing;
using assemblyLineApp.Interfaces;
using Colorful;
using Console = Colorful.Console;

namespace assemblyLineApp.FunctionalParts;

/// <summary>
/// Исполнительный механизм №2
/// </summary>
public class ActuatingMechanism2: ActuatingMechanismBase,IActuatingMechanism2
{
    private readonly StyleSheet _styleFuchsia;
    private readonly StyleSheet _styleWhite;
    private readonly StyleSheet _styleRed;

    public ActuatingMechanism2()
    {
        _styleFuchsia = new StyleSheet(Color.Fuchsia);
        _styleWhite = new StyleSheet(Color.White);
        _styleRed = new StyleSheet(Color.Red);
    }

    /// <inheritdoc />
    public override async Task DetailProcessing()
    {
        Console.WriteLine();
        Console.WriteLineStyled("   Исполнительный механизм №2",_styleWhite);
        Console.WriteLineStyled("   Подготовка к обработке детали",_styleWhite);
        await Task.Run(Work); 
        Console.WriteLineStyled("   Окончание обработки детали",_styleWhite);
        Console.WriteLine();
    }

    /// <inheritdoc />  
    private protected override void Work()
    {
        Thread.Sleep(1500);     // имитация продолжительной работы
        Console.WriteLineStyled("   Процесс обработки",_styleFuchsia);
        Thread.Sleep(1500);     // имитация продолжительной работы
        
        var rnd = new Random();
        var value = rnd.Next(0, 10);
        
        // имитация аварии
        if (value > 5)
        {
            Console.WriteLineStyled("   Произошла авария во время обработки "
                + "детали!",_styleRed);
            Console.WriteLineStyled("   Для продолжения нажмите клавишу 'v'!",_styleRed);
            string key;

            do
            {
                key = Console.ReadKey().KeyChar.ToString().ToLower();
            } while (key != "v");
        }
    }
}