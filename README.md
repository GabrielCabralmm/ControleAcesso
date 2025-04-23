create database controleacesso;

use controleacesso;

create table usuarios (
id int not null auto_increment,
nome varchar(60) not null,
cpf varchar(11) not null unique,
tipo int not null,
senha varchar(32) not null,
primary key (id)
);
select * from usuarios;

create table registro_acessos (
id int not null auto_increment,
id_usuario int not null,
data_hora datetime default current_timestamp,
tipo_operacao varchar(30) not null,
primary key (id),
foreign key (id_usuario) references usuarios (id)
);
select * from registro_acessos;
