use RestauranteXYZ

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------Procedimientos Almacenados para empleado--------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------

--Procedimiento almacenado para insertar
Create Procedure Sp_InsertarEmpleado
	@Nombre nvarchar(20),
	@Apellido nvarchar(20),
	@Telefono varchar(9),
	@Correo nvarchar(30),
	@Direccion nvarchar(200),
	@IdSexo int,
	@IdTipoEmpleado int
As
Begin
	Set nocount off
	Insert into Empleado
	values (@Nombre, @Apellido, @Telefono, @Correo, @Direccion, @IdSexo, @IdTipoEmpleado)
End

Exec Sp_InsertarEmpleado 'Samuel', 'Aguilar', '2780-0000', 'kike.as58@gmail.com', 'B° La esperanza', 1, 3 

--Procedimiento almacenado para modificar
Create Procedure Sp_ModificarEmpleado 
	@IdEmpleado int, 
	@Nombre nvarchar(20),
	@Apellido nvarchar(20),
	@Telefono varchar(9),
	@Correo nvarchar(30),
	@Direccion nvarchar(200),
	@IdSexo int,
	@IdTipoEmpleado int
As
Begin
	Set nocount off
	Update Empleado
	Set Nombre = @Nombre,
		Apellido = @Apellido,
		Telefono = @Telefono,
		Correo = @Correo,
		Direccion = @Direccion,
		IdSexo = @IdSexo, 
		IdTipoEmpleado = @IdTipoEmpleado
	Where IdEmpleado = @IdEmpleado
END

Select * from Empleado
Exec Sp_ModificarEmpleado 1, 'Samuel', 'Aguilar', '2780-0000', 'kike.as58@gmail.com', 'B° La esperanza', 1, 1

--Procedimiento almacenado para eliminar Empleado.
Create Procedure Sp_EliminarEmpleado
	@IdEmpleado int
As
Begin
	Set nocount off
	Delete 
	From Empleado
	Where IdEmpleado = @IdEmpleado
End

--Procedimiento almacenado para listar todos los Empleados.
Create Procedure Sp_MostrarEmpleados
As
Begin
	Set nocount on
	Select e.IdEmpleado, e.Nombre, e.Apellido, e.Telefono, e.Correo, e.Direccion, s.Sexo, t.TipoEmpleado
	From Empleado e inner join TipoEmpleado t
		on e.IdTipoEmpleado= T.IdTipoEmpleado
		inner join Sexo s
		on e.IdSexo = s.IdSexo
End

Create Procedure Sp_BuscarEmpleadoNombre
	@Nombre nvarchar(20)
As
	Begin
		Set nocount on
		Select e.IdEmpleado, e.Nombre, e.Apellido, e.Telefono, e.Correo, e.Direccion, s.Sexo, t.TipoEmpleado
		From Empleado e inner join TipoEmpleado t
			on e.IdTipoEmpleado= T.IdTipoEmpleado
			inner join Sexo s
			on e.IdSexo = s.IdSexo
		Where e.Nombre = @Nombre
	End
Go


Create Procedure Sp_BuscarEmpleadoId
	@IdEmpleado int
As
	Begin
		Set nocount on
		Select e.IdEmpleado, e.Nombre, e.Apellido, e.Telefono, e.Correo, e.Direccion, s.Sexo, t.TipoEmpleado
		From Empleado e inner join TipoEmpleado t
			on e.IdTipoEmpleado= T.IdTipoEmpleado
			inner join Sexo s
			on e.IdSexo = s.IdSexo
		Where e.IdEmpleado = @IdEmpleado
	End
Go


--Porcedimiento almacenado para listar los tipo de empleado
Create Procedure Sp_ListarTipoEmpleado
AS
BEGIN
	Set nocount on
	Select *
	From TipoEmpleado
End

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------Procedimientos Almacenados para Sexo--------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
Create Procedure Sp_ListarSexo
AS
BEGIN
	Set nocount on
	Select * 
	From Sexo
End

------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
-------------------------------Procedimientos Almacenados para Mesa-----------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
Create PROCEDURE Sp_ModEstadoMesa
@IdMesa int,
@Estado bit

AS
BEGIN
	SET NOCOUNT OFF
	Update Mesa
	Set Estado = @Estado
	Where IdMesa = @IdMesa
END
	
Create PROCEDURE Sp_EstadoMesa
	@IdMesa int

AS
BEGIN
    SET NOCOUNT OFF
    Select Estado
    From Mesa
    Where IdMesa = @IdMesa
END


Create procedure Sp_InsertarMesa
	@Estado bit,
	@Capacidad int,
	@IdEmpleado int
AS
BEGIN
	Set nocount off
	Insert into Mesa
	values (@Estado, @Capacidad, @IdEmpleado)
End

Create Procedure Sp_EliminarMesa
	@IdMesa int
