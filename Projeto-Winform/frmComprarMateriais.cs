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
    public partial class frmComprarMateriais : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmnd;

        SqlDataAdapter adapt_GridPurchase;
        SqlDataAdapter adapt_GridMaterials;
        SqlDataAdapter adapt_cmboxMaterial;

        DataTable Virtual_listMaterials = new DataTable();
        int[] id_Materials, id_PurchaseMaterial;
        int id, rowIndex;

        bool INSERT, InsertMaterial; //INSERT == true
        bool UPDATE, UpdateMaterial; //UPDATE == true
        bool DELETE, DeleteMaterial; //ZONA DE PERIGO DELETE == true
        public frmComprarMateriais()
        {
            InitializeComponent();
            edtDesc.Focus();
            sqlcon.Open();
            DataTable purchase = new DataTable();
            adapt_GridPurchase = new SqlDataAdapter(@"SELECT id AS ID, 
                                                                  descricao AS Descricao, 
                                                                  buyDate AS Data
                                                              FROM tblPurchase", sqlcon);
            adapt_GridPurchase.Fill(purchase);
            dGridView_Compras.DataSource = purchase;
            sqlcon.Close();
        }
        private void frmComprarMateriais_Load(object sender, EventArgs e)
        {
            edtDesc.Enabled = false;
            mskedtBuyDate.Enabled = false;
            cmbMaterials.Enabled = false;
            edtQtMaterial.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Compras.Enabled = true;
            dGridView_Materials.Enabled = true;

            imgButton_Add.Enabled = true;
            imgButton_Update.Enabled = true;
            imgButton_Delete.Enabled = false;
            imgButton_Refresh.Enabled = false;
            imgButton_Save.Enabled = false;
            imgButton_Cancel.Enabled = false;

            ExibirDados();
            id = (int)dGridView_Compras.Rows[0].Cells[0].Value;
            FiltrarDados("material");
            FiltrarDados("GridMaterial");
            edtID.Text = dGridView_Compras.Rows[0].Cells[0].Value.ToString();
            edtDesc.Text = dGridView_Compras.Rows[0].Cells[1].Value.ToString();
            mskedtBuyDate.Text = dGridView_Compras.Rows[0].Cells[2].Value.ToString();
        }
        private void dGridView_Compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ExibirDados();
                id = (int)dGridView_Compras.Rows[e.RowIndex].Cells[0].Value;
                FiltrarDados("material");
                FiltrarDados("GridMaterial");
                edtID.Text = dGridView_Compras.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtDesc.Text = dGridView_Compras.Rows[e.RowIndex].Cells[1].Value.ToString();
                mskedtBuyDate.Text = dGridView_Compras.Rows[e.RowIndex].Cells[2].Value.ToString();
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
                DataTable purchase = new DataTable();
                adapt_GridPurchase = new SqlDataAdapter(@"SELECT id AS ID, 
                                                                  descricao AS Descricao, 
                                                                  buyDate AS Data
                                                              FROM tblPurchase", sqlcon);
                adapt_GridPurchase.Fill(purchase);
                dGridView_Compras.DataSource = purchase;
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
            if (dado == "material")
            {
                string filter_materials = ($@"  DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT BuyMaterials.id_rawmaterial_fk AS IDmaterial, 
                                                           material.descricao AS Material, 
                                                           BuyMaterials.qt_Item AS Quantidade,
                                                           BuyMaterials.preco_ITEM AS Preco,
                                                           BuyMaterials.id
                                                    FROM tblPurchase_RawMaterials AS BuyMaterials   
                                                    LEFT JOIN tblRawMaterial AS material ON BuyMaterials.id_rawmaterial_fk = material.id
                                                    INNER JOIN tblPurchase AS Purchase ON BuyMaterials.id_purchase_fk = Purchase.id
                                                    WHERE BuyMaterials.id_purchase_fk = @id;");

                DataTable material = new DataTable();
                adapt_cmboxMaterial = new SqlDataAdapter(filter_materials, sqlcon);
                adapt_cmboxMaterial.Fill(material);
                id_Materials = new int[material.Rows.Count];
                id_PurchaseMaterial = new int[material.Rows.Count];
                cmbMaterials.Items.Clear();
                //loop que preenche o ComboBox de Materiais
                for (int i = 0; i < material.Rows.Count; i++)
                {
                    id_Materials[i] = (int)material.Rows[i][0];
                    cmbMaterials.Items.Add(material.Rows[i][1]);
                    id_PurchaseMaterial[i] = (int)material.Rows[i][4];
                }
            }
            if (dado == "GridMaterial")
            {
                string filter_materials = ($@"  DECLARE @id INT;
                                                    SELECT @id = {id};
                                                    SELECT BuyMaterials.id_rawmaterial_fk AS IDmaterial, 
                                                           material.descricao AS Material, 
                                                           BuyMaterials.qt_Item AS Quantidade,
                                                           BuyMaterials.preco_ITEM AS Preco
                                                    FROM tblPurchase_RawMaterials AS BuyMaterials
                                                    LEFT JOIN tblRawMaterial AS material ON BuyMaterials.id_rawmaterial_fk = material.id
                                                    INNER JOIN tblPurchase AS Purchase ON BuyMaterials.id_purchase_fk = Purchase.id
                                                    WHERE BuyMaterials.id_purchase_fk = @id;");

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
            mskedtBuyDate.Text = "";
            edtDesc.Focus();
        }
        private void FormatListMaterials()
        {
            Virtual_listMaterials.Columns.Clear();
            Virtual_listMaterials.Rows.Clear();

            Virtual_listMaterials.Columns.Add("IDmaterial");
            Virtual_listMaterials.Columns.Add("Material");
            Virtual_listMaterials.Columns.Add("Quantidade");
            Virtual_listMaterials.Columns.Add("Preco");
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
                    Virtual_listMaterials.Rows.Add(id_Materials[cmbMaterials.SelectedIndex], cmbMaterials.SelectedItem, edtQtMaterial.Text, edtPreco.Text);
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
                //      PROGRAMAR UMA MANEIRA DE QUE O USUÁRIO SELECIONE O MATERIAL
                //          A SER EDITADO SOMENTE APÓS CLICAR NO BOTÃO EDITAR

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
                            Virtual_listMaterials.Rows.Add(dGridView_Materials.Rows[i].Cells[0].Value, dGridView_Materials.Rows[i].Cells[1].Value.ToString(), dGridView_Materials.Rows[i].Cells[2].Value.ToString(), dGridView_Materials.Rows[i].Cells[3].Value.ToString()); ;
                        }

                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].SetField(0, id_Materials[cmbMaterials.SelectedIndex]);
                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].SetField(1, cmbMaterials.SelectedItem);
                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].SetField(2, edtQtMaterial.Text);
                        Virtual_listMaterials.Rows[dGridView_Materials.Rows[rowIndex].Index].SetField(3, edtPreco.Text);

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
                            Virtual_listMaterials.Rows.Add(dGridView_Materials.Rows[i].Cells[0].Value, dGridView_Materials.Rows[i].Cells[1].Value.ToString(), dGridView_Materials.Rows[i].Cells[2].Value.ToString(), dGridView_Materials.Rows[i].Cells[3].Value.ToString());
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
            mskedtBuyDate.Enabled = true;
            pnlCentro.Enabled = true;
            dGridView_Compras.Enabled = false;
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
        private void imgButton_Update_Click(object sender, EventArgs e)
        {
            INSERT = false;
            UPDATE = true; //UPDATE = true
            DELETE = false;

            ExibirDados();

            edtDesc.Enabled = true;
            mskedtBuyDate.Enabled = true;
            pnlCentro.Enabled = true;
            dGridView_Compras.Enabled = false;
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
        private void imgButton_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("ATENÇÃO!! ESTA É UMA AÇÃO QUE NÃO PODE SER DESFEITA?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                INSERT = false;
                UPDATE = false;
                DELETE = true;  //DELETE = true

                edtDesc.Enabled = false;
                mskedtBuyDate.Enabled = false;
                dGridView_Compras.Enabled = false;
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
                if (edtDesc.Text != ""  && mskedtBuyDate.Text != "")
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
                        FormatListMaterials();
                        ExibirDados();

                        edtDesc.Enabled = false;
                        mskedtBuyDate.Enabled = false;
                        pnlCentro.Enabled = false;
                        dGridView_Compras.Enabled = true;
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
                if (edtDesc.Text != "" && mskedtBuyDate.Text != "")
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
                            cmnd.Parameters.Add("@buyDate", SqlDbType.VarChar).Value = mskedtBuyDate.Text;

                            sqlcon.Open();
                            cmnd.ExecuteNonQuery();
                            cmnd.Parameters.Clear();
                            sqlcon.Close();

                            ////////////////////////////////////////////////////////////////////////////////////////////////////////

                            cmnd = new SqlCommand(updateMaterials_inRecipe, sqlcon);
                            cmnd.CommandType = CommandType.Text;
                            cmnd.Parameters.Clear();

                            for (int i = 0; i < id_PurchaseMaterial.Length; i++)      //MULTIPLOS UPDATES NA tblRaw_Recipe
                            {
                                cmnd.Parameters.Add("@id", SqlDbType.Int).Value = id_PurchaseMaterial[i];
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
                        FormatListMaterials();
                        edtDesc.Enabled = false;
                        mskedtBuyDate.Enabled = false;
                        dGridView_Compras.Enabled = true;
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
                    FormatListMaterials();
                    edtDesc.Enabled = false;
                    mskedtBuyDate.Enabled = false;
                    dGridView_Compras.Enabled = true;
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
            FormatListMaterials();
            ExibirDados();

            edtDesc.Enabled = false;
            mskedtBuyDate.Enabled = false;
            cmbMaterials.Enabled = false;
            edtQtMaterial.Enabled = false;
            pnlCentro.Enabled = false;
            dGridView_Compras.Enabled = true;
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
    }
}
