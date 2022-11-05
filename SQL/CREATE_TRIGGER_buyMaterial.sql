USE [dboPadaria]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER buyMaterial on tblPurchase_RawMaterials
FOR INSERT AS
BEGIN
	DECLARE
	@Buy_qtMaterial INT,
	@Material_ID INT,
	@Estoque_qtMaterial INT,
	@Equacao_de_compra INT;
	----------------------------------------------------------------------------------------
	SELECT @Buy_qtMaterial = (SELECT qt_Item 
								FROM tblPurchase_RawMaterials
								WHERE id = (SELECT id FROM inserted));

	SELECT @Material_ID = (SELECT purchase.id_rawmaterial_fk FROM inserted AS purchase);

	SELECT @Estoque_qtMaterial = (SELECT material.qt_estoque FROM tblRawMaterial AS material
									WHERE material.id = @Material_ID);
		IF @Estoque_qtMaterial IS NULL
			SELECT @Estoque_qtMaterial = 0;

	SELECT @Equacao_de_compra = @Estoque_qtMaterial + @Buy_qtMaterial;
	----------------------------------------------------------------------------------------
	UPDATE tblRawMaterial
		SET
			qt_estoque = @Equacao_de_compra
		WHERE id = @Material_ID;
END
GO