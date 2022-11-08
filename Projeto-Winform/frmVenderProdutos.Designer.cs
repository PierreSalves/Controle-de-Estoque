namespace ProjetoWinform
{
    partial class frmVenderProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenderProdutos));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.mskedtSellDate = new System.Windows.Forms.MaskedTextBox();
            this.edtID = new System.Windows.Forms.TextBox();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.edtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.edtPreco = new System.Windows.Forms.TextBox();
            this.lblpreco = new System.Windows.Forms.Label();
            this.edtQtProduct = new System.Windows.Forms.TextBox();
            this.lblListProducts = new System.Windows.Forms.Label();
            this.lblQtProduct = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dGridView_Products = new System.Windows.Forms.DataGridView();
            this.dGridView_Vendas = new System.Windows.Forms.DataGridView();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.imgButton_Save = new System.Windows.Forms.PictureBox();
            this.imgButton_Update = new System.Windows.Forms.PictureBox();
            this.imgButton_Add = new System.Windows.Forms.PictureBox();
            this.imgButton_Delete = new System.Windows.Forms.PictureBox();
            this.imgButton_Cancel = new System.Windows.Forms.PictureBox();
            this.imgButton_Refresh = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Vendas)).BeginInit();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Refresh)).BeginInit();
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
            this.pnlSuperior.TabIndex = 56;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuperior.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(247, 0);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(303, 41);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "VENDER PRODUTOS";
            this.lblSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mskedtSellDate
            // 
            this.mskedtSellDate.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.mskedtSellDate.Location = new System.Drawing.Point(661, 57);
            this.mskedtSellDate.Mask = "00/00/0000";
            this.mskedtSellDate.Name = "mskedtSellDate";
            this.mskedtSellDate.Size = new System.Drawing.Size(99, 20);
            this.mskedtSellDate.TabIndex = 232;
            this.mskedtSellDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskedtSellDate.ValidatingType = typeof(System.DateTime);
            // 
            // edtID
            // 
            this.edtID.Enabled = false;
            this.edtID.Location = new System.Drawing.Point(66, 57);
            this.edtID.Name = "edtID";
            this.edtID.ReadOnly = true;
            this.edtID.Size = new System.Drawing.Size(36, 20);
            this.edtID.TabIndex = 231;
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSellDate.Location = new System.Drawing.Point(569, 60);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(85, 13);
            this.lblSellDate.TabIndex = 230;
            this.lblSellDate.Text = "Dia da Compra";
            // 
            // edtDesc
            // 
            this.edtDesc.Location = new System.Drawing.Point(175, 57);
            this.edtDesc.Name = "edtDesc";
            this.edtDesc.Size = new System.Drawing.Size(388, 20);
            this.edtDesc.TabIndex = 228;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(108, 60);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(61, 13);
            this.lblDesc.TabIndex = 229;
            this.lblDesc.Text = "Descrição";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 13);
            this.lblID.TabIndex = 227;
            this.lblID.Text = "ID";
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro.Controls.Add(this.edtPreco);
            this.pnlCentro.Controls.Add(this.lblpreco);
            this.pnlCentro.Controls.Add(this.edtQtProduct);
            this.pnlCentro.Controls.Add(this.lblListProducts);
            this.pnlCentro.Controls.Add(this.lblQtProduct);
            this.pnlCentro.Controls.Add(this.btnDelete);
            this.pnlCentro.Controls.Add(this.cmbProducts);
            this.pnlCentro.Controls.Add(this.lblProduct);
            this.pnlCentro.Controls.Add(this.btnCancel);
            this.pnlCentro.Controls.Add(this.btnOK);
            this.pnlCentro.Controls.Add(this.btnEditProduct);
            this.pnlCentro.Controls.Add(this.btnAddProduct);
            this.pnlCentro.Location = new System.Drawing.Point(44, 95);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(457, 134);
            this.pnlCentro.TabIndex = 233;
            // 
            // edtPreco
            // 
            this.edtPreco.Location = new System.Drawing.Point(357, 54);
            this.edtPreco.Name = "edtPreco";
            this.edtPreco.Size = new System.Drawing.Size(75, 20);
            this.edtPreco.TabIndex = 221;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(244, 57);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(103, 13);
            this.lblpreco.TabIndex = 220;
            this.lblpreco.Text = "Preço do Produto";
            // 
            // edtQtProduct
            // 
            this.edtQtProduct.Location = new System.Drawing.Point(163, 54);
            this.edtQtProduct.Name = "edtQtProduct";
            this.edtQtProduct.Size = new System.Drawing.Size(75, 20);
            this.edtQtProduct.TabIndex = 219;
            // 
            // lblListProducts
            // 
            this.lblListProducts.AutoSize = true;
            this.lblListProducts.Location = new System.Drawing.Point(3, 4);
            this.lblListProducts.Name = "lblListProducts";
            this.lblListProducts.Size = new System.Drawing.Size(109, 13);
            this.lblListProducts.TabIndex = 5;
            this.lblListProducts.Text = "Lista de Produtos";
            // 
            // lblQtProduct
            // 
            this.lblQtProduct.AutoSize = true;
            this.lblQtProduct.Location = new System.Drawing.Point(18, 57);
            this.lblQtProduct.Name = "lblQtProduct";
            this.lblQtProduct.Size = new System.Drawing.Size(139, 13);
            this.lblQtProduct.TabIndex = 218;
            this.lblQtProduct.Text = "Quantidade de Produtos";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(183, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(73, 20);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(359, 21);
            this.cmbProducts.TabIndex = 216;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(18, 23);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(49, 13);
            this.lblProduct.TabIndex = 217;
            this.lblProduct.Text = "Produto";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(357, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(276, 91);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Location = new System.Drawing.Point(102, 91);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 1;
            this.btnEditProduct.Text = "Editar";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(21, 91);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Adicionar";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dGridView_Products
            // 
            this.dGridView_Products.AllowUserToAddRows = false;
            this.dGridView_Products.AllowUserToDeleteRows = false;
            this.dGridView_Products.AllowUserToResizeColumns = false;
            this.dGridView_Products.AllowUserToResizeRows = false;
            this.dGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridView_Products.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGridView_Products.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView_Products.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridView_Products.GridColor = System.Drawing.SystemColors.WindowText;
            this.dGridView_Products.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dGridView_Products.Location = new System.Drawing.Point(519, 95);
            this.dGridView_Products.MultiSelect = false;
            this.dGridView_Products.Name = "dGridView_Products";
            this.dGridView_Products.ReadOnly = true;
            this.dGridView_Products.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Products.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridView_Products.RowHeadersVisible = false;
            this.dGridView_Products.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridView_Products.RowTemplate.ReadOnly = true;
            this.dGridView_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Products.Size = new System.Drawing.Size(240, 134);
            this.dGridView_Products.TabIndex = 234;
            this.dGridView_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_Products_CellContentClick);
            // 
            // dGridView_Vendas
            // 
            this.dGridView_Vendas.AllowUserToAddRows = false;
            this.dGridView_Vendas.AllowUserToDeleteRows = false;
            this.dGridView_Vendas.AllowUserToResizeColumns = false;
            this.dGridView_Vendas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridView_Vendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGridView_Vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridView_Vendas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dGridView_Vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGridView_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView_Vendas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGridView_Vendas.EnableHeadersVisualStyles = false;
            this.dGridView_Vendas.GridColor = System.Drawing.SystemColors.GrayText;
            this.dGridView_Vendas.Location = new System.Drawing.Point(44, 244);
            this.dGridView_Vendas.MultiSelect = false;
            this.dGridView_Vendas.Name = "dGridView_Vendas";
            this.dGridView_Vendas.ReadOnly = true;
            this.dGridView_Vendas.RowHeadersVisible = false;
            this.dGridView_Vendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridView_Vendas.RowTemplate.ReadOnly = true;
            this.dGridView_Vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Vendas.Size = new System.Drawing.Size(715, 150);
            this.dGridView_Vendas.TabIndex = 235;
            this.dGridView_Vendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_Vendas_CellContentClick);
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInferior.Controls.Add(this.imgButton_Save);
            this.pnlInferior.Controls.Add(this.imgButton_Update);
            this.pnlInferior.Controls.Add(this.imgButton_Add);
            this.pnlInferior.Controls.Add(this.imgButton_Delete);
            this.pnlInferior.Controls.Add(this.imgButton_Cancel);
            this.pnlInferior.Controls.Add(this.imgButton_Refresh);
            this.pnlInferior.Location = new System.Drawing.Point(0, 397);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(802, 53);
            this.pnlInferior.TabIndex = 236;
            // 
            // imgButton_Save
            // 
            this.imgButton_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButton_Save.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Save.ErrorImage")));
            this.imgButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("imgButton_Save.Image")));
            this.imgButton_Save.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Save.InitialImage")));
            this.imgButton_Save.Location = new System.Drawing.Point(660, 3);
            this.imgButton_Save.Name = "imgButton_Save";
            this.imgButton_Save.Size = new System.Drawing.Size(46, 46);
            this.imgButton_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgButton_Save.TabIndex = 7;
            this.imgButton_Save.TabStop = false;
            this.imgButton_Save.Click += new System.EventHandler(this.imgButton_Save_Click);
            // 
            // imgButton_Update
            // 
            this.imgButton_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButton_Update.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Update.ErrorImage")));
            this.imgButton_Update.Image = ((System.Drawing.Image)(resources.GetObject("imgButton_Update.Image")));
            this.imgButton_Update.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Update.InitialImage")));
            this.imgButton_Update.Location = new System.Drawing.Point(95, 3);
            this.imgButton_Update.Name = "imgButton_Update";
            this.imgButton_Update.Size = new System.Drawing.Size(46, 46);
            this.imgButton_Update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgButton_Update.TabIndex = 6;
            this.imgButton_Update.TabStop = false;
            this.imgButton_Update.Click += new System.EventHandler(this.imgButton_Update_Click);
            // 
            // imgButton_Add
            // 
            this.imgButton_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButton_Add.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Add.ErrorImage")));
            this.imgButton_Add.Image = ((System.Drawing.Image)(resources.GetObject("imgButton_Add.Image")));
            this.imgButton_Add.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Add.InitialImage")));
            this.imgButton_Add.Location = new System.Drawing.Point(43, 3);
            this.imgButton_Add.Name = "imgButton_Add";
            this.imgButton_Add.Size = new System.Drawing.Size(46, 46);
            this.imgButton_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgButton_Add.TabIndex = 3;
            this.imgButton_Add.TabStop = false;
            this.imgButton_Add.Click += new System.EventHandler(this.imgButton_Add_Click);
            // 
            // imgButton_Delete
            // 
            this.imgButton_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButton_Delete.Enabled = false;
            this.imgButton_Delete.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Delete.ErrorImage")));
            this.imgButton_Delete.Image = ((System.Drawing.Image)(resources.GetObject("imgButton_Delete.Image")));
            this.imgButton_Delete.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Delete.InitialImage")));
            this.imgButton_Delete.Location = new System.Drawing.Point(147, 3);
            this.imgButton_Delete.Name = "imgButton_Delete";
            this.imgButton_Delete.Size = new System.Drawing.Size(46, 46);
            this.imgButton_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgButton_Delete.TabIndex = 2;
            this.imgButton_Delete.TabStop = false;
            this.imgButton_Delete.Click += new System.EventHandler(this.imgButton_Delete_Click);
            // 
            // imgButton_Cancel
            // 
            this.imgButton_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.imgButton_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButton_Cancel.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Cancel.ErrorImage")));
            this.imgButton_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("imgButton_Cancel.Image")));
            this.imgButton_Cancel.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Cancel.InitialImage")));
            this.imgButton_Cancel.Location = new System.Drawing.Point(712, 3);
            this.imgButton_Cancel.Name = "imgButton_Cancel";
            this.imgButton_Cancel.Size = new System.Drawing.Size(46, 46);
            this.imgButton_Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgButton_Cancel.TabIndex = 1;
            this.imgButton_Cancel.TabStop = false;
            this.imgButton_Cancel.Click += new System.EventHandler(this.imgButton_Cancel_Click);
            // 
            // imgButton_Refresh
            // 
            this.imgButton_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgButton_Refresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Refresh.ErrorImage")));
            this.imgButton_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("imgButton_Refresh.Image")));
            this.imgButton_Refresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgButton_Refresh.InitialImage")));
            this.imgButton_Refresh.Location = new System.Drawing.Point(608, 3);
            this.imgButton_Refresh.Name = "imgButton_Refresh";
            this.imgButton_Refresh.Size = new System.Drawing.Size(46, 46);
            this.imgButton_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgButton_Refresh.TabIndex = 0;
            this.imgButton_Refresh.TabStop = false;
            this.imgButton_Refresh.Click += new System.EventHandler(this.imgButton_Refresh_Click);
            // 
            // frmVenderProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.dGridView_Vendas);
            this.Controls.Add(this.dGridView_Products);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.mskedtSellDate);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.lblSellDate);
            this.Controls.Add(this.edtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVenderProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmVenderProdutos_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Vendas)).EndInit();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.MaskedTextBox mskedtSellDate;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.TextBox edtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.TextBox edtPreco;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox edtQtProduct;
        private System.Windows.Forms.Label lblListProducts;
        private System.Windows.Forms.Label lblQtProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dGridView_Products;
        private System.Windows.Forms.DataGridView dGridView_Vendas;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.PictureBox imgButton_Save;
        private System.Windows.Forms.PictureBox imgButton_Update;
        private System.Windows.Forms.PictureBox imgButton_Add;
        private System.Windows.Forms.PictureBox imgButton_Delete;
        private System.Windows.Forms.PictureBox imgButton_Cancel;
        private System.Windows.Forms.PictureBox imgButton_Refresh;
    }
}