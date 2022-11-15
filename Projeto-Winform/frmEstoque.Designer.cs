namespace ProjetoWinform
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.dGridView_Estoque = new System.Windows.Forms.DataGridView();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblListRecipe = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Estoque)).BeginInit();
            this.pnlCentro.SuspendLayout();
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
            this.pnlSuperior.TabIndex = 58;
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSuperior.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(324, 0);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(151, 41);
            this.lblSuperior.TabIndex = 0;
            this.lblSuperior.Text = "ESTOQUE";
            this.lblSuperior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGridView_Estoque
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridView_Estoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridView_Estoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridView_Estoque.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Estoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGridView_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridView_Estoque.GridColor = System.Drawing.SystemColors.Control;
            this.dGridView_Estoque.Location = new System.Drawing.Point(12, 131);
            this.dGridView_Estoque.MultiSelect = false;
            this.dGridView_Estoque.Name = "dGridView_Estoque";
            this.dGridView_Estoque.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGridView_Estoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGridView_Estoque.RowHeadersVisible = false;
            this.dGridView_Estoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGridView_Estoque.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGridView_Estoque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridView_Estoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridView_Estoque.Size = new System.Drawing.Size(776, 307);
            this.dGridView_Estoque.TabIndex = 59;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCentro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentro.Controls.Add(this.lblListRecipe);
            this.pnlCentro.Controls.Add(this.cmbFilter);
            this.pnlCentro.Controls.Add(this.lblFilter);
            this.pnlCentro.Location = new System.Drawing.Point(12, 65);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(776, 60);
            this.pnlCentro.TabIndex = 243;
            // 
            // lblListRecipe
            // 
            this.lblListRecipe.AutoSize = true;
            this.lblListRecipe.Location = new System.Drawing.Point(3, 0);
            this.lblListRecipe.Name = "lblListRecipe";
            this.lblListRecipe.Size = new System.Drawing.Size(55, 13);
            this.lblListRecipe.TabIndex = 5;
            this.lblListRecipe.Text = "Pesquisa";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(73, 20);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(672, 21);
            this.cmbFilter.TabIndex = 216;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(18, 23);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(43, 13);
            this.lblFilter.TabIndex = 217;
            this.lblFilter.Text = "Filtro";
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.dGridView_Estoque);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridView_Estoque)).EndInit();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.DataGridView dGridView_Estoque;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblListRecipe;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label lblFilter;
    }
}