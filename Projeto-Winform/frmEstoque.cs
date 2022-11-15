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
    public partial class frmEstoque : Form
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=A315-42G\\SQLEXPRESS;Initial Catalog=dboPadaria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmnd;
    
        SqlDataAdapter adapt_GridEstoque;
        public frmEstoque()
        {
            InitializeComponent();
        }
        private void frmEstoque_Load(object sender, EventArgs e)
        {
            pnlCentro.Enabled = true;
            cmbFilter.Items.Add("Materiais");
            cmbFilter.Items.Add("Produtos");
        }
        private void FiltrarDados(byte dado)
        {
            if (dado == 0)
            {
                string filter_material = @"SELECT id AS ID,
                                                  descricao AS Descrição,
                                                  tipo AS Tipo,
                                                  unidade AS Unidade,
                                                  qt_estoque AS Quantidade_em_Estoque
                                           FROM tblRawMaterial";

                DataTable fillGrid = new DataTable();
                adapt_GridEstoque = new SqlDataAdapter(filter_material, sqlcon);
                adapt_GridEstoque.Fill(fillGrid);
                dGridView_Estoque.DataSource = fillGrid;
            }
            if (dado == 1)
            {
                string filter_product = @"SELECT id AS ID,
                                                 descricao AS Descrição,
                                                 tipo AS Tipo,
                                                 unidade AS Unidade,
                                                 qt_estoque AS Quantidade_em_Estoque
                                          FROM tblProduct";

                DataTable fillGrid = new DataTable();
                adapt_GridEstoque = new SqlDataAdapter(filter_product, sqlcon);
                adapt_GridEstoque.Fill(fillGrid);
                dGridView_Estoque.DataSource = fillGrid;
            }
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDados((byte)cmbFilter.SelectedIndex);
        }
    }
}
