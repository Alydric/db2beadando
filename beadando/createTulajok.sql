drop table tulajok;

create table tulajok(
	id int not null,
	nev varchar2(200) not null,
    dateOfBirth date,

	constraint pk_tulajok primary key(id)
);