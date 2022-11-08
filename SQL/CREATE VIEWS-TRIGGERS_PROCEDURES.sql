CREATE VIEW [consulta_estoque_product] AS
	SELECT Product.descricao, Produce.produceDay, Product.qt_estoque
	FROM tblProduct AS Product
	LEFT JOIN tblRecipe AS Recipe ON Recipe.id_product_fk = Product.id
	INNER JOIN tblProd_Produced AS Produce ON Produce.id_recipe_fk = Recipe.id;
---------------------------------------------------------------------------------------------------------------	
CREATE TRIGGER ProduceProduct ON tblProd_Produced
FOR INSERT AS
BEGIN 
	DECLARE
	@Produce_qtProduct INT,
	@Recipe_ID INT,
	@Product_ID INT,
	@Estoque_qtProduct INT,
	@Estoque_qtMaterial INT,
	@Equacao_de_producao INT,
	@Equacao_de_Materiais_Usados INT,
	@i INT = 0,
	@qt_Materials_inRecipe INT;

	DECLARE Material_id_cursor CURSOR FOR 
		SELECT  rawrecipe.id_rawmaterial_fk
		FROM tblRaw_Recipe AS rawrecipe
		INNER JOIN tblRawMaterial AS rawmaterial ON rawrecipe.id_rawmaterial_fk = rawmaterial.id
		WHERE rawrecipe.id_recipe_fk = 6;--@Recipe_ID;
		
	SELECT @Recipe_ID = (SELECT produce.id_recipe_fk 
							FROM inserted AS produce);

	----------------------------------------------------------------------------PRODUCT
	SELECT @Produce_qtProduct = (SELECT qt_produce 
									FROM tblRecipe
									WHERE id = @Recipe_ID);

	SELECT @Product_ID = (SELECT recipe.id_product_fk
							FROM tblRecipe AS recipe
							WHERE recipe.id = @Recipe_ID);

	SELECT @Estoque_qtProduct = (SELECT product.qt_estoque 
									FROM tblProduct AS product
									WHERE product.id = @Product_ID);
		IF @Estoque_qtProduct IS NULL
			SELECT @Estoque_qtProduct = 0;
	SELECT @Equacao_de_producao = @Estoque_qtProduct + @Produce_qtProduct;

	----------------------------------------------------------------------------UPDATE qtProduct
	UPDATE tblProduct
		SET	
			qt_estoque = @Equacao_de_producao
		WHERE id = @Product_ID;

	----------------------------------------------------------------------------MATERIALS				
	DECLARE
		@Material_ID INT,
		@qt_Material INT;
	DECLARE cursor_idMaterial CURSOR FOR 
		SELECT  rawrecipe.id_rawmaterial_fk
		FROM tblRaw_Recipe AS rawrecipe
		INNER JOIN tblRawMaterial AS rawmaterial ON rawrecipe.id_rawmaterial_fk = rawmaterial.id
		WHERE rawrecipe.id_recipe_fk = @Recipe_ID;
		
	OPEN cursor_idMaterial;
	FETCH NEXT FROM cursor_idMaterial INTO
		@Material_ID;

	----------------------------------------------------------------------------UPDATE qtMaterials
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		SELECT @Estoque_qtMaterial = (SELECT material.qt_estoque 
										FROM tblRawMaterial AS material
										WHERE id = @Material_ID);

		SELECT @qt_Material = (SELECT rawrecipe.qt_Item 
									FROM tblRaw_Recipe AS rawrecipe
									WHERE rawrecipe.id_recipe_fk = @Recipe_ID
										AND rawrecipe.id_rawmaterial_fk = @Material_ID);

		SELECT @Equacao_de_Materiais_Usados = @Estoque_qtMaterial - @qt_Material;

		UPDATE tblRawMaterial
			SET
				qt_estoque = @Equacao_de_Materiais_Usados
			WHERE id = @Material_ID;

		FETCH NEXT FROM cursor_idMaterial INTO
			@Material_ID;
	END
	CLOSE cursor_idMaterial;  
	DEALLOCATE cursor_idMaterial; 
END
GO
---------------------------------------------------------------------------------------------------
CREATE TRIGGER SellProduct ON tblSales_Product
FOR INSERT AS
BEGIN 
	DECLARE
	@Sale_qtProduct INT,
	@Product_ID INT,
	@Estoque_qtProduct INT,
	@equacao_de_venda INT;

	SELECT @Sale_qtProduct = (SELECT qt_Item 
								FROM tblSales_Product
								WHERE id = (SELECT id FROM inserted));
	SELECT @Product_ID = (SELECT sale.id_product_fk FROM inserted AS sale);
	SELECT @Estoque_qtProduct =	(SELECT product.qt_estoque FROM tblProduct AS product
									WHERE product.id = @Product_ID);

	SELECT equacao_de_venda = @Estoque_qtProduct - @Sale_qtProduct;

	UPDATE tblProduct
		SET
			qt_estoque = @equacao_de_venda
		WHERE id = @Product_ID;
END
GO
---------------------------------------------------------------------------------------------------
CREATE TRIGGER buyMaterial on tblPurchase_RawMaterials
FOR INSERT AS
BEGIN
	DECLARE
	@Buy_qtMaterial INT,
	@Material_ID INT,
	@Estoque_qtMaterial INT,
	@Equacao_de_compra INT;

	SELECT @Buy_qtMaterial = (SELECT qt_Item 
								FROM tblPurchase_RawMaterials
								WHERE id = (SELECT id FROM inserted));
	SELECT @Material_ID = (SELECT purchase.id_rawmaterial_fk FROM inserted AS purchase);
	SELECT @Estoque_qtMaterial = (SELECT material.qt_estoque FROM tblRawMaterial AS material
									WHERE material.id = @Material_ID);
	SELECT @Equacao_de_compra = @Estoque_qtMaterial + @Buy_qtMaterial;

	UPDATE tblRawMaterial
		SET
			qt_estoque = @Equacao_de_compra
		WHERE id = @Material_ID;
END
GO