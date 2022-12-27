using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Tags.ValueObjects;

public record TagId : ValueObject<long>
{
    public TagId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeTagIdException($"{nameof(TagId)} を負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeTagIdException : Exception
{
    public NegativeTagIdException()
    {
    }

    public NegativeTagIdException(string? message) : base(message)
    {
    }

    public NegativeTagIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeTagIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
