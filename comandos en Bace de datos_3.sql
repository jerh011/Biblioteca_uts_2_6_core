
-----Procesos almacenados------
create procedure Sp_Modificar_Prestamos
(	
	@Id_Prestamo INT ,
	@Identificador int ,
	@Fecha_prestamo date,
	@Fecha_devolucion date ,
	@No_Adquisicion int 
	)
	as BEGIN
	 update Prestamo set 
	@Identificador=Identificador,
	@Fecha_prestamo=Fecha_prestamo,
	@Fecha_devolucion=Fecha_devolucion,
	@No_Adquisicion=No_Adquisicion
	where Id_Prestamo = @Id_Prestamo
	end
	go
--###########################################################################################--

create procedure Sp_Buscar_Prestamos
(
@Id_Prestamo int null
)
as
begin
select * from Prestamo where Id_Prestamo = @Id_Prestamo 
end
go
--###########################################################################################--

create procedure sp_Listar_Prestamos
as
begin
select * from Prestamo 
end
go

--###########################################################################################--

	create procedure SP_Eliminar_Prestamos
	(
		@Id_Prestamo int=null
	)
	as 
	begin  
	delete from Prestamo where Id_Prestamo=@Id_Prestamo
	end
	go
--###########################################################################################--
	create procedure SP_Registrar_Prestamos
(
	@Id_Prestamo INT ,
	@Identificador int ,
	@Fecha_prestamo date,
	@Fecha_devolucion date ,
	@No_Adquisicion int 
	
	)
	as BEGIN
	insert into Prestamo values (
	@Identificador,
	@Fecha_prestamo,
	@Fecha_devolucion,
	@No_Adquisicion 
	)
	end
	go
