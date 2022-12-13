using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Profiles.ValueObjects;

public record Biography : ValueObject<string>
{
    private static readonly int maxLength = 160;

    public Biography(string value) : base(value)
    {
        if (value.Length > maxLength)
        {
            throw new BiographyLengthOutOfRangeException($"自己紹介を {maxLength} を超える値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class BiographyLengthOutOfRangeException : Exception
{
    public BiographyLengthOutOfRangeException()
    {
    }

    public BiographyLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public BiographyLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected BiographyLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
