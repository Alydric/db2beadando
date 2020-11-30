drop table cars;

create table cars
(
	id int not null,
	rendszam char2(6) not null,
    tulajdonos varchar2(200) not null,
    marka varchar2(200) not null,
    tipus varchar2(200) not null,
    evjarat int not null,
    hp int not null,
    ccm int not null,

	constraint pk_cars primary key(id),
	constraint uq_autok_alvazszam unique(rendszam),
	constraint fk_tulajok foreign key(tulajdonos) references tulajok(nev)

);