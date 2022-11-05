CREATE VIEW [consulta_estoque_product] AS
	SELECT Product.descricao, Produce.produceDay, Product.qt_estoque
	FROM tblProduct AS Product
	LEFT JOIN tblRecipe AS Recipe ON Recipe.id_product_fk = Product.id
	INNER JOIN tblProd_Produced AS Produce ON Produce.id_recipe_fk = Recipe.id;
	
CREATE TRIGGER ProduceProduct ON tblProd_Produced
FOR INSERT AS
BEGIN 
	DECLARE
	@Produce_qtProduct INT,
	@Recipe_ID INT,
	@Product_ID INT,
	@Estoque_qtProduct INT,
	@equacao_de_producao INT;

	SELECT @Produce_qtProduct = 1;
	SELECT @Recipe_ID = recipe.id_recipe_fk FROM inserted AS recipe;
	SELECT @Product_ID = (SELECT product.id FROM tblProduct AS product
							LEFT JOIN tblRecipe AS recipe ON recipe.id_product_fk = product.id
							INNER JOIN tblProd_Produced AS produce ON produce.id_recipe_fk = recipe.id
							WHERE produce.id_recipe_fk = @Recipe_ID);
	SELECT @Estoque_qtProduct = (SELECT SUM(product.qt_estoque) FROM tblProduct AS product
									LEFT JOIN tblRecipe AS recipe ON recipe.id_product_fk = product.id
									INNER JOIN tblProd_Produced AS produce ON produce.id_recipe_fk = recipe.id
									WHERE produce.id_recipe_fk = @Recipe_ID);
	SELECT @equacao_de_producao = @Estoque_qtProduct + @Produce_qtProduct;

	UPDATE tblProduct
		SET
			qt_estoque = @equacao_de_producao
		WHERE id = @Product_ID;
END
GO

CREATE TRIGGER SellProduct ON tblSales_Product
FOR INSERT AS
BEGIN 
	DECLARE
	@Sale_qtProduct INT,
	@Produce_ID INT,
	@Product_ID INT,
	@Estoque_qtProduct INT,
	@equacao_de_venda INT;

	SELECT @Sale_qtProduct = (SELECT qt_Item 
								FROM tblSales_Product
								WHERE id = (SELECT id FROM inserted));
	SELECT @Produce_ID = (SELECT Produce.id_prod_produced_fk FROM inserted AS Produce);
	SELECT @Estoque_qtProduct =	(SELECT SUM(product.qt_estoque) FROM tblProduct AS product
									LEFT JOIN tblRecipe AS recipe on recipe.id = product.id
									INNER JOIN tblProd_Produced as produce on produce.id_recipe_fk = recipe.id 
									WHERE produce.id = @Produce_ID);
	SELECT @Product_ID = (SELECT product.id FROM tblProduct AS product
							LEFT JOIN tblRecipe AS recipe on recipe.id = product.id
							INNER JOIN tblProd_Produced as produce on produce.id_recipe_fk = recipe.id 
							WHERE produce.id = @Produce_ID);
	SELECT equacao_de_venda = @Estoque_qtProduct - @Sale_qtProduct;

	UPDATE tblProduct
		SET
			qt_estoque = @equacao_de_venda
		WHERE id = @Product_ID;
END
GO

CREATE TRIGGER buyMaterial on tblPurchase_RawMaterials
FOR INSERT AS
BEGIN
	DECLARE
	@Buy_qtProduct INT,
	@Material_ID INT,
	@Estoque_qtMaterial INT,
	@Equacao_de_compra INT;

	SELECT @Buy_qtProduct = (SELECT qt_Item 
								FROM tblPurchase_RawMaterials
								WHERE id = (SELECT id FROM inserted));
	SELECT @Material_ID = (SELECT purchase.id_rawmaterial_fk FROM inserted AS purchase);
	SELECT @Estoque_qtMaterial = (SELECT material.qt_estoque FROM tblRawMaterial AS material
									WHERE material.id = @Material_ID);
	SELECT @Equacao_de_compra = @Estoque_qtMaterial + @Buy_qtProduct;

	UPDATE tblRawMaterial
		SET
			qt_estoque = @Equacao_de_compra
		WHERE id = @Material_ID;
END
GO

