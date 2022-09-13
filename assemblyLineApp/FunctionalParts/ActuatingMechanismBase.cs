using assemblyLineApp.Interfaces;

namespace assemblyLineApp.FunctionalParts;

public class ActuatingMechanismBase: IActuatingMechanismBase
{
    /// <inheritdoc />
    public virtual Task DetailProcessing()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Совершаемая работа
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    private protected virtual void Work()
    {
        throw new NotImplementedException();
    }
}