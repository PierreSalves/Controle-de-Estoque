using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWinform
{
    public partial class frmProducao : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmnd;

        SqlDataAdapter adapt_GridProduce;
        SqlDataAdapter adapt_GridMaterials;
        SqlDataAdapter adapt_cmboxRecipes;

        DataTable Virtual_listMaterials = new DataTable();
        int[] id_Recipes, id_SaleProduct;
        int id, rowIndex;

        bool INSERT; //INSERT == true
        bool UPDATE; //UPDATE == true
        bool DELETE; //ZONA DE PERIGO DELETE == true
        public frmProducao()
        {
            InitializeComponent();
            edtDesc.Focus();
            sqlcon.Open();
            DataTable produce = new DataTable();
            adapt_GridProduce = new SqlDataAdapter(@"SELECT id AS ID, 
                                                            id_recipe_fk, 
                                                            produceDay AS Data,
                                                            situacao AS STATUS
                                                        FROM tblProd_Produced", sqlcon);
            adapt_GridProduce.Fill(produce);
            dGridView_Produce.DataSource = produce;
            sqlcon.Close();
        }
        private void frmProducao_Load(object sender, EventArgs e)
        {
            edtDesc.Enabled = false;
            mskedtSellDate.Enabled = false;
            cmbRecipes.Enabled = false;
            edtQtProduce.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Produce.Enabled = true;
            dGridView_Materials.Enabled = true;

            imgButton_Add.Enabled = true;
            imgButton_Update.Enabled = true;
            imgButton_Delete.Enabled = false;
            imgButton_Refresh.Enabled = false;
            imgButton_Save.Enabled = false;
            imgButton_Cancel.Enabled = false;

            ExibirDados();
            id = (int)dGridView_Produce.Rows[0].Cells[0].Value;
            FiltrarDados("material");
            FiltrarDados("GridMaterial");
            edtID.Text = dGridView_Produce.Rows[0].Cells[0].Value.ToString();
            edtDesc.Text = dGridView_Produce.Rows[0].Cells[1].Value.ToString();
            mskedtSellDate.Text = dGridView_Produce.Rows[0].Cells[2].Value.ToString();
        }
        private void dGridView_Vendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ExibirDados();
                id = (int)dGridView_Produce.Rows[e.RowIndex].Cells[0].Value;
                FiltrarDados("material");
                FiltrarDados("GridMaterial");
                edtID.Text = dGridView_Produce.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtDesc.Text = dGridView_Produce.Rows[e.RowIndex].Cells[1].Value.ToString();
                mskedtSellDate.Text = dGridView_Produce.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                if (dGridView_Materials.Rows.Count == 0)
                {
                    FormatListProducts();
                }
            }
        }
        private void dGridView_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = e.RowIndex;
                cmbRecipes.SelectedIndex = (int)dGridView_Materials.Rows[e.RowIndex].Index;
                edtQtProduce.Text = dGridView_Materials.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }
        private void ExibirDados()
        {
            try
            {
                sqlcon.Open();
                DataTable sales = new DataTable();
                adapt_GridProduce = new SqlDataAdapter(@"SELECT id AS ID, 
                                                            id_recipe_fk, 
                                                            produceDay AS Data,
                                                            situacao AS STATUS
                                                        FROM tblProd_Produced", sqlcon);
                adapt_GridProduce.Fill(sales);
                dGridView_Produce.DataSource = sales;
                //////////////////////////////////////////////////////////////////////////////////////
                DataTable recipe = new DataTable();
                adapt_cmboxRecipes = new SqlDataAdapter("SELECT id,descricao FROM tblRecipe", sqlcon);
                adapt_cmboxRecipes.Fill(recipe);
                id_Recipes = new int[recipe.Rows.Count];    //array que armazena id de Receitas

                //loop que preencre o array de id e o ComboBox de Receitas
                cmbRecipes.Items.Clear();
                for (int i = 0; i < recipe.Rows.Count; i++)
                {
                    id_Recipes[i] = (int)(recipe.Rows[i][0]);
                    cmbRecipes.Items.Add(recipe.Rows[i][1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                throw;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        private void FiltrarDados(string dado)
        {
            if (dado == "Product")
            {
                string filter_products = ($@"  DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT saleProduct.id_product_fk AS IDproduto, 
                                                            product.descricao AS Produto, 
                                                            saleProduct.qt_Item AS Quantidade,
                                                            saleProduct.preco_ITEM AS Preco,
                                                            saleProduct.id
                                                    FROM tblSales_Product AS saleProduct   
                                                    LEFT JOIN tblProduct AS product ON saleProduct.id_product_fk = product.id
                                                    INNER JOIN tblSales AS sale ON saleProduct.id_sale_fk = sale.id
                                                    WHERE saleProduct.id_sale_fk = @id;");

                DataTable product = new DataTable();
                adapt_cmboxRecipes = new SqlDataAdapter(filter_products, sqlcon);
                adapt_cmboxRecipes.Fill(product);
                id_Recipes = new int[product.Rows.Count];
                id_SaleProduct = new int[product.Rows.Count];
                cmbRecipes.Items.Clear();
                //loop que preenche o ComboBox de Materiais
                for (int i = 0; i < product.Rows.Count; i++)
                {
                    id_Recipes[i] = (int)product.Rows[i][0];
                    cmbRecipes.Items.Add(product.Rows[i][1]);
                    id_SaleProduct[i] = (int)product.Rows[i][4];
                }
            }
            if (dado == "GridProduct")
            {
                string filter_products = ($@"  DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT saleProduct.id_product_fk AS IDproduto, 
                                                            product.descricao AS Produto, 
                                                            saleProduct.qt_Item AS Quantidade,
                                                            saleProduct.preco_ITEM AS Preco,
                                                    FROM tblSales_Product AS saleProduct   
                                                    LEFT JOIN tblProduct AS product ON saleProduct.id_product_fk = product.id
                                                    INNER JOIN tblSales AS sale ON saleProduct.id_sale_fk = sale.id
                                                    WHERE saleProduct.id_sale_fk = @id;");

                DataTable list_gridProducts = new DataTable();
                adapt_GridMaterials = new SqlDataAdapter(filter_products, sqlcon);
                adapt_GridMaterials.Fill(list_gridProducts);
                dGridView_Materials.DataSource = list_gridProducts;
            }
        }
        private void LimparDados()
        {
            edtID.Text = "";
            edtDesc.Text = "";
            mskedtSellDate.Text = "";
            edtDesc.Focus();
        }
        private void FormatListProducts()
        {
            Virtual_listMaterials.Columns.Clear();
            Virtual_listMaterials.Rows.Clear();

            Virtual_listMaterials.Columns.Add("IDproduto");
            Virtual_listMaterials.Columns.Add("Produto");
            Virtual_listMaterials.Columns.Add("Quantidade");
            Virtual_listMaterials.Columns.Add("Preco");
            dGridView_Materials.DataSource = Virtual_listMaterials;
        }
        private void imgButton_Add_Click(object sender, EventArgs e)
        {
            INSERT = true; //INSERT == true
            UPDATE = false;
            DELETE = false;

            LimparDados();
            FormatListProducts();
            ExibirDados();

            edtDesc.Enabled = true;
            mskedtSellDate.Enabled = true;
            pnlCentro.Enabled = true;
            dGridView_Produce.Enabled = false;
            dGridView_Materials.Enabled = true;

            imgButton_Add.Enabled = false; imgButton_Add.Image = imgButton_Add.ErrorImage;
            imgButton_Update.Enabled = false; imgButton_Update.Image = imgButton_Update.InitialImage;
            imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
            imgButton_Refresh.Enabled = true; imgButton_Refresh.Image = imgButton_Refresh.ErrorImage;
            imgButton_Save.Enabled = true; imgButton_Save.Image = imgButton_Save.ErrorImage;
            imgButton_Cancel.Enabled = true; imgButton_Cancel.Image = imgButton_Cancel.ErrorImage;
        }
        private void imgButton_Update_Click(object sender, EventArgs e)
        {
            INSERT = false;
            UPDATE = true; //UPDATE = true
            DELETE = false;

            ExibirDados();

            edtDesc.Enabled = true;
            mskedtSellDate.Enabled = true;
            pnlCentro.Enabled = true;
            dGridView_Produce.Enabled = false;
            dGridView_Materials.Enabled = false;

            imgButton_Add.Enabled = false; imgButton_Add.Image = imgButton_Add.InitialImage;
            imgButton_Update.Enabled = false; imgButton_Update.Image = imgButton_Update.ErrorImage;
            imgButton_Delete.Enabled = true; imgButton_Delete.Image = imgButton_Delete.ErrorImage;
            imgButton_Refresh.Enabled = true; imgButton_Refresh.Image = imgButton_Refresh.ErrorImage;
            imgButton_Save.Enabled = true; imgButton_Save.Image = imgButton_Save.ErrorImage;
            imgButton_Cancel.Enabled = true; imgButton_Cancel.Image = imgButton_Cancel.ErrorImage;
        }
        private void imgButton_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ATENÇÃO!! ESTA É UMA AÇÃO QUE NÃO PODE SER DESFEITA?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                INSERT = false;
                UPDATE = false;
                DELETE = true;  //DELETE = true

                edtDesc.Enabled = false;
                mskedtSellDate.Enabled = false;
                dGridView_Produce.Enabled = false;
                dGridView_Materials.Enabled = false;

                imgButton_Add.Enabled = false; imgButton_Add.Image = imgButton_Add.InitialImage;
                imgButton_Update.Enabled = false; imgButton_Update.Image = imgButton_Update.InitialImage;
                imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.ErrorImage;
                imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
                imgButton_Save.Enabled = true; imgButton_Save.Image = imgButton_Save.ErrorImage;
                imgButton_Cancel.Enabled = true; imgButton_Cancel.Image = imgButton_Cancel.ErrorImage;
            }
        }
        private void imgButton_Refresh_Click(object sender, EventArgs e)
        {
            LimparDados();
            FormatListProducts();
            ExibirDados();
        }
        private void imgButton_Save_Click(object sender, EventArgs e)
        {
            if (INSERT)
            {
                if (edtDesc.Text != "" && mskedtSellDate.Text != "")
                {
                    string insertPurchase = @"INSERT INTO[dbo].[tblPurchase]
                                                      ([descricao],
                                                      [buyDate])
                                             OUTPUT INSERTED.ID
                                             VALUES 
                                                      (@descricao,
                                                      @buyDate);";

                    string insertMaterials_inPurchase = @"INSERT INTO[dbo].[tblPurchase_RawMaterials]
                                                                    ([id_purchase_fk],
                                                                    [id_rawmaterial_fk],
                                                                    [qt_Item],
                                                                    [preco_ITEM])
                                                         VALUES
                                                                    (@id_purchase_fk,
                                                                    @id_rawmaterial_fk,
                                                                    @qt_Item,
                                                                    @preco_ITEM);";

                    //////////////////////////////////////////////////////////////////////////////////////////////////////

                    try
                    {
                        cmnd = new SqlCommand(insertPurchase, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do SqlCommand cmnd
                        cmnd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = edtDesc.Text;
                        cmnd.Parameters.Add("@buyDate", SqlDbType.Date).Value = DateTime.Today;

                        sqlcon.Open();
                        int lastId = (int)cmnd.ExecuteScalar();
                        //cmnd.ExecuteNonQuery();
                        cmnd.Parameters.Clear();
                        sqlcon.Close();

                        ///////////////////////////////////////////////////////////////////////////////////////////////////

                        cmnd = new SqlCommand(insertMaterials_inPurchase, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        ExibirDados();

                        for (int i = 0; i < Virtual_listMaterials.Rows.Count; i++)      //MULTIPLOS INSERTS NA tblRaw_Recipe
                        {

                            cmnd.Parameters.Add("@id_purchase_fk", SqlDbType.Int).Value = lastId;
                            cmnd.Parameters.Add("@id_rawmaterial_fk", SqlDbType.Int).Value = Virtual_listMaterials.Rows[i][0];
                            cmnd.Parameters.Add("@qt_Item", SqlDbType.Int).Value = Virtual_listMaterials.Rows[i][2];
                            cmnd.Parameters.Add("@preco_ITEM", SqlDbType.Real).Value = Virtual_listMaterials.Rows[i][3];
                            sqlcon.Open();
                            cmnd.ExecuteNonQuery();
                            cmnd.Parameters.Clear();
                            sqlcon.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        LimparDados();
                        FormatListProducts();
                        ExibirDados();

                        edtDesc.Enabled = false;
                        mskedtSellDate.Enabled = false;
                        pnlCentro.Enabled = false;
                        dGridView_Produce.Enabled = true;
                        dGridView_Materials.Enabled = true;

                        imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
                        imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
                        imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
                        imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
                        imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
                        imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;

                        INSERT = false;
                        UPDATE = false;
                        DELETE = false;
                    }
                }
            }
            if (UPDATE)
            {
                if (edtDesc.Text != "" && mskedtSellDate.Text != "")
                {
                    string updatePurchase = @"UPDATE [dbo].[tblPurchase]
                                            SET
                                                      [descricao] = @descricao,
                                                      [buyDate] = @buyDate
                                            WHERE [id] = @id";

                    string updateMaterials_inRecipe = @"UPDATE [dbo].[tblPurchase_RawMaterials]
                                                        SET
                                                                [id_purchase_fk] = @id_purchase_fk,
                                                                [id_rawmaterial_fk] = @id_rawmaterial_fk,
                                                                [qt_Item] = @qt_Item,
                                                                [preco_ITEM] = @preco_ITEM
                                                        WHERE [id] = @id";

                    ////////////////////////////////////////////////////////////////////////////////////////////////////////

                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            cmnd = new SqlCommand(updatePurchase, sqlcon);
                            cmnd.CommandType = CommandType.Text;
                            //adicionar parametros do comando
                            cmnd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            cmnd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = edtDesc.Text;
                            cmnd.Parameters.Add("@buyDate", SqlDbType.VarChar).Value = mskedtSellDate.Text;

                            sqlcon.Open();
                            cmnd.ExecuteNonQuery();
                            cmnd.Parameters.Clear();
                            sqlcon.Close();

                            ////////////////////////////////////////////////////////////////////////////////////////////////////////

                            cmnd = new SqlCommand(updateMaterials_inRecipe, sqlcon);
                            cmnd.CommandType = CommandType.Text;
                            cmnd.Parameters.Clear();

                            for (int i = 0; i < id_SaleProduct.Length; i++)      //MULTIPLOS UPDATES NA tblRaw_Recipe
                            {
                                cmnd.Parameters.Add("@id", SqlDbType.Int).Value = id_SaleProduct[i];
                                cmnd.Parameters.Add("@id_purchase_fk", SqlDbType.Int).Value = id;
                                cmnd.Parameters.Add("@id_rawmaterial_fk", SqlDbType.Int).Value = Virtual_listMaterials.Rows[i][0];
                                cmnd.Parameters.Add("@qt_Item", SqlDbType.Int).Value = Virtual_listMaterials.Rows[i][2];
                                cmnd.Parameters.Add("@preco_ITEM", SqlDbType.Real).Value = Virtual_listMaterials.Rows[i][3];

                                sqlcon.Open();
                                cmnd.ExecuteNonQuery();
                                cmnd.Parameters.Clear();
                                sqlcon.Close();
                            }

                            MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    finally
                    {
                        LimparDados();
                        FormatListProducts();
                        edtDesc.Enabled = false;
                        mskedtSellDate.Enabled = false;
                        dGridView_Produce.Enabled = true;
                        dGridView_Materials.Enabled = true;
                        pnlCentro.Enabled = false;

                        imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
                        imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
                        imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
                        imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
                        imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
                        imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;
                        ExibirDados();

                        INSERT = false;
                        UPDATE = false;
                        DELETE = false;
                    }
                }
            }
            if (DELETE)
            {
                string delete = @"  DELETE FROM[dbo].[tblPurchase_RawMaterial]
                                    WHERE id_purchase_fk = @id;
                                    DELETE FROM[dbo].[tblPurchase] 
                                    WHERE id = @id;";
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        cmnd = new SqlCommand(delete, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do comando
                        cmnd.Parameters.Add("@id", SqlDbType.Int).Value = id;


                        sqlcon.Open();
                        cmnd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro excluído permanentemente!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    sqlcon.Close();
                    LimparDados();
                    FormatListProducts();
                    edtDesc.Enabled = false;
                    mskedtSellDate.Enabled = false;
                    dGridView_Produce.Enabled = true;
                    dGridView_Materials.Enabled = true;
                    pnlCentro.Enabled = false;

                    imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
                    imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
                    imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
                    imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
                    imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
                    imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;
                    ExibirDados();

                    INSERT = false;
                    UPDATE = false;
                    DELETE = false;
                }
            }
        }
        private void imgButton_Cancel_Click(object sender, EventArgs e)
        {
            INSERT = false;
            UPDATE = false;
            DELETE = false;

            LimparDados();
            FormatListProducts();
            ExibirDados();

            edtDesc.Enabled = false;
            mskedtSellDate.Enabled = false;
            cmbRecipes.Enabled = false;
            edtQtProduce.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Produce.Enabled = true;
            dGridView_Materials.Enabled = true;

            imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
            imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
            imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
            imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
            imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
            imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;
        }
    }
}
