using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmOrcamentoCusto
{
    public partial class FrmOrcamentoCusto : Form
    {
        public FrmOrcamentoCusto()
        {
            InitializeComponent();
        }
        public void SelecionarEmpresa()
        {
            FrmSelecionarEmpresa selecionar = new FrmSelecionarEmpresa();
            selecionar.ShowDialog();

            txtCodigoEmpresa.Text = selecionar.CodEmpresa;
            txtEmpresa.Text = selecionar.Empresa;
            txtAnoOrcamento.Text = selecionar.AnoOrcamento;
            txtVersao.Text = selecionar.Versao;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionarEmpresa_Click(object sender, EventArgs e)
        {
            SelecionarEmpresa();
        }
    }
}
