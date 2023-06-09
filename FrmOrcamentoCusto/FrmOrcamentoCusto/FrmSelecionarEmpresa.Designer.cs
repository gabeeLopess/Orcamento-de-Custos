namespace FrmOrcamentoCusto
{
    partial class FrmSelecionarEmpresa
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
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.txtAnoOrcamento = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblAnoOrcamento = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.colCodEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnoOrcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVersao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigoEmpresa = new System.Windows.Forms.Label();
            this.txtCodigoEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(87, 35);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(447, 20);
            this.txtEmpresa.TabIndex = 0;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.txtEmpresa_TextChanged);
            // 
            // txtVersao
            // 
            this.txtVersao.Location = new System.Drawing.Point(87, 93);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(447, 20);
            this.txtVersao.TabIndex = 1;
            this.txtVersao.TextChanged += new System.EventHandler(this.txtVersao_TextChanged);
            // 
            // txtAnoOrcamento
            // 
            this.txtAnoOrcamento.Location = new System.Drawing.Point(87, 64);
            this.txtAnoOrcamento.Name = "txtAnoOrcamento";
            this.txtAnoOrcamento.Size = new System.Drawing.Size(447, 20);
            this.txtAnoOrcamento.TabIndex = 2;
            this.txtAnoOrcamento.TextChanged += new System.EventHandler(this.txtAnoOrcamento_TextChanged);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(4, 38);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 3;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblAnoOrcamento
            // 
            this.lblAnoOrcamento.AutoSize = true;
            this.lblAnoOrcamento.Location = new System.Drawing.Point(0, 71);
            this.lblAnoOrcamento.Name = "lblAnoOrcamento";
            this.lblAnoOrcamento.Size = new System.Drawing.Size(81, 13);
            this.lblAnoOrcamento.TabIndex = 4;
            this.lblAnoOrcamento.Text = "Ano Orçamento";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(4, 100);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 5;
            this.lblVersao.Text = "Versão";
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEmpresa,
            this.colEmpresa,
            this.colAnoOrcamento,
            this.colVersao});
            this.gridLayout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLayout.Location = new System.Drawing.Point(7, 131);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.Size = new System.Drawing.Size(527, 263);
            this.gridLayout.TabIndex = 6;
            this.gridLayout.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLayout_CellMouseDoubleClick);
            // 
            // colCodEmpresa
            // 
            this.colCodEmpresa.HeaderText = "Código Empresa";
            this.colCodEmpresa.Name = "colCodEmpresa";
            this.colCodEmpresa.ReadOnly = true;
            // 
            // colEmpresa
            // 
            this.colEmpresa.HeaderText = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.ReadOnly = true;
            // 
            // colAnoOrcamento
            // 
            this.colAnoOrcamento.HeaderText = "Ano Orçamento";
            this.colAnoOrcamento.Name = "colAnoOrcamento";
            this.colAnoOrcamento.ReadOnly = true;
            // 
            // colVersao
            // 
            this.colVersao.HeaderText = "Versão";
            this.colVersao.Name = "colVersao";
            this.colVersao.ReadOnly = true;
            // 
            // lblCodigoEmpresa
            // 
            this.lblCodigoEmpresa.AutoSize = true;
            this.lblCodigoEmpresa.Location = new System.Drawing.Point(4, 13);
            this.lblCodigoEmpresa.Name = "lblCodigoEmpresa";
            this.lblCodigoEmpresa.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoEmpresa.TabIndex = 7;
            this.lblCodigoEmpresa.Text = "Codigo Empresa";
            // 
            // txtCodigoEmpresa
            // 
            this.txtCodigoEmpresa.Location = new System.Drawing.Point(87, 6);
            this.txtCodigoEmpresa.Name = "txtCodigoEmpresa";
            this.txtCodigoEmpresa.Size = new System.Drawing.Size(206, 20);
            this.txtCodigoEmpresa.TabIndex = 8;
            this.txtCodigoEmpresa.TextChanged += new System.EventHandler(this.txtCodigoEmpresa_TextChanged);
            // 
            // FrmSelecionarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 396);
            this.Controls.Add(this.txtCodigoEmpresa);
            this.Controls.Add(this.lblCodigoEmpresa);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblAnoOrcamento);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtAnoOrcamento);
            this.Controls.Add(this.txtVersao);
            this.Controls.Add(this.txtEmpresa);
            this.Name = "FrmSelecionarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Empresa";
            this.Load += new System.EventHandler(this.FrmSelecionarEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.TextBox txtAnoOrcamento;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblAnoOrcamento;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnoOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVersao;
        private System.Windows.Forms.Label lblCodigoEmpresa;
        private System.Windows.Forms.TextBox txtCodigoEmpresa;
    }
}