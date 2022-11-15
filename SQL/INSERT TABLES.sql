USE dboPadaria;

INSERT INTO tblUsers VALUES(
	'root',
	'0990',
	'adm_root@root.com',
	'0000',
	'2022-10-10');

INSERT INTO tblProduct(descricao, tipo, unidade,data_criacao) VALUES
('Pão Francês','Pão Branco','unidade','2022-10-21'),
('Bolo de Fubá','Bolo','unidade','2022-10-21');

INSERT INTO tblRawMaterial(descricao,tipo,unidade,data_criacao) VALUES
('Farinha de Trigo','Farináceos','gramas','2022-10-21'),
('Ovo Grande','Ovos','unidade','2022-10-21'),
('Gordura','Óleos Comestíveis','gramas','2022-10-21'),
('Leite Integral','Laticínios','mililitros','2022-10-21'),
('Polvilho Doce','Farináceos','gramas','2022-10-21'),
('Água','Ingrediente Líquido','mililitros','2022-10-21'),
('Sal','Ingrediente Sólido','gramas','2022-10-21'),
('Açucar','Ingrediente Sólido','gramas','2022-10-21'),
('Fermento Biológico Seco','Fermento','gramas','2022-10-21'),
('Fubá','Farináceos','gramas','2022-10-21'),
('Polvilho Azedo','Farináceos','gramas','2022-10-21');

INSERT INTO tblRecipe VALUES
(1,'Receita de Pão Frances',50,'2022-10-21'),
(2,'Receita de Bolo de Fubá',4,'2022-10-21');

INSERT INTO tblRaw_Recipe VALUES
(1,1,2750),
(1,6,1667),
(1,9,100),
(1,7,67),
(1,8,34),
(1,3,117);

INSERT INTO tblPurchase VALUES
('Compra geral','2022-10-21');

INSERT INTO tblPurchase_RawMaterials VALUES
(1,1,50000,1),
(1,2,200,1),
(1,3,10000,1),
(1,4,10000,3),
(1,5,50000,2),
(1,6,20000,1),
(1,7,10000,1),
(1,8,50000,2),
(1,9,5000,6),
(1,10,50000,3),
(1,11,50000,2);