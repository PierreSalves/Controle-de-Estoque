namespace ProjetoWinform
{
    partial class frmCadastroUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSenha = new System.Windows.Forms.Label();
            this.edtSenha = new System.Windows.Forms.TextBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.edtID = new System.Windows.Forms.TextBox();
            this.edtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfimaSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.imgButton_Save = new System.Windows.Forms.PictureBox();
            this.imgButton_Update = new System.Windows.Forms.PictureBox();
            this.imgButton_Add = new System.Windows.Forms.PictureBox();
            this.imgButton_Delete = new System.Windows.Forms.PictureBox();
            this.imgButton_Cancel = new System.Windows.Forms.PictureBox();
            this.imgButton_Refresh = new System.Windows.Forms.PictureBox();
            this.dGridView_Users = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlSuperior.SuspendLayout();
            this.pnlInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(191, 95);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 13);
            this.lblSenha.TabIndex = 300;
            this.lblSenha.Text = "Senha ";
            // 
            // edtSenha
            // 
            this.edtSenha.Enabled = false;
            this.edtSenha.Location = new System.Drawing.Point(234, 92);
            this.edtSenha.Name = "edtSenha";
            this.edtSenha.Size = new System.Drawing.Size(159, 20);
            this.edtSenha.TabIndex = 4;
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
            this.pnlSuperior.TabIndex = 340;
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
            this.lblSuperior.Text = "CADASTRO DE USUARIOS";
            // 
            // edtID
            // 
            this.edtID.Enabled = false;
            this.edtID.Location = new System.Drawing.Point(66, 58);
            this.edtID.Name = "edtID";
            this.edtID.ReadOnly = true;
            this.edtID.Size = new System.Drawing.Size(36, 20);
            this.edtID.TabIndex = 1;
            // 
            // edtConfirmarSenha
            // 
            this.edtConfirmarSenha.Enabled = false;
            this.edtConfirmarSenha.Location = new System.Drawing.Point(496, 92);
            this.edtConfirmarSenha.Name = "edtConfirmarSenha";
            this.edtConfirmarSenha.Size = new System.Drawing.Size(159, 20);
            this.edtConfirmarSenha.TabIndex = 5;
            // 
            // edtEmail
            // 
            this.edtEmail.Enabled = false;
            this.edtEmail.Location = new System.Drawing.Point(442, 58);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(213, 20);
            this.edtEmail.TabIndex = 3;
            // 
            // edtNome
            // 
            this.edtNome.Enabled = false;
            this.edtNome.Location = new System.Drawing.Point(148, 58);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(245, 20);
            this.edtNome.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(399, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 230;
            this.lblEmail.Text = "Email";
            // 
            // lblConfimaSenha
            // 
            this.lblConfimaSenha.AutoSize = true;
            this.lblConfimaSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblConfimaSenha.Location = new System.Drawing.Point(399, 95);
            this.lblConfimaSenha.Name = "lblConfimaSenha";
            this.lblConfimaSenha.Size = new System.Drawing.Size(97, 13);
            this.lblConfimaSenha.TabIndex = 220;
            this.lblConfimaSenha.Text = "Confirmar Senha";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(111, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(31, 13);
            this.lblNome.TabIndex = 210;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 200;
            this.label1.Text = "ID";
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
            this.pnlInferior.TabIndex = 8;
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
            // dGridView_Users
            // 
            this.dGridView_Users.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridView_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridView_Users.BackgroundColor = System.Drawing.Color.LightGray;
            this.dGridView_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridView_Users.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGridView_Users.GridColor = System.Drawing.SystemColors.GrayText;
            this.dGridView_Users.Location = new System.Drawing.Point(44, 131);
            this.dGridView_Users.MultiSelect = false;
            this.dGridView_Users.Name = "dGridView_Users";
            this.dGridView_Users.ReadOnly = true;
            this.dGridView_Users.RowHeadersVisible = false;
            this.dGridView_Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGridView_Users.RowTemplate.ReadOnly = true;
            this.dGridView_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Users.Size = new System.Drawing.Size(744, 260);
            this.dGridView_Users.TabIndex = 6;
            this.dGridView_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridView_Users_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "adm",
            "user1",
            "user2"});
            this.comboBox1.Location = new System.Drawing.Point(667, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Nivel de Usuário";
            // 
            // frmCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dGridView_Users);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.edtID);
            this.Controls.Add(this.edtConfirmarSenha);
            this.Controls.Add(this.edtEmail);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblConfimaSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtSenha);
            this.Controls.Add(this.lblSenha);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroUser";
            this.Text = "ProjetoLoja";
            this.Load += new System.EventHandler(this.frmCadastroUser_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgButton_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox edtSenha;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.TextBox edtID;
        private System.Windows.Forms.TextBox edtConfirmarSenha;
        private System.Windows.Forms.TextBox edtEmail;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConfimaSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.PictureBox imgButton_Save;
        private System.Windows.Forms.PictureBox imgButton_Update;
        private System.Windows.Forms.PictureBox imgButton_Add;
        private System.Windows.Forms.PictureBox imgButton_Delete;
        private System.Windows.Forms.PictureBox imgButton_Cancel;
        private System.Windows.Forms.PictureBox imgButton_Refresh;
        private System.Windows.Forms.DataGridView dGridView_Users;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}