--Menu Principal >> Configurações Gerais
INSERT INTO ROTINAS (nopai, nofilho, desnofilho) values ('tn_geral_config', 'tn_users', 'Usuários')
--Sub Menu Usuários
INSERT INTO ROTINAS1 (nopai, nofilho, nameform) values ('tn_geral_config', 'tn_users', 'Gestão de Usuários')

--Fim submenu Usuários
INSERT INTO ROTINAS (nopai, nofilho, desnofilho) values ('tn_geral_config', 'tn_config', 'Configurações')

select * from rotinas
select * from rotinas1