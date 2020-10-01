Create table Table_DB_Bank(
Id int not null IDENTITY,
BankName nvarchar(max) null,
IFSC nvarchar(100) null,
CONSTRAINT PK_Table_DB_Bank PRIMARY KEY (Id)
);