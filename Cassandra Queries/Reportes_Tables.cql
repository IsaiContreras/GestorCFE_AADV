drop table IF EXISTS Reporte_General;
create table Reporte_General(
	ID_Cliente				uuid,
	Year					int,
	Month					tinyint,
	Tipo_serv				boolean,
	Total_pago				decimal,
	Total_pendiente			decimal,
	
	PRIMARY KEY(ID_Cliente, Year, Month, Tipo_serv)
);

drop table IF EXISTS Reporte_Tarifas;
create table Reporte_Tarifas(
	Year					int,
	Month					tinyint,
	Tipo_serv				boolean,
	Tar_basica				decimal,
	Tar_intermedia			decimal,
	Tar_excedente			decimal,
	
	PRIMARY KEY((Year, Month, Tipo_serv))
);

drop table IF EXISTS Reporte_Consumos;
create table Reporte_Consumos(
	Year					int,
	Month					tinyint,
	Tipo_serv				boolean,
	Medidor					bigint,
	kW_totales				int,
	kW_basica				int,
	kW_intermedia			int,
	kW_excedente			int,
	
	PRIMARY KEY((Year, Month, Tipo_serv, Medidor))
);

drop table IF EXISTS Consumo_Historico;
create table Consumo_Historico(
	ID_Serv					uuid,
	Year					int,
	Month					tinyint,
	Medidor					bigint,
	Consumo_kW				int,
	Pago_total				decimal,
	Importe_Pago			decimal,
	Pendiente_Pago			decimal,
	
	PRIMARY KEY(ID_Serv, Year, Month)
);