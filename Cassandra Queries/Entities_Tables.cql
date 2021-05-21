drop table IF EXISTS Administrador;
create table Administrador(
	ID_Admin				uuid,
	Nombre_usuario			text,
	
	PRIMARY KEY(ID_Admin)
);

drop table IF EXISTS Empleado;
create table Empleado(
	NUM_Empleado			uuid,
	Nombres					text,
	Apellidos				text,
	Fecha_nac				date,
	RFC						text,
	CURP					text,
	Telefonos				set<text>,
	Correo_electronico		text,
	Contrasena				text,
	Activo					boolean,
	
	PRIMARY KEY(NUM_Empleado)
);

drop table IF EXISTS Registro_actividad;
create table Registro_actividad(
	NUM_Empleado			uuid,
	CLAVE					uuid,
	Fecha_reg				timestamp,
	Accion					text,
	Descripcion				text,
	
	PRIMARY KEY(NUM_Empleado, CLAVE)
);

drop table IF EXISTS Cliente;
create table Cliente(
	ID_Cliente				uuid,
	Nombres					text,
	Apellidos				text,
	Fecha_nac				date,
	Domicilio				text,
	CURP					text,
	Telefonos				set<text>,
	Tarjetas				list<text>,
	Cuentas_bancarias		list<text>,
	Pagos_efectivo			map<timestamp, decimal>,
	Correo_electronico		text,
	Contrasena				text,
	Activo					boolean,
	
	PRIMARY KEY(ID_Cliente)
);

drop table IF EXISTS Servicio;
create table Servicio(
	ID_Cliente				uuid,
	ID_Serv					uuid,
	Medidor					bigint,
	Tipo_serv				boolean,
	Domicilio				text,
	Activo					boolean,
	
	PRIMARY KEY(ID_Cliente, ID_Serv)
);
create index on Servicio(Medidor);
create index on Servicio(Tipo_serv);

drop table IF EXISTS Recibos;
create table Recibos(
	ID_Serv					uuid,
	ID_Rec					uuid,
	Year					int,
	Month					tinyint,
	Tipo_serv				boolean,
	Medidor					bigint,
	Domicilio				text,
	Fecha_venci				date,
	Consumo_basico			int,
	Consumo_intermedio		int,
	Consumo_excedente		int,
	Consumo_total			int,
	Tarifa_basica			decimal,
	Tarifa_intermedia		decimal,
	Tarifa_excedente		decimal,
	Precio_basico			decimal,
	Precio_intermedio		decimal,
	Precio_excedente		decimal,
	Precio_total			decimal,
	Cargo_IVA				decimal,
	Pago_total				decimal,
	Importe_Pago			decimal,
	Pendiente_Pago			decimal,
	Prev_pendiente			decimal,
	Pagado					boolean,
	
	PRIMARY KEY(ID_Serv, ID_Rec)
);
create index on Recibos(Year);
create index on Recibos(Month);