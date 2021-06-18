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
    public partial class Empresa_Selecionada : Form
    {
        public Empresa_Selecionada()
        {
            InitializeComponent();
        }

        private void Empresa_Selecionada_Load(object sender, EventArgs e)
        {
            dynamic EmpresaInfo = Empresa.getEmpresaInfo(Empresa.iD);
            txtNome.Text = EmpresaInfo.nome;
            txtContacto.Text = EmpresaInfo.contacto;
            txtMorada.Text = EmpresaInfo.morada;
            txtID.Text = Empresa.iD.ToString();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (DbFunctions.is2x("Nome", "Empresas", txtNome.Text))
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

            MessageBox.Show("Empresa alterada com sucesso!\nClique no botão do refresh!");
            Empresa.update(txtNome.Text, txtMorada.Text, txtContacto.Text, Int32.Parse(txtID.Text));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
