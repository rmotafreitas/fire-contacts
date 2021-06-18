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
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        private void FormApp_Load(object sender, EventArgs e)
        {

        }

        private void todosOsContactosdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAll FrmTodosContactos= new ListAll();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Todos os contactos";
            FrmTodosContactos.Show();
        }

        private void janelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fecharTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                MessageBox.Show("Nenhuma janela aberta");
            else
            {
                while (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
            }

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De certeza que quer fechar", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void famíliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarFamilia FrmTodosContactos = new ListarFamilia();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Contactos Família";
            FrmTodosContactos.Show();
        }

        private void amigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAmigos FrmTodosContactos = new ListarAmigos();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Todos os amigos";
            FrmTodosContactos.Show();
        }

        private void colegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarColegas FrmTodosContactos = new ListarColegas();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Todos os colegas";
            FrmTodosContactos.Show();
        }

        private void negociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarNegocios FrmTodosContactos = new ListarNegocios();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Todos os negociantes";
            FrmTodosContactos.Show();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdicionarContacto FrmTodosContactos = new AdicionarContacto();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "";
            FrmTodosContactos.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarEmpresas FrmTodosContactos = new ListarEmpresas();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Empresas";
            FrmTodosContactos.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar_Empresa FrmTodosContactos = new Adicionar_Empresa();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Acinar Empresa";
            FrmTodosContactos.Show();
        }

        private void favoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Favoritos FrmTodosContactos = new Favoritos();
            FrmTodosContactos.MdiParent = this;
            FrmTodosContactos.Text = "Contactos Favoritos";
            FrmTodosContactos.Show();
        }
    }
}
