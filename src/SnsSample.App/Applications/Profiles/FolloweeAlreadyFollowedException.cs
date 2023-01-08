using System.Runtime.Serialization;

namespace SnsSample.App.Applications.Profiles;

[Serializable]
internal class FolloweeAlreadyFollowedException : Exception
{
    public FolloweeAlreadyFollowedException()
    {
    }

    public FolloweeAlreadyFollowedException(string? message) : base(message)
    {
    }

    public FolloweeAlreadyFollowedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected FolloweeAlreadyFollowedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}