/*
create database Nutri; 
go
use Nutri; 
go

create table Alumnos (
	matricula int primary key not null,
	nombre varchar(50),
	edad int,
	sexo char(1),
	peso float,
	altura float,
	imc float,
	actividadFisica varchar(30),
	estatus varchar(30),
	calorias int
);



---Procedimientos almacenados---

create procedure estadisticaHombres as
select  estatus, count(estatus) as total
from Alumnos where sexo = 'H'
group by estatus

create procedure estadisticaMujeres as
select  estatus, count(estatus) as total
from Alumnos where sexo = 'M'
group by estatus


create procedure estadisticaNinos as
select estatus, COUNT(estatus) as total
from Alumnos where edad between 1 and 17
group by estatus

create procedure estadisticaJovenes as
select estatus, COUNT(estatus) as total
from Alumnos where edad between 18 and 29
group by estatus

create procedure estadisticaAdultos as
select estatus, COUNT(estatus) as total
from Alumnos where edad between 30 and 100
group by estatus

*/

--- Insert de prueba---
insert into Alumnos values 
(21, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Delgadez aceptable', 300),
(22, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Delgadez moderada', 300),
(23, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Delgadez severa', 300),
(24, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Peso normal', 300),
(25, 'Juana', 49, 'M', 60, 1.58, 30, 'Bajo', 'Sobrepeso', 300),
(26, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Obesidad 1', 300),
(27, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Obesidad 2', 300),
(28, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Obesidad 3', 300),
(29, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Obesidad 4', 300),
(30, 'Juana', 40, 'M', 60, 1.58, 30, 'Bajo', 'Obesidad 4', 300)


