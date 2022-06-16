CREATE PROCEDURE [dbo].[spAsset_Delete]
	@Id int
AS
BEGIN 
	DELETE
	FROM dbo.[Asset]
	WHERE Id = @Id;
END
