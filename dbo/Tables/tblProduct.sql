CREATE TABLE [dbo].[tblProduct] (
    [pid]      INT           IDENTITY (1, 1) NOT NULL,
    [pname]    VARCHAR (100) NOT NULL,
    [quantity] INT           CONSTRAINT [DF_tblProduct_quantity] DEFAULT ((0)) NOT NULL,
    [ptypeid]  INT           NOT NULL,
    CONSTRAINT [PK_tblProduct] PRIMARY KEY CLUSTERED ([pid] ASC),
    CONSTRAINT [FK_tblProductType_tblProduct] FOREIGN KEY ([ptypeid]) REFERENCES [dbo].[tblProductType] ([ptypeid])
);

