using SnsSample.Domain.Models.Account.ValueObjects;
using SnsSample.Domain.Models.Article.ValueObjects;

namespace SnsSample.Domain.Models.Article.Entities;

public class ArticleEntity
{
    public ArticleId ArticleId { get; init; }
    public AccountId AccountId { get; init; }
    public Slug Slug { get; init; }
    public Text Text { get; init; }

    public ArticleEntity(ArticleId articleId, AccountId accountId, Slug slug, Text text)
    {
        this.ArticleId = articleId;
        AccountId = accountId;
        Slug = slug;
        Text = text;
    }
}
