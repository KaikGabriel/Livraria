create database LivrariaTI14T;
use LIvrariaTI14T;

create table Cliente(
codigoCliente int not null auto_increment primary key,
nome varchar(100) not null,
dataDeNascimento date not null,
telefone varchar(12) not null,
usuario varchar(45) not null,
senha varchar(15) not null,
endereco varchar (100) not null
)Engine = InnoDB;


create table Compra(
	codigoCompra int not null auto_increment primary key,
    quantidade int not null,
    valorTotal decimal(10,2) not null,
    tipoDePagamento varchar(45) not null,
    dataDaCompra date not null
)Engine = InnoDB;

create table Livro(
	codigoLivro int not null auto_increment primary key,
    titulo varchar(45) not null,
    anoDeLancamento year not null,
    editora varchar(45) not null,
    numeroDePaginas int not null,
    valor decimal(10,2) not null,
    disponiveis int not null,
    autor varchar(45) not null,
    categoria varchar(45) not null
)Engine = InnoDB;

create table Autor(
	codigoAutor int not null auto_increment primary key,
    nome varchar(100) not null
)Engine = InnoDB;


create table Categoria(
	codigoCategoria int not null auto_increment primary key,
    descricao varchar(45) not null
)Engine = InnoDB;

drop table livro;

select * from livro;

describe cliente;

drop table cliente;
