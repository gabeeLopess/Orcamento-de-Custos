using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmOrcamentoCusto
{
    public partial class FrmSelecionarEmpresa : Form
    {
        public string CodEmpresa { get; private set; }
        public string Empresa { get; private set; }
        public string AnoOrcamento { get; private set; }
        public string Versao { get; private set; }
        public string devolucao { get; private set; }
        public FrmSelecionarEmpresa()
        {
            InitializeComponent();
        }

        private void CarregarEmpresasGrid()
        {
            gridLayout.Rows.Clear();    
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                SelecionarEmpresaDAO dao = new SelecionarEmpresaDAO(connection);
                List<OrcamentoCustoModel> empresas = dao.GetEmpresas();
                foreach(OrcamentoCustoModel empresa in empresas)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];
                    row.Cells[colCodEmpresa.Index].Value = empresa.CodEmpresa;
                    row.Cells[colEmpresa.Index].Value = empresa.Empresa;
                    row.Cells[colAnoOrcamento.Index].Value = empresa.AnoOrcamento;
                    row.Cells[colVersao.Index].Value = empresa.Versao;

                }
            }
        }

        private void FrmSelecionarEmpresa_Load(object sender, EventArgs e)
        {
            CarregarEmpresasGrid();
        }

        public void Fechar()
        {
            CodEmpresa = txtCodigoEmpresa.Text;
            Empresa = txtEmpresa.Text;
            AnoOrcamento = txtAnoOrcamento.Text;
            Versao = txtVersao.Text;
            this.Close();
        }

 
        private void txtCodigoEmpresa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtCodigoEmpresa.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string codEmpresa = row.Cells[colCodEmpresa.Index].Value.ToString().Trim();
                bool exibir = codEmpresa.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtEmpresa.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string empresa = row.Cells[colEmpresa.Index].Value.ToString().Trim();
                bool exibir = empresa.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtAnoOrcamento_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtAnoOrcamento.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string anoOrcamento = row.Cells[colAnoOrcamento.Index].Value.ToString().Trim();
                bool exibir = anoOrcamento.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    

        private void txtVersao_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtVersao.Text.Trim();

            foreach (DataGridViewRow row in gridLayout.Rows)
            {
                string versao = row.Cells[colVersao.Index].Value.ToString().Trim();
                bool exibir = versao.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void gridLayout_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigoEmpresa.Text = gridLayout.Rows[e.RowIndex].Cells[colCodEmpresa.Index].Value + "";
                txtEmpresa.Text = gridLayout.Rows[e.RowIndex].Cells[colEmpresa.Index].Value + "";
                txtAnoOrcamento.Text = gridLayout.Rows[e.RowIndex].Cells[colAnoOrcamento.Index].Value + "";
                txtVersao.Text = gridLayout.Rows[e.RowIndex].Cells[colVersao.Index].Value + "";
                Fechar();
            }
        }
    }
}
