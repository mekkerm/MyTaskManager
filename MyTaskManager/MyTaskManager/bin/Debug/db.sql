PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE Tasks(
	ID TEXT PRIMARY KEY NOT NULL,
	TITLE TEXT NOT NULL,
	DESCRIPTION TEXT,
	CREATION_DATE DATETIME NOT NULL
);
INSERT INTO "Tasks" VALUES('d6f5a201-cdf4-4061-ab76-edd588ba2b0e','432f','fdsfsd','2/14/2016 12:39:45 PM');
INSERT INTO "Tasks" VALUES('5b3b19c2-f7a2-4b45-b5c3-7b0d924a13c3','newest task','jkldfsdfhjdsfhj klahsdhl 
fgdsg
 asd
h
gfh
 .','2/14/2016 1:03:09 PM');
INSERT INTO "Tasks" VALUES('6cbaa4c5-99e4-4626-a599-9aca3446d8e4','Gyurika task','kl;jasdfjklsdf asdklas dkljasd kl; adsads ','2/14/2016 2:27:43 PM');
CREATE TABLE TaskTimes(
	ID INTEGER PRIMARY KEY NOT NULL,
	TASK_ID TEXT NOT NULL,
	START_DATE DATETIME,
	END_DATE DATETIME,
	FOREIGN KEY(TASK_ID) REFERENCES Tasks(ID)
);
COMMIT;
