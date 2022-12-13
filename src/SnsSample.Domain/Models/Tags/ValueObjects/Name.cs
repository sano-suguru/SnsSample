using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Tags.ValueObjects;

public record Name : ValueObject<string>
{
    private static readonly int maxLength = 140;

    public Name(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceNameException($"{nameof(Name)} を NULL または空白にすることはできません。実際の値：'{value}'");
        }

        if (value.Length > maxLength)
        {
            throw new NameLengthOutOfRangeException($"{nameof(Name)} を {maxLength} を超える値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NameLengthOutOfRangeException : Exception
{
    public NameLengthOutOfRangeException()
    {
    }

    public NameLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public NameLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NameLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class NullOrWhiteSpaceNameException : Exception
{
    public NullOrWhiteSpaceNameException()
    {
    }

    public NullOrWhiteSpaceNameException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceNameException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceNameException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
