-- =============================================
-- Author:		FRANCISCO PEREZ
-- Create date: 22/02/2026
-- Description:	STORE PROCEDURE PARA ELIMINAR CUENTA
-- =============================================

CREATE PROCEDURE usp_cuentas_eliminar
	-- PARAMETROS DE ENTRADA
	(
	@CodigoCuenta int
	)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE tbl_cuentas
	WHERE CodigoCuenta=@CodigoCuenta
END