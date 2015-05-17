
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/29/2014 21:59:40
-- Generated from EDMX file: C:\Users\Leonid\Desktop\s\MvcApplication1\Models\Model.edmx

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Newse]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Newse];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Newses'
CREATE TABLE [dbo].[Newses] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NULL,
    [Text] nvarchar(max)  NULL,
    [Date] datetime  NULL,
    [IsDeleted] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Newses'
ALTER TABLE [dbo].[Newses]
ADD CONSTRAINT [PK_Newses]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------