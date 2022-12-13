using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Articles.ValueObjects;

public record Slug : ValueObject<string>
{
    private static readonly int maxLength = 26;

    public Slug(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceSlugException($"{nameof(Slug)} を null または空白にすることはできません。実際の値：'{value}'");
        }

        if (value.Length > maxLength)
        {
            throw new SlugLengthOutOfRangeException($"'{nameof(Slug)}' を {maxLength}を超える値にすることはできません。実際の値：'{value}'");
        }

        if (!Regex.IsMatch(value, @"^[0-9a-zA-Z]+$"))
        {
            throw new IllegalSlugPatternException($"'{nameof(Slug)}' を 半角英数字以外の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class IllegalSlugPatternException : Exception
{
    public IllegalSlugPatternException()
    {
    }

    public IllegalSlugPatternException(string? message) : base(message)
    {
    }

    public IllegalSlugPatternException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected IllegalSlugPatternException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class SlugLengthOutOfRangeException : Exception
{
    public SlugLengthOutOfRangeException()
    {
    }

    public SlugLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public SlugLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected SlugLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class NullOrWhiteSpaceSlugException : Exception
{
    public NullOrWhiteSpaceSlugException()
    {
    }

    public NullOrWhiteSpaceSlugException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceSlugException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceSlugException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
