/*create database Nutri; 
go
use Nutri; 
go

create table Alumnos (
	matricula int primary key not null,
	edad int,
	sexo char(1),
	peso float,
	altura float,
	imc float,
	actividadFisica varchar(30),
	estatus varchar(30),
	calorias int
);*/

select * from Alumnos;

/*
-- Registros de prueba --
insert into Alumnos values 
(1, 18, 'H', 60, 1.58, null, null, null, 300),
(2, 23, 'M', 70, 1.80, null, null, null, 600);
*/