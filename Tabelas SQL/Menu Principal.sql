--Menu Principal >> Configura��es Gerais
INSERT INTO ROTINAS (nopai, nofilho, desnofilho) values ('tn_geral_config', 'tn_users', 'Usu�rios')
--Sub Menu Usu�rios
INSERT INTO ROTINAS1 (nopai, nofilho, nameform) values ('tn_geral_config', 'tn_users', 'Gest�o de Usu�rios')

--Fim submenu Usu�rios
INSERT INTO ROTINAS (nopai, nofilho, desnofilho) values ('tn_geral_config', 'tn_config', 'Configura��es')

select * from rotinas
select * from rotinas1