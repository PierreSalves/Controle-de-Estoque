using ProjetoWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWinform
{
    public partial class frmCadastroReceita : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmnd;

        SqlDataAdapter adapt_GridRecipes;
        SqlDataAdapter adapt_GridMaterials;
        SqlDataAdapter adapt_cmboxProduct;
        SqlDataAdapter adapt_cmboxMaterial;

        DataTable Virtual_listMaterials = new DataTable();
        int[] id_Products, id_Materials, id_Recipes, id_RawRecipe;
        int id, rowIndex;
        
        bool INSERT, InsertMaterial; //INSERT == true   
        bool UPDATE, UpdateMaterial; //UPDATE == true
        bool DELETE, DeleteMaterial; //ZONA DE PERIGO DELETE == true
        public frmCadastroReceita()
        { 
            InitializeComponent();
            edtDesc.Focus();
            sqlcon.Open();
                DataTable recipe = new DataTable();
                adapt_GridRecipes = new SqlDataAdapter(@"SELECT id AS ID, 
                                                                  id_product_fk AS idProduto,
                                                                  descricao AS Descricao, 
                                                                  qt_produce AS Quantidade_Produzida, 
                                                                  data_criacao AS 
                                                                  Data_de_Criacao 
                                                              FROM tblRecipe", sqlcon);
                adapt_GridRecipes.Fill(recipe);
                dGridView_Receitas.DataSource = recipe;
            sqlcon.Close();
        }
        private void frmCadastroReceita_Load(object sender, EventArgs e)
        {
            edtDesc.Enabled = false;
            edtQtProduce.Enabled = false;
            cmbProduct.Enabled = false;
            cmbMaterials.Enabled = false;
            edtQtMaterial.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Receitas.Enabled = true;
            dGridView_Materials.Enabled = true;

            imgButton_Add.Enabled = true;
            imgButton_Update.Enabled = true;
            imgButton_Delete.Enabled = false;
            imgButton_Refresh.Enabled = false;
            imgButton_Save.Enabled = false;
            imgButton_Cancel.Enabled = false;

            ExibirDados();
            id = (int)dGridView_Receitas.Rows[0].Cells[0].Value;
            FiltrarDados("product");
            FiltrarDados("material");
            FiltrarDados("GridMaterial");
            cmbProduct.SelectedIndex = 0;
            edtID.Text = dGridView_Receitas.Rows[0].Cells[0].Value.ToString();
            edtDesc.Text = dGridView_Receitas.Rows[0].Cells[2].Value.ToString();
            edtQtProduce.Text = dGridView_Receitas.Rows[0].Cells[3].Value.ToString();
        }
        private void dGridView_Receitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ExibirDados();
                id = (int)dGridView_Receitas.Rows[e.RowIndex].Cells[0].Value;
                FiltrarDados("product");
                FiltrarDados("material");
                FiltrarDados("GridMaterial");
                edtID.Text = dGridView_Receitas.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbProduct.SelectedIndex = 0;
                edtDesc.Text = dGridView_Receitas.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtQtProduce.Text = dGridView_Receitas.Rows[e.RowIndex].Cells[3].Value.ToString();
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
        private void dGridView_Materials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  AINDA NÃO CONFIGUREI TODO O CRUD DE MATERIAIS NA RECEITA!!
            //         CRUD:   INSERT - OK
            //                 READ - OK
            //                 UPDATE - OK ------  AINDA COM MUITOS ERROS
            //                 DELETE - OK
            //
            try
            {
                rowIndex = e.RowIndex;
                cmbMaterials.SelectedIndex = (int)dGridView_Materials.Rows[e.RowIndex].Index;
                edtQtMaterial.Text = dGridView_Materials.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                DataTable recipe = new DataTable();
                adapt_GridRecipes = new SqlDataAdapter(@"SELECT id AS ID, 
                                                              id_product_fk AS idProduto,
                                                              descricao AS Descricao, 
                                                              qt_produce AS Quantidade_Produzida, 
                                                              data_criacao AS 
                                                              Data_de_Criacao 
                                                          FROM tblRecipe", sqlcon);
                adapt_GridRecipes.Fill(recipe);
                dGridView_Receitas.DataSource = recipe;
                /*id_Recipes = new int[recipe.Rows.Count];      //PARTE DESNECESSÁRIA POIS JÁ EXISTE UMA FUNÇÃO PARA ISSO DENTRO DO SqlCommand    

                //loop que preencre o array de id de Receitas   
                for (int i = 0; i < recipe.Rows.Count; i++)   
                {
                    id_Recipes[i] = (int)(recipe.Rows[i][0]);
                }*/
                //////////////////////////////////////////////////////////////////////////////////////
                DataTable product = new DataTable();
                adapt_cmboxProduct = new SqlDataAdapter("SELECT id,descricao FROM tblProduct", sqlcon);
                adapt_cmboxProduct.Fill(product);
                id_Products = new int[product.Rows.Count];      //array que armazena id de Produtos

                //loop que preenche o array de id e o ComboBox de Produtos
                cmbProduct.Items.Clear();
                for (int i = 0; i < product.Rows.Count; i++)
                {
                    id_Products[i] = (int)(product.Rows[i][0]);
                    cmbProduct.Items.Add(product.Rows[i][1]);
                }
                //////////////////////////////////////////////////////////////////////////////////////
                DataTable material = new DataTable();
                adapt_cmboxMaterial = new SqlDataAdapter("SELECT id,descricao FROM tblRawMaterial", sqlcon);
                adapt_cmboxMaterial.Fill(material);
                id_Materials = new int[material.Rows.Count];    //array que armazena id de Materiais

                //loop que preencre o array de id e o ComboBox de Materiais
                cmbMaterials.Items.Clear();
                for (int i = 0; i < material.Rows.Count; i++)
                {
                    id_Materials[i] = (int)(material.Rows[i][0]);
                    cmbMaterials.Items.Add(material.Rows[i][1]);
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
            if (dado == "product")
            {
                string filter_product = ($@"  DECLARE @id INT;
                                                   SELECT @id = {id}
                                                   SELECT produto.descricao
                                                   FROM tblProduct AS produto
                                                   INNER JOIN tblRecipe AS receita ON produto.id = receita.id_product_fk
                                                   WHERE receita.id = @id;");

                DataTable product = new DataTable();
                adapt_cmboxProduct = new SqlDataAdapter(filter_product, sqlcon);
                adapt_cmboxProduct.Fill(product);
                cmbProduct.Items.Clear();
                cmbProduct.Items.Add(product.Rows[0][0]);
            }
            //////////////////////////////////////////////////////////////////////////////////////
            if (dado == "material")
            {
                string filter_materials = ($@"  DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT rawrecipe.id_rawmaterial_fk AS IDmaterial, 
                                                           rawmaterial.descricao AS Material, 
                                                           rawrecipe.qt_Item AS Quantidade,
                                                           rawrecipe.id
                                                    FROM tblRaw_Recipe AS rawrecipe
                                                    INNER JOIN tblRawMaterial AS rawmaterial ON rawrecipe.id_rawmaterial_fk = rawmaterial.id
                                                    WHERE rawrecipe.id_recipe_fk = @id;");

                DataTable material = new DataTable();
                adapt_cmboxMaterial = new SqlDataAdapter(filter_materials, sqlcon);
                adapt_cmboxMaterial.Fill(material);
                id_Materials = new int[material.Rows.Count];
                id_RawRecipe = new int[material.Rows.Count];
                cmbMaterials.Items.Clear();
                //loop que preenche o ComboBox de Materiais
                for (int i = 0; i < material.Rows.Count; i++)
                {
                    id_Materials[i] = (int)material.Rows[i][0];
                    cmbMaterials.Items.Add(material.Rows[i][1]);
                    id_RawRecipe[i] = (int)material.Rows[i][3];
                }  
            }
            if (dado == "GridMaterial")
            {
                string filter_materials = ($@"  DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT rawrecipe.id_rawmaterial_fk AS IDmaterial, 
                                                           rawmaterial.descricao AS Material, 
                                                           rawrecipe.qt_Item AS Quantidade
                                                    FROM tblRaw_Recipe AS rawrecipe
                                                    INNER JOIN tblRawMaterial AS rawmaterial ON rawrecipe.id_rawmaterial_fk = rawmaterial.id
                                                    WHERE rawrecipe.id_recipe_fk = @id;");

                DataTable list_gridMaterials = new DataTable();
                adapt_GridMaterials = new SqlDataAdapter(filter_materials, sqlcon);
                adapt_GridMaterials.Fill(list_gridMaterials);
                dGridView_Materials.DataSource = list_gridMaterials;
            }
        }
        private void LimparDados()
        {
            edtID.Text = "";
            edtDesc.Text = "";
            edtQtProduce.Text = "";
            edtDesc.Focus();
        }
        private void FormatListMaterials()
        {
            Virtual_listMaterials.Columns.Clear();
            Virtual_listMaterials.Rows.Clear();

            Virtual_listMaterials.Columns.Add("IDmaterial");
            Virtual_listMaterials.Columns.Add("Material");
            Virtual_listMaterials.Columns.Add("Quantidade");
            dGridView_Materials.DataSource = Virtual_listMaterials;
        }
        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            InsertMaterial = true;
            UpdateMaterial = false;
            DeleteMaterial = false;

            ExibirDados();
            
            dGridView_Materials.Enabled = false;
            cmbMaterials.Enabled = true;
            edtQtMaterial.Enabled = true;

            btnAddMaterial.Enabled = false;
            btnEditMaterial.Enabled = false;
            btnDelete.Enabled = false;

            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void btnEditMaterial_Click(object sender, EventArgs e)
        {
            InsertMaterial = false;
            UpdateMaterial = true;
            DeleteMaterial = false;

            ExibirDados();
            FormatListMaterials();
            FiltrarDados("GridMaterial");

            dGridView_Materials.Enabled = true;
            cmbMaterials.Enabled = true;
            edtQtMaterial.Enabled = true;

            btnAddMaterial.Enabled = false;
            btnEditMaterial.Enabled = false;
            btnDelete.Enabled = true;

            btnOK.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ATENÇÃO!! ESTA É UMA AÇÃO QUE NÃO PODE SER DESFEITA?", "Deseja Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                InsertMaterial = false;
                UpdateMaterial = false;
                DeleteMaterial = true;

                cmbMaterials.Enabled = false;
                edtQtMaterial.Enabled = false;

                btnAddMaterial.Enabled = false;
                btnEditMaterial.Enabled = false;
                btnDelete.Enabled = false;

                btnOK.Enabled = true;
                btnCancel.Enabled = true;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InsertMaterial)
            {
                try
                {
                    btnAddMaterial.Enabled = true;
                    btnEditMaterial.Enabled = true;
                    btnDelete.Enabled = false;

                    btnOK.Enabled = false;
                    btnCancel.Enabled = false;

                    Virtual_listMaterials.NewRow();
                    Virtual_listMaterials.Rows.Add(id_Materials[cmbMaterials.SelectedIndex], cmbMaterials.SelectedItem, edtQtMaterial.Text); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally 
                {
                    cmbMaterials.Enabled = false;
                    edtQtMaterial.Enabled = false;
                    cmbMaterials.SelectedIndex = -1;
                    edtQtMaterial.Text = "";
                    dGridView_Materials.Enabled = true;

                    InsertMaterial = false;
                    UpdateMaterial = false;
                    DeleteMaterial = false;
                }
            }
            if (UpdateMaterial) 
            {
                //  VARIOS BUGS DURANTE UTILIZAÇÃO 
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        btnAddMaterial.Enabled = true;
                        btnEditMaterial.Enabled = true;
                        btnDelete.Enabled = false;

                        btnOK.Enabled = false;
                        btnCancel.Enabled = false;

                        for (int i = 0; i < dGridView_Materials.Rows.Count; i++)
                        {
                            Virtual_listMaterials.NewRow();
                            Virtual_listMaterials.Rows.Add(dGridView_Materials.Rows[i].Cells[0].Value, dGridView_Materials.Rows[i].Cells[1].Value.ToString(), dGridView_Materials.Rows[i].Cells[2].Value.ToString());
                        }

                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].SetField(0, id_Materials[cmbMaterials.SelectedIndex]);
                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].SetField(1, cmbMaterials.SelectedItem);
                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].SetField(2, edtQtMaterial.Text);

                        dGridView_Materials.DataSource = Virtual_listMaterials;
                        FiltrarDados("material");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    cmbMaterials.Enabled = false;
                    edtQtMaterial.Enabled = false;
                    cmbMaterials.SelectedIndex = -1;
                    edtQtMaterial.Text = "";
                    dGridView_Materials.Enabled = true;

                    InsertMaterial = false;
                    UpdateMaterial = false;
                    DeleteMaterial = false;
                }
            }
            if (DeleteMaterial)
            {
                //  PODE SER QUE EU TENHA QUE ARMAZENAR A LINHA QUE EU ESTOU EXCLUINDO NUMA VARIÁVEL
                //      PORQUE DEPOIS EU VOU PRECISAR DO INDEX DA LINHA QUE FOI EXCLUÍDA NA LISTA VIRTUAL
                //      PARA DEPOIS DAR UM DELETE NO BANCO
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o material?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        btnAddMaterial.Enabled = true;
                        btnEditMaterial.Enabled = true;
                        btnDelete.Enabled = false;

                        btnOK.Enabled = false;
                        btnCancel.Enabled = false;

                        for (int i = 0; i < dGridView_Materials.Rows.Count; i++)
                        {
                            Virtual_listMaterials.NewRow();
                            Virtual_listMaterials.Rows.Add(dGridView_Materials.Rows[i].Cells[0].Value, dGridView_Materials.Rows[i].Cells[1].Value.ToString(), dGridView_Materials.Rows[i].Cells[2].Value.ToString());
                        }

                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].Delete();
                        
                        dGridView_Materials.DataSource = Virtual_listMaterials;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    cmbMaterials.Enabled = false;
                    edtQtMaterial.Enabled = false;
                    cmbMaterials.SelectedIndex = -1;
                    edtQtMaterial.Text = "";
                    dGridView_Materials.Enabled = true;

                    InsertMaterial = false;
                    UpdateMaterial = false;
                    DeleteMaterial = false;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbMaterials.Enabled = false;
            edtQtMaterial.Enabled = false;

            btnAddMaterial.Enabled = true;
            btnEditMaterial.Enabled = true;
            btnDelete.Enabled = false;

            btnOK.Enabled = false;
            btnCancel.Enabled = false;

            cmbMaterials.SelectedIndex = -1;
            edtQtMaterial.Text = "";
        }
        private void imgButton_Add_Click(object sender, EventArgs e)
        {
            INSERT = true; //INSERT == true
            UPDATE = false;
            DELETE = false;

            LimparDados();
            FormatListMaterials();
            ExibirDados();

            edtDesc.Enabled = true;
            cmbProduct.Enabled = true;
            edtQtProduce.Enabled = true;
            pnlCentro.Enabled = true;
            dGridView_Receitas.Enabled = false;
            dGridView_Materials.Enabled = true;

            btnAddMaterial.Enabled = true;
            btnEditMaterial.Enabled = true;
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

        private void imgButton_Delete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("ATENÇÃO!! ESTA É UMA AÇÃO QUE NÃO PODE SER DESFEITA?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                INSERT = false;
                UPDATE = false;
                DELETE = true;  //DELETE = true

                edtDesc.Enabled = false;
                cmbProduct.Enabled = false;
                edtQtProduce.Enabled = false;
                dGridView_Receitas.Enabled = false;
                dGridView_Materials.Enabled = false;

                imgButton_Add.Enabled = false; imgButton_Add.Image = imgButton_Add.InitialImage;
                imgButton_Update.Enabled = false; imgButton_Update.Image = imgButton_Update.InitialImage;
                imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.ErrorImage;
                imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
                imgButton_Save.Enabled = true; imgButton_Save.Image = imgButton_Save.ErrorImage;
                imgButton_Cancel.Enabled = true; imgButton_Cancel.Image = imgButton_Cancel.ErrorImage;
            }
        }
        private void imgButton_Update_Click(object sender, EventArgs e)
        {
            INSERT = false;
            UPDATE = true; //UPDATE = true
            DELETE = false;

            ExibirDados();

            edtDesc.Enabled = true;
            cmbProduct.Enabled = true;
            edtQtProduce.Enabled = true;
            pnlCentro.Enabled = true;
            dGridView_Receitas.Enabled = false;
            dGridView_Materials.Enabled = false;

            btnAddMaterial.Enabled = true;
            btnEditMaterial.Enabled = true;
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
        private void imgButton_Refresh_Click(object sender, EventArgs e)
        {
            LimparDados();
            FormatListMaterials();
            ExibirDados();
        }
        private void imgButton_Cancel_Click(object sender, EventArgs e)
        {
            INSERT = false;
            UPDATE = false;
            DELETE = false;

            LimparDados();
            FormatListMaterials();
            ExibirDados();

            edtDesc.Enabled = false;
            cmbProduct.Enabled = false;
            edtQtProduce.Enabled = false;
            cmbMaterials.Enabled = false;
            edtQtMaterial.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Receitas.Enabled = true;
            dGridView_Materials.Enabled = true;

            btnAddMaterial.Enabled = false;
            btnEditMaterial.Enabled = false;
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
        private void imgButton_Save_Click(object sender, EventArgs e)
        {
            Recipe newRecipe = new Recipe();
            RawMaterial rawMaterial;
            if (INSERT)
            {
                if (edtDesc.Text != "" && cmbProduct.Text != "" && edtQtProduce.Text != "")
                {
                    string insertRecipe = @"INSERT INTO[dbo].[tblRecipe]
                                                      ([id_product_fk],
                                                      [descricao],
                                                      [qt_produce],
                                                      [data_criacao])
                                             VALUES 
                                                      (@id_product_fk,
                                                      @descricao,
                                                      @qt_produce,
                                                      @data_criacao);";

                    string insertMaterials_inRecipe = @"INSERT INTO[dbo].[tblRaw_Recipe]
                                                                    ([id_recipe_fk],
                                                                    [id_rawmaterial_fk],
                                                                    [qt_Item])
                                                         OUTPUT INSERTED.ID
                                                         VALUES
                                                                    (@id_recipe_fk,
                                                                    @id_rawmaterial_fk,
                                                                    @qt_Item);";

                    //////////////////////////////////////////////////////////////////////////////////////////////////////
                    
                    try
                    {
                        cmnd = new SqlCommand(insertRecipe, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do SqlCommand cmnd
                        cmnd.Parameters.Add("@id_product_fk", SqlDbType.Int).Value = id_Products[cmbProduct.SelectedIndex];
                        cmnd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = edtDesc.Text;
                        cmnd.Parameters.Add("@qt_produce", SqlDbType.VarChar).Value = edtQtProduce.Text;
                        cmnd.Parameters.Add("@data_criacao", SqlDbType.Date).Value = DateTime.Today;

                        sqlcon.Open();
                        int lastId = (int)cmnd.ExecuteScalar();
                        cmnd.Parameters.Clear();
                        sqlcon.Close();

                        ///////////////////////////////////////////////////////////////////////////////////////////////////
                        
                        cmnd = new SqlCommand(insertMaterials_inRecipe, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        ExibirDados();

                        for(int i = 0; i < Virtual_listMaterials.Rows.Count; i++)      //MULTIPLOS INSERTS NA tblRaw_Recipe
                        {   
                            
                            cmnd.Parameters.Add("@id_recipe_fk", SqlDbType.Int).Value = lastId;
                            cmnd.Parameters.Add("@id_rawmaterial_fk", SqlDbType.Int).Value = Virtual_listMaterials.Rows[i][0];
                            cmnd.Parameters.Add("@qt_Item", SqlDbType.Real).Value = Virtual_listMaterials.Rows[i][2];
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
                        FormatListMaterials();
                        ExibirDados();

                        edtDesc.Enabled = false;
                        cmbProduct.Enabled = false;
                        edtQtProduce.Enabled = false;
                        pnlCentro.Enabled = false;
                        dGridView_Receitas.Enabled = true;
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
                if (edtDesc.Text != "" && cmbProduct.Text != "" && edtQtProduce.Text != "")
                {
                    string updateRecipe = @"UPDATE [dbo].[tblRecipe]
                                            SET
                                                      [id_product_fk] = @id_product_fk,
                                                      [descricao] = @descricao,
                                                      [qt_produce] = @qt_produce
                                            WHERE [id] = @id";

                    string updateMaterials_inRecipe = @"UPDATE [dbo].[tblRaw_Recipe]
                                                        SET
                                                                [id_recipe_fk] = @id_recipe_fk,
                                                                [id_rawmaterial_fk] = @id_rawmaterial_fk,
                                                                [qt_Item] = @qt_Item
                                                        WHERE [id] = @id";

                    ////////////////////////////////////////////////////////////////////////////////////////////////////////

                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            cmnd = new SqlCommand(updateRecipe, sqlcon);
                            cmnd.CommandType = CommandType.Text;
                            //adicionar parametros do comando
                            cmnd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            cmnd.Parameters.Add("@id_product_fk", SqlDbType.Int).Value = id_Products[cmbProduct.SelectedIndex];
                            cmnd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = edtDesc.Text;
                            cmnd.Parameters.Add("@qt_produce", SqlDbType.VarChar).Value = edtQtProduce.Text;

                            sqlcon.Open();
                            cmnd.ExecuteNonQuery();
                            cmnd.Parameters.Clear();
                            sqlcon.Close();

                            ////////////////////////////////////////////////////////////////////////////////////////////////////////
                            /////   PODE SER MELHOR EU CRIAR UMA FUNÇÃO ESPECÍFICA PARA REALIZAR OS INSERTS
                           
                            ///AQUI É PARA DAR INSERT NA TABELA CASO EU ADICIONE NOVOS ITENS NA RECEITA                          
                               /* string insertMaterials_inRecipe = @"INSERT INTO[dbo].[tblRaw_Recipe] 
                                                                    ([id_recipe_fk],
                                                                    [id_rawmaterial_fk],
                                                                    [qt_Item])
                                                         VALUES
                                                                    (@id_recipe_fk,
                                                                    @id_rawmaterial_fk,
                                                                    @qt_Item);";
                                ////////////////////////////////////////////////////////////////////////////////////////////////////
                                cmnd = new SqlCommand(insertMaterials_inRecipe, sqlcon);
                                cmnd.CommandType = CommandType.Text;
                                ExibirDados();

                                for (int i = 0; i < Virtual_listMaterials.Rows.Count; i++)      //MULTIPLOS INSERTS NA tblRaw_Recipe
                                {
                                    cmnd.Parameters.Add("@id_recipe_fk", SqlDbType.Int).Value = id_Recipes.Last();
                                    cmnd.Parameters.Add("@id_rawmaterial_fk", SqlDbType.Int).Value = Virtual_listMaterials.Rows[i][0];
                                    cmnd.Parameters.Add("qt_Item", SqlDbType.Real).Value = Virtual_listMaterials.Rows[i][2];
                                    sqlcon.Open();
                                    cmnd.ExecuteNonQuery();
                                    cmnd.Parameters.Clear();
                                    sqlcon.Close();
                                }*/
                           
                                cmnd = new SqlCommand(updateMaterials_inRecipe, sqlcon);
                                cmnd.CommandType = CommandType.Text;
                                cmnd.Parameters.Clear();

                                for (int i = 0; i < id_RawRecipe.Length; i++)      //MULTIPLOS UPDATES NA tblRaw_Recipe
                                {
                                    cmnd.Parameters.Add("@id", SqlDbType.Int).Value = id_RawRecipe[i];
                                    cmnd.Parameters.Add("@id_recipe_fk", SqlDbType.Int).Value = id;
                                    cmnd.Parameters.Add("@id_rawmaterial_fk", SqlDbType.Int).Value = Virtual_listMaterials.Rows[i][0];
                                    cmnd.Parameters.Add("qt_Item", SqlDbType.Real).Value = Virtual_listMaterials.Rows[i][2];

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
                        FormatListMaterials();
                        edtDesc.Enabled = false;
                        cmbProduct.Enabled = false;
                        edtQtProduce.Enabled = false;
                        dGridView_Receitas.Enabled = true;
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
                string delete = @"  DELETE FROM[dbo].[tblRaw_Recipe]
                                    WHERE id_recipe_fk = @id;
                                    DELETE FROM[dbo].[tblRecipe] 
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
                    FormatListMaterials();
                    edtDesc.Enabled = false;
                    cmbProduct.Enabled = false;
                    edtQtProduce.Enabled = false;
                    dGridView_Receitas.Enabled = true;
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
    }
}
