CREATE PROCEDURE [dbo].[spAsset_Insert]
	@Status bit
AS
BEGIN
	INSERT INTO dbo.[Asset](Status)
	VALUES (@Status)
END
