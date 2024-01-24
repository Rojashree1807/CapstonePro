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

CREATE TABLE [AdminInfo] (
    [AdminId] int NOT NULL IDENTITY,
    [EmailId] nvarchar(50) NOT NULL,
    [Password] nvarchar(50) NOT NULL,
    CONSTRAINT [PK_AdminInfo] PRIMARY KEY ([AdminId])
);
GO

CREATE TABLE [BlogInfo] (
    [BlogId] int NOT NULL IDENTITY,
    [Title] nvarchar(50) NOT NULL,
    [Subject] nvarchar(50) NOT NULL,
    [DateOfCreation] datetime2 NOT NULL,
    [BolgUrl] nvarchar(max) NOT NULL,
    [EmpEmailId] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_BlogInfo] PRIMARY KEY ([BlogId])
);
GO

CREATE TABLE [EmpInfo] (
    [EmpId] int NOT NULL IDENTITY,
    [EmailId] nvarchar(max) NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    [DateOfJoining] datetime2 NOT NULL,
    [PassCode] int NOT NULL,
    CONSTRAINT [PK_EmpInfo] PRIMARY KEY ([EmpId])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240123085626_Blogmig', N'6.0.25');
GO

COMMIT;
GO

