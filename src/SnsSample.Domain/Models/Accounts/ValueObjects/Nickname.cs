using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Accounts.ValueObjects;

public record Nickname : ValueObject<string>
{
    private static readonly int maxLength = 50;

    public Nickname(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceNicknameException($"{nameof(Nickname)} を null または空白にすることはできません。実際の値：'{value}'");
        }

        if (value.Length > maxLength)
        {
            throw new NicknameLengthOutOfRangeException($"{nameof(Nickname)} を {maxLength} を超える値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NicknameLengthOutOfRangeException : Exception
{
    public NicknameLengthOutOfRangeException()
    {
    }

    public NicknameLengthOutOfRangeException(string? message) : base(message)
    {
    }

    public NicknameLengthOutOfRangeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NicknameLengthOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

[Serializable]
internal class NullOrWhiteSpaceNicknameException : Exception
{
    public NullOrWhiteSpaceNicknameException()
    {
    }

    public NullOrWhiteSpaceNicknameException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceNicknameException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceNicknameException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
