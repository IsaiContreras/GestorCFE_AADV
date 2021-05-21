drop table IF EXISTS Log_Administrador;
create table Log_Administrador(
	Correo_electronico			text,
	Contrasena					text,
	ID_Admin					uuid,
	Nombre_usuario				text,
	
	PRIMARY KEY(Correo_electronico)
);
create index on Log_Administrador(Contrasena);

drop table IF EXISTS Log_Empleado;
create table Log_Empleado(
	Correo_electronico			text,
	Contrasena					text,
	NUM_Empleado				uuid,
	Nombre_usuario				text,
	Bloqueo						boolean,
	
	PRIMARY KEY(Correo_electronico)
);
create index on Log_Empleado(Contrasena);

drop table IF EXISTS Log_Cliente;
create table Log_Cliente(
	Correo_electronico			text,
	Contrasena					text,
	ID_Cliente					uuid,
	Nombre_usuario				text,
	Bloqueo						boolean,
	
	PRIMARY KEY(Correo_electronico)
);
create index on Log_Cliente(Contrasena);

drop table IF EXISTS Recordar_contra;
create table Recordar_contra(
	Tipo_user					tinyint,
	Correo_electronico			text,
	Contrasena					text,
	
	PRIMARY KEY ((Tipo_user, Correo_electronico))
);