CREATE TABLE [dbo].[tblLogin] (
    [lid]      INT           IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (500) NOT NULL,
    [password] VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED ([lid] ASC)
);

