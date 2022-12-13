using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Comments.ValueObjects;

public record CommentId : ValueObject<long>
{
    public CommentId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeCommentIdException($"{nameof(CommentId)} は負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeCommentIdException : Exception
{
    public NegativeCommentIdException()
    {
    }

    public NegativeCommentIdException(string? message) : base(message)
    {
    }

    public NegativeCommentIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeCommentIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
