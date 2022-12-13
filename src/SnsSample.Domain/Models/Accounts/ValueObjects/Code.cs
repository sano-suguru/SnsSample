using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Accounts.ValueObjects;

public record Code : ValueObject<string>
{
    private static readonly int maxLength = 15;

    public Code(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceCodeException($"{nameof(Code)} を null または空白にすることはできません。実際の値：'{value}'");
        }

        if (value.Length > maxLength)
        {
            throw new CodeLengthOutOfRangeException($"{nameof(Code)} を {maxLength} を超える値にできません。実際の値：'{value}'");
        }

        if (!Regex.IsMatch(value, @"^[0-9a-zA-Z]+$"))
        {
            throw new IllegalCodePatternException($"{nameof(Code)} は半角英数値以外の値にはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
public class NullOrWhiteSpaceCodeException : Exception
{
    public NullOrWhiteSpaceCodeException()
    {
    }

    public NullOrWhiteSpaceCodeException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceCodeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
public class CodeLengthOutOfRangeException : Exception
{
    public CodeLengthOutOfRangeException()
    {
    }

    public CodeLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public CodeLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CodeLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
public class IllegalCodePatternException : Exception
{
    public IllegalCodePatternException()
    {
    }

    public IllegalCodePatternException(string? message) : base(message)
    {
    }

    public IllegalCodePatternException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected IllegalCodePatternException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
