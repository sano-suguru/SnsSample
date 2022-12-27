using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Friendships.ValueObjects;

public record FriendshipId : ValueObject<long>
{
    public FriendshipId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeFriendshipIdException($"{nameof(FriendshipId)} を負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeFriendshipIdException : Exception
{
    public NegativeFriendshipIdException()
    {
    }

    public NegativeFriendshipIdException(string? message) : base(message)
    {
    }

    public NegativeFriendshipIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeFriendshipIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
