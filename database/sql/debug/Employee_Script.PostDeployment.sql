/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [Employee].[dbo].[aspnet_Applications]
           ([ApplicationName]
           ,[LoweredApplicationName]
           ,[ApplicationId]
           ,[Description])
     VALUES
           ('/', '/', '63E49599-DD91-44EA-A703-BA95CBA966D6', NULL)
GO

INSERT INTO [Employee].[dbo].[aspnet_Users]
           ([ApplicationId]
           ,[UserId]
           ,[UserName]
           ,[LoweredUserName]
           ,[MobileAlias]
           ,[IsAnonymous]
           ,[LastActivityDate])
     VALUES
           (
				'63E49599-DD91-44EA-A703-BA95CBA966D6',	
				'38AE5412-0AD9-45F1-8E28-F1AD9CED8F80',	
				'administrator',
				'administrator',	
				NULL,	
				0,	
				'2012-03-04 16:38:55.297'
			)
GO

INSERT INTO [Employee].[dbo].[aspnet_Membership]
           ([ApplicationId]
           ,[UserId]
           ,[Password]
           ,[PasswordFormat]
           ,[PasswordSalt]
           ,[MobilePIN]
           ,[Email]
           ,[LoweredEmail]
           ,[PasswordQuestion]
           ,[PasswordAnswer]
           ,[IsApproved]
           ,[IsLockedOut]
           ,[CreateDate]
           ,[LastLoginDate]
           ,[LastPasswordChangedDate]
           ,[LastLockoutDate]
           ,[FailedPasswordAttemptCount]
           ,[FailedPasswordAttemptWindowStart]
           ,[FailedPasswordAnswerAttemptCount]
           ,[FailedPasswordAnswerAttemptWindowStart]
           ,[Comment])
     VALUES
           (
'63E49599-DD91-44EA-A703-BA95CBA966D6',	'38AE5412-0AD9-45F1-8E28-F1AD9CED8F80',	'bYw4/L14jVG1j/lwVYTTr4/q0WI=',	1,	'hLqjWEOveBW5/0X3w4tHYA==',	NULL,	
'dheeraj.vanteru@gmail.com',	'dheeraj.vanteru@gmail.com',	NULL,	NULL,	1,	0,	'2012-03-04 16:38:55.000',	'2012-03-04 16:38:55.297',
	'2012-03-04 16:38:55.000',	'1754-01-01 00:00:00.000',	0,	'1754-01-01 00:00:00.000',	0,	'1754-01-01 00:00:00.000',	NULL)
GO

INSERT INTO [Employee].[dbo].[aspnet_Roles]
           ([ApplicationId]
           ,[RoleId]
           ,[RoleName]
           ,[LoweredRoleName]
           ,[Description])
     VALUES
           (
'63E49599-DD91-44EA-A703-BA95CBA966D6',	'FD41DC42-D624-484F-B590-ED6005B0C705',	'Admin',	'admin',	NULL)
GO

INSERT INTO [Employee].[dbo].[aspnet_SchemaVersions]
           ([Feature]
           ,[CompatibleSchemaVersion]
           ,[IsCurrentVersion])
     VALUES
			('common',	1,	1),
			('health monitoring',	1,	1),
			('membership',	1,	1),
			('personalization',	1,	1),
			('profile',	1,	1),
			('role manager',	1,	1)
GO



INSERT INTO [Employee].[dbo].[JobTitle]
           ([Name])
     VALUES
           ('Development Manager'),
			('Product Manager'),
			('Lead Developer'),
			('Senior Developer'),
			('Mid-Level Developer'),
			('Junior Developer')
GO

INSERT INTO [Employee].[dbo].[Employee]
           ([Name]
           ,[Email]
           ,[JobTitleId])
     VALUES
           ('Employee1',	'employee1@email.com',	1),
			('Employee2',	'employee2@email.com',	2),
			('Employee3',	'employee3@email.com',	2),
			('Employee4',	'employee4@email.com',	3),
			('Employee5',	'employee5@email.com',	3),
			('Employee6',	'employee6@email.com',	3),
			('Employee7',	'employee7@email.com',	3),
			('Employee8',	'employee8@email.com',	4),
			('Employee9',	'employee9@email.com',	4),
			('Employee10',	'employee10@email.com',	4),
			('Employee11',	'employee11@email.com',	5),
			('Employee12',	'employee12@email.com',	5)
GO


