using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Articles.ValueObjects;
using SnsSample.Domain.Models.Favorite.ValueObjects;

namespace SnsSample.Domain.Models.Favorites.Entities;

public class Favorite
{
    public FavoriteId? Id { get; private set; }
    public AccountId AccountId { get; private set; }
    public ArticleId ArticleId { get; private set; }

    public Favorite(
        AccountId accountId
        , ArticleId articleId)
    {
        this.AccountId = accountId;
        this.ArticleId = articleId;
    }
}
