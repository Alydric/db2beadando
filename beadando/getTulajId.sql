create or replace procedure sf_getTulajId
(
	p_nev in tulajok.nev%type
)	
return int
deterministic

as
	temp int;
	temp_cnt int;
begin
	select count(*) into temp_cnt FROM tulajok where nev = p_nev;

	if temp_cnt = 0 then
		return null;
	else
		SELECT id into temp from tulajok where nev = p_nev;
	end if;

	return temp;

end sf_getTulajId;