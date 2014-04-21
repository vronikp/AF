
create FUNCTION [dbo].[Fnc_CustodioAnteriorIdentificacion]
(
	@Activo_Codigo	int
)
RETURNS nvarchar(max)
AS
BEGIN
	DECLARE @result nvarchar(max);
	SELECT top 1 @result=vw_Persona.Identificacion
		FROM         ActivoCustodio INNER JOIN
		vw_Persona ON ActivoCustodio.Emplea_Custodio = vw_Persona.Entida_Codigo
		where ActCus_Activo=0
		and Activo_Codigo=@Activo_Codigo
		order by ActCus_FechaDesde desc
	RETURN (@result);

END

GO

create FUNCTION [dbo].Fnc_CustodioAnterior
(
	@Activo_Codigo	int
)
RETURNS nvarchar(max)
AS
BEGIN
	DECLARE @result nvarchar(max);
	SELECT top 1 @result=vw_Persona.NombreCompleto
		FROM         ActivoCustodio INNER JOIN
		vw_Persona ON ActivoCustodio.Emplea_Custodio = vw_Persona.Entida_Codigo
		where ActCus_Activo=0
		and Activo_Codigo=@Activo_Codigo
		order by ActCus_FechaDesde desc
	RETURN (@result);

END


GO
create FUNCTION [dbo].[Fnc_CustodioActualIdentificacion]
(
	@Activo_Codigo	int
)
RETURNS nvarchar(max)
AS
BEGIN
	DECLARE @result nvarchar(max);
	SELECT top 1 @result=vw_Persona.Identificacion
		FROM         ActivoCustodio INNER JOIN
		vw_Persona ON ActivoCustodio.Emplea_Custodio = vw_Persona.Entida_Codigo
		where ActCus_Activo=1
		and Activo_Codigo=@Activo_Codigo
		order by ActCus_FechaDesde desc
	RETURN (@result);

END

GO

