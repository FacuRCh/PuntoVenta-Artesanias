
select * from Usuario

select * from Rol

insert into Rol(Descripcion) values ('SUPER ADMIN')
insert into Rol(Descripcion) values ('ADMIN')
insert into Rol(Descripcion) values ('EMPLEADO')

insert into Usuario(Documento,Nombre,Apellido,Correo,Clave,IdRol,Estado) values ('21100100','Enzo','Medina','enzo912@gmail.com','enzo24',1,1)

delete from Usuario

DBCC CHECKIDENT(Usuario, RESEED,0)

Select * from Permiso

insert into Permiso(IdRol,NombreMenu) values
(1,'menuacercade')

insert into Permiso(IdRol,NombreMenu) values
(2,'menuusuario'),
(2,'menumantenedor'),
(2,'menuproveedores'),
(2,'menuacercade')

insert into Permiso(IdRol,NombreMenu) values
(3,'menuventas'),
(3,'menucompras'),
(3,'menuclientes'),
(3,'menuacercade')