AS
BEGIN
	Set nocount off
	Delete
	From Mesa
	Where IdMesa = @IdMesa
END

Create Procedure Sp_ActualizarMesa
	@IdMesa int,
	@Estado bit,
	@Capacidad int, 
	@IdEmpleado int
AS
BEGIN
	Set nocount off
	UPDATE Mesa
	Set Estado = @Estado,
		Capacidad = @Capacidad,
		IdEmpleado = @IdEmpleado
	Where IdMesa = @IdMesa
End


/*PROCEDIMIENTOS ALMACENADOS PARA PRODUCTO*/
-------------------------------------------------
-------------------------------------------------
/*Insertar Producto*/
----------------------------------------------------
Create procedure Sp_InsertarProducto
  @Nombre nvarchar(35), 
  @Precio money , 
  @IdTipoProducto int	
	 AS BEGIN 
		Set nocount off
			Insert into Producto
     Values(@Nombre,@Precio,@IdTipoProducto)
	  END
-----------------------------------------------------
/*Modificar producto*/
-----------------------------------------------------
Create procedure Sp_ModificarProducto
@IdProducto int,
@Nombre nvarchar(35),
@Precio money ,
@IdTipoProducto int 

	As
	Begin 
		Set nocount off
		Update Producto
		Set Nombre=@Nombre,
			Precio=@Precio,
			IdTipoProducto=@IdTipoProducto
		Where IdProducto=@IdProducto
	End
------------------------------------------------------

/*Eliminar producto*/
------------------------------------------------------
Create procedure Sp_EliminarProducto
@IdProducto int 

	As 
	Begin 
	Set nocount off
	Delete 
	From Producto
	Where IdProducto=@IdProducto
End
------------------------------------------------------
/*Mostrar producto*/
------------------------------------------------------
Create procedure Sp_MostrarProducto
	As BEGIN
	  Set nocount on  
	  Select a.IdProducto, a.Nombre,a.Precio,p.IdTipoProducto
	   From Producto a inner Join TipoProducto p   
	           on a.IdTipoProducto = p.IdTipoProducto 
END
------------------------------------------------------

/*Ejecutar procedimiento almacenado */
------------------------------------------
exec Sp_MostrarProducto 
------------------------------------------

/*PROCEDIMIENTOS ALMACENADOS PARA DETALLEFACTURA*/
--------------------------------------------------
--------------------------------------------------
/*Insertar detalle de factura*/
--------------------------------------------------
Create procedure Sp_InsertarDFactura
@IdFactura int,
@IdProducto int,
@Cantidad int

As
	Begin
	Set nocount off
	Insert into DetalleFactura
	Values (@IdFactura,@IdProducto,@Cantidad)
	End
---------------------------------------------------
/*Modificar detalle de factura*/
--------------------------------------------------
Create procedure Sp_ModificarDFactura
@IdFactura int,
@IdProducto int,
@Cantidad int

As 
	Begin 
	Set nocount off
	Update DetalleFactura
		Set IdFactura=@IdFactura,
			IdProducto=@IdProducto,
			Cantidad=@Cantidad
	Where IdFactura=@IdFactura
End
--------------------------------------------------
/*Eliminar Detalle de Factura*/
--------------------------------------------------
Create procedure Sp_EliminarDFactura
@IdFactura int 

	As 
	Begin 
	Set nocount off
	Delete 
	From DetalleFactura
	Where IdFactura=@IdFactura
End
--------------------------------------------------
/*Mostrar detalle de factura*/
--------------------------------------------------
Create procedure Sp_MostrarDFactura
As BEGIN
	  Set nocount on  
	  Select a.IdFactura,p.IdTipoProducto,a.Cantidad
	  	   From DetalleFactura a inner Join Producto p  
	           on a.IdProducto = p.IdProducto 
END
--------------------------------------------------
/*PROCEDIMIENTO ALMACENADO PARA FACTURA*/
--------------------------------------------------
--------------------------------------------------
/*Insertar factura*/
--------------------------------------------------
Create procedure Sp_InsertarFactura
@IdEmpleado int,
@NombreCliente nvarchar(20),
@RTN nvarchar(14),
@Fecha datetime

As 
	Begin
	Set nocount off
	Insert into Factura
	Values(@IdEmpleado,@NombreCliente,@RTN,@Fecha)
End
--------------------------------------------------
/*Modificar Factura*/
--------------------------------------------------
Create procedure Sp_ModificarFactura
@IdFactura int,
@IdEmpleado int,
@NombreCliente nvarchar(20),
@RTN nvarchar(14),
@Fecha datetime
As 
	Begin
	Set nocount off
	Update Factura
		Set 
			IdEmpleado=@IdEmpleado,
			NombreCliente=@NombreCliente,
			RTN=@RTN,
			Fecha=@Fecha
		Where IdFactura=@IdFactura
