USE [AF_SRI_Inventario2012]
GO

/****** Object:  UserDefinedFunction [dbo].[Fnc_CustodioActualIdentificacion]    Script Date: 11/01/2012 22:16:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
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


