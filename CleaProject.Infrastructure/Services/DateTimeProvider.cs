using CleanProject.Application.Common.interfaces.Services;

namespace CleanProject.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}