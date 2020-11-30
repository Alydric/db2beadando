create or replace procedure spInsert_cars(
	p_id 			in cars.id%type,
	p_rendszam 		in cars.rendszam%type,
	p_tulajdonos	in tulajok.nev%type,
	p_marka 		in cars.marka%type,
	p_tipus			in cars.tipus%type,
	p_evjarat		in cars.evjarat%type,
	p_hp			in cars.hp%type,
	p_ccm			in cars.ccm%type,

	p_out_rowcnt out int
)

authid definer
as
	v_check_rendszam int;
begin
	p_out_rowcnt := 0;

	if v_check_rendszam = 1 then
		insert into cars
			(id, rendszam, tulajok_nev, marka, tipus, evjarat, hp, ccm)
		values
			(p_id, p_rendszam, p_tulajdonos, p_marka, p_tipus, p_evjarat, p_hp, p_ccm);
		p_out_rowcnt := SQL%rowcount;
		commit;
	end if;

end spInsert_cars;