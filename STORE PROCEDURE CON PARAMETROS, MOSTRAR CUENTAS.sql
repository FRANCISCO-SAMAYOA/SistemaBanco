-- =============================================
-- Author:		Francisco Pérez
-- Create date: 22/02/2025
-- Description:	Store Procedure to show the counts of the table tbl_cuentas.
-- =============================================
CREATE PROCEDURE usp_cuentas_mostrar
AS
BEGIN
	SET NOCOUNT ON;

	select
		CodigoCuenta as 'CodigoCuenta',
		CodigoCliente,
		NumeroCuenta,
		TipoCuenta,
		Saldo,
		FechaApertura,
		Estado
	from tbl_cuentas;
END
