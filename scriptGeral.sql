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

CREATE TABLE [Marcas] (
    [IdMarca] int NOT NULL IDENTITY,
    [dsMarca] nvarchar(max) NULL,
    CONSTRAINT [PK_Marcas] PRIMARY KEY ([IdMarca])
);
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitude] nvarchar(max) NULL,
    [Longitude] nvarchar(max) NULL,
    [DataAcesso] datetime2 NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Veiculos] (
    [Id] int NOT NULL IDENTITY,
    [IdMarca] nvarchar(max) NULL,
    [Modelo] nvarchar(max) NULL,
    [ClasseEnum] int NOT NULL,
    CONSTRAINT [PK_Veiculos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220420155722_MigracaoTeste', N'6.0.4');
GO

COMMIT;
GO

