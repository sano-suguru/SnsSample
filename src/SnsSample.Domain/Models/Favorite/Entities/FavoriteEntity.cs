using SnsSample.Domain.Models.Account.ValueObjects;
using SnsSample.Domain.Models.Article.ValueObjects;
using SnsSample.Domain.Models.Favorite.ValueObjects;

namespace SnsSample.Domain.Models.Favorite.Entities;

public class FavoriteEntity
{
    public FavoriteId FavoriteId { get; private set; }
    public AccountId AccountId { get; private set; }
    public ArticleId ArticleId { get; private set; }

    public FavoriteEntity(
        FavoriteId favoriteId
        , AccountId accountId
        , ArticleId articleId)
    {
        this.FavoriteId = favoriteId;
        this.AccountId = accountId;
        this.ArticleId = articleId;
    }
}
