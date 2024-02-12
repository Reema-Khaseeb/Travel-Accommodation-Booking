public class ExceptionLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionLoggingMiddleware> _logger;

    public ExceptionLoggingMiddleware(RequestDelegate next, ILogger<ExceptionLoggingMiddleware> logger)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            LogException(ex);
            RethrowException(ex);
        }
    }

    private void LogException(Exception ex)
    {
        _logger.LogError(ex, "An unhandled exception occurred.");
    }

    private static void RethrowException(Exception ex)
    {
        // Rethrow the exception to maintain normal exception flow
        throw ex;
    }
}

public static class ExceptionLoggingMiddlewareExtensions
{
    public static IApplicationBuilder UseExceptionLogging(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionLoggingMiddleware>();
    }
}
