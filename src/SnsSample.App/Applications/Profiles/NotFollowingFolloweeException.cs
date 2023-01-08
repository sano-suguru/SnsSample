using System.Runtime.Serialization;

namespace SnsSample.App.Applications.Profiles;

[Serializable]
internal class NotFollowingFolloweeException : Exception
{
    public NotFollowingFolloweeException()
    {
    }

    public NotFollowingFolloweeException(string? message) : base(message)
    {
    }

    public NotFollowingFolloweeException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NotFollowingFolloweeException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
