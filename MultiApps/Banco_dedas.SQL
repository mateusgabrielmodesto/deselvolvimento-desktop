CREATE DATABASE multiapps_dev;

CREATE TABLE IF NOT EXISTS categorias (
    id INT AUTO_INCREMENT PRIMARY KEY,                
    nome VARCHAR(255) NOT NULL UNIQUE,  
	data_criacao TIMESTAMP NOT NULL,
	data_alteracao TIMESTAMP DEFAULT  CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	status ENUM('ativo', 'inativo') DEFAULT 'ativo',  
       
       primary key (id)
       );
       CREATE TABLE IF NOT EXISTS produto(
		id INT AUTO_INCREMENT PRIMARY KEY,   
		categoria_id  INT NOT NULL,
		nome VARCHAR(255) NOT NULL UNIQUE,  
		preco DECIMAL NOT NULL,
		quantidade_estoque INT NOT NULL,
		data_criacao TIMESTAMP NOT NULL,
		data_alteracao TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
		status ENUM('ativo', 'inativo') DEFAULT 'ativo',  
        
       PRIMARY KEY (id),
       FOREIGN KEY (categoria_id) REFERENCES categoria (categotia_id)
   
);

