
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/02/2018 03:59:18
-- Generated from EDMX file: C:\Users\Asus\Documents\GitHub\KinderGarten-Web\WebApplication3\WebApplication3\User.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Table_1'
CREATE TABLE [dbo].[Table_1] (
    [UserID] nchar(250)  NOT NULL,
    [Email] varchar(254)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [ConfirmPassword] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Table_1_Entity1'
CREATE TABLE [dbo].[Table_1_Entity1] (
    [UserID] nchar(250)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [UserID] in table 'Table_1'
ALTER TABLE [dbo].[Table_1]
ADD CONSTRAINT [PK_Table_1]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [UserID] in table 'Table_1_Entity1'
ALTER TABLE [dbo].[Table_1_Entity1]
ADD CONSTRAINT [PK_Table_1_Entity1]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserID] in table 'Table_1_Entity1'
ALTER TABLE [dbo].[Table_1_Entity1]
ADD CONSTRAINT [FK_Entity1_inherits_Table_1]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Table_1]
        ([UserID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------