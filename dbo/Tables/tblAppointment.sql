CREATE TABLE [dbo].[tblAppointment] (
    [aid]  INT      IDENTITY (1, 1) NOT NULL,
    [acid] INT      NOT NULL,
    [apid] INT      NOT NULL,
    [time] TIME (7) NOT NULL,
    [date] DATE     NOT NULL,
    CONSTRAINT [PK_tblAppointment] PRIMARY KEY CLUSTERED ([aid] ASC),
    CONSTRAINT [FK_tblCustomer_tblAppointment] FOREIGN KEY ([acid]) REFERENCES [dbo].[tblCustomer] ([custid]),
    CONSTRAINT [FK_tblPackage_tblAppointment] FOREIGN KEY ([apid]) REFERENCES [dbo].[tblPackage] ([pid])
);

