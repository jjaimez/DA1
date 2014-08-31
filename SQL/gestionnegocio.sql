drop database if exists gestionnegocio;
create database gestionnegocio;

use gestionnegocio;

CREATE  TABLE `gestionnegocio`.`articulos` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `codigo` VARCHAR(45) NOT NULL ,
  `descripcion` VARCHAR(500) NULL ,
  `marca` VARCHAR(100) NULL ,
  `stock` INT NULL DEFAULT 0 ,
  `stock_minimo` INT(11) NULL DEFAULT 0
  `precio_compra` FLOAT NULL DEFAULT 0 ,
  `precio_venta` FLOAT NULL DEFAULT 0 ,
  `proveedor_id` INT(9) NULL,
  PRIMARY KEY (`id`) );

CREATE  TABLE `gestionnegocio`.`clientes` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `nombre` VARCHAR(100) NOT NULL ,
  `telefono` VARCHAR(60) NULL ,
  `celular` VARCHAR(60) NULL ,
  `email` VARCHAR(60) NULL ,
  `documento` VARCHAR(45) NULL ,
  PRIMARY KEY (`id`) );

CREATE  TABLE `gestionnegocio`.`proveedors` (
  `id` INT NOT NULL AUTO_INCREMENT ,
  `nombre` VARCHAR(100) NOT NULL ,
  `cuit` VARCHAR(45) NULL ,
  `telefono` VARCHAR(45) NULL ,
  `celular` VARCHAR(45) NULL ,
  `email` VARCHAR(45) NULL ,
  PRIMARY KEY (`id`) );

create table gestionnegocio.ventas (
    id integer not null auto_increment,
    monto float,
    cliente_id integer,
    fecha date not null,
    pago int,
    PRIMARY KEY (`id`) );

create table gestionnegocio.compras (
    id integer not null auto_increment,
    monto float,
    proveedor_id integer,
    fecha date not null,
    pago int,
    PRIMARY KEY (`id`) );


create table clientes_articulos(
    id integer not null auto_increment,
    cliente_id integer,
    articulo_id integer,
    cantidad float not null,
  precio_final float,
  check (cantidad>0),
  check (precio_final>0),
    primary key(id) );


create table articulos_ventas (
    id integer not null auto_increment,
    venta_id integer,
    articulo_id integer,
    cantidad float not null,
  precio_final float,
  check (cantidad>0),
  check (precio_final>0),
    primary key(id) );


create table articulos_compras (
    id integer not null auto_increment,
    compra_id integer,
    articulo_id integer,
    cantidad float not null,
    precio_final float,
  check (cantidad>0),
  check (precio_final>0),
    primary key(id));

create table usuarios (
  id integer not null auto_increment,
  nombre varchar(50) default 'gestionnegocio',
  pass varchar(50) default 'gestionnegocio',
  primary key(id));