using SnsSample.Domain.Models.Account.ValueObjects;
using SnsSample.Domain.Models.Article.ValueObjects;

namespace SnsSample.Domain.Models.Article.Entities;

public class ArticleEntity
{
    public ArticleId ArticleId { get; private set; }
    public AccountId AccountId { get; private set; }
    public Slug Slug { get; private set; }
    public Text Text { get; private set; }

    public ArticleEntity(ArticleId articleId, AccountId accountId, Slug slug, Text text)
    {
        this.ArticleId = articleId;
        this.AccountId = accountId;
        this.Slug = slug;
        this.Text = text;
    }
}
