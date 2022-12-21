CREATE TABLE "Account" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Code"	TEXT NOT NULL UNIQUE,
	"Salt"	TEXT NOT NULL,
	"Hashed"	TEXT NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
)

CREATE INDEX "IX_Account_Code" ON "Account" (
	"Code"
)

CREATE INDEX "IX_Account_CreatedAt" ON "Account" (
	"CreatedAt"
)

CREATE TABLE "Profile" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL UNIQUE,
	"Nickname"	TEXT NOT NULL,
	"Biography"	TEXT,
	"Location"	TEXT,
	"WebSite"	TEXT,
	"Birthday"	TEXT,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("AccountId") REFERENCES "Account"("Id")
)

CREATE INDEX "IX_Profile_AccountId" ON "Profile" (
	"AccountId"
)

CREATE INDEX "IX_Profile_Nickname" ON "Profile" (
	"Nickname"
)

CREATE INDEX "IX_Profile_CreatedAt" ON "Profile" (
	"CreatedAt"
)

CREATE TABLE "Friendship" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL,
	"FolllowedBy"	INTEGER NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("FolllowedBy") REFERENCES "Account"("Id"),
	FOREIGN KEY("AccountId") REFERENCES "Account"("Id")
)

CREATE INDEX "IX_Friendship_AccountId" ON "Friendship" (
	"AccountId"
)

CREATE INDEX "IX_Friendship_FollowedBy" ON "Friendship" (
	"FolllowedBy"
)

CREATE INDEX "IX_Friendship_CreatedAt" ON "Friendship" (
	"CreatedAt"
)

CREATE TABLE "Article" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL,
	"Slug"	TeXT NOT NULL UNIQUE,
	"Text"	TEXT NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("AccountId") REFERENCES "Account"("Id")
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
	"Id"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL,
	"ArticleId"	INTEGER NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdateAt"	INTEGER,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("AccountId") REFERENCES "Account"("Id"),
	FOREIGN KEY("ArticleId") REFERENCES "Article"("Id")
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
	"Id"	INTEGER NOT NULL UNIQUE,
	"AccountId"	INTEGER NOT NULL,
	"ArticleId"	INTEGER NOT NULL,
	"Text"	TEXT NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("ArticleId") REFERENCES "Article"("Id"),
	FOREIGN KEY("AccountId") REFERENCES "Account"("Id")
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
	"Id"	INTEGER NOT NULL UNIQUE,
	"Name"	TEXT NOT NULL UNIQUE,
	"CreatedAt"	TEXT NOT NULL,
	"UpdatedAt"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
)

CREATE INDEX "IX_Tag_Name" ON "Tag" (
	"Name"
)

CREATE INDEX "IX_Tag_CreatedAt" ON "Tag" (
	"CreatedAt"
)

CREATE TABLE "Tagging" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"ArticleId"	INTEGER NOT NULL,
	"TagId"	INTEGER NOT NULL,
	"CreatedAt"	TEXT NOT NULL,
	"UpdateAt"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("TagId") REFERENCES "Tag"("Id"),
	FOREIGN KEY("ArticleId") REFERENCES "Article"("Id")
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
