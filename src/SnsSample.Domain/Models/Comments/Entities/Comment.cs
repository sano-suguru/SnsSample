using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Articles.ValueObjects;
using SnsSample.Domain.Models.Comments.ValueObjects;
using Text = SnsSample.Domain.Models.Comments.ValueObjects.Text;

namespace SnsSample.Domain.Models.Comments.Entities;

public class Comment
{
    public CommentId CommentId { get; private set; }
    public AccountId AccountId { get; private set; }
    public ArticleId ArticleId { get; private set; }
    public Text Text { get; private set; }

    public Comment(CommentId commentId
        , AccountId accountId
        , ArticleId articleId
        , Text text)
    {
        this.CommentId = commentId;
        this.AccountId = accountId;
        this.ArticleId = articleId;
        this.Text = text;
    }
}
