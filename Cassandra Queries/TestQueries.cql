-- ////////////////////////
-- ////////// ADMINISTRADOR --
insert into Administrador(ID_Admin, Nombre_usuario)
values (now(), 'Juan Alejandro Villarreal Mojica');
insert into Log_Administrador(Correo_electronico, Contrasena, ID_Admin, Nombre_usuario)
values('juan_al@user.com', '12345678', c299cf20-b9f8-11eb-ad94-fba2c2fddc37, 'Juan Alejandro Villarreal Mojica');

select * from Administrador;
select * from Log_Administrador;

select count(*) from Log_Administrador where Correo_electronico = 'test@user.com';


-- ///////////////////
-- ////////// EMPLEADO --
insert into Empleado(NUM_Empleado, Nombres, Apellidos, Fecha_nac, RFC, CURP, Correo_electronico, Contrasena, Activo)
values (now(), 'Gerardo', 'Lopez', '1990-06-18', 'RFCSAMPLE1234', 'CURPSAMPLE12345678', 'employee@user.com', '22332233', true);

insert into Log_Empleado(Correo_electronico, Contrasena, NUM_Empleado, Nombre_usuario, Bloqueo)
values ('employee@user.com', '22332233', a3fa3d60-b1f2-11eb-b1f1-3daf39d21896, 'Gerardo Lopez', false);

update Log_Empleado set Bloqueo = false where Correo_electronico = 'employee@user.com';

select * from Empleado;
select * from Log_Empleado;
select NUM_Empleado, Nombre_usuario, Bloqueo from Log_Empleado where Correo_electronico = 'employee@user.com';

update Empleado set Activo = true where NUM_Empleado = 1b4ae97e-e166-4db8-9164-6e4e0f242838;

-- ///////////////////
-- ////////// CLIENTES --
insert into Cliente(ID_Cliente, Nombres, Apellidos, Fecha_nac, Domicilio, CURP, Correo_electronico, Contrasena, Activo)
values(now(), 'Alfredo', 'Uribe', '19960150', 'DomicilioX', 'CURPSAMPLE33333333', 'fredo@user.com', '55443322', true);
insert into Log_Cliente(Correo_electronico, Contrasena, ID_Cliente, Nombre_usuario, Bloqueo)
values('fredo@user.com', '55443322', e5a1d220-b1fa-11eb-b1f1-3daf39d21896, 'Alfredo Uribe', false);

insert into Cliente(ID_Cliente, Nombres, Apellidos, Fecha_nac, Domicilio, CURP, Correo_electronico, Contrasena, Activo)
values(now(), 'Abigail', 'Galindo', '19960823', 'DomicilioX', 'CURPSAMPLE33333333', 'abi@user.com', 'hola1234', true);
insert into Log_Cliente(Correo_electronico, Contrasena, ID_Cliente, Nombre_usuario, Bloqueo)
values('abi@user.com', '33221122', 666e6900-b2c7-11eb-a32f-e7185d99f820, 'Abigail Galindo', false);

update Log_Cliente set Bloqueo = false where Correo_electronico = 'fredo@user.com';

update Cliente set Domicilio = 'Jacarandas,563,,Arboleda,Escobedo,Nuevo León,66721', Fecha_nac = '1996-01-06' where ID_Cliente = e5a1d220-b1fa-11eb-b1f1-3daf39d21896;
update Cliente set Domicilio = 'Cobre,380,,Metales,Apodaca,Nuevo León,62312', Fecha_nac = '1996-08-23' where ID_Cliente = 666e6900-b2c7-11eb-a32f-e7185d99f820;
 
select * from Cliente;
select * from Log_Cliente;
select ID_Cliente, Nombre_usuario, Bloqueo from Log_Cliente where Correo_electronico = '' and Contrasena = '';

-- ///////////////////
-- ////////// SERVICIO --
select ID_Serv from Servicio where Medidor = 66623 allow filtering;
select * from Servicio;

-- //////////////////
-- ////////// TARIFAS --
select * from Reporte_Tarifas;
update Reporte_Tarifas set Tar_basica = 0.25, Tar_intermedia = 0.5, Tar_excedente = 1.25
where Year = 2021 and Month = 9 and Tipo_serv = false;

-- ///////////////////
-- ////////// CONSUMOS --
select * from Reporte_Consumos;
select * from Consumo_Historico;
select * from Reporte_General;

-- //////////////////
-- ////////// RECIBOS --
select * from Recibos;

-- ////////////////////////////////
-- //////// REGISTRO DE CONTRASEÑAS
insert into Recordar_contra (Tipo_user, Correo_electronico, Contrasena)
values (0, 'fredo@user.com', '55443322');
insert into Recordar_contra (Tipo_user, Correo_electronico, Contrasena)
values (1, 'employee@user.com', '22332233');
insert into Recordar_contra (Tipo_user, Correo_electronico, Contrasena)
values (2, 'test@user.com', '12345678');

select * from Recordar_contra;

insert into Registro_actividad (NUM_Empleado, CLAVE, Fecha_reg, Accion, Descripcion)
values(now(), now(), toTimestamp(now()), 'XD', 'XD');

select * from Registro_actividad;