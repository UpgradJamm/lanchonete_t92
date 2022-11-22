# Triggers são disparadores que permitem chamar PROCEDURES ou FUNCTIONS
# do banco de dados automaticamente quando um evento do banco é disparado

DROP TRIGGER IF EXISTS `TRG_ENTRADA_PRODUTO_AFIN`;
# Atualizar o estoque APÓS a entrada de produto
DELIMITER //
CREATE TRIGGER `TRG_ENTRADA_PRODUTO_AFIN` 
	AFTER INSERT ON lanchonete_t92.entradas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( new.produtos_id_produto );
END //
DELIMITER ;

DROP TRIGGER IF EXISTS `TRG_SAIDA_PRODUTO_AFIN`;
# Atualizar o estoque APÓS a saída de produto
DELIMITER //
CREATE TRIGGER `TRG_SAIDA_PRODUTO_AFIN` 
	AFTER INSERT ON lanchonete_t92.saidas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( new.produtos_id_produto );
END //
DELIMITER ;

# Atualizar o estoque APÓS o UPDATE da entrada de produto
DROP TRIGGER IF EXISTS `TRG_ENTRADA_PRODUTO_AFUP`;
DELIMITER //
CREATE TRIGGER `TRG_ENTRADA_PRODUTO_AFUP` 
	AFTER UPDATE ON lanchonete_t92.entradas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END //
DELIMITER ;

# Atualizar o estoque APÓS o UPDATE da saida de produto
DROP TRIGGER IF EXISTS `TRG_SAIDA_PRODUTO_AFUP`;
DELIMITER //
CREATE TRIGGER `TRG_ENTRADA_SAIDA_AFUP` 
	AFTER UPDATE ON lanchonete_t92.saidas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END //
DELIMITER ;

# Atualizar o estoque APÓS o DELETE da entrada de produto
DROP TRIGGER IF EXISTS `TRG_ENTRADA_PRODUTO_AFDEL`;
DELIMITER //
CREATE TRIGGER `TRG_ENTRADA_PRODUTO_AFDEL` 
	AFTER DELETE ON lanchonete_t92.entradas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END //
DELIMITER ;

# Atualizar o estoque APÓS o DELETE da saida de produto
DROP TRIGGER IF EXISTS `TRG_SAIDA_PRODUTO_AFDEL`;
DELIMITER //
CREATE TRIGGER `TRG_SAIDA_PRODUTO_AFDEL` 
	AFTER DELETE ON lanchonete_t92.saidas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END //
DELIMITER ;

SHOW TRIGGERS; # exibe as trigger do BD





