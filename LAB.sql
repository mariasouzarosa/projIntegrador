CREATE DATABASE imobiliaria;

USE imobiliaria;

CREATE TABLE MUNICIPIO
(
 codMuni INT NOT NULL,
 nome VARCHAR(30),
 populacao VARCHAR(10),
 estado VARCHAR(2),
 PRIMARY KEY (codMuni)
);

CREATE TABLE PROPRIETARIO
(
 cpfProp VARCHAR(11) NOT NULL,
 nome VARCHAR(30),
 estadoCivil VARCHAR(15),
 profissao TEXT,
 telefone VARCHAR(10),
 PRIMARY KEY (cpfProp)
 );

INSERT INTO MUNICIPIO (codMuni, nome, populacao, estado) VALUES
    (1, "Belo Horizonte", "2.722.000", "MG"),
    (2, "Gramado", "36.255", "RS"),
    (3, "Palmas", "306.296", "TO"),
    (4, "Formosa", "123.684", "GO"),
    (5, "Ilhéus", "159.923", "BA");
    
INSERT INTO PROPRIETARIO (cpfProp, nome, estadoCivil, profissao, telefone) VALUES
    (47334143825, "Adriano", "Casado", "Gerente", "752059114"),
    (77338374996, "Bianca", "Solteira", "Enfermeira", "487180231"),
    (46307088630, "Isabela", "Divorciada", "Mecânica", "846522456"),
    (28421002201, "João", "Casado", "Engenheiro", "252005693"),
    (12853332764, "Matheus", "Solteiro", "Professor", "519224301");


