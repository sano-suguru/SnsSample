using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Articles.ValueObjects;

public record ArticleId : ValueObject<long>
{
    public ArticleId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeArticleIdException($"{nameof(ArticleId)} は負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeArticleIdException : Exception
{
    public NegativeArticleIdException()
    {
    }

    public NegativeArticleIdException(string? message) : base(message)
    {
    }

    public NegativeArticleIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeArticleIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
