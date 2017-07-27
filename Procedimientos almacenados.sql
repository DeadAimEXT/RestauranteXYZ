use RestauranteXYZ


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
--------------------------------------------------