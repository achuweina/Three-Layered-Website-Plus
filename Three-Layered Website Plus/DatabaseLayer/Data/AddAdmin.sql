IF (EXISTS (SELECT [TABLE_CATALOG] FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'Membership' AND TABLE_NAME = 'User'))
BEGIN
	IF (NOT EXISTS(SELECT [Id] FROM [Membership].[UserDetails] WHERE [Username] = 'Admin'))
	BEGIN
		DECLARE @AdminUserId INT
		DECLARE @AdminRoleId INT
		DECLARE @UserDetailsId INT
		DECLARE @UserActivityId INT
		DECLARE @UserAndPasswordId INT
		DECLARE @UserSecurityQuestionAndAnswerId INT
		DECLARE @SecurityQuestionId INT

		IF (NOT EXISTS(SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'Which is your favorite web browser?'))
		BEGIN
			INSERT INTO [Membership].[SecurityQuestion]
			([Text],[SystemDefault])
			VALUES
			('Which is your favorite web browser?',0)
			SET @SecurityQuestionId = @@IDENTITY
		END
		ELSE
		BEGIN
			SELECT @SecurityQuestionId = [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = 'Which is your favorite web browser?'
		END

		INSERT INTO [Membership].[UserSecurityQuestionAndAnswer]
		([QuestionId],[Answer])
		VALUES
		(@SecurityQuestionId,'')
		SET @UserSecurityQuestionAndAnswerId = @@IDENTITY

		--Admin password Admin1234
		INSERT INTO [Membership].[UserAndPassword]
		([Password],[LastChanged])
		VALUES
		('$2a$05$ViiCeg9QFXDyOUzTFqHKI.SkpD7pSiqxOjDNybJ/DJ51aGhJRB.4K',GETDATE())
		SET @UserAndPasswordId = @@IDENTITY
		
		INSERT INTO [Membership].[UserActivity]
		([IsApproved],[IsLockedOut],[CreatedDate],[LastLoggedInDate],[LastActiveDate],[LastLockedOutDate])
		VALUES
		(1,0,GETDATE(),NULL,GETDATE(),NULL)
		SET @UserActivityId = @@IDENTITY

		INSERT INTO [Membership].[UserDetails]
		([Username],[Email],[Comment])
		VALUES
		('Admin','admin@website18.com','')
		SET @UserDetailsId = @@IDENTITY

		SELECT @AdminRoleId = [Id] FROM [Membership].[Role] WHERE [Name] = 'Administrator'

		INSERT INTO [Membership].[User]
		([SecurityQuestionAnswerId],[UserAndPasswordId],[UserActivityId],[UserDetailsId])
		VALUES
		(@UserSecurityQuestionAndAnswerId,@UserAndPasswordId,@UserActivityId,@UserDetailsId)
		SET @AdminUserId = @@IDENTITY

		INSERT INTO [Membership].[UserToRole]
		([RoleId],[UserId])
		VALUES
		(@AdminRoleId,@AdminUserId)

	END
END