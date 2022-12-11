
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/11/2022 15:29:09
-- Generated from EDMX file: C:\Users\alexander\Desktop\хлам\demo\Glazki\glazki_save\Models\DBConnect.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [blagodat_1100];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_clients_zakazy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[clients] DROP CONSTRAINT [FK_clients_zakazy];
GO
IF OBJECT_ID(N'[Хранилище blagodat_1100ModelContainer].[FK_role_user]', 'F') IS NOT NULL
    ALTER TABLE [Хранилище blagodat_1100ModelContainer].[role] DROP CONSTRAINT [FK_role_user];
GO
IF OBJECT_ID(N'[Хранилище blagodat_1100ModelContainer].[FK_uslugi_zakazy]', 'F') IS NOT NULL
    ALTER TABLE [Хранилище blagodat_1100ModelContainer].[uslugi] DROP CONSTRAINT [FK_uslugi_zakazy];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[clients];
GO
IF OBJECT_ID(N'[dbo].[user]', 'U') IS NOT NULL
    DROP TABLE [dbo].[user];
GO
IF OBJECT_ID(N'[dbo].[zakazy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[zakazy];
GO
IF OBJECT_ID(N'[Хранилище blagodat_1100ModelContainer].[role]', 'U') IS NOT NULL
    DROP TABLE [Хранилище blagodat_1100ModelContainer].[role];
GO
IF OBJECT_ID(N'[Хранилище blagodat_1100ModelContainer].[uslugi]', 'U') IS NOT NULL
    DROP TABLE [Хранилище blagodat_1100ModelContainer].[uslugi];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'clients'
CREATE TABLE [dbo].[clients] (
    [id] int IDENTITY(1,1) NOT NULL,
    [FIO] varchar(max)  NULL,
    [Code_Clienta] int  NULL,
    [Passport_Data] varchar(max)  NULL,
    [Birthday] datetime  NULL,
    [Adress] varchar(max)  NULL,
    [e_mail] varchar(max)  NULL,
    [Password] varchar(max)  NULL,
    [id_zakaza] int  NULL
);
GO

-- Creating table 'user'
CREATE TABLE [dbo].[user] (
    [ID] int  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [RoleID] int  NOT NULL,
    [Password] nvarchar(max)  NULL,
    [FIO] nvarchar(max)  NULL,
    [img1] varchar(max)  NULL
);
GO

-- Creating table 'zakazy'
CREATE TABLE [dbo].[zakazy] (
    [id] int  NOT NULL,
    [code] varchar(max)  NULL,
    [date_creation] datetime  NULL,
    [time] time  NULL,
    [code_client] int  NULL,
    [uslugi] nvarchar(max)  NULL,
    [status] varchar(max)  NULL,
    [date_of_closing] datetime  NULL,
    [time_prokat] nvarchar(max)  NULL
);
GO

-- Creating table 'role'
CREATE TABLE [dbo].[role] (
    [RoleID] int  NOT NULL,
    [Title] nvarchar(max)  NULL
);
GO

-- Creating table 'uslugi'
CREATE TABLE [dbo].[uslugi] (
    [ID] int  NOT NULL,
    [title] varchar(max)  NULL,
    [code] nvarchar(max)  NULL,
    [price] int  NULL,
    [id_zakazy] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'clients'
ALTER TABLE [dbo].[clients]
ADD CONSTRAINT [PK_clients]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [RoleID] in table 'user'
ALTER TABLE [dbo].[user]
ADD CONSTRAINT [PK_user]
    PRIMARY KEY CLUSTERED ([RoleID] ASC);
GO

-- Creating primary key on [id] in table 'zakazy'
ALTER TABLE [dbo].[zakazy]
ADD CONSTRAINT [PK_zakazy]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [RoleID] in table 'role'
ALTER TABLE [dbo].[role]
ADD CONSTRAINT [PK_role]
    PRIMARY KEY CLUSTERED ([RoleID] ASC);
GO

-- Creating primary key on [ID] in table 'uslugi'
ALTER TABLE [dbo].[uslugi]
ADD CONSTRAINT [PK_uslugi]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [id_zakaza] in table 'clients'
ALTER TABLE [dbo].[clients]
ADD CONSTRAINT [FK_clients_zakazy]
    FOREIGN KEY ([id_zakaza])
    REFERENCES [dbo].[zakazy]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_clients_zakazy'
CREATE INDEX [IX_FK_clients_zakazy]
ON [dbo].[clients]
    ([id_zakaza]);
GO

-- Creating foreign key on [RoleID] in table 'role'
ALTER TABLE [dbo].[role]
ADD CONSTRAINT [FK_role_user]
    FOREIGN KEY ([RoleID])
    REFERENCES [dbo].[user]
        ([RoleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_zakazy] in table 'uslugi'
ALTER TABLE [dbo].[uslugi]
ADD CONSTRAINT [FK_uslugi_zakazy]
    FOREIGN KEY ([id_zakazy])
    REFERENCES [dbo].[zakazy]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_uslugi_zakazy'
CREATE INDEX [IX_FK_uslugi_zakazy]
ON [dbo].[uslugi]
    ([id_zakazy]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------