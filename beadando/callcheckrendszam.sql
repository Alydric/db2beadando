set serveroutput on;
declare
	v_call_rendszam int;
	v_rendszam cars.rendszam%type := 'ABC123';
begin
	v_call_rendszam := sf_check_rendszam(v_rendszam);

	if v_call_rendszam = 1 then
		DBMS_OUTPUT.PUT_LINE('Az alábbi rendszám helyes: '||v_rendszam);
	ELSE
		DBMS_OUTPUT.PUT_LINE('Az alábbi rendszám helytelen: '||v_rendszam);
	END IF;

end;