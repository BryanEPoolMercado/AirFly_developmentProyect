--create database AirFly_BDD
use AirFly_BDD

CREATE TABLE Aerolinea
(
    id_aerolinea int identity(1,1) not null,
    nombre_aerolinea varchar(50),
    CONSTRAINT PK_idaerolinea PRIMARY KEY (id_aerolinea)
)

CREATE TABLE Estado_pago
(
    id_estadopago int identity(1,1) not null,
    descripcion varchar(200),
    CONSTRAINT PK_idestadopago PRIMARY KEY (id_estadopago)
)

CREATE TABLE Paypal
(
    id_paypal int identity(1,1) not null,
    nombre_paypal varchar(50),
    fecha_vencimiento date,
    tipo varchar(50),
    cvc int,
    CONSTRAINT PK_idpaypal PRIMARY KEY(id_paypal)
)

CREATE TABLE Metodo_pago
(
    id_metodopago int identity(1,1) not null,
    monto_pago varchar(50),
    CONSTRAINT PK_idmetodopago PRIMARY KEY(id_metodopago)
)

CREATE TABLE Moneda
(
    id_moneda int identity(1,1) not null,
    nombre_moneda varchar(50),
    valor_moneda decimal,
    CONSTRAINT PK_idmoneda PRIMARY KEY(id_moneda)
)

CREATE TABLE Pais
(
    id_pais int identity(1,1) not null,
    nombre_pais varchar(50),
    CONSTRAINT PK_idpais PRIMARY KEY(id_pais)
)

CREATE TABLE Secciones
(
    id_secciones int identity(1,1) not null,
    nombre_seccion varchar(50),
    CONSTRAINT PK_idsecciones PRIMARY KEY(id_secciones)
)

CREATE TABLE Pasajeros
(
    id_pasajero int identity(1,1) not null,
    nombre_pasajero varchar(50),
    apellido_pat varchar(50),
    apellido_mat varchar(50),
    fecha_nac date,
    CONSTRAINT PK_idpasajero PRIMARY KEY(id_pasajero)
)

CREATE TABLE Perfil
(
    id_perfil int identity(1,1) not null,
    nombre_perfil varchar(30),
    CONSTRAINT PK_idperfil PRIMARY KEY (id_perfil)
)

CREATE TABLE Ciudad
(
    id_ciudad int identity(1,1) not null,
    nombre_ciudad varchar(50),
    id_pais int,
    CONSTRAINT PK_idciudad PRIMARY KEY (id_ciudad),
	CONSTRAINT FK_idpais FOREIGN KEY (id_pais)REFERENCES Pais(id_pais)
)

CREATE TABLE Aeropuerto
(
    id_aeropuerto int identity(1,1) not null,
    nombre_aeropuerto varchar(50),
    id_ciudad int,
    CONSTRAINT PK_idaeropuerto PRIMARY KEY (id_aeropuerto),
	CONSTRAINT FK_idciudad FOREIGN KEY(id_ciudad)references Ciudad(id_ciudad),	
)

CREATE TABLE Asientos
(
    id_asiento int identity(1,1) not null,
    num_fila int,
    num_columna int,
    id_secciones int,
    CONSTRAINT PK_asientos PRIMARY KEY(id_asiento),
	CONSTRAINT FK_idsecciones FOREIGN KEY (id_secciones)REFERENCES Secciones(id_secciones)
)
create table Modelo_avion(
id_modelo int identity(1,1) not null,
Nombre_modelo varchar(50),
Filas int,
columnas int,
constraint PK_id_modelo primary key(id_modelo)		
)


CREATE TABLE Avion
(
    id_avion int identity(1,1) not null,
    numfila_avion int,
	numcolumna_avion int,
    nombre_avion varchar(50),
	id_modelo int,
    id_aerolinea int,
    id_secciones int,
    CONSTRAINT PK_idavion PRIMARY KEY(id_avion),
	CONSTRAINT FK_MODELO_AVION FOREIGN KEY (id_modelo)references Modelo_avion(id_modelo),
	CONSTRAINT FK_idsecciones1 FOREIGN KEY (id_secciones)REFERENCES Secciones(id_secciones),
    CONSTRAINT FK_idaerolinea FOREIGN KEY (id_aerolinea)REFERENCES Aerolinea(id_aerolinea)
)

CREATE TABLE Ruta
(
    id_ruta int identity(1,1) not null,
	nombre_ruta varchar(50),
    distancia varchar(10),
    tiempo varchar(10),
    aeropuerto_origen int,
    aeropuerto_destino int,
    CONSTRAINT PK_idruta PRIMARY KEY (id_ruta),
    CONSTRAINT FK_idaerorigen FOREIGN KEY (aeropuerto_origen)REFERENCES Aeropuerto(id_aeropuerto), 
    CONSTRAINT FK_idaerodestino FOREIGN KEY (aeropuerto_destino)REFERENCES Aeropuerto(id_aeropuerto)
)

