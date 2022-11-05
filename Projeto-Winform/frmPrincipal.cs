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

        private void btnCadUsers_Click(object sender, EventArgs e)
        {
            frmCadastroUser user = new frmCadastroUser();
            user.Show();
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
    }
}
