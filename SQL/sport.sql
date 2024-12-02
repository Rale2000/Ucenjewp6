use master;
go

drop database if exists sport;
go

create database sport;
go

use sport;
go


create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan int not null,
stadion varchar(30),
predsjednik varchar(20),
drzava varchar(100),
liga varchar(20)
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum int not null,
vrijeme varchar(50) not null,
lokacija varchar(30),
stadion varchar(50),
domaciklub int not null references klub(sifra),
gostujuciklub int not null references klub(sifra)
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
klub int not null references klub(sifra),
nacionalnost varchar(100),
iskustvo varchar(20)
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50),
datumrodenja int not null,
pozicija varchar(20) not null,
brojdresa int,
klub int not null references klub(sifra)
);
