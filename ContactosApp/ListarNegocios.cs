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
    public partial class ListarNegocios : Form
    {
        public ListarNegocios()
        {
            InitializeComponent();
        }

        private void ListarNegocios_Load(object sender, EventArgs e)
        {
            int[] ids = Grupos.getIdsOfPeopleInIDGroup(3);

            for (int i = 0; i < ids.Length; i++)
            {
                dynamic Contacto = ContactosApp.Contacto.getContactoInfo(ids[i]);

                ListViewItem li = new ListViewItem(Contacto.nome);
                li.SubItems.Add(Contacto.contacto);
                li.SubItems.Add(Contacto.email);
                li.SubItems.Add(Contacto.morada);

                lstConcatos.Items.Add(li);
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        public string getIDofSlected()
        {
            string id = "";
            string NomePessoa = "";
            try
            {
                NomePessoa = lstConcatos.Items[lstConcatos.SelectedIndices[0]].SubItems[1].Text;
            }
            catch { }
            string[] ids = DbFunctions.getAllIDs("ID", "Contactos");
            for (int i = 0; i < ids.Length; i++)
            {
                if (Contacto.getContactoInfo(Int32.Parse(ids[i])).contacto == NomePessoa) id = ids[i];
            }
            return id;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            if (lstConcatos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nada selecionado!");
                return;
            }
            int index = Int32.Parse(getIDofSlected());

            DialogResult result = MessageBox.Show($"De certeza que quer apagar o contacto:  {Contacto.getContactoInfo(index).nome}", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                lstConcatos.Items[lstConcatos.SelectedIndices[0]].Remove();
                DbFunctions.deleteRecord("Contactos", $"ID = {index}");
                DbFunctions.deleteRecord("PessoasEmGrupos", $"IDPessoa = {index}");
            }
        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            AdicionarContacto formAdd = new AdicionarContacto();

            formAdd.MdiParent = this.MdiParent;
            formAdd.Show();
        }

        private void bunifuButton4_Click_1(object sender, EventArgs e)
        {
            lstConcatos.Items.Clear();

            string[] ids = DbFunctions.getAllIDs("ID", "Contactos");

            for (int i = 0; i < ids.Length; i++)
            {
                dynamic Contacto = ContactosApp.Contacto.getContactoInfo(Int32.Parse(ids[i]));

                ListViewItem li = new ListViewItem(Contacto.nome);
                li.SubItems.Add(Contacto.contacto);
                li.SubItems.Add(Contacto.email);
                li.SubItems.Add(Contacto.morada);

                lstConcatos.Items.Add(li);
            }
        }

        private void bunifuButton5_Click_1(object sender, EventArgs e)
        {
            if (lstConcatos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nada selecionado!");
                return;
            }
            int index = Int32.Parse(getIDofSlected());
            Contacto.iD = index;
            ContactoSelecionado formAdd = new ContactoSelecionado();

            formAdd.MdiParent = this.MdiParent;
            formAdd.Show();
        }
    }
}
