/*# Roles(Políticas ou regras) de usuários do sistema

# sistema pode fazer todas as alterações no banco - owner
CREATE USER IF NOT EXISTS 'sistema'@'localhost' 
	IDENTIFIED BY '1234';
    
GRANT ALL ON lanchonete_t92.* TO 'sistema'@'localhost';

# gerentes podem fazer tudo, menos alterar/ criar estruturas de tabelas
CREATE USER IF NOT EXISTS 'gerente'@'localhost' 
	IDENTIFIED BY '1234';
    
GRANT SELECT, DELETE, UPDATE, INSERT ON lanchonete_t92.* 
	TO 'gerente'@'localhost';
    
# estoque apenas lerão as tabelas de estoque (entrada, saida, estoque)    
CREATE USER IF NOT EXISTS 'estoque'@'localhost' 
	IDENTIFIED BY '1234';
    
GRANT SELECT, DELETE, UPDATE, INSERT ON lanchonete_t92.entradas_estoque
	TO 'estoque'@'localhost';
    
GRANT SELECT, DELETE, UPDATE, INSERT ON lanchonete_t92.saidas_estoque
	TO 'estoque'@'localhost';
    
GRANT SELECT ON lanchonete_t92.estoque
	TO 'estoque'@'localhost';
    
# funcionários apenas 
CREATE USER IF NOT EXISTS 'funcionarios'@'localhost' 
	IDENTIFIED BY '1234';
    
REVOKE ALL ON lanchonete_t92.* FROM 'funcionarios'@'localhost';
    
*/
    
    
    
    