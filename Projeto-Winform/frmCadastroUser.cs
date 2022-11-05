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
    public partial class frmCadastroUser : Form
    {
        public frmCadastroUser()
        {
            InitializeComponent();
            ExibirDados();
            edtNome.Focus();
        }
        SqlConnection sqlcon = new SqlConnection("Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmnd;
        SqlDataAdapter adapt;
        bool INSERT; //INSERT == true   
        bool UPDATE; //UPDATE == true
        bool DELETE; //ZONA DE PERIGO if(DELETE == true){};

        private void ExibirDados()
        {
            try
            {
                sqlcon.Open();
                DataTable dataTable = new DataTable();
                adapt = new SqlDataAdapter("SELECT id, nome, email, senha FROM tblUsers", sqlcon);
                adapt.Fill(dataTable);
                dGridView_Users.DataSource = dataTable;
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
            edtNome.Enabled = false;
            edtEmail.Enabled = false;
            edtSenha.Enabled = false;
            edtConfirmarSenha.Enabled = false;
            edtNome.Focus();
        }

        private void imgButton_Add_Click(object sender, EventArgs e)
        {
            INSERT = true; //INSERT == true
            UPDATE = false;
            DELETE = false;

            LimparDados();
            edtNome.Enabled = true;
            edtEmail.Enabled = true;
            edtSenha.Enabled = true;
            edtConfirmarSenha.Enabled = true;

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

            edtNome.Enabled = true;
            edtEmail.Enabled = true;
            edtSenha.Enabled = true;
            edtConfirmarSenha.Enabled = true;

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

                edtNome.Enabled = false;
                edtEmail.Enabled = false;
                edtSenha.Enabled = false;
                edtConfirmarSenha.Enabled = false;

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
                if (edtNome.Text != "" && edtSenha.Text != "" && edtConfirmarSenha.Text != "")
                {
                    string insert = @"INSERT INTO[dbo].[tblUsers]
                                                     ([nome],
                                                     [email],
                                                     [senha],
                                                     [permit]
                                                     [data_criacao])
                                            VALUES
                                                     (@nome,
                                                     @email,
                                                     @senha,
                                                     @permit
                                                     @data_criacao);";
                    try
                    {
                        cmnd = new SqlCommand(insert, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do SqlCommand cmnd
                        cmnd.Parameters.Add("@nome", SqlDbType.VarChar).Value = edtNome.Text;
                        cmnd.Parameters.Add("@email", SqlDbType.VarChar).Value = edtEmail.Text;
                        if (edtSenha.Text == edtConfirmarSenha.Text)
                        {
                            cmnd.Parameters.Add("@senha", SqlDbType.VarChar).Value = edtSenha.Text;
                        }
                        else
                        {
                            throw new Exception("Senhas diferentes");
                        }
                        cmnd.Parameters.Add("@permit", SqlDbType.Char).Value = "1111";
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
                        edtNome.Enabled = false;
                        edtEmail.Enabled = false;
                        edtSenha.Enabled = false;
                        edtConfirmarSenha.Enabled = false;

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
                if (edtNome.Text != "" && edtSenha.Text != "" && edtConfirmarSenha.Text != "")
                {
                    string update = @"UPDATE [dbo].[tblUsers]
                                            SET
                                                     [nome] = @nome,
                                                     [peso] = @email,
                                                     [altura] = @senha 
                                        WHERE [id] = @id";
                    try
                    {
                        if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {
                            cmnd = new SqlCommand(update, sqlcon);
                            cmnd.CommandType = CommandType.Text;
                            //adicionar parametros do SqlCommand cmnd
                            cmnd.Parameters.Add("@nome", SqlDbType.VarChar).Value = edtNome.Text;
                            cmnd.Parameters.Add("@email", SqlDbType.VarChar).Value = edtEmail.Text;
                            if (edtSenha.Text == edtConfirmarSenha.Text)
                            {
                                cmnd.Parameters.Add("@senha", SqlDbType.VarChar).Value = edtSenha.Text;
                            }
                            else
                            {
                                throw new Exception("Senhas diferentes");
                            }

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
                        edtNome.Enabled = false;
                        edtEmail.Enabled = false;
                        edtSenha.Enabled = false;
                        edtConfirmarSenha.Enabled = false;

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
                string delete = "DELETE FROM[dbo].[tblUsers] " +
                                    "WHERE id = @id;";
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        cmnd = new SqlCommand(delete, sqlcon);
                        cmnd.CommandType = CommandType.Text;
                        //adicionar parametros do comando
                        cmnd.Parameters.Add("@id", SqlDbType.Int).Value = dGridView_Users.SelectedRows[0].Cells[0].Value;


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
                    edtNome.Enabled = false;
                    edtEmail.Enabled = false;
                    edtSenha.Enabled = false;
                    edtConfirmarSenha.Enabled = false;

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
            edtNome.Enabled = false;
            edtEmail.Enabled = false;
            edtSenha.Enabled = false;
            edtConfirmarSenha.Enabled = false;

            imgButton_Add.Enabled = true; imgButton_Add.Image = imgButton_Add.ErrorImage;
            imgButton_Update.Enabled = true; imgButton_Update.Image = imgButton_Update.ErrorImage;
            imgButton_Delete.Enabled = false; imgButton_Delete.Image = imgButton_Delete.InitialImage;
            imgButton_Refresh.Enabled = false; imgButton_Refresh.Image = imgButton_Refresh.InitialImage;
            imgButton_Save.Enabled = false; imgButton_Save.Image = imgButton_Save.InitialImage;
            imgButton_Cancel.Enabled = false; imgButton_Cancel.Image = imgButton_Cancel.InitialImage;
            ExibirDados();
        }

        private void frmCadastroUser_Load(object sender, EventArgs e)
        {
            edtNome.Enabled = false;
            edtEmail.Enabled = false;
            edtSenha.Enabled = false;
            edtConfirmarSenha.Enabled = false;

            imgButton_Add.Enabled = true;
            imgButton_Update.Enabled = true;
            imgButton_Delete.Enabled = false;
            imgButton_Refresh.Enabled = false;
            imgButton_Save.Enabled = false;
            imgButton_Cancel.Enabled = false;

            edtNome.Text = dGridView_Users.Rows[0].Cells[1].Value.ToString();
            edtEmail.Text = dGridView_Users.Rows[0].Cells[2].Value.ToString();
            edtSenha.Text = dGridView_Users.Rows[0].Cells[3].Value.ToString();
            edtConfirmarSenha.Text = dGridView_Users.Rows[0].Cells[3].Value.ToString();
        }

        private void dGridView_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                edtID.Text = dGridView_Users.Rows[e.RowIndex].Cells[0].Value.ToString();
                edtNome.Text = dGridView_Users.Rows[e.RowIndex].Cells[1].Value.ToString();
                edtEmail.Text = dGridView_Users.Rows[e.RowIndex].Cells[2].Value.ToString();
                edtSenha.Text = dGridView_Users.Rows[e.RowIndex].Cells[3].Value.ToString();
                edtConfirmarSenha.Text = dGridView_Users.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
        }
    }
}
