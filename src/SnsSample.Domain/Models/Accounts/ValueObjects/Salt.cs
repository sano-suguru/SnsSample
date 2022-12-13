using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Accounts.ValueObjects;

public record Salt : ValueObject<string>
{
    private static readonly int maxLength = 24;

    public Salt(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceSaltException($"{nameof(Salt)} を null または空白にすることはできません。実際の値：'{value}'");
        }

        if (value.Length > maxLength)
        {
            throw new SaltLengthOutOfRangeException($"{nameof(Salt)} を {maxLength} を超える値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class SaltLengthOutOfRangeException : Exception
{
    public SaltLengthOutOfRangeException()
    {
    }

    public SaltLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public SaltLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected SaltLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class NullOrWhiteSpaceSaltException : Exception
{
    public NullOrWhiteSpaceSaltException()
    {
    }

    public NullOrWhiteSpaceSaltException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceSaltException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceSaltException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
