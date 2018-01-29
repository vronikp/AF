
/****** Object:  StoredProcedure [dbo].[proc_Usuario]    Script Date: 21/11/2017 22:18:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[proc_Usuario] (
	@accion 		char(2),
	@Usuari_Codigo 		varchar(18)=null,
	@Usuari_Descripcion 	varchar(30)=null,
	@Usuari_Password 	varchar(18)=null,
	@Usuari_Mensaje		text=null,
	@Usuari_Regentsal		bit=null,
	@Usuari_Regingmodeli	bit=null,
	@Usuari_Regimp		bit=null,
	@Usuari_Regconfidencial	bit=null,
	@Entida_Empleado		int=null,
	@Usuari_CambiarContrasena	bit=null,
	@Usuari_Activo	bit=1,
	@Parame_Ubicacion	int=null,
	@Pardet_Ubicacion	int=null,
	@Usuari_RequerirAprobacionCambioCustodio	bit=null,
	
	@filtro		nvarchar(150)=null
)
as
	declare @encri varbinary(255)
	if @accion in ('i','mp')
	begin
		declare @minlen int
		Select @minlen = Pardet_datoint1
		from parametrodet
		where Parame_Codigo=2 and Pardet_Secuencia=2

		if (len(@Usuari_Password)<@minlen)
		begin
			select -11
			return 0
		end

		declare @historial int
		Select @historial = Pardet_datoint1
		from parametrodet
		where Parame_Codigo=2 and Pardet_Secuencia=3

		declare @minmayus int
		Select @minmayus = Pardet_datoint1
		from parametrodet
		where Parame_Codigo=2 and Pardet_Secuencia=4

		declare @minminus int
		Select @minminus = Pardet_datoint1
		from parametrodet
		where Parame_Codigo=2 and Pardet_Secuencia=5

		declare @minnumero int
		Select @minnumero = Pardet_datoint1
		from parametrodet
		where Parame_Codigo=2 and Pardet_Secuencia=6

		declare @minespecial int
		Select @minespecial = Pardet_datoint1
		from parametrodet
		where Parame_Codigo=2 and Pardet_Secuencia=7

		if exists(
			select Histor_Password
			from
			(
				select Histor_Password, ROW_NUMBER() over (order by histor_fecha desc) recno
				from UsuarioPasswords
				where Usuari_Codigo=@Usuari_Codigo
			) x
			where recno<=@historial
			and pwdcompare(@Usuari_Password, convert(varbinary(255),Histor_Password), 0)=1
		)
		begin
			select -10
			return 0
		end

		declare @mayus int
		declare @minus int
		declare @numero int
		declare @especial int
		
		;WITH CTE AS 
		(
			SELECT STUFF(@Usuari_Password,1,1,'') TXT, LEFT(@Usuari_Password,1) Col1
			UNION ALL
			SELECT STUFF(TXT,1,1,'') TXT, LEFT(TXT,1) Col1 FROM CTE
			WHERE LEN(TXT) > 0
		),
		CUENTA AS
		(
			select Col1
				,patindex('%[a-z]%', Col1 COLLATE Latin1_General_BIN) minus
				,patindex('%[A-Z]%', Col1 COLLATE Latin1_General_BIN) mayus
				,patindex('%[!%$^&@()#+*=.,?/\]%', Col1 COLLATE Latin1_General_BIN) especial
				, ISNUMERIC(Col1) numero
			from CTE
		)
		select @minus=sum(minus), @mayus=sum (mayus), @especial = sum (especial), @numero = sum(numero)
		from cuenta

		if @mayus<@minmayus
		begin
			select -12
			return 0
		end
		if @minus<@minminus
		begin
			select -13
			return 0
		end
		if @numero<@minnumero
		begin
			select -14
			return 0
		end
		if @especial<@minespecial
		begin
			select -15
			return 0
		end
	end
		
	if @accion = 'i'
	begin
		select @encri=convert(varbinary(255),pwdencrypt(@Usuari_Password))

		insert into usuario(Usuari_Codigo, Usuari_Descripcion, Usuari_Password, Usuari_Mensaje, Usuari_Regentsal, Usuari_Regingmodeli, Usuari_Regimp, Usuari_Regconfidencial, Entida_Empleado, Usuari_CambiarContrasena, Usuari_Activo, Parame_Ubicacion, Pardet_Ubicacion, Usuari_RequerirAprobacionCambioCustodio)
		values(@Usuari_Codigo,@Usuari_Descripcion, @encri, @Usuari_Mensaje, @Usuari_Regentsal, @Usuari_Regingmodeli, @Usuari_Regimp, @Usuari_Regconfidencial, @Entida_Empleado, @Usuari_CambiarContrasena, @Usuari_Activo, @Parame_Ubicacion, @Pardet_Ubicacion, @Usuari_RequerirAprobacionCambioCustodio)
	end

	if @accion = 'm'
	begin
		update usuario 
		set Usuari_Descripcion = @Usuari_Descripcion,
			Usuari_Mensaje=@Usuari_Mensaje,
			Usuari_Regentsal=@Usuari_Regentsal, Usuari_Regingmodeli=@Usuari_Regingmodeli, 
			Usuari_Regimp=@Usuari_Regimp, Usuari_Regconfidencial=@Usuari_Regconfidencial,
			Entida_Empleado=@Entida_Empleado, Usuari_CambiarContrasena=@Usuari_CambiarContrasena,
			Usuari_Activo= @Usuari_Activo,
			Parame_Ubicacion = @Parame_Ubicacion, Pardet_Ubicacion= @Pardet_Ubicacion,
			Usuari_RequerirAprobacionCambioCustodio= @Usuari_RequerirAprobacionCambioCustodio
		where Usuari_Codigo=@Usuari_Codigo

		select 1
		return 0
	end

	if @accion = 'mp'
	begin
		select @encri=convert(varbinary(255),pwdencrypt(@Usuari_Password))

		update usuario 
		set Usuari_Password=@encri, Usuari_CambiarContrasena = 0, Usuari_FechaCambioPassword = getdate()
		where Usuari_Codigo=@Usuari_Codigo
	end

	if @accion in ('i','mp')
	begin
		insert into UsuarioPasswords (Usuari_Codigo, Histor_Fecha, Histor_Password)
		values (@Usuari_Codigo, getdate(), @encri)

		select 1
		return 0
	end

	if @accion = 'c'
	begin
		declare @age int
		select @age= DATEDIFF(day, usuari_fechacambiopassword, getdate()) 
			from usuario 
			where Usuari_Codigo=@Usuari_Codigo
		
		declare @maxage int
		Select @maxage = Pardet_datoint1
		from parametrodet
		where Parame_Codigo=2 and Pardet_Secuencia=1

		if @age> @maxage
		begin
			update Usuario
			set Usuari_CambiarContrasena = 1
			where Usuari_Codigo = @Usuari_Codigo
		end

		select Usuari_Codigo, Usuari_Descripcion, Usuari_Mensaje, Usuari_Regentsal, Usuari_Regingmodeli, Usuari_Regimp, Usuari_Regconfidencial, Entida_Empleado, Usuari_CambiarContrasena, Usuari_Activo, Parame_Ubicacion, Pardet_Ubicacion, Usuari_RequerirAprobacionCambioCustodio
		from usuario 
		where Usuari_Codigo=@Usuari_Codigo
		return 0
	end

	if @accion = 'cp' --consulta si el password es correcto
	begin
		declare @pass sysname
		select @pass=(select Usuari_Password from usuario where Usuari_Codigo=@Usuari_Codigo)

		IF (pwdcompare(@Usuari_Password, convert(varbinary(255),@pass), 0)=1 )
			select 1
		else
			select 0
		 
		return 0
	end

	if @accion = 'e'
	begin
		delete restriccion 
		where Usuari_Codigo=@Usuari_Codigo
		delete usuario 
		where Usuari_Codigo=@Usuari_Codigo
		return 0
	end

	if @accion = 'f'
	begin
		select Usuari_Codigo, Usuari_Descripcion, Usuari_Mensaje, Usuari_Regentsal, Usuari_Regingmodeli, Usuari_Regimp, Usuari_Regconfidencial, Entida_Empleado, Usuari_CambiarContrasena, Usuari_Activo, Parame_Ubicacion, Pardet_Ubicacion, Usuari_RequerirAprobacionCambioCustodio
		from usuario 
		where (case when @filtro is null then 1
			when Usuari_Codigo like '%' + @filtro + '%' then 1
			when Usuari_Descripcion like '%' + @filtro + '%' then 1
			else 0 end)=1
		order by Usuari_Codigo
		return 0
	end


