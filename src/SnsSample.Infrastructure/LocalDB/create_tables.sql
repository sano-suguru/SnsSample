CREATE TABLE "Account" (
	"AccountId"	INTEGER NOT NULL UNIQUE,
	"Code"	TEXT NOT NULL UNIQUE,
	"NIckname"	TEXT NOT NULL,
	"Introduction"	TEXT,
	"Location"	TEXT,
	"WebSite"	TEXT,
	"Birthday"	TEXT,
	"Salt"	TEXT NOT NULL,
	"Hashed"	TEXT NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("AccountId" AUTOINCREMENT)
)

CREATE INDEX "IX_Account_Code" ON "Account" (
	"Code"
)

CREATE INDEX "IX_Account_Nickname" ON "Account" (
	"NIckname"
)

CREATE INDEX "IX_Account_CreatedAt" ON "Account" (
	"CreatedAt"
)

CREATE TABLE "Friendship" (
	"FriendshipId"	INTEGER NOT NULL UNIQUE,
	"Following"	INTEGER NOT NULL,
	"Followed"	INTEGER NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	FOREIGN KEY("Followed") REFERENCES "Account"("AccountId"),
	FOREIGN KEY("Following") REFERENCES "Account"("AccountId"),
	PRIMARY KEY("FriendshipId" AUTOINCREMENT)
)

CREATE INDEX "IX_Friendship_Following" ON "Friendship" (
	"Following"
)

CREATE INDEX "IX_Friendship_Followed" ON "Friendship" (
	"Followed"
)

CREATE INDEX "IX_Friendship_CreatedAt" ON "Friendship" (
	"CreatedAt"
)

CREATE TABLE "Article" (
	"ArticleId"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL,
	"Slug"	TeXT NOT NULL UNIQUE,
	"Text"	TEXT NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("ArticleId" AUTOINCREMENT)
)

CREATE INDEX "IX_Article_AccountId" ON "Article" (
	"AccountId"
)

CREATE INDEX "IX_Article_Slug" ON "Article" (
	"Slug"
)

CREATE INDEX "IX_Article_CreatedAt" ON "Article" (
	"CreatedAt"
)

CREATE TABLE "Favorite" (
	"FavoriteId"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL,
	"ArticleId"	INTEGER NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdateAt"	INTEGER,
	FOREIGN KEY("ArticleId") REFERENCES "Article"("ArticleId"),
	FOREIGN KEY("AccountId") REFERENCES "Account"("AccountId"),
	PRIMARY KEY("FavoriteId" AUTOINCREMENT)
)

CREATE INDEX "IX_Favorite_AccountId" ON "Favorite" (
	"AccountId"
)

CREATE INDEX "IX_Favorite_ArticleId" ON "Favorite" (
	"ArticleId"
)

CREATE INDEX "IX_Favorite_CreatedAt" ON "Favorite" (
	"CreatedAt"
)

CREATE TABLE "Comment" (
	"CommentId"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL,
	"ArticleId"	INTEGER NOT NULL,
	"Text"	TEXT NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	FOREIGN KEY("ArticleId") REFERENCES "Article"("ArticleId"),
	FOREIGN KEY("AccountId") REFERENCES "Account"("AccountId"),
	PRIMARY KEY("CommentId" AUTOINCREMENT)
)

CREATE INDEX "IX_Comment_AccountId" ON "Comment" (
	"AccountId"
)

CREATE INDEX "IX_Comment_ArticleId" ON "Comment" (
	"ArticleId"
)

CREATE INDEX "IX_Comment_CreatedAt" ON "Comment" (
	"CreatedAt"
)

CREATE TABLE "Tag" (
	"TagId"	INTEGER NOT NULL UNIQUE,
	"Name"	TEXT NOT NULL UNIQUE,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("TagId" AUTOINCREMENT)
)

CREATE INDEX "IX_Tag_Name" ON "Tag" (
	"Name"
)

CREATE INDEX "IX_Tag_CreatedAt" ON "Tag" (
	"CreatedAt"
)

CREATE TABLE "Tagging" (
	"TaggingId"	INTEGER NOT NULL UNIQUE,
	"ArticleId"	INTEGER NOT NULL,
	"TagId"	INTEGER NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdateAt"	TEXT,
	FOREIGN KEY("TagId") REFERENCES "Tag"("TagId"),
	FOREIGN KEY("ArticleId") REFERENCES "Article"("ArticleId"),
	PRIMARY KEY("TaggingId" AUTOINCREMENT)
)

CREATE INDEX "IX_Tagging_ArticleId" ON "Tagging" (
	"ArticleId"
)

CREATE INDEX "IX_Tagging_TagId" ON "Tagging" (
	"TagId"
)

CREATE INDEX "IX_Tagging_CreatedAt" ON "Tagging" (
	"CreatedAt"
)
