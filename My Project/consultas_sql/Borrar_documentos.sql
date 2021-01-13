IF EXISTS (SELECT * FROM sysobjects WHERE name = 'Delete_documento' AND user_name(uid) = 'dbo')
	DROP PROCEDURE dbo.Delete_documento
GO

CREATE PROCEDURE dbo.Delete_documento
(
	@Original_td tinyint,
	@Original_Folio int,
	@Original_serie char(2)
)
AS
	SET NOCOUNT OFF;
DELETE FROM Documentos
WHERE        (td = @Original_td) AND (Folio = @Original_Folio) AND (serie = @Original_serie)
GO

