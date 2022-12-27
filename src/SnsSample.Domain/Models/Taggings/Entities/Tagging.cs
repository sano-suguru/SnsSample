using SnsSample.Domain.Models.Articles.ValueObjects;
using SnsSample.Domain.Models.Taggings.ValueObjects;
using SnsSample.Domain.Models.Tags.ValueObjects;

namespace SnsSample.Domain.Models.Taggings.Entities;

public class TaggingEntity
{
    public TaggingId? TaggingId { get; private set; }
    public ArticleId ArticleId { get; private set; }
    public TagId TagId { get; private set; }

    public TaggingEntity(ArticleId articleId, TagId tagId)
    {
        this.ArticleId = articleId;
        this.TagId = tagId;
    }
}
