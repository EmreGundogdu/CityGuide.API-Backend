CREATE TABLE [dbo].Photos
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CityId] INT NOT NULL, 
    [DateAdded] DATETIME2(7) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL,
    [IsMain] BIT NOT NULL,
    [Url] NVARCHAR(MAX) NULL,
    [PublicId] NVARCHAR(MAX) NULL
)