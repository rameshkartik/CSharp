
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 10/26/2015 17:56:34
-- Generated from EDMX file: D:\Projects\Energetic Scrummies\Techies\WCF Articles\WCF Articles\2015\Entity_ModelFirst\Entity_ModelFirst\College.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Universities'
CREATE TABLE [dbo].[Universities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UniversityName] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UColleges'
CREATE TABLE [dbo].[UColleges] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CollegeName] nvarchar(max)  NOT NULL,
    [NoOfDepts] int  NOT NULL,
    [PrincipalName] nvarchar(max)  NOT NULL,
    [UniversityId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Universities'
ALTER TABLE [dbo].[Universities]
ADD CONSTRAINT [PK_Universities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UColleges'
ALTER TABLE [dbo].[UColleges]
ADD CONSTRAINT [PK_UColleges]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UniversityId] in table 'UColleges'
ALTER TABLE [dbo].[UColleges]
ADD CONSTRAINT [FK_UniversityUCollege]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityUCollege'
CREATE INDEX [IX_FK_UniversityUCollege]
ON [dbo].[UColleges]
    ([UniversityId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------