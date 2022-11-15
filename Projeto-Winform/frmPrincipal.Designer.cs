namespace ProjetoWinform
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.btnCadMaterial = new System.Windows.Forms.Button();
            this.btnCadProduct = new System.Windows.Forms.Button();
            this.btnCadUsers = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnCadReceita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnBuyMaterials = new System.Windows.Forms.Button();
            this.bntProduction = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSuperior.TabIndex = 54;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuperior.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(313, 4);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(151, 41);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "PADARIA";
            this.lblSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCadMaterial
            // 
            this.btnCadMaterial.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadMaterial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadMaterial.FlatAppearance.BorderSize = 2;
            this.btnCadMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCadMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadMaterial.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnCadMaterial.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCadMaterial.Location = new System.Drawing.Point(10, 12);
            this.btnCadMaterial.Name = "btnCadMaterial";
            this.btnCadMaterial.Size = new System.Drawing.Size(192, 30);
            this.btnCadMaterial.TabIndex = 55;
            this.btnCadMaterial.Text = "CADASTRAR MATERIAIS";
            this.btnCadMaterial.UseVisualStyleBackColor = false;
            this.btnCadMaterial.Click += new System.EventHandler(this.btnCadMaterial_Click);
            // 
            // btnCadProduct
            // 
            this.btnCadProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadProduct.FlatAppearance.BorderSize = 2;
            this.btnCadProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCadProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProduct.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnCadProduct.Location = new System.Drawing.Point(10, 61);
            this.btnCadProduct.Name = "btnCadProduct";
            this.btnCadProduct.Size = new System.Drawing.Size(192, 30);
            this.btnCadProduct.TabIndex = 56;
            this.btnCadProduct.Text = "CADASTRAR PRODUTOS";
            this.btnCadProduct.UseVisualStyleBackColor = false;
            this.btnCadProduct.Click += new System.EventHandler(this.btnCadProduct_Click);
            // 
            // btnCadUsers
            // 
            this.btnCadUsers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadUsers.FlatAppearance.BorderSize = 2;
            this.btnCadUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCadUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsers.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnCadUsers.Location = new System.Drawing.Point(10, 162);
            this.btnCadUsers.Name = "btnCadUsers";
            this.btnCadUsers.Size = new System.Drawing.Size(192, 30);
            this.btnCadUsers.TabIndex = 57;
            this.btnCadUsers.Text = "CADASTRAR USUÁRIOS";
            this.btnCadUsers.UseVisualStyleBackColor = false;
            this.btnCadUsers.Click += new System.EventHandler(this.btnCadUsers_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.btnCadReceita);
            this.pnlRight.Controls.Add(this.btnCadMaterial);
            this.pnlRight.Controls.Add(this.btnCadUsers);
            this.pnlRight.Controls.Add(this.btnCadProduct);
            this.pnlRight.Location = new System.Drawing.Point(588, 69);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(212, 317);
            this.pnlRight.TabIndex = 58;
            // 
            // btnCadReceita
            // 
            this.btnCadReceita.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadReceita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadReceita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadReceita.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadReceita.FlatAppearance.BorderSize = 2;
            this.btnCadReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnCadReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadReceita.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnCadReceita.Location = new System.Drawing.Point(10, 111);
            this.btnCadReceita.Name = "btnCadReceita";
            this.btnCadReceita.Size = new System.Drawing.Size(192, 30);
            this.btnCadReceita.TabIndex = 58;
            this.btnCadReceita.Text = "CADASTRAR RECEITAS";
            this.btnCadReceita.UseVisualStyleBackColor = false;
            this.btnCadReceita.Click += new System.EventHandler(this.btnCadReceita_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnBuyMaterials);
            this.panel1.Controls.Add(this.bntProduction);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 317);
            this.panel1.TabIndex = 59;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSales.FlatAppearance.BorderSize = 2;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnSales.Location = new System.Drawing.Point(10, 111);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(192, 30);
            this.btnSales.TabIndex = 58;
            this.btnSales.Text = "VENDER PRODUTOS";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnBuyMaterials
            // 
            this.btnBuyMaterials.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuyMaterials.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuyMaterials.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyMaterials.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuyMaterials.FlatAppearance.BorderSize = 2;
            this.btnBuyMaterials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnBuyMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMaterials.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnBuyMaterials.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuyMaterials.Location = new System.Drawing.Point(10, 12);
            this.btnBuyMaterials.Name = "btnBuyMaterials";
            this.btnBuyMaterials.Size = new System.Drawing.Size(192, 30);
            this.btnBuyMaterials.TabIndex = 55;
            this.btnBuyMaterials.Text = "COMPRAR MATERIAIS";
            this.btnBuyMaterials.UseVisualStyleBackColor = false;
            this.btnBuyMaterials.Click += new System.EventHandler(this.btnBuyMaterials_Click);
            // 
            // bntProduction
            // 
            this.bntProduction.BackColor = System.Drawing.Color.DodgerBlue;
            this.bntProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntProduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntProduction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bntProduction.FlatAppearance.BorderSize = 2;
            this.bntProduction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.bntProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntProduction.Font = new System.Drawing.Font("Consolas", 12F);
            this.bntProduction.Location = new System.Drawing.Point(10, 61);
            this.bntProduction.Name = "bntProduction";
            this.bntProduction.Size = new System.Drawing.Size(192, 30);
            this.bntProduction.TabIndex = 56;
            this.bntProduction.Text = "PRODUZIR";
            this.bntProduction.UseVisualStyleBackColor = false;
            this.bntProduction.Click += new System.EventHandler(this.bntProduction_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEstoque.FlatAppearance.BorderSize = 2;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnEstoque.Location = new System.Drawing.Point(11, 162);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(192, 30);
            this.btnEstoque.TabIndex = 59;
            this.btnEstoque.Text = "ESTOQUE";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlSuperior);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Button btnCadMaterial;
        private System.Windows.Forms.Button btnCadProduct;
        private System.Windows.Forms.Button btnCadUsers;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnCadReceita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnBuyMaterials;
        private System.Windows.Forms.Button bntProduction;
        private System.Windows.Forms.Button btnEstoque;
    }
}

