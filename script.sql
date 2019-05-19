info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 2.2.4-servicing-10062 initialized 'StackOverflowContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: None
IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Problemas] (
    [ProblemaId] int NOT NULL IDENTITY,
    [Titulo] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    [Data] datetime2 NOT NULL,
    CONSTRAINT [PK_Problemas] PRIMARY KEY ([ProblemaId])
);

GO

CREATE TABLE [Solucoes] (
    [SolucaoId] int NOT NULL IDENTITY,
    [Descricao] nvarchar(max) NULL,
    [Data] datetime2 NOT NULL,
    [Votos] int NOT NULL,
    [ProblemaId] int NOT NULL,
    CONSTRAINT [PK_Solucoes] PRIMARY KEY ([SolucaoId]),
    CONSTRAINT [FK_Solucoes_Problemas_ProblemaId] FOREIGN KEY ([ProblemaId]) REFERENCES [Problemas] ([ProblemaId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Solucoes_ProblemaId] ON [Solucoes] ([ProblemaId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190518130235_CricaoInicial', N'2.2.4-servicing-10062');

GO


