-- =============================================
-- Author:		FRANCISCO PEREZ
-- Create date: 22/02/2025
-- Description:	STORE PROCEDURE CREAR CUENTA
-- =============================================

CREATE PROCEDURE usp_cuentas_crear
	-- PARAMETROS DE ENTRADA
	(
	@CodigoCliente int,
	@NumeroCuenta varchar(50),
	@TipoCuenta varchar(50),
	@Saldo decimal(10,2),
	@FechaApertura datetime,
	@Estado varchar(15)
	)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO tbl_cuentas
	(
		CodigoCliente,
		NumeroCuenta,
		TipoCuenta,
		Saldo,
		FechaApertura,
		Estado
		
	) values
	(
		@CodigoCliente,
		@NumeroCuenta,
		@TipoCuenta,
		@Saldo,
		@FechaApertura,
		@Estado
	)
END