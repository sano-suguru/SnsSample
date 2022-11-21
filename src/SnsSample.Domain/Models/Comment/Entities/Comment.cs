using System;
using SnsSample.Domain.Models.Account.ValueObjects;
using SnsSample.Domain.Models.Article.ValueObjects;
using SnsSample.Domain.Models.Comment.ValueObjects;
using Text = SnsSample.Domain.Models.Comment.ValueObjects.Text;

namespace SnsSample.Domain.Models.Comment.Entities;

public class Comment
{
    public CommentId CommentId { get; init; }
    public AccountId AccountId { get; init; }
    public ArticleId ArticleId { get; init; }
    public Text Text { get; init; }

    public Comment(CommentId commentId, AccountId accountId, ArticleId articleId, Text text)
    {
        CommentId = commentId;
        AccountId = accountId;
        ArticleId = articleId;
        Text = text;
    }
}
