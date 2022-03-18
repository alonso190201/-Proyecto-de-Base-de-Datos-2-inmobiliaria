CREATE DATABASE dbinmobiliaria
GO

USE dbinmobiliaria
GO

--crear tabla persona
if(not exists(select 1 from SYS.tables where name ='Persona'))
CREATE TABLE dbo.Persona(
persona_id int identity(1,1) PRIMARY KEY ,
dni char(8) NOT NULL,
nombre varchar(150),
apellido varchar(250) not null,
sexo char(1) not null,
email varchar(250) unique not null,
celular char(9) unique not null,
direccion text null,
fechanacimiento date null
)

--crear tabla usuario
if(not exists(select 1 from SYS.tables where name ='Usuario'))
CREATE TABLE dbo.Usuario(
usuario_id int identity(1,1),
persona_id int,
usuario varchar(50) unique not null,
clave varchar(15) not null,
nivel varchar(30) not null,
estado char(1) not null
PRIMARY KEY(usuario_id),
FOREIGN KEY(persona_id)REFERENCES Persona
)

--crear tabla empleado
if(not exists(select 1 from SYS.tables where name ='Empleado'))
CREATE TABLE dbo.Empleado(
persona_id int identity(1,1) PRIMARY KEY ,
dni char(8) NOT NULL,
nombre varchar(150),
apellido varchar(250) not null,
sexo char(1) not null,
email varchar(250) unique not null,
celular char(9) unique not null,
direccion text null,
fechanacimiento date null
)

--crear tabla inmueble
if(not exists(select 1 from SYS.tables where name ='Inmueble'))
CREATE TABLE dbo.Inmueble(
inmueble_id int identity(1,1) PRIMARY KEY ,
dni char(8) NOT NULL,
nombre varchar(150),
apellido varchar(250) not null,
celular char(9) unique not null,
tipoinmueble varchar(150),
direccion text null,
)


--insert en la tabla persona
INSERT INTO dbo.Persona(dni,nombre,apellido,sexo,email,celular,direccion,fechanacimiento)
values('11223344','arnold','Aguilar Carrasco', 'M','neiaguilarc@upt.pe','945456654','calle siempre viva','1994/07/14')
INSERT INTO dbo.Persona(dni,nombre,apellido,sexo,email,celular,direccion,fechanacimiento)
values('11223345','bianca','Chura Velo', 'F','bchura@upt.pe','98765432','calle siempre viva','1994/07/14')
INSERT INTO dbo.Persona(dni,nombre,apellido,sexo,email,celular,direccion,fechanacimiento)
values('11223346','vanesa','Yucra Mamani', 'F','vyucra@upt.pe','94563214','calle siempre viva','1994/07/14')

--insert en la tabla usuario
INSERT INTO dbo.Usuario VALUES (1,'admin','admin','Administrador','A')
INSERT INTO dbo.Usuario VALUES (2,'bianca','chura','Administrador','A')
INSERT INTO dbo.Usuario VALUES (3,'vanesa','yucra','Administrador','A')

