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
    public partial class ListarEmpresas : Form
    {
        public ListarEmpresas()
        {
            InitializeComponent();
        }

        private void ListarEmpresas_Load(object sender, EventArgs e)
        {
            string[] ids = DbFunctions.getAllIDs("ID", "Empresas");

            for (int i = 0; i < ids.Length; i++)
            {
                dynamic EmpresaInfo = Empresa.getEmpresaInfo(Int32.Parse(ids[i]));

                ListViewItem li = new ListViewItem(EmpresaInfo.nome);
                li.SubItems.Add(EmpresaInfo.contacto);
                li.SubItems.Add(EmpresaInfo.morada);

                lstViewEmpresas.Items.Add(li);
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            lstViewEmpresas.Items.Clear();
            string[] ids = DbFunctions.getAllIDs("ID", "Empresas");

            for (int i = 0; i < ids.Length; i++)
            {
                dynamic EmpresaInfo = Empresa.getEmpresaInfo(Int32.Parse(ids[i]));

                ListViewItem li = new ListViewItem(EmpresaInfo.nome);
                li.SubItems.Add(EmpresaInfo.contacto);
                li.SubItems.Add(EmpresaInfo.morada);

                lstViewEmpresas.Items.Add(li);
            }
        }
        private bool AlreadyOPen(string FormName)
        {
            bool flag = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == FormName)
                {
                    flag = true;
                }
            }
            return flag;
        }
        private void btnEmpresaEditar_Click(object sender, EventArgs e)
        {
            if (lstViewEmpresas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nada selecionado!");
                return;
            }
            int index = Int32.Parse(getIDofSlected());

            Empresa.iD = index;

            Empresa_Selecionada form = new Empresa_Selecionada();

            form.MdiParent = this.MdiParent; // assign MdiParent of FormB to FormC
            form.Show();


        }

        public string getIDofSlected()
        {
            string id = "";
            string NomeEmpresa = "";
            try
            {
                NomeEmpresa = lstViewEmpresas.Items[lstViewEmpresas.SelectedIndices[0]].SubItems[0].Text;
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

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Adicionar_Empresa form = new Adicionar_Empresa();
            form.MdiParent = this.MdiParent; 
            form.Show();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (lstViewEmpresas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nada selecionado!");
                return;
            }
            int index = Int32.Parse(getIDofSlected());

            string contactsIncommon = Empresa.WhichContactsHaveThisCompany(index);

            if (contactsIncommon != "")
            {
                MessageBox.Show($"Existem contactos com tal empresa:\n\n{contactsIncommon}\nDe tal modo não foi possivél remover essa emrpesa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"De certeza que quer apagar a empresa {Empresa.getEmpresaInfo(index).nome}", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                lstViewEmpresas.Items[lstViewEmpresas.SelectedIndices[0]].Remove();
                DbFunctions.deleteRecord("Empresas", $"ID = {index}");
            }

        }
    }
}
