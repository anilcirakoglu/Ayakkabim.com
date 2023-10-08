CREATE TABLE [dbo].[Product] (
    [Id]        INT          NOT NULL,
    [name]      TEXT         NULL,
    [price]     DECIMAL (18) NULL,
    [shoesSize] DECIMAL (18) NULL,
    [Gender]    TEXT         NULL,
    [Brand]     TEXT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

