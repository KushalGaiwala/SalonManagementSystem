CREATE TABLE [dbo].[tblCategory] (
    [cid]   INT           IDENTITY (1, 1) NOT NULL,
    [cname] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_tblCategories] PRIMARY KEY CLUSTERED ([cid] ASC)
);

