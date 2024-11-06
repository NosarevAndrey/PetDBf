IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Genders] (
    [Id] int NOT NULL IDENTITY,
    [GenderName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Genders] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PetTypes] (
    [Id] int NOT NULL IDENTITY,
    [TypeName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_PetTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Clients] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [GenderId] int NOT NULL,
    [Address] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Clients_Genders_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [Genders] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Pets] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [GenderId] int NOT NULL,
    [TypeId] int NOT NULL,
    [AgeMonth] int NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Pets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Pets_Genders_GenderId] FOREIGN KEY ([GenderId]) REFERENCES [Genders] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Pets_PetTypes_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [PetTypes] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AdoptedPets] (
    [Id] int NOT NULL IDENTITY,
    [PetId] int NOT NULL,
    [ClientId] int NOT NULL,
    [AdoptionDate] datetime2 NOT NULL,
    CONSTRAINT [PK_AdoptedPets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AdoptedPets_Clients_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [Clients] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AdoptedPets_Pets_PetId] FOREIGN KEY ([PetId]) REFERENCES [Pets] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_AdoptedPets_ClientId] ON [AdoptedPets] ([ClientId]);
GO

CREATE UNIQUE INDEX [IX_AdoptedPets_PetId] ON [AdoptedPets] ([PetId]);
GO

CREATE INDEX [IX_Clients_GenderId] ON [Clients] ([GenderId]);
GO

CREATE INDEX [IX_Pets_GenderId] ON [Pets] ([GenderId]);
GO

CREATE INDEX [IX_Pets_TypeId] ON [Pets] ([TypeId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20241106061543_InitialCreate', N'8.0.10');
GO

COMMIT;
GO

