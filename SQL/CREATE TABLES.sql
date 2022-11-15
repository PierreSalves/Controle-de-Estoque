CREATE DATABASE dboPadaria;

USE	dboPadaria;

CREATE TABLE tblUsers(
	id INT PRIMARY KEY identity(1,1) not null,
	nome VARCHAR(255) not null,
	email VARCHAR(100) not null,
	senha VARCHAR(50)not null,
	permit CHAR(4) not null,
	data_criacao DATE not null
);

CREATE TABLE tblProduct(
	id INT PRIMARY KEY identity(1,1) not null,
	descricao VARCHAR(255) not null,
	tipo VARCHAR(255) not null,
	unidade VARCHAR(255) not null,
	qt_estoque INT,
	data_criacao DATE
);

CREATE TABLE tblRawMaterial(
	id INT PRIMARY KEY identity(1,1) not null,
	descricao VARCHAR(255) not null,
	tipo VARCHAR(255) not null,
	unidade VARCHAR(255) not null,
	qt_estoque REAL,
	data_criacao DATE
);

CREATE TABLE tblPurchase(
	id INT PRIMARY KEY identity(1,1) not null,
	descricao VARCHAR(255) not null,
	buyDate DATE
);

CREATE TABLE tblSales(
	id INT PRIMARY KEY identity(1,1) not null,
	descricao VARCHAR(255),
	sellDate DATE
);

CREATE TABLE tblRecipe(
	id INT PRIMARY KEY identity(1,1) not null,
	id_product_fk INT FOREIGN KEY (id_product_fk) REFERENCES tblProduct(id),
	descricao VARCHAR(255) not null,
	qt_produce REAL not null,
	data_criacao DATE
);

CREATE TABLE tblRaw_Recipe(
	id INT PRIMARY KEY identity(1,1) not null,
	id_recipe_fk INT FOREIGN KEY (id_recipe_fk) REFERENCES tblRecipe(id),
	id_rawmaterial_fk INT FOREIGN KEY (id_rawmaterial_fk) REFERENCES tblRawMaterial(id),
	qt_Item REAL CHECK (qt_Item >= 1)
);

CREATE TABLE tblPurchase_RawMaterials(
	id INT PRIMARY KEY identity(1,1) not null,
	id_purchase_fk INT FOREIGN KEY (id_purchase_fk) REFERENCES tblPurchase(id),
	id_rawmaterial_fk INT FOREIGN KEY (id_rawmaterial_fk) REFERENCES tblRawMaterial(id),
	qt_Item INT CHECK (qt_Item >= 1),
	preco_ITEM REAL not null
);

CREATE TABLE tblProd_Produced(
	id INT PRIMARY KEY identity(1,1) not null,
	id_recipe_fk INT FOREIGN KEY (id_recipe_fk) REFERENCES tblRecipe(id),
	produceDay DATE,
	situacao CHAR
);

CREATE TABLE tblSales_Product(
	id INT PRIMARY KEY identity(1,1) not null,
	id_sale_fk INT FOREIGN KEY (id_sale_fk) REFERENCES tblSales(id),
	id_product_fk INT FOREIGN KEY (id_product_fk) REFERENCES tblProduct(id),
	qt_Item INT CHECK (qt_Item > 0),
	preco_ITEM REAL
);