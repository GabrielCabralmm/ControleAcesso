<p>create database controleacesso;

<p>use controleacesso;

<p>create table usuarios (
<p>id int not null auto_increment,
<p>nome varchar(60) not null,
<p>cpf varchar(11) not null unique,
<p>tipo int not null,
<p>senha varchar(32) not null,
<p>primary key (id)
<p>);
<p>select * from usuarios;

<p>create table registro_acessos (
<p>id int not null auto_increment,
<p>id_usuario int not null,
<p>data_hora datetime default current_timestamp,
<p>tipo_operacao varchar(30) not null,
<p>primary key (id),
<p>foreign key (id_usuario) references usuarios (id)
<p>);
<p>select * from registro_acessos;
