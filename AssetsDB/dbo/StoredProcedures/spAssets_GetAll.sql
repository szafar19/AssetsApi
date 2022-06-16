CREATE PROCEDURE [dbo].[spAssets_GetAll]
AS
BEGIN 
	SELECT Id, Status, registration_date
	FROM dbo.[Asset];
END
