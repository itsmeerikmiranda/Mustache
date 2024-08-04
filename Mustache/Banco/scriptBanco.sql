-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema mustachedb01
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mustachedb01
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mustachedb01` DEFAULT CHARACTER SET utf8 ;
USE `mustachedb01` ;

-- -----------------------------------------------------
-- Table `mustachedb01`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`clientes` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `cpf` VARCHAR(11) NOT NULL,
  `data_nasc` DATE NOT NULL,
  `ativo` BIT(1) NOT NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  `telefone` CHAR(14) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) VISIBLE,
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`niveis`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`niveis` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `sigla` CHAR(3) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`profissionais`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`profissionais` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nivel_id` INT(4) NOT NULL,
  `nome` VARCHAR(100) NOT NULL,
  `disponibilidade` CHAR(1) NOT NULL,
  `ativo` BIT(1) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Profissional_Niveis1_idx` (`nivel_id` ASC) VISIBLE,
  CONSTRAINT `fk_Profissional_Niveis1`
    FOREIGN KEY (`nivel_id`)
    REFERENCES `mustachedb01`.`niveis` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`categorias` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NOT NULL,
  `sigla` CHAR(3) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`servicos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`servicos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `categoria_id` INT(4) NOT NULL,
  `nome` VARCHAR(60) NOT NULL,
  `valor_unit` DOUBLE NOT NULL,
  `duracao_estimada` TIME NOT NULL,
  `desconto` DOUBLE NOT NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  PRIMARY KEY (`id`),
  INDEX `fk_Serviços_Categoria1_idx` (`categoria_id` ASC) VISIBLE,
  CONSTRAINT `fk_Serviços_Categoria1`
    FOREIGN KEY (`categoria_id`)
    REFERENCES `mustachedb01`.`categorias` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`usuarios` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `nivel_id` INT(4) NOT NULL,
  `nome` VARCHAR(60) NOT NULL,
  `email` VARCHAR(60) NOT NULL,
  `data_cad` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  `ativo` BIT(1) NOT NULL,
  `senha` VARCHAR(45) NOT NULL,
  `cpf` VARCHAR(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC) VISIBLE,
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) VISIBLE,
  INDEX `fk_Usuarios_Niveis1_idx` (`nivel_id` ASC) VISIBLE,
  CONSTRAINT `fk_Usuarios_Niveis1`
    FOREIGN KEY (`nivel_id`)
    REFERENCES `mustachedb01`.`niveis` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 7
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`agendamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`agendamentos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `cliente_id` INT(4) NOT NULL,
  `usuario_id` INT(4) NOT NULL,
  `profissional_id` INT(4) NOT NULL,
  `servico_id` INT(4) NOT NULL,
  `status` CHAR(3) NOT NULL,
  `data` DATE NOT NULL,
  `hora_inicio` TIME NOT NULL,
  `hora_termino` TIME NOT NULL,
  `data_criacao` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  PRIMARY KEY (`id`),
  INDEX `fk_Agendamento_Clientes1_idx` (`cliente_id` ASC) VISIBLE,
  INDEX `fk_Agendamento_Profissional1_idx` (`profissional_id` ASC) VISIBLE,
  INDEX `fk_Agendamento_Usuarios1_idx` (`usuario_id` ASC) VISIBLE,
  INDEX `fk_Agendamento_Serviços1_idx` (`servico_id` ASC) VISIBLE,
  CONSTRAINT `fk_Agendamento_Clientes1`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `mustachedb01`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Agendamento_Profissional1`
    FOREIGN KEY (`profissional_id`)
    REFERENCES `mustachedb01`.`profissionais` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Agendamento_Serviços1`
    FOREIGN KEY (`servico_id`)
    REFERENCES `mustachedb01`.`servicos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Agendamento_Usuarios1`
    FOREIGN KEY (`usuario_id`)
    REFERENCES `mustachedb01`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`atendimentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`atendimentos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `agendamento_id` INT(4) NOT NULL,
  `profissional_id` INT(4) NOT NULL,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  `descricao` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Atendimentos_Agendamento1_idx` (`agendamento_id` ASC) VISIBLE,
  INDEX `fk_Atendimentos_Profissional1_idx` (`profissional_id` ASC) VISIBLE,
  CONSTRAINT `fk_Atendimentos_Agendamento1`
    FOREIGN KEY (`agendamento_id`)
    REFERENCES `mustachedb01`.`agendamentos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Atendimentos_Profissional1`
    FOREIGN KEY (`profissional_id`)
    REFERENCES `mustachedb01`.`profissionais` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`comandas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`comandas` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `atendimento_id` INT(4) NOT NULL,
  `cliente_id` INT(4) NOT NULL,
  `status` CHAR(1) NOT NULL,
  `desconto` DOUBLE NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Comandas_Atendimentos1_idx` (`atendimento_id` ASC) VISIBLE,
  INDEX `fk_Comandas_Clientes1_idx` (`cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_Comandas_Atendimentos1`
    FOREIGN KEY (`atendimento_id`)
    REFERENCES `mustachedb01`.`atendimentos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Comandas_Clientes1`
    FOREIGN KEY (`cliente_id`)
    REFERENCES `mustachedb01`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`comandaservico`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`comandaservico` (
  `Id` INT(4) NOT NULL AUTO_INCREMENT,
  `servico_id` INT(4) NOT NULL,
  `comanda_id` INT(4) NOT NULL,
  `preco` DOUBLE NOT NULL,
  `desconto` DOUBLE NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Agendaservico_Serviços1_idx` (`servico_id` ASC) VISIBLE,
  INDEX `fk_Comandaservico_Comanda1_idx` (`comanda_id` ASC) VISIBLE,
  CONSTRAINT `fk_Agendaservico_Serviços1`
    FOREIGN KEY (`servico_id`)
    REFERENCES `mustachedb01`.`servicos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Comandaservico_Comanda1`
    FOREIGN KEY (`comanda_id`)
    REFERENCES `mustachedb01`.`comandas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`enderecos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`enderecos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `clientes_id` INT(4) NOT NULL,
  `cep` CHAR(8) NOT NULL,
  `logradouro` VARCHAR(100) NOT NULL,
  `numero` VARCHAR(40) NOT NULL,
  `complemento` VARCHAR(45) NULL DEFAULT NULL,
  `bairro` VARCHAR(60) NOT NULL,
  `cidade` VARCHAR(60) NOT NULL,
  `uf` CHAR(2) NOT NULL,
  `tipo` CHAR(3) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Enderecos_Clientes1_idx` (`clientes_id` ASC) VISIBLE,
  CONSTRAINT `fk_Enderecos_Clientes1`
    FOREIGN KEY (`clientes_id`)
    REFERENCES `mustachedb01`.`clientes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`pagamentos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`pagamentos` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `comanda_id` INT(4) NOT NULL,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  `valor` DOUBLE NOT NULL,
  `taxa` DOUBLE NOT NULL,
  `forma_pag` VARCHAR(12) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Pagamentos_Comanda1_idx` (`comanda_id` ASC) VISIBLE,
  CONSTRAINT `fk_Pagamentos_Comanda1`
    FOREIGN KEY (`comanda_id`)
    REFERENCES `mustachedb01`.`comandas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`profissionalservico`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`profissionalservico` (
  `profissional_id` INT(4) NOT NULL,
  `servico_id` INT(4) NOT NULL,
  PRIMARY KEY (`profissional_id`, `servico_id`),
  INDEX `fk_Profissionalserviço_Serviços1_idx` (`servico_id` ASC) VISIBLE,
  CONSTRAINT `fk_Profissionalserviço_Profissional1`
    FOREIGN KEY (`profissional_id`)
    REFERENCES `mustachedb01`.`profissionais` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Profissionalserviço_Serviços1`
    FOREIGN KEY (`servico_id`)
    REFERENCES `mustachedb01`.`servicos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mustachedb01`.`recibo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mustachedb01`.`recibo` (
  `id` INT(4) NOT NULL AUTO_INCREMENT,
  `pagamento_id` INT(4) NOT NULL,
  `data` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP() ON UPDATE CURRENT_TIMESTAMP(),
  `valor` DOUBLE NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Nivel_Pagamentos1_idx` (`pagamento_id` ASC) VISIBLE,
  CONSTRAINT `fk_Nivel_Pagamentos1`
    FOREIGN KEY (`pagamento_id`)
    REFERENCES `mustachedb01`.`pagamentos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

USE `mustachedb01` ;

-- --------------------------------------------
-- PROCEDURES PROJETO  INTEGRADOR - MUSTACHEDB
-- --------------------------------------------

use mustachedb01;

 
-- --------------------------------------------- 
-- -----------PROCEDURES CLIENTE ----------------
-- ---------------------------------------------	
    -- 	INSERT (sp_cliente_insert)
    
    delimiter $$
		create procedure sp_cliente_insert (
			sp_nome varchar(100),
            sp_email varchar(45),
            sp_cpf varchar(11),
            sp_data_nasc date, -- !!!!!!!!alterar para tinyint(1) ou bit(1) na estrutura do banco e na procedure!!!!!!!!!!
            sp_telefone char(14)
        )
		begin
			insert into clientes values(0, sp_nome, sp_email, sp_cpf, sp_data_nasc, 1, default, sp_telefone);
            select last_insert_id();
		end
    $$
    
    drop procedure sp_cliente_insert;
    
    call sp_cliente_insert("Matheus Lima", "ma@gmail.com", "12345678911", '2006-05-20', 11959792484);
    
    
    -- UPDATE (sp_cliente_update) -- CORRIGIR
        delimiter $$
		create procedure sp_cliente_update(
			sp_id int,
            sp_nome varchar(100),
            sp_email varchar(45),
            sp_cpf varchar(11),
            sp_data_nasc date,
            sp_ativo bit(1),
            sp_telefone char(14)
        )
		begin
			update clientes set 
            nome = sp_nome,
            email = sp_email,
            cpf = sp_cpf,
            data_nasc = sp_data_nasc,
			ativo = sp_ativo,
            telefone = sp_telefone
            where id = sp_id;
        end
    $$
    call sp_cliente_update(1, "Matchow das Couves", "mat@gmail.com", "12345678911",'2006-05-20', 1, 11959798424);
    
    -- DESABLE (sp_cliente_desable)
    delimiter $$
		create procedure sp_cliente_desable(
			sp_id int,
            sp_ativo bit(1)
        )
        begin
			update clientes set 
            ativo = sp_ativo
            where id = sp_id;
        end
    $$
    
    call sp_cliente_desable(1,0);
    
-- --------------------------------------------- 
-- ---------- PROCEDURES ENDEREÇOS --------------
-- ---------------------------------------------

-- INSERT (sp_endereco_insert)
 delimiter $$
	create procedure sp_endereco_insert (
		sp_cliente_id int(4),
		sp_cep char(8),
		sp_logradouro varchar(100),
		sp_numero varchar(40),
		sp_complemento varchar(45),
		sp_bairro varchar(60),
		sp_cidade varchar(60),
		sp_uf char(2),
		sp_tipo char(3)
	)
	begin
		insert into enderecos values(0, sp_cliente_id, sp_cep, sp_logradouro, sp_numero, sp_complemento, sp_bairro, sp_cidade, sp_uf, sp_tipo);
		select * from enderecos where id = last_insert_id();
    end
 $$
 
 call sp_endereco_insert(1, 12345678, "Rua Augusta de Jesus ", 8, "A", "Jardim Das Rosas", "São Paulo", "SP", "RES")
 
 
 -- UPDATE (sp_endereco_update)
 delimiter $$
	create procedure sp_endereco_update(
		sp_id int,
        sp_cep char(8),
        sp_logradouro varchar(100),
        sp_numero varchar(100), 
        sp_complemento varchar(45),
        sp_bairro varchar(60),
        sp_cidade varchar(60),
        sp_uf char(2),
		sp_tipo char(3)
    )
	begin
		update enderecos set
        cep = sp_cep,
        logradouro = sp_logradouro,
        numero = sp_numero,
        complemento = sp_complemento,
        bairro = sp_bairro,
        cidade =  sp_cidade,
        uf = sp_uf,
        tipo = sp_tipo
        where id = sp_id;
    end
 $$
 
 call sp_endereco_update(1, "87654321", "Rua Aldeia da Formiga", 8, "C", "Jardim Nossas Senhora", "Belo Horizonte", "BH", "RES");
 
 -- DELECT (sp_endereco_delete)
 delimiter $$
	create procedure sp_endereco_delete(
		sp_id int
    )
    begin
		delete from enderecos where id = sp_id;
    end
  $$
  
  call sp_endereco_delete(2);
  
  -- --------------------------------------------- 
-- ----------    PROCEDURES NIVEIS --------------
-- ---------------------------------------------

-- INSERT (sp_nivel_insert) 
use mustachedb01;

delimiter $$
 
create procedure sp_nivel_insert (
sp_nome varchar(45),
sp_sigla char(3)
)
 
begin
insert into niveis values (0,sp_nome, sp_sigla);
select * from niveis where id = last_insert_id();
end $$
 
call  sp_nivel_insert ('Atendente','ATD');

-- UPDATE (sp_nivel_update)
delimiter $$
	create procedure sp_nivel_update
(
sp_id int(4),
sp_nome varchar(45),
sp_sigla char(3)
)

begin
    update niveis set
	nome = sp_nome,
	sigla = sp_sigla
	where id = sp_id;
end
$$

call sp_nivel_update(1, 'BARBEIRO', 'BRB');

-- --------------------------------------------- 
-- ----------  PROCEDURES USUARIOS  ------------
-- ---------------------------------------------
drop procedure sp_usuario_insert;
 -- INSERT (sp_usuario_insert)
delimiter $$
	create procedure sp_usuario_insert(
		sp_nivel_id int(4),
		sp_nome varchar(60),
		sp_email varchar(60),
		sp_senha varchar (45),
        sp_cpf varchar(11)
		)
	begin insert into usuarios values (0,sp_nivel_id, sp_nome, sp_email, default, 1 ,md5(sp_senha), sp_cpf);
		select last_insert_id();
	end 
$$

-- call sp_usuario_insert (2,'Erik','ErikS@gmail.com',1,1234);


-- UPDATE (sp_usuario_update)
delimiter $$
	create procedure sp_usuario_update(
		sp_id int(4),
		sp_nivel_id int(4),
		sp_nome varchar(60),
		sp_email varchar(60),
		sp_ativo bit (1),
		sp_senha varchar(45)
		)
	begin
		update usuarios set
		nivel_id = sp_nivel_id,
		nome = sp_nome,
		email = sp_email,
		ativo = sp_ativo,
		senha = md5(sp_senha)
		where id = sp_id;
	end 
$$

drop procedure sp_usuario_update;

call sp_usuario_update (1,1,'ERI','eri@yahoo.com',1,123);


-- DESABLE (sp_usuario_desable)
delimiter $$
create procedure sp_usuario_desable(
sp_id int(4),
sp_ativo bit (1)
)
begin
update usuarios set
ativo = sp_ativo
where id = sp_id;
end $$

call sp_usuario_desable(1,0);   

  
  
  
-- ----------------------------------------------- 
-- ---------- PROCEDURES PROFISSIONAL-------------
-- -----------------------------------------------

-- INSERT (sp_profissional_insert)
  delimiter $$
	create procedure sp_profissional_insert(
        sp_niveis_id int,
		sp_nome varchar(100),
        sp_disponibilidade char(1)
    )
    begin
		insert into profissionais values(0, sp_niveis_id, sp_nome, sp_disponibilidade, 1);
        select * from profissionais where id = last_insert_id();    
    end 
  $$
  drop procedure sp_profissional_insert;
  call sp_profissional_insert(2, "Matheus", "L");
  
  
  -- UPDATE (sp_profissional_update)
delimiter $$
	create procedure sp_profissional_update(
		sp_id int,
        sp_nivel_id int,
        sp_nome varchar(100),
        sp_disponibilidade char(1)
    )
	begin
		update profissionais set 
        nivel_id = sp_nivel_id,
        nome = sp_nome,
        disponibilidade = sp_disponibilidade
        where id = sp_id;
    end
$$

drop procedure sp_profissional_update;

call sp_profissional_update(1,1, "Erik Carlos", "D");

-- DESABLE (sp_profissional_desable)
delimiter $$
	create procedure sp_profissional_desable(
		sp_id int,
        sp_ativo bit(1)
    )
	begin
		update profissionais set
		ativo = sp_ativo
		where id = sp_id;
	end
$$

  call sp_profissional_desable(2, 0);       
  
  
-- ------------------------------------------------ 
-- ----------  PROCEDURES CATEGORIAS  -------------
-- ------------------------------------------------

-- INSERT (sp_categoria_insert) 

use mustachedb01;

delimiter $$ 
	create procedure sp_categoria_insert( 
		sp_descricao varchar(45), 
		sp_sigla char(3) 
	) 

	begin 
		insert into categorias values (0,sp_descricao,sp_sigla); 
		select last_insert_id(); 
	end
$$ 
call sp_categoria_insert ('Careca','CRC'); 


-- UPDATE (sp_categoria_update)
delimiter $$
	create procedure sp_categoria_update (
		sp_id int(4),
		sp_descricao varchar(45),
		sp_sigla char(3)
	)
	begin
		update categorias set
		descricao = sp_descricao,
		sigla = sp_sigla
		where id = sp_id;
	end 
$$

call sp_categoria_update (1,'Corte','CRT');


-- DELETE (sp_categoria_delete)
delimiter $$
	create procedure sp_categoria_delete (
	sp_id int
	)
	begin
		delete from categorias where id= sp_id;
	end 
$$

-- ------------------------------------------------ 
-- ----------    PROCEDURES SERVICOS --------------
-- ------------------------------------------------
  
-- INSERT (sp_servico_insert)
 
delimiter $$
	create procedure sp_servico_insert (
		sp_nome varchar(60),
		sp_categoria_id int,
		sp_valor_unit double,
		sp_duracao_estimada time,
		sp_desconto double
	)
	begin
		insert into servicos
		values(0, sp_categoria_id, sp_nome, sp_valor_unit, sp_duracao_estimada, sp_desconto, default);
		select last_insert_id() as id;
	end 
$$
 
call sp_servico_insert ("Classico", 1, 40, '0:40.00', 0);


-- UPDATE (sp_servico_update) 
delimiter $$
	create procedure sp_servico_update (
		sp_id int,
		sp_categoria_id int,
		sp_nome varchar(60),
		sp_valor_unit double,
		sp_duracao_estimada time,
		sp_desconto double
	)	
	begin
		update servicos set
		nome = sp_nome,
		valor_unit = sp_valor_unit,
		duracao_estimada = sp_duracao_estimada,
		desconto = sp_desconto
		where id = sp_id;
	end
$$
 
call sp_servico_update (2, 1, "Classico", 65, '00:20:00', 0);


-- --------------------------------------------- 
-- ------ PROCEDURES PROFISSIONALSERVICO -------
-- ---------------------------------------------
-- INSERT (sp_profissionalservico_insert)

delimiter $$
	create procedure sp_profissionalservico_insert(
		sp_profissional_id int(4),
        sp_servico_id int(4)
    )

	begin
		insert into profissionalservico values(sp_profissional_id, sp_servico_id);
    end
$$

call sp_profissionalservico_insert(2,2);

-- UPDATE (sp_profissionalservico_update)
delimiter $$
	create procedure sp_profissionalservico_update(
		sp_profissional_id int,
        sp_servico_id int
    )

	begin
		update profissionalservico set
        servico_id = sp_servico_id
        where profissional_id = sp_profissional_id;
    end
$$

call sp_profissionalservico_update(2, 1);


-- DELETE (sp_profissionalservico_delete)
delimiter $$	
    create procedure sp_profissionalservico_delete(
		sp_profissional_id int,
        sp_servico_id int
    )
	begin
		delete from profissionalservico where profissional_id = sp_profissional_id and servico_id = sp_servico_id;
    end
$$

drop procedure sp_procedureservico_delete;

call sp_profissionalservico_delete(2, 1);


-- --------------------------------------------- 
-- ----------- PROCEDURES COMANDAS -------------
-- ---------------------------------------------
-- INSERT (sp_comanda_insert)
 
delimiter $$
	create procedure sp_comanda_insert ( 
		sp_atendimento_id int(4),
        sp_cliente_id int(4),
		sp_status char(1),
		sp_desconto double
	)
	begin
		insert into comandas values(0, sp_atendimento_id, sp_cliente_id, sp_status, sp_desconto);
		select last_insert_id() as id;
	end
$$

-- drop procedure sp_comanda_insert;
 
call sp_comanda_insert (1, 1,'A', 0);
 

-- UPDATE (sp_comanda_update)
 
delimiter $$
	create procedure sp_comanda_update (
		sp_id int,
        sp_atendimento_id int,
        sp_cliente_id int,
		sp_status char(1),
		sp_desconto double
	)
	begin
		update comandas set
        atendimento_id = sp_atendimento_id,
        cliente_id = sp_cliente_id,
		status = sp_status,
		desconto = sp_desconto
		where id = sp_id;
	end 
$$
 
call sp_comanda_update (1, 1, 'F', 0);
 
select * from comandas;


 -- --------------------------------------------- 
-- -------- PROCEDURES COMANDASERVICO -----------
-- ----------------------------------------------

-- INSERT (sp_comandaservico_insert)
delimiter $$ 
	create procedure sp_comandaservico_insert(
        sp_servico_id int(4),
        sp_comanda_id int(4),
        sp_desconto double
    )
    begin
		insert into comandaservico values(0, sp_servico_id, sp_comanda_id, (select valor_unit from servicos where id = sp_servico_id), sp_desconto);
    end
$$

call sp_comandaservico_insert(1,1,0);

-- UPDATE (sp_comaandaservico_update)
delimiter $$
	create procedure sp_comandaservico_update(
		sp_id int,
        sp_servico_id int,
        sp_comanda_id int,
        sp_desconto double
    )
    begin 
		update comandaservico set 
        servico_id = sp_servico_id,
        comanda_id = sp_comanda_id,
        preco = (select valor_unit from servicos where id = sp_servico_id),
        desconto = sp_desconto
        where id = sp_id;
    end
$$


call sp_comandaservico_update(1, 2, 1, 0);

-- DELETE (sp_comandaservico_delete)
delimiter $$
	create procedure sp_comandaservico_delete(
		sp_id int
    )
	begin
		delete from comandaservico where id = sp_id;
    end
$$

call sp_comandaservico_delete(1);

-- --------------------------------------------- 
-- -------- PROCEDURES AGENDAMENTO    -----------
-- ----------------------------------------------
-- INSERT (sp_agendamento_insert)

delimiter $$ 
	create procedure sp_agendamento_insert(
		sp_cliente_id int(4),
        sp_usuario_id int(4),
        sp_profissional_id int(4),
        sp_servico_id int(4),
        sp_status char(3),
        sp_data date,
		sp_hora_inicio time,
		sp_hora_termino time
    )
	begin
		insert into agendamentos values(0, sp_cliente_id, sp_usuario_id, sp_profissional_id,
        sp_servico_id, sp_status, sp_data, sp_hora_inicio, sp_hora_termino, default);
    end
$$

call sp_agendamento_insert(1, 1, 1, 1, "ABR", '2024-07-05', '11:00:00', '12:00:00');

-- UPDATE (sp_agendamento_update)
delimiter $$
	create procedure sp_agendamento_update(
		sp_id int,
        sp_cliente_id int,
        sp_usuario_id int,
        sp_profissional_id int,
        sp_servico_id int,
        sp_status char(3),
        sp_data date,
        sp_hora_inicio time,
        sp_hora_termino time
    )
	begin
		update agendamentos set
        cliente_id = sp_cliente_id,
        usuario_id = sp_usuario_id,
        profissional_id = sp_profissional_id,
        servico_id = sp_servico_id,
        status = sp_status,
        data = sp_data,
        hora_termino = sp_hora_termino,
        hora_inicio = sp_hora_inicio,
        data_criacao = default
        where id = sp_id;
    end
$$

drop procedure sp_agendamento_update;

call sp_agendamento_update(1, 1, 1, 2, 2,"abr",'2024-07-05','10:00:00','11:00:00');

-- DELETE (sp_agendamento_delete)
-- delimiter $$
-- 	create procedure sp_agendamento_delete(
-- 		sp_id int
--     )
--     begin
-- 		delete from agendamentos where id = sp_id;
--     end
-- $$

-- --------------------------------------------- 
-- -------- PROCEDURES ATENDIMENTO    -----------
-- ----------------------------------------------
-- INSERT (sp_atendimento_insert)
 
delimiter $$
	create procedure sp_atendimento_insert(
		sp_agendamento_id int(4),
		sp_profissional_id int(4),
		sp_descricao varchar(45)
	)
	begin 
		insert into atendimentos values (0, sp_agendamento_id, sp_profissional_id, default, sp_descricao);
		select * from atendimentos where id = last_insert_id();
	end 
$$

call sp_atendimento_insert(1, 1, "Corte moderno");

 
-- PROCEDURE UPDATE ATENDIMENTO
delimiter $$
create procedure sp_atendimento_update (
sp_id int(4),
sp_agendamento_id int (4),
sp_profissional_id int (4),
sp_descricao varchar (45)
)
begin
 
update atendimentos set
agendamento_id = sp_agendamento_id,
profissional_id = sp_profissional_id,
descricao = sp_descricao
where id = sp_id;
end $$

drop procedure sp_atendimento_update;

call sp_atendimento_update(1, 1, 2, "Corte moderno e barba");


-- --------------------------------------------- 
-- -------- PROCEDURES PAGAMENTO      ----------
-- ---------------------------------------------

    

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
