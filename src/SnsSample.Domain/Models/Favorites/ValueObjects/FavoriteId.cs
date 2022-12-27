using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Favorite.ValueObjects;

public record FavoriteId : ValueObject<long>
{
    public FavoriteId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeFavoriteIdException($"{nameof(FavoriteId)} を負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeFavoriteIdException : Exception
{
    public NegativeFavoriteIdException()
    {
    }

    public NegativeFavoriteIdException(string? message) : base(message)
    {
    }

    public NegativeFavoriteIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeFavoriteIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
