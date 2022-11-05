USE dboPadaria;

INSERT INTO tblProduct(descricao, tipo, unidade,data_criacao) VALUES
('Pão Francês','Pão Branco','unidade','2022-10-21'),
('Bolo de Fubá','Bolo','unidade','2022-10-21');

INSERT INTO tblRawMaterial(descricao,tipo,unidade,data_criacao) VALUES
('Farinha de Trigo','Farinhas','gramas','2022-10-21'),
('Ovo Grande','Ovos','unidade','2022-10-21'),
('Gordura','Óleos Comestíveis','gramas','2022-10-21'),
('Leite Integral','Laticínios','mililitros','2022-10-21'),
('Polvilho Doce','Farináceios','gramas','2022-10-21'),
('Água','Ingrediente Líquido','mililitros','2022-10-21'),
('Sal','Ingrediente Sólido','gramas','2022-10-21'),
('Açucar','Ingrediente Sólido','gramas','2022-10-21'),
('Fermento Biológico Seco','Fermento','gramas','2022-10-21');

INSERT INTO tblRecipe VALUES
(1,'Receita de Pão Frances',50,'2022-10-21'),
(2,'Receita de Bolo de Fubá',4,'2022-10-21');

INSERT INTO tblRaw_Recipe VALUES
(1,1,2750),
(1,6,1667),
(1,13,100),
(1,8,67),
(1,12,34),
(1,3,117);