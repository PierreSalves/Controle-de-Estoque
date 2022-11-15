using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWinform
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadMaterial_Click(object sender, EventArgs e)
        {
            frmCadastroRawMaterial cliente = new frmCadastroRawMaterial();
            cliente.Show();
        }

        private void btnCadProduct_Click(object sender, EventArgs e)
        {
            frmCadastroProduct produto = new frmCadastroProduct();
            produto.Show();
        }
        private void btnCadReceita_Click(object sender, EventArgs e)
        {
            frmCadastroReceita receita = new frmCadastroReceita();
            receita.Show();
        }

        private void btnBuyMaterials_Click(object sender, EventArgs e)
        {
            frmComprarMateriais compra = new frmComprarMateriais();
            compra.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmVenderProdutos venda = new frmVenderProdutos();
            venda.Show();
        }

        private void bntProduction_Click(object sender, EventArgs e)
        {
            frmProducao producao = new frmProducao();
            producao.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque();
            estoque.Show();
        }
    }
}
