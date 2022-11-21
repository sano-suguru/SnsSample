using SnsSample.Domain.Models.Tag.ValueObjects;

namespace SnsSample.Domain.Models.Tag.Entities;

public class TagEntity
{
    public TagId TagId { get; init; }
    public Name Name { get; init; }

    public TagEntity(TagId tagId, Name name)
    {
        TagId = tagId;
        Name = name;
    }
}
