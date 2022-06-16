CREATE PROCEDURE [dbo].[spAsset_Update]
	@Id int,
	@Status bit
AS
BEGIN
	UPDATE dbo.[Asset]
	SET Status = @Status
	WHERE Id = @Id
END
