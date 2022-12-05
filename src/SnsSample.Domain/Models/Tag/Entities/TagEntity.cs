using SnsSample.Domain.Models.Tag.ValueObjects;

namespace SnsSample.Domain.Models.Tag.Entities;

public class TagEntity
{
    public TagId TagId { get; private set; }
    public Name Name { get; private set; }

    public TagEntity(TagId tagId, Name name)
    {
        this.TagId = tagId;
        this.Name = name;
    }
}
