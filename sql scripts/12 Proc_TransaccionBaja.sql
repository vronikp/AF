
/****** Object:  StoredProcedure [dbo].[proc_TransaccionBaja]    Script Date: 03/14/2018 09:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER Procedure [dbo].[proc_TransaccionBaja]
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
		set Language 'Spanish'
		SELECT      TraBaj_Codigo, Usuari_Codigo, TraBaj_Fecha, TraBaj_Observacion,  TipoBaja, Activo_CodigoBarra, 
                       Activo_Clase, Activo_Descripcion, Activo_Marca, Activo_Modelo, Activo_Serie, CustodioActual, 
                       UbicacionActual, Cabecera, Pie
		FROM         vw_TransaccionBaja
		where TraBaj_Codigo= @TraBaj_Codigo
		order by TraBaj_Codigo, Activo_CodigoBarra
		return 0
	end
	
end
