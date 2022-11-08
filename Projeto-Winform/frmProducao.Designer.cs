namespace ProjetoWinform
{
    partial class frmProducao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducao));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.dGridView_Produce = new System.Windows.Forms.DataGridView();
            this.dGridView_Materials = new System.Windows.Forms.DataGridView();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.edtQtProduce = new System.Windows.Forms.TextBox();
            this.lblListRecipe = new System.Windows.Forms.Label();
            this.lblQtProduce = new System.Windows.Forms.Label();
            this.cmbRecipes = new System.Windows.Forms.ComboBox();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.mskedtSellDate = new System.Windows.Forms.MaskedTextBox();
            this.edtID = new System.Windows.Forms.TextBox();
            this.lblSellDate = new System.Windows.Forms.Label();
            this.edtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.imgButton_Save = new System.Windows.Forms.PictureBox();
            this.imgButton_Update = new System.Windows.Forms.PictureBox();
            this.imgButton_Add = new System.Windows.Forms.PictureBox();
            this.imgButton_Delete = new System.Windows.Forms.PictureBox();
            this.imgButton_Cancel = new System.Windows.Forms.PictureBox();
            this.imgButton_Refresh = new System.Windows.Forms.PictureBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.edtProduct = new System.Windows.Forms.TextBox();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Produce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Materials)).BeginInit();
            this.pnlCentro.SuspendLayout();
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
            this.pnlSuperior.TabIndex = 57;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuperior.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(310, 0);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(170, 41);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "PRODUZIR";
            this.lblSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGridView_Produce
            // 
            this.dGridView_Produce.AllowUserToAddRows = false;
            this.dGridView_Produce.AllowUserToDeleteRows = false;
            this.dGridView_Produce.AllowUserToResizeColumns = false;
            this.dGridView_Produce.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridView_Produce.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dGridView_Produce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridView_Produce.BackgroundColor = System.Drawing.Color.LightGray;
            this.dGridView_Produce.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Produce.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dGridView_Produce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Produce.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView_Produce.DefaultCellStyle = dataGridViewCellStyle15;
            this.dGridView_Produce.EnableHeadersVisualStyles = false;
            this.dGridView_Produce.GridColor = System.Drawing.SystemColors.GrayText;
            this.dGridView_Produce.Location = new System.Drawing.Point(44, 244);
            this.dGridView_Produce.MultiSelect = false;
            this.dGridView_Produce.Name = "dGridView_Produce";
            this.dGridView_Produce.ReadOnly = true;
            this.dGridView_Produce.RowHeadersVisible = false;
            this.dGridView_Produce.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridView_Produce.RowTemplate.ReadOnly = true;
            this.dGridView_Produce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Produce.Size = new System.Drawing.Size(715, 150);
            this.dGridView_Produce.TabIndex = 244;
            this.dGridView_Produce.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_Vendas_CellContentClick);
            // 
            // dGridView_Materials
            // 
            this.dGridView_Materials.AllowUserToAddRows = false;
            this.dGridView_Materials.AllowUserToDeleteRows = false;
            this.dGridView_Materials.AllowUserToResizeColumns = false;
            this.dGridView_Materials.AllowUserToResizeRows = false;
            this.dGridView_Materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridView_Materials.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGridView_Materials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Materials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dGridView_Materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Materials.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView_Materials.DefaultCellStyle = dataGridViewCellStyle17;
            this.dGridView_Materials.GridColor = System.Drawing.SystemColors.WindowText;
            this.dGridView_Materials.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dGridView_Materials.Location = new System.Drawing.Point(519, 95);
            this.dGridView_Materials.MultiSelect = false;
            this.dGridView_Materials.Name = "dGridView_Materials";
            this.dGridView_Materials.ReadOnly = true;
            this.dGridView_Materials.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Materials.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dGridView_Materials.RowHeadersVisible = false;
            this.dGridView_Materials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridView_Materials.RowTemplate.ReadOnly = true;
            this.dGridView_Materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Materials.Size = new System.Drawing.Size(240, 134);
            this.dGridView_Materials.TabIndex = 243;
            this.dGridView_Materials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_Products_CellContentClick);
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro.Controls.Add(this.edtProduct);
            this.pnlCentro.Controls.Add(this.lblProduct);
            this.pnlCentro.Controls.Add(this.edtQtProduce);
            this.pnlCentro.Controls.Add(this.lblListRecipe);
            this.pnlCentro.Controls.Add(this.lblQtProduce);
            this.pnlCentro.Controls.Add(this.cmbRecipes);
            this.pnlCentro.Controls.Add(this.lblRecipe);
            this.pnlCentro.Location = new System.Drawing.Point(44, 95);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(457, 96);
            this.pnlCentro.TabIndex = 242;
            // 
            // edtQtProduce
            // 
            this.edtQtProduce.Location = new System.Drawing.Point(382, 54);
            this.edtQtProduce.Name = "edtQtProduce";
            this.edtQtProduce.Size = new System.Drawing.Size(50, 20);
            this.edtQtProduce.TabIndex = 219;
            // 
            // lblListRecipe
            // 
            this.lblListRecipe.AutoSize = true;
            this.lblListRecipe.Location = new System.Drawing.Point(3, 4);
            this.lblListRecipe.Name = "lblListRecipe";
            this.lblListRecipe.Size = new System.Drawing.Size(109, 13);
            this.lblListRecipe.TabIndex = 5;
            this.lblListRecipe.Text = "Lista de Receitas";
            // 
            // lblQtProduce
            // 
            this.lblQtProduce.AutoSize = true;
            this.lblQtProduce.Location = new System.Drawing.Point(250, 57);
            this.lblQtProduce.Name = "lblQtProduce";
            this.lblQtProduce.Size = new System.Drawing.Size(127, 13);
            this.lblQtProduce.TabIndex = 218;
            this.lblQtProduce.Text = "Quantidade Produzida";
            // 
            // cmbRecipes
            // 
            this.cmbRecipes.FormattingEnabled = true;
            this.cmbRecipes.Location = new System.Drawing.Point(73, 20);
            this.cmbRecipes.Name = "cmbRecipes";
            this.cmbRecipes.Size = new System.Drawing.Size(359, 21);
            this.cmbRecipes.TabIndex = 216;
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(18, 23);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(49, 13);
            this.lblRecipe.TabIndex = 217;
            this.lblRecipe.Text = "Receita";
            // 
            // mskedtSellDate
            // 
            this.mskedtSellDate.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.mskedtSellDate.Location = new System.Drawing.Point(672, 57);
            this.mskedtSellDate.Mask = "00/00/0000";
            this.mskedtSellDate.Name = "mskedtSellDate";
            this.mskedtSellDate.Size = new System.Drawing.Size(88, 20);
            this.mskedtSellDate.TabIndex = 241;
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
            this.edtID.TabIndex = 240;
            // 
            // lblSellDate
            // 
            this.lblSellDate.AutoSize = true;
            this.lblSellDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSellDate.Location = new System.Drawing.Point(569, 60);
            this.lblSellDate.Name = "lblSellDate";
            this.lblSellDate.Size = new System.Drawing.Size(97, 13);
            this.lblSellDate.TabIndex = 239;
            this.lblSellDate.Text = "Dia da Produção";
            // 
            // edtDesc
            // 
            this.edtDesc.Location = new System.Drawing.Point(175, 57);
            this.edtDesc.Name = "edtDesc";
            this.edtDesc.Size = new System.Drawing.Size(388, 20);
            this.edtDesc.TabIndex = 237;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(108, 60);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(61, 13);
            this.lblDesc.TabIndex = 238;
            this.lblDesc.Text = "Descrição";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 13);
            this.lblID.TabIndex = 236;
            this.lblID.Text = "ID";
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
            this.pnlInferior.TabIndex = 245;
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
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(18, 57);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(49, 13);
            this.lblProduct.TabIndex = 220;
            this.lblProduct.Text = "Produto";
            // 
            // edtProduct
            // 
            this.edtProduct.Location = new System.Drawing.Point(73, 54);
            this.edtProduct.Name = "edtProduct";
            this.edtProduct.Size = new System.Drawing.Size(171, 20);
            this.edtProduct.TabIndex = 222;
            // 
            // frmProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.dGridView_Produce);
            this.Controls.Add(this.dGridView_Materials);
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
            this.Name = "frmProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmProducao_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Produce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Materials)).EndInit();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
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
        private System.Windows.Forms.DataGridView dGridView_Produce;
        private System.Windows.Forms.DataGridView dGridView_Materials;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.TextBox edtQtProduce;
        private System.Windows.Forms.Label lblListRecipe;
        private System.Windows.Forms.Label lblQtProduce;
        private System.Windows.Forms.ComboBox cmbRecipes;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.MaskedTextBox mskedtSellDate;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.Label lblSellDate;
        private System.Windows.Forms.TextBox edtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.PictureBox imgButton_Save;
        private System.Windows.Forms.PictureBox imgButton_Update;
        private System.Windows.Forms.PictureBox imgButton_Add;
        private System.Windows.Forms.PictureBox imgButton_Delete;
        private System.Windows.Forms.PictureBox imgButton_Cancel;
        private System.Windows.Forms.PictureBox imgButton_Refresh;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox edtProduct;
    }
}