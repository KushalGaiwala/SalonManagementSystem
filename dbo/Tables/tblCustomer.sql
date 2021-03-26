CREATE TABLE [dbo].[tblCustomer] (
    [custid]    INT           IDENTITY (1, 1) NOT NULL,
    [custname]  VARCHAR (100) NOT NULL,
    [houseno]   VARCHAR (20)  NOT NULL,
    [street]    VARCHAR (50)  NOT NULL,
    [area]      VARCHAR (50)  NOT NULL,
    [cityid]    INT           NOT NULL,
    [contactno] BIGINT        NOT NULL,
    [gender]    CHAR (1)      CONSTRAINT [DF_tblCustomer_gender] DEFAULT ('M') NOT NULL,
    CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED ([custid] ASC),
    CONSTRAINT [FK_tblCity_tblCustomer] FOREIGN KEY ([cityid]) REFERENCES [dbo].[tblCity] ([cityid])
);

