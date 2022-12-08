using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmFrutas : Form
    {
        public frmFrutas()
        {
            InitializeComponent();
        }

        private void btnSelcionar_Click(object sender, EventArgs e)
        {
            int operador;
            string frutas = "";

            operador = int.Parse(txtSelecione.Text);

            switch (operador)
            {
                case 1:
                    frutas = "Banana";
                    break;

                case 2:
                    frutas = "Maça";
                    break;
                case 3:
                    frutas = "Pera";
                    break;
                case 4:
                    frutas = "Melancia";
                    break;
                default:
                    frutas = "Nenhuma fruta selecionada.";
                    break;
            }
            txtFrutaSelecionada.Text = frutas;

            //txtFrutaSelecionada.Text = "";
            //txtFrutaSelecionada.Focus();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //executar o método criado
            limparCampos();
        }
        //criar o método para limpar os componentes
        public void limparCampos()
        {
            txtFrutaSelecionada.Clear();
            txtSelecione.Text = "";
            ltbFrutas.Items.Clear();
            cbbFrutasListadas.Items.Clear();
            cbbFrutasListadas.Text = "";

            txtSelecione.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ltbFrutas.Items.Clear();
            cbbFrutasListadas.Items.Clear();
            ltbFrutas.Items.Add(txtFrutaSelecionada.Text);
            cbbFrutasListadas.Items.Add(txtFrutaSelecionada.Text);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //formas de sair
            //Close();
            //this.Close();

            DialogResult res;

            res = MessageBox.Show("Deseja sair?",
                "Mensagem do Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                limparCampos();
            }


        }

        private void txtSelecione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelcionar.Focus();
            }
        }
    }
}
