CREATE PROCEDURE [dbo].[spUser_Get]
	@Email nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	SELECT *
	FROM dbo.[User]
	WHERE Email = @Email AND Password = @Password
END
