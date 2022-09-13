using Microsoft.Extensions.Logging;

namespace assemblyLineApp;

public class AssemblyLine: IAssemblyLine
{
    private readonly ILogger _logger;

    public AssemblyLine(ILogger logger)
    {
        _logger = logger;
    }

    public void StartLine()
    {
        
        _logger.LogInformation("111111111111");
    }
}