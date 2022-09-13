using assemblyLineApp.FunctionalParts;
using assemblyLineApp.Interfaces;
using Autofac;

namespace assemblyLineApp;

/// <summary>
/// Класс конфигурации Autofack
/// </summary>
public static class ConfigurationAutofac
{
    /// <summary>
    /// Конфигурация контейнера
    /// </summary>
    public static IContainer CompositionRoot()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<Application>();
        builder.RegisterType<AssemblyLine>().As<IAssemblyLine>();
        builder.RegisterType<ActuatingMechanism1>().As<IActuatingMechanism1>();
        builder.RegisterType<ActuatingMechanism2>().As<IActuatingMechanism2>();
        builder.RegisterType<ActuatingMechanism3>().As<IActuatingMechanism3>();
        builder.RegisterType<ActuatingMechanism4>().As<IActuatingMechanism4>();
        return builder.Build();
    }
}