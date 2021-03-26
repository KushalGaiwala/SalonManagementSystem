CREATE TABLE [dbo].[tblServicePackage] (
    [spid] INT IDENTITY (1, 1) NOT NULL,
    [ppid] INT NOT NULL,
    [cpid] INT NOT NULL,
    CONSTRAINT [PK_tblServicePackage] PRIMARY KEY CLUSTERED ([spid] ASC),
    CONSTRAINT [FK_tblCategory__tblServicePackage] FOREIGN KEY ([cpid]) REFERENCES [dbo].[tblCategory] ([cid]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_tblPackage_tblServicePackage] FOREIGN KEY ([ppid]) REFERENCES [dbo].[tblPackage] ([pid]) ON DELETE CASCADE ON UPDATE CASCADE
);

