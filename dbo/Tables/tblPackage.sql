CREATE TABLE [dbo].[tblPackage] (
    [pid]   INT           IDENTITY (1, 1) NOT NULL,
    [pname] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_tblPackages] PRIMARY KEY CLUSTERED ([pid] ASC)
);

