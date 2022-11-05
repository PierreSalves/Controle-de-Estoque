namespace ProjetoWinform
{
    partial class frmCadastroReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroReceita));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.edtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.edtQtProduce = new System.Windows.Forms.TextBox();
            this.lblQtProduce = new System.Windows.Forms.Label();
            this.edtDesc = new System.Windows.Forms.TextBox();
            this.lblIDProduct = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.imgButton_Save = new System.Windows.Forms.PictureBox();
            this.imgButton_Update = new System.Windows.Forms.PictureBox();
            this.imgButton_Add = new System.Windows.Forms.PictureBox();
            this.imgButton_Delete = new System.Windows.Forms.PictureBox();
            this.imgButton_Cancel = new System.Windows.Forms.PictureBox();
            this.imgButton_Refresh = new System.Windows.Forms.PictureBox();
            this.dGridView_Receitas = new System.Windows.Forms.DataGridView();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblQtMaterial = new System.Windows.Forms.Label();
            this.edtQtMaterial = new System.Windows.Forms.TextBox();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblListMaterial = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnEditMaterial = new System.Windows.Forms.Button();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.dGridView_Materials = new System.Windows.Forms.DataGridView();
            this.pnlSuperior.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Receitas)).BeginInit();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Materials)).BeginInit();
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
            this.lblSuperior.Location = new System.Drawing.Point(202, 0);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(398, 41);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "CADASTRO DE RECEITAS";
            // 
            // edtID
            // 
            this.edtID.Enabled = false;
            this.edtID.Location = new System.Drawing.Point(66, 57);
            this.edtID.Name = "edtID";
            this.edtID.ReadOnly = true;
            this.edtID.Size = new System.Drawing.Size(36, 20);
            this.edtID.TabIndex = 209;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 60);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 13);
            this.lblID.TabIndex = 210;
            this.lblID.Text = "ID";
            // 
            // edtQtProduce
            // 
            this.edtQtProduce.Location = new System.Drawing.Point(415, 95);
            this.edtQtProduce.Name = "edtQtProduce";
            this.edtQtProduce.Size = new System.Drawing.Size(86, 20);
            this.edtQtProduce.TabIndex = 208;
            // 
            // lblQtProduce
            // 
            this.lblQtProduce.AutoSize = true;
            this.lblQtProduce.BackColor = System.Drawing.Color.Transparent;
            this.lblQtProduce.Location = new System.Drawing.Point(270, 98);
            this.lblQtProduce.Name = "lblQtProduce";
            this.lblQtProduce.Size = new System.Drawing.Size(127, 13);
            this.lblQtProduce.TabIndex = 206;
            this.lblQtProduce.Text = "Quantidade Produzida";
            // 
            // edtDesc
            // 
            this.edtDesc.Location = new System.Drawing.Point(175, 57);
            this.edtDesc.Name = "edtDesc";
            this.edtDesc.Size = new System.Drawing.Size(584, 20);
            this.edtDesc.TabIndex = 203;
            // 
            // lblIDProduct
            // 
            this.lblIDProduct.AutoSize = true;
            this.lblIDProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblIDProduct.ForeColor = System.Drawing.Color.Black;
            this.lblIDProduct.Location = new System.Drawing.Point(41, 98);
            this.lblIDProduct.Name = "lblIDProduct";
            this.lblIDProduct.Size = new System.Drawing.Size(49, 13);
            this.lblIDProduct.TabIndex = 205;
            this.lblIDProduct.Text = "Produto";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(108, 60);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(61, 13);
            this.lblDesc.TabIndex = 204;
            this.lblDesc.Text = "Descrição";
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
            this.pnlInferior.TabIndex = 211;
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
            // dGridView_Receitas
            // 
            this.dGridView_Receitas.AllowUserToAddRows = false;
            this.dGridView_Receitas.AllowUserToDeleteRows = false;
            this.dGridView_Receitas.AllowUserToResizeColumns = false;
            this.dGridView_Receitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridView_Receitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridView_Receitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridView_Receitas.BackgroundColor = System.Drawing.Color.LightGray;
            this.dGridView_Receitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Receitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGridView_Receitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Receitas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView_Receitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGridView_Receitas.EnableHeadersVisualStyles = false;
            this.dGridView_Receitas.GridColor = System.Drawing.SystemColors.GrayText;
            this.dGridView_Receitas.Location = new System.Drawing.Point(44, 244);
            this.dGridView_Receitas.MultiSelect = false;
            this.dGridView_Receitas.Name = "dGridView_Receitas";
            this.dGridView_Receitas.ReadOnly = true;
            this.dGridView_Receitas.RowHeadersVisible = false;
            this.dGridView_Receitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridView_Receitas.RowTemplate.ReadOnly = true;
            this.dGridView_Receitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Receitas.Size = new System.Drawing.Size(715, 150);
            this.dGridView_Receitas.TabIndex = 212;
            this.dGridView_Receitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_Receitas_CellContentClick);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(96, 95);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(165, 21);
            this.cmbProduct.TabIndex = 213;
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(79, 20);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.Size = new System.Drawing.Size(165, 21);
            this.cmbMaterials.TabIndex = 216;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(18, 23);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(55, 13);
            this.lblMaterial.TabIndex = 217;
            this.lblMaterial.Text = "Material";
            // 
            // lblQtMaterial
            // 
            this.lblQtMaterial.AutoSize = true;
            this.lblQtMaterial.Location = new System.Drawing.Point(250, 23);
            this.lblQtMaterial.Name = "lblQtMaterial";
            this.lblQtMaterial.Size = new System.Drawing.Size(139, 13);
            this.lblQtMaterial.TabIndex = 218;
            this.lblQtMaterial.Text = "Quantidade de Material";
            // 
            // edtQtMaterial
            // 
            this.edtQtMaterial.Location = new System.Drawing.Point(395, 20);
            this.edtQtMaterial.Name = "edtQtMaterial";
            this.edtQtMaterial.Size = new System.Drawing.Size(37, 20);
            this.edtQtMaterial.TabIndex = 219;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro.Controls.Add(this.edtQtMaterial);
            this.pnlCentro.Controls.Add(this.lblListMaterial);
            this.pnlCentro.Controls.Add(this.lblQtMaterial);
            this.pnlCentro.Controls.Add(this.btnDelete);
            this.pnlCentro.Controls.Add(this.cmbMaterials);
            this.pnlCentro.Controls.Add(this.lblMaterial);
            this.pnlCentro.Controls.Add(this.btnCancel);
            this.pnlCentro.Controls.Add(this.btnOK);
            this.pnlCentro.Controls.Add(this.btnEditMaterial);
            this.pnlCentro.Controls.Add(this.btnAddMaterial);
            this.pnlCentro.Location = new System.Drawing.Point(44, 133);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(457, 96);
            this.pnlCentro.TabIndex = 220;
            // 
            // lblListMaterial
            // 
            this.lblListMaterial.AutoSize = true;
            this.lblListMaterial.Location = new System.Drawing.Point(3, 4);
            this.lblListMaterial.Name = "lblListMaterial";
            this.lblListMaterial.Size = new System.Drawing.Size(115, 13);
            this.lblListMaterial.TabIndex = 5;
            this.lblListMaterial.Text = "Lista de Materiais";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(183, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remover";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(357, 55);
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
            this.btnOK.Location = new System.Drawing.Point(276, 55);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnEditMaterial
            // 
            this.btnEditMaterial.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMaterial.Location = new System.Drawing.Point(102, 55);
            this.btnEditMaterial.Name = "btnEditMaterial";
            this.btnEditMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnEditMaterial.TabIndex = 1;
            this.btnEditMaterial.Text = "Editar";
            this.btnEditMaterial.UseVisualStyleBackColor = false;
            this.btnEditMaterial.Click += new System.EventHandler(this.btnEditMaterial_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMaterial.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaterial.Location = new System.Drawing.Point(21, 55);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAddMaterial.TabIndex = 0;
            this.btnAddMaterial.Text = "Adicionar";
            this.btnAddMaterial.UseVisualStyleBackColor = false;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Materials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dGridView_Materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Materials.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView_Materials.DefaultCellStyle = dataGridViewCellStyle5;
            this.dGridView_Materials.GridColor = System.Drawing.SystemColors.WindowText;
            this.dGridView_Materials.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dGridView_Materials.Location = new System.Drawing.Point(519, 95);
            this.dGridView_Materials.MultiSelect = false;
            this.dGridView_Materials.Name = "dGridView_Materials";
            this.dGridView_Materials.ReadOnly = true;
            this.dGridView_Materials.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Materials.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dGridView_Materials.RowHeadersVisible = false;
            this.dGridView_Materials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGridView_Materials.RowTemplate.ReadOnly = true;
            this.dGridView_Materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Materials.Size = new System.Drawing.Size(240, 134);
            this.dGridView_Materials.TabIndex = 221;
            this.dGridView_Materials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_Materials_CellContentClick);
            // 
            // frmCadastroReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGridView_Materials);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.dGridView_Receitas);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.edtQtProduce);
            this.Controls.Add(this.lblQtProduce);
            this.Controls.Add(this.edtDesc);
            this.Controls.Add(this.lblIDProduct);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlCentro);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCadastroReceita_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Receitas)).EndInit();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Materials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox edtQtProduce;
        private System.Windows.Forms.Label lblQtProduce;
        private System.Windows.Forms.TextBox edtDesc;
        private System.Windows.Forms.Label lblIDProduct;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.PictureBox imgButton_Save;
        private System.Windows.Forms.PictureBox imgButton_Update;
        private System.Windows.Forms.PictureBox imgButton_Add;
        private System.Windows.Forms.PictureBox imgButton_Delete;
        private System.Windows.Forms.PictureBox imgButton_Cancel;
        private System.Windows.Forms.PictureBox imgButton_Refresh;
        private System.Windows.Forms.DataGridView dGridView_Receitas;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbMaterials;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblQtMaterial;
        private System.Windows.Forms.TextBox edtQtMaterial;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnEditMaterial;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Label lblListMaterial;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dGridView_Materials;
    }
}