IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Cars] (
    [Id] int NOT NULL IDENTITY,
    [RegistrationNumber] nvarchar(max) NULL,
    [Brand] nvarchar(max) NULL,
    [Mark] nvarchar(max) NULL,
    [Year] datetime2 NOT NULL,
    [IsReturned] bit NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [PhoneNumber] int NOT NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Bookings] (
    [Id] int NOT NULL IDENTITY,
    [CarId] int NOT NULL,
    [CustomerId] int NOT NULL,
    [StartTime] datetime2 NOT NULL,
    [EndTime] datetime2 NOT NULL,
    CONSTRAINT [PK_Bookings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Bookings_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Bookings_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Bookings_CarId] ON [Bookings] ([CarId]);

GO

CREATE INDEX [IX_Bookings_CustomerId] ON [Bookings] ([CustomerId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181022113246_init', N'2.1.4-rtm-31024');

GO

