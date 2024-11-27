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
golovidomaci varchar(10),
golovigosti varchar(10)  
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
values ('FC Barcelona','1899-11-29','Camp Nou'),
('Real Madrid','1902-3-6','Santiago Bernabeu')


insert into utakmica (datum,domaci,gosti,golovigosti,golovidomaci)
values ('2024-10-26',2,1,4,0),
('2010-11-29',1,2,0,5);


insert into igrac (ime,prezime,podrijetlo,pozicija,vrijednost,klub)
values ('Lamine','Yamal','Marokanac','RW',150.00,1),
 ('Vinicius','Junior','Brazilac','LW',200.00,2);