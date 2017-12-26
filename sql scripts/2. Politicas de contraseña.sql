insert into Parametro (Parame_Codigo, Parame_Descripcion, Parame_Modificable, [Parame_LeyendaDatoInt1])
values (2, 'Seguridad contrase�a', 1, 'Valor')

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 1, 'Caducidad de contrase�a en d�as', '', 30, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 2, 'Longitud m�nima de caracteres', '', 6, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 3, 'Exigir historial de contrase�as', '', 3, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 4, 'Complejidad, m�nima cantidad de may�sculas', '', 1, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 5, 'Complejidad, m�nima cantidad de min�sculas', '', 1, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 6, 'Complejidad, m�nima cantidad de n�meros', '', 1, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 7, 'Complejidad, m�nima cantidad de caracteres especiales', '', 1, 1)

CREATE Table UsuarioPasswords (
Usuari_Codigo char(18), 
Histor_Fecha datetime, 
Histor_Password varbinary(255))

insert into UsuarioPasswords (Usuari_Codigo, Histor_Fecha, Histor_Password)
select usuari_codigo, getdate(), usuari_password 
from Usuario

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_Modificable, Parame_padre, Pardet_Padre)
values (5, 905, 'Politicas', 1, 4, 900)

exec proc_restriccion 'u'