-- =============================================
-- Author:		FRANCISCO PEREZ
-- Create date: 22/02/2025
-- Description: STORE PROCEDURE EDITAR CUENTAS
-- =============================================
CREATE PROCEDURE usp_cuentas_editar
(
	@CodigoCuenta int,
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
	UPDATE tbl_cuentas
	SET CodigoCliente = @CodigoCliente,
		NumeroCuenta = @NumeroCuenta,
		TipoCuenta = @TipoCuenta,
		Saldo = @Saldo,
		FechaApertura = @FechaApertura,
		Estado = @Estado
	WHERE CodigoCuenta = @Codigocuenta
END

