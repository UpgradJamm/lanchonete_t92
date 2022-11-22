-- ----------------------------------------------------------------------------
-- MySQL Workbench Migration
-- Migrated Schemata: lanchonete_t92
-- Source Schemata: lanchonete_t92
-- Created: Fri Sep 23 11:48:07 2022
-- Workbench Version: 8.0.29
-- ----------------------------------------------------------------------------

SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------------------------------------------------------
-- Schema lanchonete_t92
-- ----------------------------------------------------------------------------
DROP SCHEMA IF EXISTS `lanchonete_t92` ;
CREATE SCHEMA IF NOT EXISTS `lanchonete_t92` ;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.cadastros
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`cadastros` (
  `id_cadastro` INT(255) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NOT NULL,
  `sobrenome` VARCHAR(255) NOT NULL,
  `cpf` VARCHAR(255) NULL DEFAULT NULL,
  `nascimento` DATE NOT NULL,
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuarios_id_usuario` INT(255) NOT NULL,
  PRIMARY KEY (`id_cadastro`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC),
  INDEX `fk_cadastros_usuarios1_idx` (`usuarios_id_usuario` ASC),
  CONSTRAINT `fk_cadastros_usuarios1`
    FOREIGN KEY (`usuarios_id_usuario`)
    REFERENCES `lanchonete_t92`.`usuarios` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.emails
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`emails` (
  `id_email` INT(255) NOT NULL AUTO_INCREMENT,
  `email` VARCHAR(255) NOT NULL,
  `preferencial` ENUM('0', '1') NOT NULL DEFAULT '0',
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuarios_id_usuario` INT(255) NOT NULL,
  PRIMARY KEY (`id_email`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC),
  INDEX `fk_emails_usuarios1_idx` (`usuarios_id_usuario` ASC),
  CONSTRAINT `fk_emails_usuarios1`
    FOREIGN KEY (`usuarios_id_usuario`)
    REFERENCES `lanchonete_t92`.`usuarios` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.emails_fornecedores
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`emails_fornecedores` (
  `id_email_fornecedor` INT(255) NOT NULL AUTO_INCREMENT,
  `email` VARCHAR(255) NOT NULL,
  `preferencial` ENUM('0', '1') NOT NULL DEFAULT '0',
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fornecedores_id_fornecedores` INT(255) NOT NULL,
  PRIMARY KEY (`id_email_fornecedor`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC),
  INDEX `fk_emails_fornecedores_fornecedores1_idx` (`fornecedores_id_fornecedores` ASC),
  CONSTRAINT `fk_emails_fornecedores_fornecedores1`
    FOREIGN KEY (`fornecedores_id_fornecedores`)
    REFERENCES `lanchonete_t92`.`fornecedores` (`id_fornecedores`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.enderecos
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`enderecos` (
  `id_endereco` INT(255) NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(255) NOT NULL,
  `logradouro` VARCHAR(255) NOT NULL,
  `numero` VARCHAR(255) NOT NULL,
  `complemento` VARCHAR(255) NULL DEFAULT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuarios_id_usuario` INT(255) NOT NULL,
  `preferencial` ENUM('0', '1') NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_endereco`),
  INDEX `fk_enderecos_usuarios_idx` (`usuarios_id_usuario` ASC),
  CONSTRAINT `fk_enderecos_usuarios`
    FOREIGN KEY (`usuarios_id_usuario`)
    REFERENCES `lanchonete_t92`.`usuarios` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.enderecos_fonecedores
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`enderecos_fonecedores` (
  `id_endereco_fornecedores` INT(255) NOT NULL,
  `tipo` VARCHAR(255) NOT NULL,
  `logradouro` VARCHAR(255) NOT NULL,
  `numero` VARCHAR(255) NOT NULL,
  `complemento` VARCHAR(255) NULL DEFAULT NULL,
  `cep` VARCHAR(8) NOT NULL,
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fornecedores_id_fornecedores` INT(255) NOT NULL,
  PRIMARY KEY (`id_endereco_fornecedores`),
  INDEX `fk_enderecos_fonecedores_fornecedores1_idx` (`fornecedores_id_fornecedores` ASC),
  CONSTRAINT `fk_enderecos_fonecedores_fornecedores1`
    FOREIGN KEY (`fornecedores_id_fornecedores`)
    REFERENCES `lanchonete_t92`.`fornecedores` (`id_fornecedores`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.entradas_estoque
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`entradas_estoque` (
  `id_entrada_estoque` INT(255) NOT NULL AUTO_INCREMENT,
  `quantidade` INT(255) NOT NULL,
  `valor_unitario` DECIMAL(9,2) NOT NULL,
  `data_validade` DATE NOT NULL,
  `data_entrada` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `produtos_id_produto` INT(255) NOT NULL,
  PRIMARY KEY (`id_entrada_estoque`),
  INDEX `fk_entradas_estoque_produtos1_idx` (`produtos_id_produto` ASC),
  CONSTRAINT `fk_entradas_estoque_produtos1`
    FOREIGN KEY (`produtos_id_produto`)
    REFERENCES `lanchonete_t92`.`produtos` (`id_produto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.estoque
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`estoque` (
  `id_estoque` INT(255) NOT NULL AUTO_INCREMENT,
  `quantidade` INT(255) NOT NULL,
  `id_criador` INT(255) NOT NULL,
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `produtos_id_produto` INT(255) NOT NULL,
  PRIMARY KEY (`id_estoque`),
  INDEX `fk_estoque_produtos1_idx` (`produtos_id_produto` ASC),
  CONSTRAINT `fk_estoque_produtos1`
    FOREIGN KEY (`produtos_id_produto`)
    REFERENCES `lanchonete_t92`.`produtos` (`id_produto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.fornecedores
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`fornecedores` (
  `id_fornecedores` INT(255) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(255) NULL DEFAULT NULL,
  `sobrenome` VARCHAR(255) NULL DEFAULT NULL,
  `cnpj` VARCHAR(255) NULL DEFAULT NULL,
  `cpf` VARCHAR(45) NULL DEFAULT NULL,
  `razao_social` VARCHAR(255) NULL DEFAULT NULL,
  `representante` VARCHAR(255) NULL DEFAULT NULL,
  `nome_fantasia` VARCHAR(255) NULL DEFAULT NULL,
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `tipo_fornecedores_id_tipo_fornecedor` INT(255) NOT NULL,
  PRIMARY KEY (`id_fornecedores`),
  INDEX `fk_fornecedores_tipo_fornecedores1_idx` (`tipo_fornecedores_id_tipo_fornecedor` ASC),
  CONSTRAINT `fk_fornecedores_tipo_fornecedores1`
    FOREIGN KEY (`tipo_fornecedores_id_tipo_fornecedor`)
    REFERENCES `lanchonete_t92`.`tipo_fornecedores` (`id_tipo_fornecedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.login_social
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`login_social` (
  `id_login_social` INT(255) NOT NULL AUTO_INCREMENT,
  `host` VARCHAR(255) NOT NULL,
  `chave_oauth` BLOB NOT NULL,
  PRIMARY KEY (`id_login_social`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.produtos
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`produtos` (
  `id_produto` INT(255) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(255) NOT NULL,
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuarios_id_usuario` INT(255) NOT NULL,
  `prazo_validade` INT(255) NOT NULL,
  `fornecedores_id_fornecedores` INT(255) NOT NULL,
  PRIMARY KEY (`id_produto`),
  UNIQUE INDEX `descricao_UNIQUE` (`descricao` ASC),
  INDEX `fk_produtos_usuarios1_idx` (`usuarios_id_usuario` ASC),
  INDEX `fk_produtos_fornecedores1_idx` (`fornecedores_id_fornecedores` ASC),
  CONSTRAINT `fk_produtos_fornecedores1`
    FOREIGN KEY (`fornecedores_id_fornecedores`)
    REFERENCES `lanchonete_t92`.`fornecedores` (`id_fornecedores`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_produtos_usuarios1`
    FOREIGN KEY (`usuarios_id_usuario`)
    REFERENCES `lanchonete_t92`.`usuarios` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.saidas_estoque
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`saidas_estoque` (
  `id_saida_estoque` INT(255) NOT NULL AUTO_INCREMENT,
  `quantidade` INT(255) NOT NULL,
  `valor_unitario` DECIMAL(9,2) NOT NULL,
  `data_validade` DATE NOT NULL,
  `data_saida` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `produtos_id_produto` INT(255) NOT NULL,
  PRIMARY KEY (`id_saida_estoque`),
  INDEX `fk_saidas_estoque_produtos1_idx` (`produtos_id_produto` ASC),
  CONSTRAINT `fk_saidas_estoque_produtos1`
    FOREIGN KEY (`produtos_id_produto`)
    REFERENCES `lanchonete_t92`.`produtos` (`id_produto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.telefones
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`telefones` (
  `id_telefone` INT(255) NOT NULL AUTO_INCREMENT,
  `pais` INT(3) NOT NULL,
  `ddd` VARCHAR(255) NOT NULL DEFAULT '55',
  `telefone` VARCHAR(255) NOT NULL,
  `tipo` VARCHAR(255) NOT NULL,
  `preferencial` ENUM('0', '1') NOT NULL DEFAULT '0',
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuarios_id_usuario` INT(255) NOT NULL,
  PRIMARY KEY (`id_telefone`),
  INDEX `fk_telefones_usuarios1_idx` (`usuarios_id_usuario` ASC),
  CONSTRAINT `fk_telefones_usuarios1`
    FOREIGN KEY (`usuarios_id_usuario`)
    REFERENCES `lanchonete_t92`.`usuarios` (`id_usuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.telefones_fornecedores
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`telefones_fornecedores` (
  `id_telefone_fornecedor` INT(255) NOT NULL AUTO_INCREMENT,
  `pais` INT(3) NOT NULL,
  `ddd` VARCHAR(255) NOT NULL,
  `telefone` VARCHAR(255) NOT NULL DEFAULT '55',
  `preferencial` ENUM('0', '1') NOT NULL DEFAULT '0',
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `fornecedores_id_fornecedores` INT(255) NOT NULL,
  PRIMARY KEY (`id_telefone_fornecedor`),
  INDEX `fk_telefones_fornecedores_fornecedores1_idx` (`fornecedores_id_fornecedores` ASC),
  CONSTRAINT `fk_telefones_fornecedores_fornecedores1`
    FOREIGN KEY (`fornecedores_id_fornecedores`)
    REFERENCES `lanchonete_t92`.`fornecedores` (`id_fornecedores`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.tipo_enderecos
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`tipo_enderecos` (
  `id_tipo_endereco` INT(255) NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(255) NOT NULL,
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_tipo_endereco`),
  UNIQUE INDEX `tipo_UNIQUE` (`tipo` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.tipo_fornecedores
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`tipo_fornecedores` (
  `id_tipo_fornecedor` INT(255) NOT NULL AUTO_INCREMENT,
  `tipo` VARCHAR(255) NOT NULL,
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '1',
  `id_criador` INT(255) NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_tipo_fornecedor`),
  UNIQUE INDEX `tipo_UNIQUE` (`tipo` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Table lanchonete_t92.usuarios
-- ----------------------------------------------------------------------------
CREATE TABLE IF NOT EXISTS `lanchonete_t92`.`usuarios` (
  `id_usuario` INT(255) NOT NULL AUTO_INCREMENT,
  `login` VARCHAR(255) NOT NULL,
  `senha` VARCHAR(255) NOT NULL,
  `tipo_acesso` INT(2) NOT NULL DEFAULT '0',
  `id_criador` INT(255) NOT NULL DEFAULT '1',
  `ativo` ENUM('0', '1') NOT NULL DEFAULT '0',
  `data_alteracao` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id_usuario`),
  UNIQUE INDEX `login_UNIQUE` (`login` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = latin1;

-- ----------------------------------------------------------------------------
-- Trigger lanchonete_t92.TRG_ENTRADA_PRODUTO_AFIN
-- ----------------------------------------------------------------------------
DELIMITER $$
USE `lanchonete_t92`$$
CREATE DEFINER=`root`@`%` TRIGGER `TRG_ENTRADA_PRODUTO_AFIN` 
	AFTER INSERT ON lanchonete_t92.entradas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( new.produtos_id_produto );
END;

-- ----------------------------------------------------------------------------
-- Trigger lanchonete_t92.TRG_ENTRADA_PRODUTO_AFUP
-- ----------------------------------------------------------------------------
DELIMITER $$
USE `lanchonete_t92`$$
CREATE DEFINER=`root`@`%` TRIGGER `TRG_ENTRADA_PRODUTO_AFUP` 
	AFTER UPDATE ON lanchonete_t92.entradas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END;

-- ----------------------------------------------------------------------------
-- Trigger lanchonete_t92.TRG_ENTRADA_PRODUTO_AFDEL
-- ----------------------------------------------------------------------------
DELIMITER $$
USE `lanchonete_t92`$$
CREATE DEFINER=`root`@`%` TRIGGER `TRG_ENTRADA_PRODUTO_AFDEL` 
	AFTER DELETE ON lanchonete_t92.entradas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END;

-- ----------------------------------------------------------------------------
-- Trigger lanchonete_t92.TRG_SAIDA_PRODUTO_AFIN
-- ----------------------------------------------------------------------------
DELIMITER $$
USE `lanchonete_t92`$$
CREATE DEFINER=`root`@`%` TRIGGER `TRG_SAIDA_PRODUTO_AFIN` 
	AFTER INSERT ON lanchonete_t92.saidas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( new.produtos_id_produto );
END;

-- ----------------------------------------------------------------------------
-- Trigger lanchonete_t92.TRG_ENTRADA_SAIDA_AFUP
-- ----------------------------------------------------------------------------
DELIMITER $$
USE `lanchonete_t92`$$
CREATE DEFINER=`root`@`%` TRIGGER `TRG_ENTRADA_SAIDA_AFUP` 
	AFTER UPDATE ON lanchonete_t92.saidas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END;

-- ----------------------------------------------------------------------------
-- Trigger lanchonete_t92.TRG_SAIDA_PRODUTO_AFDEL
-- ----------------------------------------------------------------------------
DELIMITER $$
USE `lanchonete_t92`$$
CREATE DEFINER=`root`@`%` TRIGGER `TRG_SAIDA_PRODUTO_AFDEL` 
	AFTER DELETE ON lanchonete_t92.saidas_estoque
FOR EACH ROW 
BEGIN
	CALL atualiza_estoque( old.produtos_id_produto );
END;
SET FOREIGN_KEY_CHECKS = 1;
