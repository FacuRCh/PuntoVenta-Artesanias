
select u.IdUsuario, u.Documento, u.Nombre, u.Apellido, u.Correo, u.Clave, u.Estado, r.IdRol, r.Descripcion from usuario u
inner join Rol r on r.IdRol = u.IdRol

/*select * from Usuario

select * from Rol

insert into Rol(Descripcion) values ('SUPER ADMIN')
insert into Rol(Descripcion) values ('ADMIN')
insert into Rol(Descripcion) values ('EMPLEADO')

insert into Usuario(Documento,Nombre,Apellido,Correo,Clave,IdRol,Estado) values ('21100100','Enzo','Medina','enzo912@gmail.com','enzo24',1,1)
insert into Usuario(Documento,Nombre,Apellido,Correo,Clave,IdRol,Estado) values ('22100100','Julian','Romero','julian1212@gmail.com','julian12',2,1)
insert into Usuario(Documento,Nombre,Apellido,Correo,Clave,IdRol,Estado) values ('23100100','Roman','Yiyo','roman10@gmail.com','roman10',3,1)


delete from Usuario

DBCC CHECKIDENT(Permiso, RESEED,0)

Select * from Permiso

delete from Permiso

insert into Permiso(IdRol,NombreMenu) values
(1,'menuusuario'),
(1,'menureportes'),
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

select p.IdRol, p.NombreMenu from Permiso p
inner join Rol r on r.IdRol = p.IdRol
inner join Usuario u on u.IdRol = r.IdRol
where u.IdUsuario = 1*/