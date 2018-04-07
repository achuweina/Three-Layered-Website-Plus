CREATE TABLE [Membership].[SecurityQuestion]
(
	[Id] INT NOT NULL  IDENTITY, 
    [Text] NVARCHAR(MAX) NOT NULL, 
    [SystemDefault] BIT NOT NULL,
	CONSTRAINT [PK_SecurityQuestion_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The id of the security question',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'SecurityQuestion',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'The question that will be shown to the user',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'SecurityQuestion',
    @level2type = N'COLUMN',
    @level2name = N'Text'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Is this question a system defaul question that will be shown in the drop down of questions a user can ask',
    @level0type = N'SCHEMA',
    @level0name = N'Membership',
    @level1type = N'TABLE',
    @level1name = N'SecurityQuestion',
    @level2type = N'COLUMN',
    @level2name = N'SystemDefault'