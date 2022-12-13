using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Articles.ValueObjects;

namespace SnsSample.Domain.Models.Articles.Entities;

public class Article
{
    public ArticleId ArticleId { get; private set; }
    public AccountId AccountId { get; private set; }
    public Slug Slug { get; private set; }
    public Text Text { get; private set; }

    public Article(ArticleId articleId, AccountId accountId, Slug slug, Text text)
    {
        this.ArticleId = articleId;
        this.AccountId = accountId;
        this.Slug = slug;
        this.Text = text;
    }
}
