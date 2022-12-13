using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Profiles.ValueObjects;

public record ProfileId : ValueObject<long>
{
    public ProfileId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeProfileIdException($"{nameof(ProfileId)} は負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeProfileIdException : Exception
{
    public NegativeProfileIdException()
    {
    }

    public NegativeProfileIdException(string? message) : base(message)
    {
    }

    public NegativeProfileIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeProfileIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
