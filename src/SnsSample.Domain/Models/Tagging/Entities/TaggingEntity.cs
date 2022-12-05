using SnsSample.Domain.Models.Article.ValueObjects;
using SnsSample.Domain.Models.Tag.ValueObjects;
using SnsSample.Domain.Models.Tagging.ValueObjects;

namespace SnsSample.Domain.Models.Tagging.Entities;

public class TaggingEntity
{
    public TaggingId TaggingId { get; private set; }
    public ArticleId ArticleId { get; private set; }
    public TagId TagId { get; private set; }

    public TaggingEntity(
        TaggingId taggingId
        , ArticleId articleId
        , TagId tagId )
    {
        this.TaggingId = taggingId;
        this.ArticleId = articleId;
        this.TagId = tagId;
    }
}
