create database Newspaper;
GO

use Newspaper;
GO

Create table News(
NewsId int not null IDENTITY,
Sections nvarchar(max) not null,
CONSTRAINT PK_News PRIMARY KEY (NewsId)
);

Create table Post(
PostId int not null identity,
NewsId int not null,
Conten nvarchar(max),
Title nvarchar(max),
Constraint PK_Post PRIMARY KEY (PostId),
Constraint FK_Post_News_NewId FOREIGN KEY (NewsId) REFERENCES News (NewsId) ON DELETE CASCADE
);

Insert into dbo.News (Sections) values (N'Enterainment');
GO
Insert into dbo.News (Sections) values (N'Sporst');
GO
Insert into dbo.News (Sections) values (N'Education');
GO
Insert into dbo.News (Sections) values (N'Business');
GO

Select top (1000) [NewsId]
,[Sections]
FROM[Newspaper].[dbo].[News]