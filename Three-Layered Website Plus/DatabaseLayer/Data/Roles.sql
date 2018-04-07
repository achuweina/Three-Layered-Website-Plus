IF (EXISTS (SELECT [TABLE_CATALOG] FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'Membership' AND TABLE_NAME = 'Role'))
BEGIN
	IF(NOT EXISTS(SELECT [Id] FROM [Membership].[Role] WHERE [Name] = 'Administrator'))
		INSERT INTO [Membership].[Role] ([Name],[SystemDefault]) VALUES ('Administrator',1)

	IF(NOT EXISTS(SELECT [Id] FROM [Membership].[Role] WHERE [Name] = 'Default'))
		INSERT INTO [Membership].[Role] ([Name],[SystemDefault]) VALUES ('Default',1)

END
