IF (EXISTS (SELECT [TABLE_CATALOG] FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'Membership' AND TABLE_NAME = 'User'))
BEGIN
	IF (NOT EXISTS(SELECT [Id] FROM [Membership].[UserDetails] WHERE [Username] = '$ext_AdminUsername$'))
	BEGIN
		DECLARE @AdminUserId INT
		DECLARE @AdminRoleId INT
		DECLARE @UserDetailsId INT
		DECLARE @UserActivityId INT
		DECLARE @UserAndPasswordId INT
		DECLARE @UserSecurityQuestionAndAnswerId INT
		DECLARE @SecurityQuestionId INT

		IF (NOT EXISTS(SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = '$ext_AdminQuestion$'))
		BEGIN
			INSERT INTO [Membership].[SecurityQuestion]
			([Text],[SystemDefault])
			VALUES
			('$ext_AdminQuestion$',0)
			SET @SecurityQuestionId = @@IDENTITY
		END
		ELSE
		BEGIN
			SELECT @SecurityQuestionId = [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = '$ext_AdminQuestion$'
		END

		INSERT INTO [Membership].[UserSecurityQuestionAndAnswer]
		([QuestionId],[Answer])
		VALUES
		(@SecurityQuestionId,'$ext_AdminAnswer$')
		SET @UserSecurityQuestionAndAnswerId = @@IDENTITY

		INSERT INTO [Membership].[UserAndPassword]
		([Password],[LastChanged])
		VALUES
		('$ext_AdminPassword$',GETDATE())
		SET @UserAndPasswordId = @@IDENTITY
		
		INSERT INTO [Membership].[UserActivity]
		([IsApproved],[IsLockedOut],[CreatedDate],[LastLoggedInDate],[LastActiveDate],[LastLockedOutDate])
		VALUES
		(1,0,GETDATE(),NULL,GETDATE(),NULL)
		SET @UserActivityId = @@IDENTITY

		INSERT INTO [Membership].[UserDetails]
		([Username],[Email],[Comment])
		VALUES
		('$ext_AdminUsername$','$ext_AdminEmail$','')
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