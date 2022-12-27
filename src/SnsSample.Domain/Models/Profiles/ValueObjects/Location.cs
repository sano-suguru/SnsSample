using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Profiles.ValueObjects;

public record Location : ValueObject<string>
{
    private static readonly int maxLength = 30;

    public Location(string value) : base(value)
    {
        if (value.Length > maxLength)
        {
            throw new LocationLengthOutOfRangeException($"{nameof(Location)} は {maxLength} を超える値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class LocationLengthOutOfRangeException : Exception
{
    public LocationLengthOutOfRangeException()
    {
    }

    public LocationLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public LocationLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected LocationLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
