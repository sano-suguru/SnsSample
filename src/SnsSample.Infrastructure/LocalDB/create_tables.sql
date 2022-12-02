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
	"UpdatedAt"	INTEGER,
	PRIMARY KEY("AccountId" AUTOINCREMENT)
)

CREATE INDEX "IX_Account_Code" ON "Account" (
	"Code"
)

CREATE INDEX "IX_Account_CreatedAt" ON "Account" (
	"CreatedAt"
)

CREATE INDEX "IX_Account_Nickname" ON "Account" (
	"NIckname"
)
CREATE TABLE "Friendship" (
	"FriendshipId"	INTEGER NOT NULL UNIQUE,
	"Following"	INTEGER NOT NULL,
	"Followed"	INTEGER NOT NULL,
	FOREIGN KEY("Followed") REFERENCES "Account"("AccountId"),
	FOREIGN KEY("Following") REFERENCES "Account"("AccountId"),
	PRIMARY KEY("FriendshipId" AUTOINCREMENT)
)

CREATE INDEX "IX_Friendship_Following_Followed" ON "Friendship" (
	"Following",
	"Followed"
)
