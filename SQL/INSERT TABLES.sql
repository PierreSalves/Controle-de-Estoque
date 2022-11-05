USE dboPadaria;

INSERT INTO tblProduct(descricao, tipo, unidade,data_criacao) VALUES
('P�o Franc�s','P�o Branco','unidade','2022-10-21'),
('Bolo de Fub�','Bolo','unidade','2022-10-21');

INSERT INTO tblRawMaterial(descricao,tipo,unidade,data_criacao) VALUES
('Farinha de Trigo','Farinhas','gramas','2022-10-21'),
('Ovo Grande','Ovos','unidade','2022-10-21'),
('Gordura','�leos Comest�veis','gramas','2022-10-21'),
('Leite Integral','Latic�nios','mililitros','2022-10-21'),
('Polvilho Doce','Farin�ceios','gramas','2022-10-21'),
('�gua','Ingrediente L�quido','mililitros','2022-10-21'),
('Sal','Ingrediente S�lido','gramas','2022-10-21'),
('A�ucar','Ingrediente S�lido','gramas','2022-10-21'),
('Fermento Biol�gico Seco','Fermento','gramas','2022-10-21');

INSERT INTO tblRecipe VALUES
(1,'Receita de P�o Frances',50,'2022-10-21'),
(2,'Receita de Bolo de Fub�',4,'2022-10-21');

INSERT INTO tblRaw_Recipe VALUES
(1,1,2750),
(1,6,1667),
(1,13,100),
(1,8,67),
(1,12,34),
(1,3,117);