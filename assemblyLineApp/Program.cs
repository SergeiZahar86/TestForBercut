using System.Diagnostics.CodeAnalysis;
using Autofac;

namespace assemblyLineApp;

[ExcludeFromCodeCoverage]
public class Program
{
    public static async Task Main(string[] args)
    {
        await ConfigurationAutofac.CompositionRoot().Resolve<Application>().Run();
    }
}