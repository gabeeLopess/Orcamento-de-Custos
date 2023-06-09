namespace FrmOrcamentoCusto
{
    partial class FrmOrcamentoCusto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrcamentoCusto));
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblAnoOrcamento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnoOrcamento = new System.Windows.Forms.TextBox();
            this.btnSelecionarEmpresa = new System.Windows.Forms.Button();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCodigoEmpresa = new System.Windows.Forms.Label();
            this.txtCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnocultarColunaVenda = new System.Windows.Forms.RadioButton();
            this.btnOcultarColunaCusto = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(429, 8);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(267, 20);
            this.txtEmpresa.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(353, 11);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblAnoOrcamento
            // 
            this.lblAnoOrcamento.AutoSize = true;
            this.lblAnoOrcamento.Location = new System.Drawing.Point(342, 37);
            this.lblAnoOrcamento.Name = "lblAnoOrcamento";
            this.lblAnoOrcamento.Size = new System.Drawing.Size(81, 13);
            this.lblAnoOrcamento.TabIndex = 2;
            this.lblAnoOrcamento.Text = "Ano Orçamento";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOcultarColunaCusto);
            this.groupBox1.Controls.Add(this.btnocultarColunaVenda);
            this.groupBox1.Controls.Add(this.lblCodigoEmpresa);
            this.groupBox1.Controls.Add(this.txtCodigoEmpresa);
            this.groupBox1.Controls.Add(this.lblVersao);
            this.groupBox1.Controls.Add(this.txtVersao);
            this.groupBox1.Controls.Add(this.btnSelecionarEmpresa);
            this.groupBox1.Controls.Add(this.txtAnoOrcamento);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.lblAnoOrcamento);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(0, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtAnoOrcamento
            // 
            this.txtAnoOrcamento.Location = new System.Drawing.Point(81, 34);
            this.txtAnoOrcamento.Name = "txtAnoOrcamento";
            this.txtAnoOrcamento.Size = new System.Drawing.Size(257, 20);
            this.txtAnoOrcamento.TabIndex = 3;
            // 
            // btnSelecionarEmpresa
            // 
            this.btnSelecionarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarEmpresa.Image")));
            this.btnSelecionarEmpresa.Location = new System.Drawing.Point(702, 8);
            this.btnSelecionarEmpresa.Name = "btnSelecionarEmpresa";
            this.btnSelecionarEmpresa.Size = new System.Drawing.Size(42, 21);
            this.btnSelecionarEmpresa.TabIndex = 4;
            this.btnSelecionarEmpresa.UseVisualStyleBackColor = true;
            this.btnSelecionarEmpresa.Click += new System.EventHandler(this.btnSelecionarEmpresa_Click);
            // 
            // txtVersao
            // 
            this.txtVersao.Location = new System.Drawing.Point(429, 34);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(267, 20);
            this.txtVersao.TabIndex = 5;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(22, 37);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 6;
            this.lblVersao.Text = "Versão";
            // 
            // lblCodigoEmpresa
            // 
            this.lblCodigoEmpresa.AutoSize = true;
            this.lblCodigoEmpresa.Location = new System.Drawing.Point(5, 11);
            this.lblCodigoEmpresa.Name = "lblCodigoEmpresa";
            this.lblCodigoEmpresa.Size = new System.Drawing.Size(70, 13);
            this.lblCodigoEmpresa.TabIndex = 8;
            this.lblCodigoEmpresa.Text = "Cod Empresa";
            // 
            // txtCodigoEmpresa
            // 
            this.txtCodigoEmpresa.Location = new System.Drawing.Point(81, 8);
            this.txtCodigoEmpresa.Name = "txtCodigoEmpresa";
            this.txtCodigoEmpresa.Size = new System.Drawing.Size(257, 20);
            this.txtCodigoEmpresa.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 305);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnocultarColunaVenda
            // 
            this.btnocultarColunaVenda.AutoSize = true;
            this.btnocultarColunaVenda.Location = new System.Drawing.Point(480, 106);
            this.btnocultarColunaVenda.Name = "btnocultarColunaVenda";
            this.btnocultarColunaVenda.Size = new System.Drawing.Size(129, 17);
            this.btnocultarColunaVenda.TabIndex = 9;
            this.btnocultarColunaVenda.TabStop = true;
            this.btnocultarColunaVenda.Text = "Ocultar Coluna Venda";
            this.btnocultarColunaVenda.UseVisualStyleBackColor = true;
            // 
            // btnOcultarColunaCusto
            // 
            this.btnOcultarColunaCusto.AutoSize = true;
            this.btnOcultarColunaCusto.Location = new System.Drawing.Point(480, 135);
            this.btnOcultarColunaCusto.Name = "btnOcultarColunaCusto";
            this.btnOcultarColunaCusto.Size = new System.Drawing.Size(125, 17);
            this.btnOcultarColunaCusto.TabIndex = 10;
            this.btnOcultarColunaCusto.TabStop = true;
            this.btnOcultarColunaCusto.Text = "Ocultar Coluna Custo";
            this.btnOcultarColunaCusto.UseVisualStyleBackColor = true;
            // 
            // FrmOrcamentoCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrcamentoCusto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento de Custo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblAnoOrcamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.Button btnSelecionarEmpresa;
        private System.Windows.Forms.TextBox txtAnoOrcamento;
        private System.Windows.Forms.Label lblCodigoEmpresa;
        private System.Windows.Forms.TextBox txtCodigoEmpresa;
        private System.Windows.Forms.RadioButton btnocultarColunaVenda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton btnOcultarColunaCusto;
    }
}

