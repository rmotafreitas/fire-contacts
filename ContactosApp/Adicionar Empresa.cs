using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactosApp
{
    public partial class Adicionar_Empresa : Form
    {
        public Adicionar_Empresa()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (DbFunctions.is1x("Nome", "Empresas", txtNome.Text))
            {
                MessageBox.Show("Já existe uma empresa com esse nome!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            
            if (!((int.TryParse(txtContacto.Text, out _)) && (txtContacto.Text.Length == 9)))
            {
                MessageBox.Show("Não inseriu um telefone valido para a empresa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContacto.Focus();
                return;
            }
            if (txtMorada.Text == "")
            {
                MessageBox.Show("Não inseriu uma morada para a empresa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMorada.Focus();
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Não inseriu um nome para a empresa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }


            Empresa.add(txtNome.Text, txtMorada.Text, txtContacto.Text);
            MessageBox.Show("Adiciona com sucesso!\nClique no botão de refresh");
            this.Close();
        }

    }
}
