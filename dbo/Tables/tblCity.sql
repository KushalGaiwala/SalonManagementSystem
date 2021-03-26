CREATE TABLE [dbo].[tblCity] (
    [cityid]   INT         IDENTITY (1, 1) NOT NULL,
    [cityname] NCHAR (100) NOT NULL,
    [pincode]  INT         NOT NULL,
    CONSTRAINT [PK_tblCity] PRIMARY KEY CLUSTERED ([cityid] ASC),
    CONSTRAINT [IX_tblCity] UNIQUE NONCLUSTERED ([pincode] ASC)
);

