create or replace procedure sp_insertTulajok(
	p_nev 	in tulajok.nev%type
)
authid definer
as
	v_id int;
begin
	select max(id) into v_id from tulajok;

	if v_id is null then
		v_id := 0;
	end if;
	v_id := v_id + 1;

	insert into tulajok
		(id, nev)
		values
		(v_id, p_nev);

end sp_insertTulajok;
