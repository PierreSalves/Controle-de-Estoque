using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjetoWinform
{
    public partial class frmLoginUser : Form
    {
        public frmLoginUser()
        {
            InitializeComponent();
            edtUser.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            string strConnectionString = "Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                
            string strQuery = string.Empty;
            strQuery = "SELECT * FROM tblUsers WHERE nome = @usuario AND senha = @senha";
            SqlConnection sqlcon = new SqlConnection(strConnectionString);

            SqlCommand comando = new SqlCommand(strQuery, sqlcon);
            comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = edtUser.Text;
            comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = edtSenha.Text;

            try
            {
                if (edtUser.Text == string.Empty)
                {
                    throw new Exception("Informe um email");
                }
                if (edtSenha.Text == string.Empty)
                {
                    throw new Exception("Informe uma senha");
                }

                sqlcon.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                if (dataReader.HasRows == false)
                {
                    throw new Exception("E-mail ou senha invalida");
                }

                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                frmPrincipal frmPrincipal = new frmPrincipal();

                frmPrincipal.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }
    }
}
