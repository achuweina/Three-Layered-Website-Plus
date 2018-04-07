IF (EXISTS (SELECT [TABLE_CATALOG] FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'Membership' AND TABLE_NAME = 'SecurityQuestion'))
BEGIN
	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What is the first and last name of your first boyfriend or girlfriend?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What is the first and last name of your first boyfriend or girlfriend?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'Which phone number do you remember most from your childhood?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('Which phone number do you remember most from your childhood?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What was your favorite place to visit as a child?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What was your favorite place to visit as a child?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'Who is your favorite actor, musician, or artist?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('Who is your favorite actor, musician, or artist?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What is the name of your favorite pet?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What is the name of your favorite pet?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'In what city were you born?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('In what city were you born?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What high school did you attend?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What high school did you attend?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What is your mother''s maiden name?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What is your mother''s maiden name?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What street did you grow up on?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What street did you grow up on?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What was the make of your first car?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What was the make of your first car?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'When is your anniversary?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('When is your anniversary?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What is your favorite color?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What is your favorite color?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What is your father''s middle name?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What is your father''s middle name?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What is the name of your first grade teacher?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What is the name of your first grade teacher?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'What was your high school mascot?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('What was your high school mascot?',1)

	IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'Which is your favorite web browser?' AND [SystemDefault] = 1))
		INSERT INTO [Membership].[SecurityQuestion] ([Text],[SystemDefault]) VALUES ('Which is your favorite web browser?',1)
END