CREATE TABLE Vuelos
(
    id_vuelo int identity (1,1)not null,
    fecha_vuelo date,
    hora_vuelo varchar(10),
    tiempo_vuelo varchar(10),
    distancia_vuelo varchar(10),
    id_avion int,
    id_ruta int,
    CONSTRAINT PK_idvuelo PRIMARY KEY (id_vuelo),
	CONSTRAINT FK_idruta FOREIGN KEY (id_ruta)REFERENCES Ruta(id_ruta),
    CONSTRAINT FK_idavion FOREIGN KEY (id_avion)REFERENCES Avion(id_avion)
)

CREATE TABLE Asiento_Avion
(
    id_asiento int,
    id_vuelo int,
	CONSTRAINT FK_idasiento FOREIGN KEY (id_asiento)REFERENCES Asientos(id_asiento),
	CONSTRAINT FK_idvuelo FOREIGN KEY (id_vuelo)REFERENCES Vuelos(id_vuelo)
)

CREATE TABLE Boleto
(
    id_boleto int identity(1,1) not null,
    id_vuelo int,
    id_asiento int,
    id_pasajero int,
    CONSTRAINT PK_idboleto PRIMARY KEY(id_boleto),
	CONSTRAINT FK_idasiento1 FOREIGN KEY (id_asiento)REFERENCES Asientos(id_asiento),
	CONSTRAINT FK_idpasajero FOREIGN KEY (id_pasajero)REFERENCES Pasajeros(id_pasajero),
    CONSTRAINT FK_idvuelo1 FOREIGN KEY (id_vuelo)REFERENCES Vuelos(id_vuelo)
)

CREATE TABLE Usuario
(
    id_usuario int identity(1,1) not null,
    nombre_usuario varchar(50),
	apellidopat_usuario varchar(50),
	apellidomat_usuario varchar(50),
	correo_usuario varchar(50),
    contraseña_usuario varchar(50),
    id_perfil int,
    CONSTRAINT PK_idusuario PRIMARY KEY(id_usuario),
	CONSTRAINT FK_idperfil FOREIGN KEY (id_perfil)REFERENCES Perfil(id_perfil)
)

CREATE TABLE Tarjeta
(
    id_tarjeta int identity(1,1) not null,
    nombre_tarjeta varchar(50),
    id_paypal int,
    CONSTRAINT PK_idtarjeta PRIMARY KEY(id_tarjeta),
	CONSTRAINT FK_idpaypal FOREIGN KEY (id_paypal)REFERENCES Paypal(id_paypal)
)

CREATE TABLE Compra
(
    id_compra int identity(1,1) not null,
    Fecha_compra date,
    Hora_compra datetime,
    Precio_compra decimal,
    id_tarjeta int,
    id_estadopago int,
    id_moneda int,
    id_metodopago int,
    id_usuario int,
	CONSTRAINT PK_idcompra PRIMARY KEY(id_compra),    
    CONSTRAINT FK_idtarjeta FOREIGN KEY (id_tarjeta)REFERENCES Tarjeta(id_tarjeta),
	CONSTRAINT FK_idestadopago FOREIGN KEY (id_estadopago)REFERENCES Estado_pago(id_estadopago),
    CONSTRAINT FK_idmoneda FOREIGN KEY (id_moneda)REFERENCES Moneda(id_moneda),
	CONSTRAINT FK_idmetodopago FOREIGN KEY (id_metodopago)REFERENCES Metodo_pago(id_metodopago),
	CONSTRAINT FK_idusuario FOREIGN KEY (id_usuario)REFERENCES Usuario(id_usuario)
)

CREATE TABLE Detalle_Compra
(
    id_boleto int,
	id_compra int,
    CONSTRAINT PK_idbolcompra PRIMARY KEY(id_boleto, id_compra),
	CONSTRAINT FK_idboleto FOREIGN KEY (id_boleto)REFERENCES Boleto(id_boleto),
	CONSTRAINT FK_idcompra FOREIGN KEY (id_compra)REFERENCES Compra(id_compra)
)

CREATE TABLE Reservacion
(
    id_reservacion int identity(1,1) not null,
    id_vuelo int,
    CONSTRAINT PK_idreservacion PRIMARY KEY(id_reservacion),
	CONSTRAINT FK_idvuelo2 FOREIGN KEY (id_vuelo)REFERENCES Vuelos(id_vuelo)
)

CREATE TABLE Reservacion_Pasajero
(
    id_reservacion int,
    id_pasajero int,
    CONSTRAINT PK_idreserpasajero PRIMARY KEY (id_reservacion, id_pasajero),
	CONSTRAINT FK_idreservacion FOREIGN KEY (id_reservacion)REFERENCES Reservacion(id_reservacion),
	CONSTRAINT FK_idpasajero1 FOREIGN KEY (id_pasajero)REFERENCES Pasajeros(id_pasajero)
)

CREATE TABLE Ubicacion
(
    id_ubicacion int identity(1,1) not null,
    nombre_ubicacion varchar(50),
    id_asiento int,
    CONSTRAINT PK_idubicacion PRIMARY KEY(id_ubicacion),
	CONSTRAINT FK_idasiento1 FOREIGN KEY (id_asiento)REFERENCES Asientos(id_asiento)
)

insert into Secciones(nombre_seccion)values('VIP')
insert into Secciones(nombre_seccion)values('Turista')

insert into Perfil(nombre_perfil)values('Administrador')
insert into Perfil(nombre_perfil)values('Usuario')