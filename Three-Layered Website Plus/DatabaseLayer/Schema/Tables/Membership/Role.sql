CREATE TABLE [Membership].[Role]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(30) NOT NULL, 
    [SystemDefault] BIT NOT NULL,
	CONSTRAINT [PK_Role_Id] PRIMARY KEY CLUSTERED ([Id] ASC)	
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The id of the role',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'Role',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The name of the role',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'Role',
    @level2type = N'COLUMN',
    @level2name = N'Name'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Is this record a system default',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'Role',
    @level2type = N'COLUMN',
    @level2name = N'SystemDefault'