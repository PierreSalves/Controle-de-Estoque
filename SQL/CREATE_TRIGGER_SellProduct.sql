USE [dboPadaria]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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

	SELECT @equacao_de_venda = (@Estoque_qtProduct - @Sale_qtProduct);

	UPDATE tblProduct
		SET
			qt_estoque = @equacao_de_venda
		WHERE id = @Product_ID;
END
GO