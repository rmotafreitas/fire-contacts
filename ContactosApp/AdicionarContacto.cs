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
    public partial class AdicionarContacto : Form
    {
        public AdicionarContacto()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarContacto_Load(object sender, EventArgs e)
        {
            string[] ids = DbFunctions.getAllIDs("ID", "Empresas");

            for (int i = 0; i < ids.Length; i++)
            {
                dynamic EmpresaInfo = Empresa.getEmpresaInfo(Int32.Parse(ids[i]));
                string nome = EmpresaInfo.nome;
                comboEmpresa.Items.Add(nome);
               
            }
        }

        public string getIDofSlected()
        {
            if (comboEmpresa.SelectedIndex == 0) return "0";
            string id = "";
            string NomeEmpresa = "";
            try
            {
                NomeEmpresa = comboEmpresa.Items[comboEmpresa.SelectedIndex].ToString();
            }
            catch { }
            string[] ids = DbFunctions.getAllIDs("ID", "Empresas");
            for (int i = 0; i < ids.Length; i++)
            {
                if (Empresa.getEmpresaInfo(Int32.Parse(ids[i])).nome == NomeEmpresa)
                    id = ids[i];
            }
            return id;
        }


        private void btnAddContacto_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") 
            {
                MessageBox.Show("Não inseriu um nome para o contacto!", "Erro!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            if (!((int.TryParse(txtTelefone.Text, out _)) && (txtTelefone.Text.Length == 9)))
            {
                MessageBox.Show("Não inseriu um telefone valido para a pessoa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
                return;
            }
            if (txtMorada.Text == "")
            {
                MessageBox.Show("Não inseriu uma morada para o contacto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtEmail.Text == "") {
                MessageBox.Show("Não inseriu um email para o contacto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtTelefone.Text == "")
            {
                MessageBox.Show("Não inseriu um telefone para o contacto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (comboEmpresa.SelectedIndex == -1)
            {
                MessageBox.Show("Não selecionou nada no campo da empresa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            //Isto é onde os grupos serão guardados num vetor
            string[] grupos = new string[0];
            foreach (CheckBox c in gpGrupos.Controls.OfType<CheckBox>())
            {
                if (c.Checked)
                {
                    Array.Resize(ref grupos, grupos.Length + 1);
                    grupos[grupos.GetUpperBound(0)] = c.Text;
                }
            }

            //Para adicionar um utilizador é perciso:
            /*
             @Nome, (string)
             @Contacto, (string)
             @Email, (string)
             @Morada, (string)
             @Foto, (string)
             @Favorito (string ["true"/"false"])
             @IDEmpresa (Int32) (Se 0 é "Nenhuma")
            */
            string nome = txtNome.Text;
            string contacto = txtTelefone.Text;
            string email = txtEmail.Text;
            string morada = txtMorada.Text;
            string foto = bunifuPictureBox1.ImageLocation;
            string favorito = (chFavorito.Checked ? "True" : "False");
            int IDEmpresa = Int32.Parse(getIDofSlected());

            if (DbFunctions.is1x("Contacto", "Contactos", contacto))
            {
                MessageBox.Show("Já existe um registo com esse telefone!");
                txtTelefone.Focus();
                return;
            }


            Contacto.Adicionar(nome, contacto, email, morada, foto, favorito, IDEmpresa);

            //Para salvar os grupos
            Grupos.SaveContactGropups(grupos, Int32.Parse(DbFunctions.getLastElement("ID", "Contactos")));

            MessageBox.Show("Contacto Adicionado com sucesso!");

            this.Close();

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            using (FileDialog fileDialog = new OpenFileDialog())
            {
                if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    string fileName = fileDialog.FileName;
                    bunifuPictureBox1.Image = Image.FromFile(fileName);
                    bunifuPictureBox1.ImageLocation = fileName;
                }
            }
        }
    }
}
