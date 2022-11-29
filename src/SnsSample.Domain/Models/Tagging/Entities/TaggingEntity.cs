﻿using SnsSample.Domain.Models.Article.ValueObjects;
using SnsSample.Domain.Models.Tag.ValueObjects;
using SnsSample.Domain.Models.Tagging.ValueObjects;

namespace SnsSample.Domain.Models.Tagging.Entities;

public class TaggingEntity
{
    public TaggingId TaggingId { get; init; }
    public ArticleId ArticleId { get; init; }
    public TagId TagId { get; init; }

    public TaggingEntity(TaggingId taggingId, ArticleId articleId, TagId tagId )
    {
        TaggingId = taggingId;
        ArticleId = articleId;
        TagId = tagId;
    }
}