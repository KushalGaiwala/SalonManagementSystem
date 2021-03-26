CREATE TABLE [dbo].[tblService] (
    [sid]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [sname] VARCHAR (50) NOT NULL,
    [price] FLOAT (53)   CONSTRAINT [DF_tblService_price] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tblService] PRIMARY KEY CLUSTERED ([sid] ASC)
);

