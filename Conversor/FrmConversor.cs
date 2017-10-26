using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Conversor
{
    public partial class FrmConversor : Form
    { 
        public FrmConversor()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            ConverterAlgarismo();
        }

        private void ConverterAlgarismo()
        {
            try
            {
                txtResultado.Text = string.Empty;

                if (!string.IsNullOrWhiteSpace(txtNumero.Text))
                    txtResultado.Text = Algarismo.Converter(txtNumero.Text);

                if (string.IsNullOrWhiteSpace(txtResultado.Text))
                    MessageBox.Show("Falha ao identificar o algarismo!");
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            try
            {
                txtNumero.Text = txtNumero.Text.ToUpper();
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        private void tabConsulta_Enter(object sender, EventArgs e)
        {
            try
            {
                if (Persistencia.Banco.Count.Equals(0))
                {
                    MessageBox.Show("Não há itens a serem exibidos!");
                    tbcConversor.SelectedTab = tabConverter;
                    return;
                }

                txtNumeroPesquisar.Text = string.Empty;
                txtResultadoConsulta.Text = string.Empty;

                dgvNumerosConvertidos.Rows.Clear();

                foreach (KeyValuePair<int, string> item in Persistencia.Banco)
                {
                    dgvNumerosConvertidos.Rows.Add(Convert.ToString(item.Key), item.Value);
                }

            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultadoConsulta.Text = string.Empty;

                if (AlgarismoArabico.ValidarStringParaConversao(txtNumeroPesquisar.Text))
                    txtResultadoConsulta.Text = Persistencia.PesquisarAlgarismoRomanoPeloArabico(Convert.ToInt32(txtNumeroPesquisar.Text));

                if (AlgarismoRomano.ValidarStringParaConversao(txtNumeroPesquisar.Text))
                    txtResultadoConsulta.Text = Persistencia.PesquisarAlgarismoArabicoPeloRomano(txtNumeroPesquisar.Text);

                if (string.IsNullOrWhiteSpace(txtResultadoConsulta.Text))
                    MessageBox.Show("Algarismo ainda não convertido");
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }

        private void txtNumeroPesquisar_Leave(object sender, EventArgs e)
        {
            try
            {
                txtNumeroPesquisar.Text = txtNumeroPesquisar.Text.ToUpper();
            }
            catch (Exception excecao)
            {
                throw excecao;
            }
        }
    }
}
