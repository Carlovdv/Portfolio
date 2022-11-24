using CDA.Application.Common.Interfaces.Services;

namespace CDA.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;

    public DateTimeOffset Now => DateTimeOffset.Now;
}