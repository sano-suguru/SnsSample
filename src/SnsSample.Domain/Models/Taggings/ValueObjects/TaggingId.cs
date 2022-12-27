using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Taggings.ValueObjects;

public record TaggingId : ValueObject<long>
{
    public TaggingId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeTaggingIdException($"{nameof(TaggingId)} は負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeTaggingIdException : Exception
{
    public NegativeTaggingIdException()
    {
    }

    public NegativeTaggingIdException(string? message) : base(message)
    {
    }

    public NegativeTaggingIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeTaggingIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
