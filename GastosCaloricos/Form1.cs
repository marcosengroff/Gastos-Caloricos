using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastosCaloricos
{
    public partial class frmCalorias : Form
    {
        public frmCalorias()
        {
            InitializeComponent();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbAtiv. SelectedText.Equals(-1))
            {
                MessageBox.Show("Insira uma opção válida de atividade física!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGasto.Clear();
                cmbAtiv.Focus();
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Insira seu peso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGasto.Clear();
                txtPeso.Focus();
            }
            else if (Convert.ToInt32(txtPeso.Text) < 1 || Convert.ToInt32(txtPeso.Text) > 200 )
            {
                MessageBox.Show("Peso deve ser maior que 1 e menor que 200", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGasto.Clear();
                txtPeso.Focus();
            }

            else
            {
                switch(cmbAtiv.SelectedItem)
                {
                    case "Alongamento":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 2);
                        break;

                    case "Bicicleta":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 7);
                        break;

                    case "Boliche":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 3);
                        break;

                    case "Caminhada":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 3.5m);
                        break;

                    case "Corrida":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 5);
                        break;

                    case "Dança":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 5.5m); ;
                        break;

                    case "Natação":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 6);
                        break;

                    case "Patins":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 7);
                        break;

                    case "Ping Pong":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 4);
                        break;

                    case "Squash":
                        txtGasto.Text = Convert.ToString(Convert.ToDecimal(txtPeso.Text) * Convert.ToDecimal(nudDuracao.Value) * 12);
                        break;

                        default:
                        MessageBox.Show("Escolha...");
                        break;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbAtiv.ResetText();
            txtPeso.Clear();
            nudDuracao.Value = 1;
            txtGasto.Clear();
            cmbAtiv.Focus();
        }

        private void cmbAtiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGasto.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
