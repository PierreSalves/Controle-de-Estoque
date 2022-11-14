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
        int[] id_Recipes;
        int id;

        bool INSERT; //INSERT == true
        bool UPDATE; //UPDATE == true
        bool DELETE; //ZONA DE PERIGO DELETE == true
        public frmProducao()
        {
            InitializeComponent();
            sqlcon.Open();
            DataTable produce = new DataTable();
            adapt_GridProduce = new SqlDataAdapter(@"SELECT produce.id AS ID, 
                                                            recipe.descricao AS Receita, 
                                                            produce.produceDay AS Data
                                                     FROM tblProd_Produced AS produce
                                                     INNER JOIN tblRecipe AS recipe ON produce.id_recipe_fk = recipe.id", sqlcon);
            adapt_GridProduce.Fill(produce);
            dGridView_Produce.DataSource = produce;
            sqlcon.Close();
        }
        private void frmProducao_Load(object sender, EventArgs e)
        {
            mskedtProduceDay.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Produce.Enabled = true;
            dGridView_Materials.Enabled = false;

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
        private void dGridView_Produce_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ExibirDados();
                id = (int)dGridView_Produce.Rows[e.RowIndex].Cells[0].Value;
                FiltrarDados("Product");
                FiltrarDados("GridProduct");
                edtID.Text = dGridView_Produce.Rows[e.RowIndex].Cells[0].Value.ToString();
                mskedtProduceDay.Text = dGridView_Produce.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                if (dGridView_Materials.Rows.Count == 0)
                {
                    FormatListMaterials();
                }
            }
        }
        private void cmbRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDados("Recipe");
        }
        private void ExibirDados()
        {
            try
            {
                sqlcon.Open();
                DataTable sales = new DataTable();
                adapt_GridProduce = new SqlDataAdapter(@"SELECT produce.id AS ID, 
                                                            recipe.descricao AS Receita, 
                                                            produce.produceDay AS Data
                                                        FROM tblProd_Produced AS produce
                                                        INNER JOIN tblRecipe AS recipe ON produce.id_recipe_fk = recipe.id", sqlcon);
                adapt_GridProduce.Fill(sales);
                dGridView_Produce.DataSource = sales;
                //////////////////////////////////////////////////////////////////////////////////////
                DataTable recipe = new DataTable();
                adapt_cmboxRecipes = new SqlDataAdapter("SELECT id,descricao FROM tblRecipe", sqlcon);
                adapt_cmboxRecipes.Fill(recipe);
                id = (int)recipe.Rows[0][0];
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
            if (dado == "Recipe")
            {
                string filter_recipe = $@"DECLARE @id_recipe INT;
                                          SELECT @id_recipe = {id_Recipes[cmbRecipes.SelectedIndex]}
                                          SELECT product.descricao,
                                                 recipe.qt_produce
                                          FROM tblRecipe AS recipe
                                          INNER JOIN tblProduct AS product ON recipe.id_product_fk = product.id
                                          WHERE recipe.id = @id_recipe";

                DataTable fillRecipe = new DataTable();
                adapt_cmboxRecipes = new SqlDataAdapter(filter_recipe, sqlcon);
                adapt_cmboxRecipes.Fill(fillRecipe);
                edtProduct.Text = fillRecipe.Rows[0][0].ToString();
                edtQtProduce.Text = fillRecipe.Rows[0][1].ToString();
            }
            if (dado == "Product")
            {
                string filter_product_inrecipe = ($@"DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT produce.id_recipe_fk AS IDreceita, 
                                                            recipe.descricao AS Receita, 
                                                            product.descricao AS Produto,
                                                            recipe.qt_produce
                                                    FROM tblProd_Produced AS produce  
                                                    INNER JOIN tblRecipe AS recipe ON produce.id_recipe_fk = recipe.id
                                                    INNER JOIN tblProduct AS product ON product.id = recipe.id_product_fk
                                                    WHERE produce.id = @id;");

                DataTable product_inrecipe = new DataTable();
                adapt_cmboxRecipes = new SqlDataAdapter(filter_product_inrecipe, sqlcon);
                adapt_cmboxRecipes.Fill(product_inrecipe);
                id_Recipes = new int[product_inrecipe.Rows.Count];
                cmbRecipes.Items.Clear();
                //loop que preenche o ComboBox de Receitas
                for (int i = 0; i < product_inrecipe.Rows.Count; i++)
                {
                    id_Recipes[i] = (int)product_inrecipe.Rows[i][0];
                    cmbRecipes.Items.Add(product_inrecipe.Rows[i][1]);
                }
                cmbRecipes.SelectedIndex = 0;
                edtProduct.Text = product_inrecipe.Rows[0][2].ToString();
                edtQtProduce.Text = product_inrecipe.Rows[0][3].ToString();
            }
            if (dado == "GridProduct")
            {
                string filter_products = ($@"  DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT rawrecipe.id_rawmaterial_fk AS IDmaterial, 
		                                                    material.descricao AS Material, 
		                                                    rawrecipe.qt_Item AS Quantidade
                                                    FROM tblRaw_Recipe AS rawrecipe
                                                    INNER JOIN tblRawMaterial AS material ON rawrecipe.id_rawmaterial_fk = material.id
                                                    INNER JOIN tblRecipe AS recipe ON rawrecipe.id_recipe_fk = recipe.id
                                                    INNER JOIN tblProd_produced AS produce ON produce.id_recipe_fk = recipe.id
                                                    WHERE produce.id = @id;");

                DataTable list_gridProducts = new DataTable();
                adapt_GridMaterials = new SqlDataAdapter(filter_products, sqlcon);
                adapt_GridMaterials.Fill(list_gridProducts);
                dGridView_Materials.DataSource = list_gridProducts;
            }
        }
        private void LimparDados()
        {
            edtID.Text = "";
            mskedtProduceDay.Text = "";
        }
        private void FormatListMaterials()
        {
            Virtual_listMaterials.Columns.Clear();
            Virtual_listMaterials.Rows.Clear();

            Virtual_listMaterials.Columns.Add("IDMaterial");
            Virtual_listMaterials.Columns.Add("Material");
            Virtual_listMaterials.Columns.Add("Quantidade");
            dGridView_Materials.DataSource = Virtual_listMaterials;
        }
        private void imgButton_Add_Click(object sender, EventArgs e)
        {
            INSERT = true; //INSERT == true
            UPDATE = false;
            DELETE = false;

            LimparDados();
            FormatListMaterials();
            ExibirDados();

            mskedtProduceDay.Enabled = true; mskedtProduceDay.Text = DateTime.Today.ToShortDateString();
            pnlCentro.Enabled = true;
            dGridView_Produce.Enabled = false;
            dGridView_Materials.Enabled = false;

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

            mskedtProduceDay.Enabled = true;
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

                mskedtProduceDay.Enabled = false;
                pnlCentro.Enabled = false;
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
            FormatListMaterials();
            ExibirDados();
        }
        private void imgButton_Save_Click(object sender, EventArgs e)
        {
            if (INSERT)
            {
                string insertPurchase = $@" DECLARE @id TABLE(id INT);
                                            INSERT INTO[dbo].[tblProd_Produced]
                                                    ([id_recipe_fk],
                                                    [produceDay])
                                            OUTPUT INSERTED.ID INTO @id
                                            VALUES 
                                                    (@id_recipe_fk,
                                                    @produceDay);";

                //////////////////////////////////////////////////////////////////////////////////////////////////////

                try
                {
                    cmnd = new SqlCommand(insertPurchase, sqlcon);
                    cmnd.CommandType = CommandType.Text;
                    //adicionar parametros do SqlCommand cmnd
                    cmnd.Parameters.Add("@id_recipe_fk", SqlDbType.VarChar).Value = id_Recipes[cmbRecipes.SelectedIndex];
                    cmnd.Parameters.Add("@produceDay", SqlDbType.Date).Value = DateTime.Today;

                    sqlcon.Open();
                    cmnd.ExecuteNonQuery();
                    cmnd.Parameters.Clear();
                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    LimparDados();
                    FormatListMaterials();
                    ExibirDados();

                    mskedtProduceDay.Enabled = false;
                    pnlCentro.Enabled = false;
                    dGridView_Produce.Enabled = true;
                    dGridView_Materials.Enabled = false;

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
            if (UPDATE)
            {
                    string updatePurchase = @"UPDATE [dbo].[tblProd_Produced]
                                            SET
                                                      [id_recipe_fk] = @id_recipe_fk,
                                                      [produceDay] = @produceDay
                                            WHERE [id] = @id";

                    ////////////////////////////////////////////////////////////////////////////////////////////////////////

                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            cmnd = new SqlCommand(updatePurchase, sqlcon);
                            cmnd.CommandType = CommandType.Text;
                            //adicionar parametros do comando
                            cmnd.Parameters.Add("@id_recipe_fk", SqlDbType.Int).Value = id_Recipes[cmbRecipes.SelectedIndex];
                            cmnd.Parameters.Add("@produceDay", SqlDbType.VarChar).Value = mskedtProduceDay.Text;
                            cmnd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                            sqlcon.Open();
                            cmnd.ExecuteNonQuery();
                            cmnd.Parameters.Clear();
                            sqlcon.Close();

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
                        FormatListMaterials();
                        mskedtProduceDay.Enabled = false;
                        dGridView_Produce.Enabled = true;
                        dGridView_Materials.Enabled = false;
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
            if (DELETE)
            {
                string delete = @"  DELETE FROM[dbo].[tblProd_Produced]
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
                        MessageBox.Show("Registro excluído permanentemente!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    FormatListMaterials();
                    mskedtProduceDay.Enabled = false;
                    dGridView_Produce.Enabled = true;
                    dGridView_Materials.Enabled = false;
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
            FormatListMaterials();
            ExibirDados();

            mskedtProduceDay.Enabled = false;
            cmbRecipes.Enabled = false;
            edtQtProduce.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Produce.Enabled = true;
            dGridView_Materials.Enabled = false;

            imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
            imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
            imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
            imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
            imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
            imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;
        }
    }
}
