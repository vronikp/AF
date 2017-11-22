insert into Parametro (Parame_Codigo, Parame_Descripcion, Parame_Modificable)
values (2, 'Seguridad contraseña', 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 1, 'Caducidad de contraseña en días', '', 30, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 2, 'Longitud mínima de caracteres', '', 6, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 3, 'Exigir historial de contraseñas', '', 3, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 4, 'Complejidad, mínima cantidad de mayúsculas', '', 1, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 5, 'Complejidad, mínima cantidad de minúsculas', '', 1, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 6, 'Complejidad, mínima cantidad de números', '', 1, 1)

insert into ParametroDet (Parame_Codigo, Pardet_Secuencia, Pardet_Descripcion, Pardet_DatoStr1, Pardet_DatoInt1, Pardet_Modificable)
values (2, 7, 'Complejidad, mínima cantidad de caracteres especiales', '', 1, 1)

insert into UsuarioPasswords (Usuari_Codigo, Histor_Fecha, Histor_Password)
select usuari_codigo, getdate(), usuari_password 
from Usuario