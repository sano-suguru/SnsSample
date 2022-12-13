using System.Runtime.Serialization;
using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Profiles.ValueObjects;

public record WebSite : ValueObject<string>
{
    public WebSite(string value) : base(value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new NullOrWhiteSpaceWebSiteException($"{nameof(Location)} は null または空白にすることはできません。実際の値：'{value}'");
        }
    }
}

[Serializable]
internal class NullOrWhiteSpaceWebSiteException : Exception
{
    public NullOrWhiteSpaceWebSiteException()
    {
    }

    public NullOrWhiteSpaceWebSiteException(string? message) : base(message)
    {
    }

    public NullOrWhiteSpaceWebSiteException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NullOrWhiteSpaceWebSiteException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
