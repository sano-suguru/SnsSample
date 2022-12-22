using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Articles.ValueObjects;
using SnsSample.Domain.Models.Comments.ValueObjects;
using Text = SnsSample.Domain.Models.Comments.ValueObjects.Text;

namespace SnsSample.Domain.Models.Comments.Entities;

public class Comment
{
    public CommentId? Id { get; private set; }
    public AccountId AccountId { get; private set; }
    public ArticleId ArticleId { get; private set; }
    public Text Text { get; private set; }

    public Comment(
        AccountId accountId
        , ArticleId articleId
        , Text text)
    {
        this.AccountId = accountId;
        this.ArticleId = articleId;
        this.Text = text;
    }
}
