# Apagar uma procedure
DROP PROCEDURE IF EXISTS mostra_estoque;

# DELIMITER - define os caracteres que interrompem a execução do código
DELIMITER //

#cria uma procedure - bloco de código que será executado qdo chamado
CREATE PROCEDURE `mostra_estoque` ( )

# início da escrita SQL
BEGIN

# Algoritmo a ser executado pelo banco de dados - SQL
	SELECT b.descricao, a.quantidade, a.data_alteracao FROM lanchonete_t92.estoque AS a
		INNER JOIN lanchonete_t92.produtos AS b;
    
# encerra a escrita do SQL
END //

#novo delimitador sempre o ; padrão do SQL
DELIMITER ;

# chamamando uma procedure 
CALL mostra_estoque();





