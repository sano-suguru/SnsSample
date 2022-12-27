using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Articles.ValueObjects;

namespace SnsSample.Domain.Models.Articles.Entities;

public class Article
{
    public ArticleId? Id { get; private set; }
    public AccountId AccountId { get; private set; }
    public Slug Slug { get; private set; }
    public Text Text { get; private set; }

    public Article(AccountId accountId, Slug slug, Text text)
    {
        this.AccountId = accountId;
        this.Slug = slug;
        this.Text = text;
    }
}
