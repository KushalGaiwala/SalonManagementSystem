CREATE TABLE [dbo].[tblProductType] (
    [ptypeid] INT           IDENTITY (1, 1) NOT NULL,
    [ptype]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_tblProductType] PRIMARY KEY CLUSTERED ([ptypeid] ASC)
);

