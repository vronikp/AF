
/****** Object:  StoredProcedure [dbo].[proc_TransaccionActivo]    Script Date: 03/08/2018 17:09:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[proc_TransaccionBaja]
(	@accion	char(2), 
	@TraBaj_Codigo	int=null, 
	@Usuari_Codigo	nvarchar(18)=null, 
	@TraBaj_Observacion	nvarchar(350)=null, 
	@TraBaj_Fecha	datetime=null,
	@Parame_TipoBaja int=null,
	@Pardet_TipoBaja int=null,
	@filtro	nvarchar(200)=null)
as
begin
	if @accion='i'
	begin
		select @TraBaj_Codigo=isnull(max(TraBaj_Codigo),0)+1 from TransaccionBaja
		
		insert into TransaccionBaja 
			(TraBaj_Codigo, Usuari_Codigo, TraBaj_Observacion, TraBaj_Fecha, Parame_TipoBaja, Pardet_TipoBaja)
		values (@TraBaj_Codigo, @Usuari_Codigo, @TraBaj_Observacion, @TraBaj_Fecha, @Parame_TipoBaja, @Pardet_TipoBaja)
		
		select @TraBaj_Codigo
		return 0
	end
	if @accion='m'
	begin
		update TransaccionBaja
			set Usuari_Codigo= @Usuari_Codigo, TraBaj_Observacion= @TraBaj_Observacion, TraBaj_Fecha= @TraBaj_Fecha,
			Parame_TipoBaja=@Parame_TipoBaja, Pardet_TipoBaja=@Pardet_TipoBaja
		where TraBaj_Codigo= @TraBaj_Codigo
		return 0
	end
	if @accion='c'
	begin
		select TraBaj_Codigo, Usuari_Codigo, TraBaj_Observacion, TraBaj_Fecha, Parame_TipoBaja, Pardet_TipoBaja
			from TransaccionBaja
		where TraBaj_Codigo= @TraBaj_Codigo
		return 0
	end
	if @accion='e'
	begin
		delete TransaccionBaja
		where TraBaj_Codigo= @TraBaj_Codigo
		return 0
	end
	if @accion='f'
	begin
		select TraBaj_Codigo, Usuari_Codigo, TraBaj_Observacion, TraBaj_Fecha, Parame_TipoBaja, Pardet_TipoBaja
		from TransaccionBaja
		where coalesce(@Usuari_Codigo, Usuari_Codigo)=Usuari_Codigo
		and (case when @filtro is null then 1
			when TraBaj_Observacion like '%' + @filtro + '%' then 1
			else 0 end)=1
		order by TraBaj_Observacion
		return 0
	end
	if @accion='r'
	begin
		SELECT     tb.TraBaj_Codigo, tb.Usuari_Codigo, tb.TraBaj_Fecha, tb.TraBaj_Observacion, dbo.ParametroDetDescripcion(tb.Parame_TipoBaja, tb.Pardet_TipoBaja, ' > ') AS TipoBaja, act.Activo_CodigoBarra, 
                      dbo.ParametroDetDescripcion(act.Parame_ClaseActivo, act.Pardet_ClaseActivo, ' > ') AS Activo_Clase, act.Activo_Descripcion, dbo.ParametroDetDescripcion(act.Parame_Marca, act.Pardet_Marca, 
                      ' > ') AS Activo_Marca, act.Activo_Modelo, act.Activo_Serie, dbo.Fnc_CustodioActual(act.Activo_Codigo) AS CustodioActual, dbo.Fnc_UbicacionActual(act.Activo_Codigo) AS UbicacionActual
		FROM         dbo.TransaccionBaja AS tb INNER JOIN
                      dbo.Activo AS act ON tb.TraBaj_Codigo = act.TraBaj_Codigo
		where tb.TraBaj_Codigo= @TraBaj_Codigo
		order by tb.TraBaj_Codigo, Activo_CodigoBarra
		return 0
	end
	
end

GO


