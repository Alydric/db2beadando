create or replace function sf_check_rendszam
(
	p_rendszam in cars.rendszam%type
)
return int
deterministic

as
	v_rendszam_char char(1);
	v_i int;
begin
	if p_rendszam is null then 
		return 0
	end if;
	if length(trim(p_rendszam)) = 6 then
		v_i := 1;
		while v_i <= 3 loop
			v_rendszam_char := substr(p_rendszam, v_i, 1);
			if not (ascii('A') <= ascii(v_rendszam_char) and ascii(v_rendszam_char) <= ascii('Z')) then
				return 0;
			end if;
			v_i := v_i + 1;
		end loop;

		while v_i <= 6 loop
			v_rendszam_char := substr(p_rendszam, v_i, 1);
			if not (ascii('0') <= ascii(v_rendszam_char) and ascii(v_rendszam_char) <= ascii('9')) then
				return 0;
			end if;
			v_i := v_i + 1;
		end loop;
		return 1;
	end if;
	return 0;







end sf_check_rendszam;