using SnsSample.Domain.Models.Tags.ValueObjects;

namespace SnsSample.Domain.Models.Tags.Entities;

public class Tag
{
    public TagId TagId { get; private set; }
    public Name Name { get; private set; }

    public Tag(TagId tagId, Name name)
    {
        this.TagId = tagId;
        this.Name = name;
    }
}
