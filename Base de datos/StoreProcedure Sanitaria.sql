--Login de usuario
create proc splogin_usuario
@nombre varchar(20),
@contraseña varchar(20)
as
select nombre, contraseña 
from usuario 
where nombre = @nombre and contraseña = @contraseña;

--ListaRequerimiento
create proc splistar_requerimiento
as
select top 200 * from requerimiento
order by id_requerimiento asc
go


--Listar requerimiento
create proc splista_reque
@tipo varchar(20),
@estado varchar(10),
@prioridad varchar(10)
as
select * from requerimiento
where tipo = @tipo
and estado = @estado
and prioridad = @prioridad
go

--Cambiar estado
create proc spcambiar_estado
@id_requerimiento int,
@estado varchar(10)
as
update requerimiento
set estado = @estado
where id_requerimiento = @id_requerimiento


--Eliminar requerimiento
create proc speliminar_requerimiento
@id_requerimiento int
as
delete from requerimiento where id_requerimiento = @id_requerimiento