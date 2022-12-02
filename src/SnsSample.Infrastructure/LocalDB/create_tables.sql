CREATE TABLE "Account" (
	"AccountId"	INTEGER NOT NULL UNIQUE,
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
