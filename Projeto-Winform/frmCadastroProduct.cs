using ProjetoWinform.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoWinform
{
    public partial class frmCadastroProduct : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmnd;
        SqlDataAdapter adapt;
        bool INSERT; //INSERT == true   
        bool UPDATE; //UPDATE == true
        bool DELETE; //ZONA DE PERIGO if(DELETE == true){};
        public frmCadastroProduct()
        {
            InitializeComponent();
            ExibirDados();
            edtDesc.Focus();
        }

        private void ExibirDados()
        {
            try
            {
                sqlcon.Open();
                DataTable dataTable = new DataTable();
                adapt = new SqlDataAdapter(@"SELECT
                                                    id AS ID,
                                                    descricao AS Descrição,
                                                    tipo AS Tipo_de_Produto,
                                                    unidade AS Unidade,
                                                    qt_Estoque As Quantidade_em_Estoque,
                                                    data_criacao AS Data_de_Criação
                                               FROM tblProduct", sqlcon);
                adapt.Fill(dataTable);
                dGridView_Produtos.DataSource = dataTable;
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

        private void LimparDados()
        {
            edtDesc.Text = "";
            edtTipo.Text = "";
            edtUnit.Text = "";
            
            edtDesc.Focus();
        }

        private void imgButton_Add_Click(object sender, EventArgs e)
        {
            INSERT = true; //INSERT == true
            UPDATE = false;
            DELETE = false;

            LimparDados();
            edtDesc.Enabled = true;
            edtTipo.Enabled = true;
            edtUnit.Enabled = true;

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

            edtDesc.Enabled = true;
            edtTipo.Enabled = true;
            edtUnit.Enabled = true;

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
                edtTipo.Enabled = false;
                edtUnit.Enabled = false;

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
            ExibirDados();
        }

        private void imgButton_Save_Click(object sender, EventArgs e)
        {
            if (INSERT)
            {
                if (edtDesc.Text != "" && edtTipo.Text != "" && edtUnit.Text != "")
                {
                    string insert = @"INSERT INTO[dbo].[tblProduct]
                                                      ([descricao],
                                                      [tipo],
                                                      [unidade],
                                                      [data_criacao])
                                             VALUES 
                                                      (@descricao,
                                                      @tipo,
                                                      @unidade,
                                                      @data_criacao);";
                    try
                    {
                        cmnd = new SqlCommand(insert, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do SqlCommand cmnd
                        cmnd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = edtDesc.Text;
                        cmnd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = edtTipo.Text;
                        cmnd.Parameters.Add("@unidade", SqlDbType.VarChar).Value = edtUnit.Text;
                        cmnd.Parameters.Add("@data_criacao", SqlDbType.Date).Value = DateTime.Today;

                        sqlcon.Open();
                        cmnd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {
                        sqlcon.Close();
                        LimparDados();
                        edtDesc.Enabled = false;
                        edtTipo.Enabled = false;
                        edtUnit.Enabled = false;

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
            if (UPDATE)
            {
                if (edtDesc.Text != "" && edtTipo.Text != "" && edtUnit.Text != "")
                {
                    string update = @"UPDATE [dbo].[tblProduct]
                                         SET
                                                      [descricao] = @descricao,
                                                      [tipo] = @tipo,
                                                      [unidade] = @unidade
                                         WHERE [id] = @id";
                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            cmnd = new SqlCommand(update, sqlcon);
                            cmnd.CommandType = CommandType.Text;
                                                                //adicionar parametros do SqlCommand cmnd
                            cmnd.Parameters.Add("@id", SqlDbType.Int).Value = dGridView_Produtos.SelectedRows[0].Cells[0].Value;
                            cmnd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = edtDesc.Text;
                            cmnd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = edtTipo.Text;
                            cmnd.Parameters.Add("@unidade", SqlDbType.VarChar).Value = edtUnit.Text;                         

                            sqlcon.Open();
                            cmnd.ExecuteNonQuery();
                            MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    finally
                    {
                        sqlcon.Close();
                        LimparDados();
                        edtDesc.Enabled = false;
                        edtTipo.Enabled = false;
                        edtUnit.Enabled = false;

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
                string delete = @"DELETE FROM[dbo].[tblProduct] 
                                     WHERE id = @id;";
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        cmnd = new SqlCommand(delete, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do comando
                        cmnd.Parameters.Add("@id", SqlDbType.Int).Value = dGridView_Produtos.SelectedRows[0].Cells[0].Value;


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
                    edtDesc.Enabled = false;
                    edtTipo.Enabled = false;
                    edtUnit.Enabled = false;

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
            LimparDados();
            edtDesc.Enabled = false;
            edtTipo.Enabled = false;  
            edtUnit.Enabled = false;

            imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
            imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
            imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
            imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
            imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
            imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;
            ExibirDados();
        }

        private void dGridView_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                edtID.Text = dGridView_Produtos.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtDesc.Text = dGridView_Produtos.Rows[e.RowIndex].Cells[1].Value.ToString();
                edtTipo.Text = dGridView_Produtos.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtUnit.Text = dGridView_Produtos.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }

        private void frmCadastroProduct_Load(object sender, EventArgs e)
        {
            edtDesc.Enabled = false;
            edtTipo.Enabled = false;
            edtUnit.Enabled = false;

            imgButton_Add.Enabled = true;
            imgButton_Update.Enabled = true;
            imgButton_Delete.Enabled = false;
            imgButton_Refresh.Enabled = false;
            imgButton_Save.Enabled = false;
            imgButton_Cancel.Enabled = false;

            edtID.Text = dGridView_Produtos.Rows[0].Cells[0].Value.ToString();
            edtDesc.Text = dGridView_Produtos.Rows[0].Cells[1].Value.ToString();
            edtTipo.Text = dGridView_Produtos.Rows[0].Cells[2].Value.ToString();
            edtUnit.Text = dGridView_Produtos.Rows[0].Cells[3].Value.ToString();
        }
    }
}
