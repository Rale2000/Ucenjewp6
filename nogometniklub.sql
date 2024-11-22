use master;
go

drop database if exists nogometniklub;
go

create database nogometniklub collate Croatian_CI_AS;
go

use nogometniklub;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
osnovan datetime,
stadion varchar(40)	
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime,
gosti int not null references klub(sifra),
domaci int not null references klub(sifra),
golovidomaci int not null references klub(sifra),
golovigosti int not null references klub(sifra)
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
podrijetlo varchar(70) not null,
pozicija varchar(11),
vrijednost decimal(18,2),
klub int not null references klub(sifra)
);

insert into klub (naziv,osnovan,stadion)
values ('FC Barcelona','1899-11-29','Camp Nou');

insert into utakmica (datum,gosti,domaci,golovidomaci,golovigosti)
values ('2024-10-26','FC Barcelona','Real Madrid',0,4)

insert into igrac (ime,prezime,podrijetlo,pozicija,vrijednost,klub)
values ('Lamine','Yamal','Marokanac','RW',150.00,'FC Barcelona');