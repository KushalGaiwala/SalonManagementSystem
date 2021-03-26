CREATE TABLE [dbo].[tblEmployee] (
    [eid]        INT           NOT NULL,
    [ename]      VARCHAR (150) NOT NULL,
    [dob]        DATE          NOT NULL,
    [gender]     CHAR (1)      CONSTRAINT [DF_tblEmployee_gender] DEFAULT ('M') NOT NULL,
    [cno]        BIGINT        NOT NULL,
    [houseno]    VARCHAR (20)  NULL,
    [street]     VARCHAR (50)  NULL,
    [area]       VARCHAR (50)  NULL,
    [cityid]     INT           NOT NULL,
    [doj]        DATE          NOT NULL,
    [experience] INT           CONSTRAINT [DF_tblEmployee_experience] DEFAULT ((0)) NOT NULL,
    [salary]     FLOAT (53)    CONSTRAINT [DF_tblEmployee_salary] DEFAULT ((0)) NOT NULL,
    [proof]      VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED ([eid] ASC),
    CONSTRAINT [FK_tblCity_tblEmployee] FOREIGN KEY ([cityid]) REFERENCES [dbo].[tblCity] ([cityid])
);

