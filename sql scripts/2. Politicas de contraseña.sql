insert into Parametro (Parame_Codigo, Parame_Descripcion, Parame_Modificable)
values (2, 'Seguridad contrase�a', 1)

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

insert into UsuarioPasswords (Usuari_Codigo, Histor_Fecha, Histor_Password)
select usuari_codigo, getdate(), usuari_password 
from Usuario