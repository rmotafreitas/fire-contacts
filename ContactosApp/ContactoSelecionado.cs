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
    public partial class ContactoSelecionado : Form
    {
        public ContactoSelecionado()
        {
            InitializeComponent();
        }

        

        private void btnGet_Click(object sender, EventArgs e)
        {

        }

        private void ContactoSelecionado_Load(object sender, EventArgs e)
        {
            string[] ids = DbFunctions.getAllIDs("ID", "Empresas");

            for (int i = 0; i < ids.Length; i++)
            {
                dynamic EmpresaInfo = Empresa.getEmpresaInfo(Int32.Parse(ids[i]));
                string nome = EmpresaInfo.nome;
                comboEmpresas.Items.Add(nome);

            }



            txtID.Text = Contacto.iD.ToString();
            dynamic ContactoInfo = Contacto.getContactoInfo(Contacto.iD);
            txtNome.Text = ContactoInfo.nome;
            txtContacto.Text = ContactoInfo.contacto;
            txtEmail.Text = ContactoInfo.email;
            txtMorada.Text = ContactoInfo.morada;
            chBoxFavorito.Checked = ContactoInfo.favorito;
            pfpBox.ImageLocation = ContactoInfo.foto;
            pfpBox.Image = Image.FromFile(ContactoInfo.foto);

            int IDEmpresa = ContactoInfo.IDEmpresa;

            if (IDEmpresa == 0) {
                comboEmpresas.SelectedIndex = 0;
            } else {
                string NomeEmpresa = Empresa.getEmpresaInfo(IDEmpresa).nome;
                int comboBoxIndex = comboEmpresas.Items.IndexOf(NomeEmpresa);
                comboEmpresas.SelectedIndex = comboBoxIndex;
            }
            

            foreach (CheckBox c in gpBoxGrupos.Controls.OfType<CheckBox>()) {
                    for (int i = 0; i < ContactoInfo.grupos.Length; i++)
                    {
                        if (c.Text == ContactoInfo.grupos[i])
                        {
                            c.Checked = true;
                        }
                    }
                }

           

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            using (FileDialog fileDialog = new OpenFileDialog())
            {
                if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    string fileName = fileDialog.FileName;
                    pfpBox.Image = Image.FromFile(fileName);
                    pfpBox.ImageLocation = fileName;
                }
            }
        }
        public string getIDofSlected()
        {
            if (comboEmpresas.SelectedIndex == 0) return "0";
            string id = "";
            string NomeEmpresa = "";
            try
            {
                NomeEmpresa = comboEmpresas.Items[comboEmpresas.SelectedIndex].ToString();
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
        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Não inseriu um nome para o contacto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtMorada.Text == "")
            {
                MessageBox.Show("Não inseriu uma morada para o contacto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Não inseriu um email para o contacto!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            if (!((int.TryParse(txtContacto.Text, out _)) && (txtContacto.Text.Length == 9)))
            {
                MessageBox.Show("Não inseriu um telefone valido para a pessoa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContacto.Focus();
                return;
            }
            if (DbFunctions.is2x("Contacto", "Contactos", txtContacto.Text))
            {
                MessageBox.Show("Já existe um registo com esse telefone!");
                txtContacto.Focus();
                return;
            }


            if (comboEmpresas.SelectedIndex == -1)
            {
                MessageBox.Show("Não selecionou nada no campo da empresa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }
            if (DbFunctions.is2x("Contacto", "Contactos", txtContacto.Text))
            {
                MessageBox.Show("Já existe um registo com esse telefone!");
                txtContacto.Focus();
                return;
            }



            string[] grupos = new string[0];
            foreach (CheckBox c in gpBoxGrupos.Controls.OfType<CheckBox>())
            {
                    if (c.Checked)
                    {
                        Array.Resize(ref grupos, grupos.Length + 1);
                        grupos[grupos.GetUpperBound(0)] = c.Text;

                    }
            }
            var Contact = new {
                nome = txtNome.Text,
                contacto = txtContacto.Text,
                email = txtEmail.Text,
                morada = txtMorada.Text,
                favorito = chBoxFavorito.Checked,
                foto = pfpBox.ImageLocation,
                grupos,
                IDEmpresa = Int32.Parse(getIDofSlected())
            };
            Contacto.SaveAContact(Contact, Int32.Parse(txtID.Text));
            MessageBox.Show("Altrado com sucesso, por favor clique no botão de refresh!");
            this.Close();
        }
    }
}
