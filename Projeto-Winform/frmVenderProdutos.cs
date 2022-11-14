using ProjetoWinform.Models;
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
    public partial class frmVenderProdutos : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmnd;

        SqlDataAdapter adapt_GridSales;
        SqlDataAdapter adapt_GridProducts;
        SqlDataAdapter adapt_cmboxProducts;

        DataTable Virtual_listProducts = new DataTable();
        int[] id_Products, id_SaleProduct;
        int id, rowIndex;

        bool INSERT, InsertProduct; //INSERT == true
        bool UPDATE, UpdateProduct; //UPDATE == true
        bool DELETE, DeleteProduct; //ZONA DE PERIGO DELETE == true
        public frmVenderProdutos()
        {
            InitializeComponent();
            edtDesc.Focus();
            sqlcon.Open();
            DataTable sales = new DataTable();
            adapt_GridSales = new SqlDataAdapter(@"SELECT id AS ID, 
                                                                  descricao AS Descricao, 
                                                                  sellDate AS Data
                                                              FROM tblSales", sqlcon);
            adapt_GridSales.Fill(sales);
            dGridView_Vendas.DataSource = sales;
            sqlcon.Close();
        }
        private void frmVenderProdutos_Load(object sender, EventArgs e)
        {
            edtDesc.Enabled = false;
            mskedtSellDate.Enabled = false;
            cmbProducts.Enabled = false;
            edtQtProduct.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Vendas.Enabled = true;
            dGridView_Products.Enabled = true;

            imgButton_Add.Enabled = true;
            imgButton_Update.Enabled = true;
            imgButton_Delete.Enabled = false;
            imgButton_Refresh.Enabled = false;
            imgButton_Save.Enabled = false;
            imgButton_Cancel.Enabled = false;

            ExibirDados();
            FiltrarDados("Product");
            FiltrarDados("GridProduct");
        }
        private void dGridView_Vendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ExibirDados();
                id = (int)dGridView_Vendas.Rows[e.RowIndex].Cells[0].Value;
                FiltrarDados("Product");
                FiltrarDados("GridProduct");
                edtID.Text = dGridView_Vendas.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtDesc.Text = dGridView_Vendas.Rows[e.RowIndex].Cells[1].Value.ToString();
                mskedtSellDate.Text = dGridView_Vendas.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                if (dGridView_Products.Rows.Count == 0)
                {
                    FormatListProducts();
                }
            }
        }
        private void dGridView_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  AINDA NÃO CONFIGUREI TODO O CRUD DE PRODUTOS NA VENDA!!
            //         CRUD:   INSERT - OK
            //                 READ - OK
            //                 UPDATE - OK ------  AINDA COM MUITOS ERROS
            //                 DELETE - OK
            //
            try
            {
                rowIndex = e.RowIndex;
                cmbProducts.SelectedIndex = (int)dGridView_Products.Rows[e.RowIndex].Index;
                edtQtProduct.Text = dGridView_Products.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                adapt_GridSales = new SqlDataAdapter(@"SELECT id AS ID, 
                                                                  descricao AS Descricao, 
                                                                  sellDate AS Data
                                                              FROM tblSales", sqlcon);
                adapt_GridSales.Fill(sales);
                dGridView_Vendas.DataSource = sales;
                //////////////////////////////////////////////////////////////////////////////////////
                DataTable product = new DataTable();
                adapt_cmboxProducts = new SqlDataAdapter("SELECT id,descricao FROM tblProduct", sqlcon);
                adapt_cmboxProducts.Fill(product);
                id = (int)product.Rows[0]["ID"];
                id_Products = new int[product.Rows.Count];    //array que armazena id de Produtos

                //loop que preencre o array de id e o ComboBox de Produtos
                cmbProducts.Items.Clear();
                for (int i = 0; i < product.Rows.Count; i++)
                {
                    id_Products[i] = (int)(product.Rows[i][0]);
                    cmbProducts.Items.Add(product.Rows[i][1]);
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
                adapt_cmboxProducts = new SqlDataAdapter(filter_products, sqlcon);
                adapt_cmboxProducts.Fill(product);
                id_Products = new int[product.Rows.Count];
                id_SaleProduct = new int[product.Rows.Count];
                cmbProducts.Items.Clear();
                //loop que preenche o ComboBox de Materiais
                for (int i = 0; i < product.Rows.Count; i++)
                {
                    id_Products[i] = (int)product.Rows[i][0];
                    cmbProducts.Items.Add(product.Rows[i][1]);
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
                                                            saleProduct.preco_ITEM AS Preco
                                                    FROM tblSales_Product AS saleProduct   
                                                    LEFT JOIN tblProduct AS product ON saleProduct.id_product_fk = product.id
                                                    INNER JOIN tblSales AS sale ON saleProduct.id_sale_fk = sale.id
                                                    WHERE saleProduct.id_sale_fk = @id;");

                DataTable list_gridProducts = new DataTable();
                adapt_GridProducts = new SqlDataAdapter(filter_products, sqlcon);
                adapt_GridProducts.Fill(list_gridProducts);
                dGridView_Products.DataSource = list_gridProducts;
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
            Virtual_listProducts.Columns.Clear();
            Virtual_listProducts.Rows.Clear();

            Virtual_listProducts.Columns.Add("IDproduto");
            Virtual_listProducts.Columns.Add("Produto");
            Virtual_listProducts.Columns.Add("Quantidade");
            Virtual_listProducts.Columns.Add("Preco");
            dGridView_Products.DataSource = Virtual_listProducts;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            InsertProduct = true;
            UpdateProduct = false;
            DeleteProduct = false;

            ExibirDados();

            dGridView_Products.Enabled = false;
            cmbProducts.Enabled = true;
            edtQtProduct.Enabled = true;

            btnAddProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnDelete.Enabled = false;

            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            InsertProduct = false;
            UpdateProduct = true;
            DeleteProduct = false;

            ExibirDados();
            FormatListProducts();
            FiltrarDados("GridProduct");

            dGridView_Products.Enabled = true;
            cmbProducts.Enabled = true;
            edtQtProduct.Enabled = true;

            btnAddProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnDelete.Enabled = true;

            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ATENÇÃO!! ESTA É UMA AÇÃO QUE NÃO PODE SER DESFEITA?", "Deseja Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                InsertProduct = false;
                UpdateProduct = false;
                DeleteProduct = true;

                cmbProducts.Enabled = false;
                edtQtProduct.Enabled = false;

                btnAddProduct.Enabled = false;
                btnEditProduct.Enabled = false;
                btnDelete.Enabled = false;

                btnOK.Enabled = true;
                btnCancel.Enabled = true;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InsertProduct)
            {
                try
                {
                    btnAddProduct.Enabled = true;
                    btnEditProduct.Enabled = true;
                    btnDelete.Enabled = false;

                    btnOK.Enabled = false;
                    btnCancel.Enabled = false;

                    Virtual_listProducts.NewRow();
                    Virtual_listProducts.Rows.Add(id_Products[cmbProducts.SelectedIndex], cmbProducts.SelectedItem, edtQtProduct.Text, edtPreco.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    cmbProducts.Enabled = false;
                    edtQtProduct.Enabled = false;
                    cmbProducts.SelectedIndex = -1;
                    edtQtProduct.Text = "";
                    dGridView_Products.Enabled = true;

                    InsertProduct = false;
                    UpdateProduct = false;
                    DeleteProduct = false;
                }
            }
            if (UpdateProduct)
            {
                //  VARIOS BUGS DURANTE UTILIZAÇÃO
                //      PROGRAMAR UMA MANEIRA DE QUE O USUÁRIO SELECIONE O MATERIAL
                //          A SER EDITADO SOMENTE APÓS CLICAR NO BOTÃO EDITAR

                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        btnAddProduct.Enabled = true;
                        btnEditProduct.Enabled = true;
                        btnDelete.Enabled = false;

                        btnOK.Enabled = false;
                        btnCancel.Enabled = false;

                        for (int i = 0; i < dGridView_Products.Rows.Count; i++)
                        {
                            Virtual_listProducts.NewRow();
                            Virtual_listProducts.Rows.Add(dGridView_Products.Rows[i].Cells[0].Value, dGridView_Products.Rows[i].Cells[1].Value.ToString(), dGridView_Products.Rows[i].Cells[2].Value.ToString(), dGridView_Products.Rows[i].Cells[3].Value.ToString()); ;
                        }

                        Virtual_listProducts.Rows[dGridView_Products.Rows[rowIndex].Index].SetField(0, id_Products[cmbProducts.SelectedIndex]);
                        Virtual_listProducts.Rows[dGridView_Products.Rows[rowIndex].Index].SetField(1, cmbProducts.SelectedItem);
                        Virtual_listProducts.Rows[dGridView_Products.Rows[rowIndex].Index].SetField(2, cmbProducts.Text);
                        Virtual_listProducts.Rows[dGridView_Products.Rows[rowIndex].Index].SetField(3, edtPreco.Text);

                        dGridView_Products.DataSource = Virtual_listProducts;
                        FiltrarDados("material");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    cmbProducts.Enabled = false;
                    edtQtProduct.Enabled = false;
                    cmbProducts.SelectedIndex = -1;
                    edtQtProduct.Text = "";
                    dGridView_Products.Enabled = true;

                    InsertProduct = false;
                    UpdateProduct = false;
                    DeleteProduct = false;
                }
            }
            if (DeleteProduct)
            {
                //  PODE SER QUE EU TENHA QUE ARMAZENAR A LINHA QUE EU ESTOU EXCLUINDO NUMA VARIÁVEL
                //      PORQUE DEPOIS EU VOU PRECISAR DO INDEX DA LINHA QUE FOI EXCLUÍDA NA LISTA VIRTUAL
                //      PARA DEPOIS DAR UM DELETE NO BANCO

                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o material?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        btnAddProduct.Enabled = true;
                        btnEditProduct.Enabled = true;
                        btnDelete.Enabled = false;

                        btnOK.Enabled = false;
                        btnCancel.Enabled = false;

                        for (int i = 0; i < dGridView_Products.Rows.Count; i++)
                        {
                            Virtual_listProducts.NewRow();
                            Virtual_listProducts.Rows.Add(dGridView_Products.Rows[i].Cells[0].Value, dGridView_Products.Rows[i].Cells[1].Value.ToString(), dGridView_Products.Rows[i].Cells[2].Value.ToString(), dGridView_Products.Rows[i].Cells[3].Value.ToString());
                        }

                        Virtual_listProducts.Rows[dGridView_Products.Rows[rowIndex].Index].Delete();

                        dGridView_Products.DataSource = Virtual_listProducts;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    cmbProducts.Enabled = false;
                    edtQtProduct.Enabled = false;
                    cmbProducts.SelectedIndex = -1;
                    edtQtProduct.Text = "";
                    dGridView_Products.Enabled = true;

                    InsertProduct = false;
                    UpdateProduct = false;
                    DeleteProduct = false;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbProducts.Enabled = false;
            edtQtProduct.Enabled = false;

            btnAddProduct.Enabled = true;
            btnEditProduct.Enabled = true;
            btnDelete.Enabled = false;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            cmbProducts.SelectedIndex = -1;
            edtQtProduct.Text = "";
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
            mskedtSellDate.Enabled = true; mskedtSellDate.Text = DateTime.Today.ToShortDateString();
            pnlCentro.Enabled = true;
            dGridView_Vendas.Enabled = false;
            dGridView_Products.Enabled = true;

            btnAddProduct.Enabled = true;
            btnEditProduct.Enabled = true;
            btnDelete.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;

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
            dGridView_Vendas.Enabled = false;
            dGridView_Products.Enabled = false;

            btnAddProduct.Enabled = true;
            btnEditProduct.Enabled = true;
            btnDelete.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            imgButton_Add.Enabled = false; imgButton_Add.Image = imgButton_Add.InitialImage;
            imgButton_Update.Enabled = false; imgButton_Update.Image = imgButton_Update.ErrorImage;
            imgButton_Delete.Enabled = true; imgButton_Delete.Image = imgButton_Delete.ErrorImage;
            imgButton_Refresh.Enabled = true; imgButton_Refresh.Image = imgButton_Refresh.ErrorImage;
            imgButton_Save.Enabled = true; imgButton_Save.Image = imgButton_Save.ErrorImage;
            imgButton_Cancel.Enabled = true; imgButton_Cancel.Image = imgButton_Cancel.ErrorImage;
        }
        private void imgButton_Delete_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("ATENÇÃO!! ESTA É UMA AÇÃO QUE NÃO PODE SER DESFEITA?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                INSERT = false;
                UPDATE = false;
                DELETE = true;  //DELETE = true

                edtDesc.Enabled = false;
                mskedtSellDate.Enabled = false;
                dGridView_Vendas.Enabled = false;
                dGridView_Products.Enabled = false;

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
                    string insertPurchase = @"INSERT INTO[dbo].[tblSales]
                                                      ([descricao],
                                                      [sellDate])
                                              OUTPUT INSERTED.id
                                              VALUES 
                                                      (@descricao,
                                                      @sellDate);";

                    string insertMaterials_inPurchase = @"INSERT INTO[dbo].[tblSales_Product]
                                                                    ([id_sale_fk],
                                                                    [id_product_fk],
                                                                    [qt_Item],
                                                                    [preco_ITEM])
                                                         VALUES
                                                                    (@id_sale_fk,
                                                                    @id_product_fk,
                                                                    @qt_Item,
                                                                    @preco_ITEM);";

                    //////////////////////////////////////////////////////////////////////////////////////////////////////

                    try
                    {
                        cmnd = new SqlCommand(insertPurchase, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do SqlCommand cmnd
                        cmnd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = edtDesc.Text;
                        cmnd.Parameters.Add("@sellDate", SqlDbType.Date).Value = DateTime.Today;

                        sqlcon.Open();
                        int lastId = (int)cmnd.ExecuteScalar();
                        cmnd.Parameters.Clear();
                        sqlcon.Close();

                        ///////////////////////////////////////////////////////////////////////////////////////////////////

                        cmnd = new SqlCommand(insertMaterials_inPurchase, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        ExibirDados();

                        for (int i = 0; i < Virtual_listProducts.Rows.Count; i++)      //MULTIPLOS INSERTS NA tblRaw_Recipe
                        {

                            cmnd.Parameters.Add("@id_sale_fk", SqlDbType.Int).Value = lastId;
                            cmnd.Parameters.Add("@id_product_fk", SqlDbType.Int).Value = Virtual_listProducts.Rows[i][0];
                            cmnd.Parameters.Add("@qt_Item", SqlDbType.Int).Value = Virtual_listProducts.Rows[i][2];
                            cmnd.Parameters.Add("@preco_ITEM", SqlDbType.Real).Value = Virtual_listProducts.Rows[i][3];
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
                        dGridView_Vendas.Enabled = true;
                        dGridView_Products.Enabled = true;

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
                    string updatePurchase = @"UPDATE [dbo].[tblSales]
                                            SET
                                                      [descricao] = @descricao,
                                                      [sellDate] = @sellDate
                                            WHERE [id] = @id";

                    string updateMaterials_inRecipe = @"UPDATE [dbo].[tblSales_Product]
                                                        SET
                                                                [id_sale_fk] = @id_sale_fk,
                                                                [id_product_fk] = @id_product_fk,
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
                            cmnd.Parameters.Add("@sellDate", SqlDbType.VarChar).Value = mskedtSellDate.Text;

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
                                cmnd.Parameters.Add("@id_sale_fk", SqlDbType.Int).Value = id;
                                cmnd.Parameters.Add("@id_product_fk", SqlDbType.Int).Value = Virtual_listProducts.Rows[i][0];
                                cmnd.Parameters.Add("@qt_Item", SqlDbType.Int).Value = Virtual_listProducts.Rows[i][2];
                                cmnd.Parameters.Add("@preco_ITEM", SqlDbType.Real).Value = Virtual_listProducts.Rows[i][3];

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
                        dGridView_Vendas.Enabled = true;
                        dGridView_Products.Enabled = true;
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
                string delete = @"  DELETE FROM[dbo].[tblSales_Product]
                                    WHERE id_sale_fk = @id;
                                    DELETE FROM[dbo].[tblSales] 
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
                    dGridView_Vendas.Enabled = true;
                    dGridView_Products.Enabled = true;
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
            cmbProducts.Enabled = false;
            edtQtProduct.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Vendas.Enabled = true;
            dGridView_Products.Enabled = true;

            btnAddProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnDelete.Enabled = false;
            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
            imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
            imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
            imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
            imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
            imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;
        }
    }
}
