use master;
go

drop database if exists edunovawp6;
go

create database edunovawp6;
go

use edunovawp6;
go

create table zivotinja(
sifra int not null primary key identity(1,1),
vrsta varchar(50) not null
ime varchar(50) not null,
djelatnik int,
prostorija int,
datum int
);

create table prostorija(
sifra int not null primary key identity(1,1),

);