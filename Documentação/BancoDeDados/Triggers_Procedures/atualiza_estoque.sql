#USE lanchonete_t92;

#DROP PROCEDURE IF EXISTS atualiza_estoque;

#DELIMITER //

CREATE PROCEDURE `atualiza_estoque` ( produto INT )

BEGIN

	# criando variáveis para armazenar os totais de entradas, saídas e estoque
    DECLARE total_entradas INT;
    DECLARE total_saidas INT;
    DECLARE total_estoque INT;
    DECLARE existe_registro INT;
    
	# Pegar a qtdade de produtos na tabela de entradas e somá-las
    SELECT SUM( quantidade ) INTO total_entradas FROM mwarbr84_t92.entradas_estoque 
		WHERE produtos_id_produto = produto;
        
	# Pegar a qtdade de produtos na tabela de saídas e somá-las
    SELECT SUM( quantidade ) INTO total_saidas FROM mwarbr84_t92.saidas_estoque 
		WHERE produtos_id_produto = produto;
        
	# Subtrair a qtdade de entradas da qtdade de saidas e exibir o valor encontrado
	#SELECT( total_entradas - total_saidas ) INTO total_estoque;
    
    # Checando se este produto já existe na tabela estoque
    SELECT COUNT(*) INTO existe_registro FROM mwarbr84_t92.estoque 
		WHERE produtos_id_produto = produto;
        
    # Inserir na tabela de estoque SE o produto ainda não existe nela
    # SENAO atualizar o produto pelo seu ID na tabela estoque
IF ( existe_registro = 0 )  THEN
     INSERT INTO mwarbr84_t92.estoque (
		produtos_id_produto,
        quantidade,
        id_criador
     ) VALUES (
		produto,
		total_entradas - total_saidas,
        1        
	);
ELSE
	UPDATE mwarbr84_t92.estoque SET quantidade = total_entradas - total_saidas
		WHERE produtos_id_produto = produto;
END IF ;

END 

#DELIMITER ;

# CALL atualiza_estoque( 1 );

# SHOW PROCEDURE STATUS; # lista todas as procedures do BD

# SHOW PROCEDURE CODE atualiza_estoque; # Exibe o código da PROCEDURE