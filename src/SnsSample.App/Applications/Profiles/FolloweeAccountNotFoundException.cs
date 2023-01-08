using System.Runtime.Serialization;

namespace SnsSample.App.Applications.Profiles;

[Serializable]
internal class FolloweeAccountNotFoundException : Exception
{
    public FolloweeAccountNotFoundException()
    {
    }

    public FolloweeAccountNotFoundException(string? message) : base(message)
    {
    }

    public FolloweeAccountNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected FolloweeAccountNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
