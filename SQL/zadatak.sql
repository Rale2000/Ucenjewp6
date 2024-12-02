use master;
go

drop database if exists rale;
go

create database rale;
go

use rale;
go

create table autor(
sifra int not null primary key identity(1,1),
ime nvarchar(50),
prezime nvarchar(50),
datumrodenja datetime not null
);

create table izdavac(
sifra int not null primary key identity(1,1),
naziv nvarchar(50),
aktivan bit
);

create table mjesto(
sifra int not null primary key identity(1,1),
naziv nvarchar(50),
postanskibroj nvarchar(10),
drzava nvarchar(50)
);

create table katalog(
sifra int not null primary key identity(1,1),
autor int not null references autor(sifra),
naslov nvarchar(50),
izdavac int not null references izdavac(sifra),
mjesto int not null references mjesto(sifra)
);