using System;
using SnsSample.Domain.Models.Account.ValueObjects;
using SnsSample.Domain.Models.Article.ValueObjects;
using SnsSample.Domain.Models.Favorite.ValueObjects;

namespace SnsSample.Domain.Models.Favorite.Entities
{
	public class FavoriteEntity
	{
        public FavoriteId FavoriteId { get; init; }
        public AccountId AccountId { get; init; }
        public ArticleId ArticleId { get; init; }

        public FavoriteEntity(FavoriteId favoriteId, AccountId accountId, ArticleId articleId)
		{
            FavoriteId = favoriteId;
            AccountId = accountId;
            ArticleId = articleId;
        }
    }
}

