using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Comments.ValueObjects;

public record Text : ValueObject<string>
{
    private static readonly int maxLength = 140;

    public Text(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceTextException($"'{nameof(Text)}' を NULL または空にすることはできません。実際の値：'{value}'");
        }

        if (value.Length > maxLength)
        {
            throw new TextLengthOutOfRangeException($"'{nameof(Text)}' を {maxLength} を超える値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class TextLengthOutOfRangeException : Exception
{
    public TextLengthOutOfRangeException()
    {
    }

    public TextLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public TextLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected TextLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class NullOrWhiteSpaceTextException : Exception
{
    public NullOrWhiteSpaceTextException()
    {
    }

    public NullOrWhiteSpaceTextException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceTextException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceTextException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
