namespace ProjetoWinform
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.edtDataCriacao = new System.Windows.Forms.TextBox();
            this.lblDataCriacao = new System.Windows.Forms.Label();
            this.edtSituacao = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.edtID = new System.Windows.Forms.TextBox();
            this.edtValor = new System.Windows.Forms.TextBox();
            this.edtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.edtDataSituacao = new System.Windows.Forms.TextBox();
            this.lblDataSituacao = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.edtCGCCliente = new System.Windows.Forms.TextBox();
            this.lblCGCCliente = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtDataCriacao
            // 
            this.edtDataCriacao.Location = new System.Drawing.Point(144, 278);
            this.edtDataCriacao.Name = "edtDataCriacao";
            this.edtDataCriacao.ReadOnly = true;
            this.edtDataCriacao.Size = new System.Drawing.Size(100, 20);
            this.edtDataCriacao.TabIndex = 38;
            this.edtDataCriacao.Text = "Now";
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.AutoSize = true;
            this.lblDataCriacao.Location = new System.Drawing.Point(41, 281);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(97, 13);
            this.lblDataCriacao.TabIndex = 37;
            this.lblDataCriacao.Text = "Data de Criação";
            // 
            // edtSituacao
            // 
            this.edtSituacao.Location = new System.Drawing.Point(102, 242);
            this.edtSituacao.Name = "edtSituacao";
            this.edtSituacao.Size = new System.Drawing.Size(100, 20);
            this.edtSituacao.TabIndex = 36;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(41, 245);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(55, 13);
            this.lblSituacao.TabIndex = 35;
            this.lblSituacao.Text = "Situação";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSuperior.Controls.Add(this.lblSuperior);
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(800, 50);
            this.pnlSuperior.TabIndex = 34;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuperior.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(321, 0);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(151, 41);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "PEDIDOS";
            // 
            // edtID
            // 
            this.edtID.Location = new System.Drawing.Point(66, 58);
            this.edtID.Name = "edtID";
            this.edtID.ReadOnly = true;
            this.edtID.Size = new System.Drawing.Size(36, 20);
            this.edtID.TabIndex = 33;
            // 
            // edtValor
            // 
            this.edtValor.Location = new System.Drawing.Point(84, 206);
            this.edtValor.Name = "edtValor";
            this.edtValor.Size = new System.Drawing.Size(100, 20);
            this.edtValor.TabIndex = 28;
            // 
            // edtDescricao
            // 
            this.edtDescricao.Location = new System.Drawing.Point(108, 92);
            this.edtDescricao.Name = "edtDescricao";
            this.edtDescricao.Size = new System.Drawing.Size(651, 20);
            this.edtDescricao.TabIndex = 27;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(41, 209);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(41, 95);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(61, 13);
            this.lblDescricao.TabIndex = 21;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 61);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 13);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "ID";
            // 
            // edtDataSituacao
            // 
            this.edtDataSituacao.Location = new System.Drawing.Point(174, 314);
            this.edtDataSituacao.Name = "edtDataSituacao";
            this.edtDataSituacao.ReadOnly = true;
            this.edtDataSituacao.Size = new System.Drawing.Size(100, 20);
            this.edtDataSituacao.TabIndex = 40;
            this.edtDataSituacao.Text = "Now";
            // 
            // lblDataSituacao
            // 
            this.lblDataSituacao.AutoSize = true;
            this.lblDataSituacao.Location = new System.Drawing.Point(41, 317);
            this.lblDataSituacao.Name = "lblDataSituacao";
            this.lblDataSituacao.Size = new System.Drawing.Size(127, 13);
            this.lblDataSituacao.TabIndex = 39;
            this.lblDataSituacao.Text = "Data Ultima Situacao";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(41, 134);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(55, 13);
            this.lblVendedor.TabIndex = 43;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(41, 172);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 13);
            this.lblCliente.TabIndex = 45;
            this.lblCliente.Text = "Cliente";
            // 
            // edtCGCCliente
            // 
            this.edtCGCCliente.Location = new System.Drawing.Point(601, 169);
            this.edtCGCCliente.Name = "edtCGCCliente";
            this.edtCGCCliente.Size = new System.Drawing.Size(158, 20);
            this.edtCGCCliente.TabIndex = 48;
            // 
            // lblCGCCliente
            // 
            this.lblCGCCliente.AutoSize = true;
            this.lblCGCCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCGCCliente.Location = new System.Drawing.Point(510, 172);
            this.lblCGCCliente.Name = "lblCGCCliente";
            this.lblCGCCliente.Size = new System.Drawing.Size(85, 13);
            this.lblCGCCliente.TabIndex = 47;
            this.lblCGCCliente.Text = "C.G.C Cliente";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(108, 131);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(339, 21);
            this.cmbVendedor.TabIndex = 49;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(108, 169);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(339, 21);
            this.cmbCliente.TabIndex = 50;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.edtCGCCliente);
            this.Controls.Add(this.lblCGCCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.edtDataSituacao);
            this.Controls.Add(this.lblDataSituacao);
            this.Controls.Add(this.edtDataCriacao);
            this.Controls.Add(this.lblDataCriacao);
            this.Controls.Add(this.edtSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.edtValor);
            this.Controls.Add(this.edtDescricao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblID);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjetoLoja";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtDataCriacao;
        private System.Windows.Forms.Label lblDataCriacao;
        private System.Windows.Forms.TextBox edtSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.TextBox edtValor;
        private System.Windows.Forms.TextBox edtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox edtDataSituacao;
        private System.Windows.Forms.Label lblDataSituacao;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox edtCGCCliente;
        private System.Windows.Forms.Label lblCGCCliente;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbCliente;
    }
}