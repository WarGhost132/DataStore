namespace DataStore.Common.Abstractions.Interfaces;

public interface ILoggingService
{
    void LogError(string message, Exception exception);
}