End
--------------------------------------------------
/*Eliminar Factura*/
--------------------------------------------------
Create procedure Sp_EliminarFactura
@IdFactura int 

	As 
	Begin 
	Set nocount off
	Delete 
	From Factura
	Where IdFactura=@IdFactura
End

INSERT INTO TipoProducto
VALUES('Entrada')
INSERT INTO TipoProducto
VALUES('Plato Fuerte')
INSERT INTO TipoProducto
VALUES('Comida Rapida')
INSERT INTO TipoProducto
VALUES('Bebida Fria')
INSERT INTO TipoProducto
VALUES('Bebida Caliente')
INSERT INTO TipoProducto
VALUES('Postre')

INSERT INTO Producto
VALUES('Sopa Gallina India',140,1)
INSERT INTO Producto
VALUES('Papas Fritas',30,1)
INSERT INTO Producto
VALUES('Sopa Tortilla', 180 ,1)

INSERT INTO Producto
VALUES('Pollo Asado',110,2)
INSERT INTO Producto
VALUES('Carne Asada',150,2)
INSERT INTO Producto
VALUES('Lomo Atenado',200,2)

INSERT INTO Producto
VALUES('Hamburgesa', 80 ,3)
INSERT INTO Producto
VALUES('Hamburgesa de Tocino',100,3)
INSERT INTO Producto
VALUES('Pupusas',50,3)

INSERT INTO Producto
VALUES('Gaseosa', 20 ,4)
INSERT INTO Producto
VALUES('Batido',50,4)
INSERT INTO Producto
VALUES('Agua',15,4)

INSERT INTO Producto
VALUES('Cafe',40,5)
INSERT INTO Producto
VALUES('Te',40,5)

INSERT INTO Producto
VALUES('Brownie',100 ,6)
INSERT INTO Producto
VALUES('Torta', 120 ,6)

CREATE Procedure Sp_NombreProducto
@IdProducto int
AS
Begin
	Select Nombre
	from Producto
	WHERE IdProducto = @IdProducto
End


CREATE Procedure Sp_PrecioProducto
@IdProducto int
AS
Begin
	Select Precio
	from Producto
	WHERE IdProducto = @IdProducto
End



ALTER procedure [dbo].[Sp_ModificarFactura]
@IdFactura int,
@NombreCliente nvarchar(20),
@RTN nvarchar(14)
As 
Begin
	Set nocount off
	Update Factura
	Set NombreCliente = @NombreCliente, RTN = @RTN
	WHERE IdFactura = @IdFactura
End


CREATE PROCEDURE Sp_MaxFactura
as
BEGIN
	SELECT max(IdFactura)
	FROM Factura
END


ALTER procedure [dbo].[Sp_InsertarFactura]
@IdEmpleado int,
@Fecha datetime
As 
	Begin
	Set nocount off
	Insert into Factura
	Values(@IdEmpleado,'','',@Fecha)
End


insert into Sexo
VALUES('Masculino')
insert into Sexo
VALUES('Femenino')
insert into TipoEmpleado
VALUES('Mesero')
insert into Empleado
VALUES('Hola', 'Mundo', '9999-9999','','Barrio El Centro', 1, 1)

ALTER procedure [dbo].[Sp_EliminarFactura]
@IdFactura int 

	As 
	Begin 
	Set nocount off
	exec Sp_EliminarDFactura @IdFactura
	Delete 
	From Factura
	Where IdFactura=@IdFactura
End

--------------------------------------------------???
ALTER procedure [dbo].[Sp_MostrarDFacturaId]-- no me dio
@IdFactura INT
As BEGIN
	  Set nocount on  
	  Select a.IdFactura,p.Nombre,p.Precio,a.Cantidad
	  	   From DetalleFactura a inner Join Producto p  
	           on a.IdProducto = p.IdProducto 
			   Where a.IdFactura = @IdFactura
END


ALTER Procedure [dbo].[Sp_ListarSexo]
AS
BEGIN
	Set nocount on
	Select * 
	From Sexo
End

---------------------------------------------------??? --porque no lleva set nocount on?

Create PROCEDURE Sp_ListarTipoEmpleado
AS
BEGIN
	SELECT *
	From TipoEmpleado
END

Create view V_Factura
AS
Select 
From Factura f inner join DetalleFactura d on f.IdFactura = d.IdFactura
			   inner join Producto p on p.IdProducto = d.IdProducto



------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
------------------------------Procedimientos Almacenados para Auditoria--------------------------------
------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------
Create Procedure Sp_MostrarAuditoriaLog
As
	Begin
		Set nocount on
		Select a.IdAuditLog, u.Usuario, e.Nombre + ' ' + e.Apellido 'Nombre Empleado', a.Descripcion
		From AuditLog a inner join Usuario u
			on a.IdUsuario = u.IdUsuario
			inner join Empleado e
			on u.IdEmpleado = e.IdEmpleado
	End
Go

exec Sp_MostrarAuditoriaLog