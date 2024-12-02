-- UPDATE naredba

select * from smjerovi;
update smjerovi set cijena = cijena * 0.9;
select * from smjerovi;

-- uvećajte sve cijene za 35%
select * from smjerovi;
update smjerovi set cijena = cijena * 1.35;
select * from smjerovi;

-- smanjite svim smjerovima cijenu za 10 eura
select * from smjerovi; 
update smjerovi set cijena = cijena - 10;
select * from smjerovi;


-- uvijet vanjskog ključa
update grupe set smjer=8 where sifra=1;


-- DELETE naredba

select * from smjerovi;
delete from smjerovi where sifra>8;
select * from smjerovi;

select * from grupe;
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;

update clanovi set grupa=2 where grupa=1;


