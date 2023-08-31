
select * from Usuario

select * from Rol

insert into Rol(Descripcion) values ('SUPER ADMIN')

insert into Usuario(Documento,Nombre,Apellido,Correo,Clave,IdRol,Estado) values ('21100100','Enzo','Medina','enzo912@gmail.com','enzo24',1,1)

delete from Usuario

DBCC CHECKIDENT(Usuario, RESEED,0)

