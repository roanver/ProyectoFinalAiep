--Crear base de datos Sanitaria
create database Sanitaria

--Crear tabla Usuario
create table usuario(
id_usuario int primary key not null,
nombre varchar(20) not null ,
apellido varchar(20),
contraseña int not null,
id_rol int,
rol varchar(50)
); 

--Crear tabla Requerimiento 
create table requerimiento(
id_requerimiento int not null,
autor int,
responsable int,
tipo varchar(10),
descripcion varchar(256),
estado varchar(10),
id_prioridad varchar(10), 

);

--Insercion de datos tabla usuario 
insert into usuario (nombre, apellido, contraseña, rol) values('Admin', 'Sistema', 123, 'admin');

