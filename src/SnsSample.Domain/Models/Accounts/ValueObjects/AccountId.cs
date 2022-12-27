using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Accounts.ValueObjects;

public record AccountId : ValueObject<long>
{
    public AccountId(long value) : base(value)
    {
        if (value < 0)
        {
            throw new NegativeAccountIdException($"{nameof(AccountId)} は負の値にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NegativeAccountIdException : Exception
{
    public NegativeAccountIdException()
    {
    }

    public NegativeAccountIdException(string? message) : base(message)
    {
    }

    public NegativeAccountIdException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NegativeAccountIdException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
