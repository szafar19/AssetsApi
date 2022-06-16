CREATE PROCEDURE [dbo].[spAsset_Get]
	@Id int
AS
BEGIN 
	SELECT Id, Status, registration_date
	FROM dbo.[Asset]
	WHERE Id = @Id;
END
