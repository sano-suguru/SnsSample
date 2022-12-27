using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Accounts.ValueObjects;

public record Hashed : ValueObject<string>
{
    private static readonly int maxLength = 64;

    public Hashed(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceHashedException($"{nameof(Hashed)} を null または空白にすることはできません。実際の値：'{value}'");
        }

        if (value.Length > maxLength)
        {
            throw new HashedLengthOutOfRangeException($"{nameof(Hashed)} を {maxLength} を超える値にすることはできません。実際の値：'{value}'");
        }

        if (!Regex.IsMatch(value, @"^[0-9a-zA-Z]+$"))
        {
            throw new IllegalHashedPatternException($"{nameof(Hashed)} を半角英数字以外の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class IllegalHashedPatternException : Exception
{
    public IllegalHashedPatternException()
    {
    }

    public IllegalHashedPatternException(string? message) : base(message)
    {
    }

    public IllegalHashedPatternException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected IllegalHashedPatternException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class HashedLengthOutOfRangeException : Exception
{
    public HashedLengthOutOfRangeException()
    {
    }

    public HashedLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public HashedLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected HashedLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class NullOrWhiteSpaceHashedException : Exception
{
    public NullOrWhiteSpaceHashedException()
    {
    }

    public NullOrWhiteSpaceHashedException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceHashedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceHashedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
