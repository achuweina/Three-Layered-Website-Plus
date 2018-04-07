CREATE TABLE [Membership].[UserToRole]
(
	[Id] INT NOT NULL IDENTITY,
	[UserId] INT NOT NULL,
	[RoleId] INT NOT NULL,
	CONSTRAINT [PK_UserToRole_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserToRole_User] FOREIGN KEY ([UserId]) REFERENCES [Membership].[User]([Id]),
    CONSTRAINT [FK_UserToRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [Membership].[Role]([Id])
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'This is the ID of the user to role',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'UserToRole',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The id of the user record',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'UserToRole',
    @level2type = N'COLUMN',
    @level2name = 'UserId'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The id of the role record',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'UserToRole',
    @level2type = N'COLUMN',
    @level2name = 'RoleId'