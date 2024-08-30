namespace DataStore.Common.Services;

public class LoggingService(ISnackbar snackbar, ILogger<LoggingService> logger) : ILoggingService
{
    private readonly ILogger<LoggingService> _logger = logger;
    private readonly ISnackbar _snackbar = snackbar;

    public void LogError(string message, Exception exception)
    {
        _logger.LogError(exception, "{Message}: {ExceptionMessage}", message, exception);

        _snackbar.Add(message, Severity.Error);
    }

    public void LogSuccess(string message)
    {
        _logger.LogInformation("{Message}", message);

        _snackbar.Add(message, Severity.Success);
    }
}
