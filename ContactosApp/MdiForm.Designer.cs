
namespace ContactosApp
{
    partial class FormApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsContactosdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famíliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactosToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosOsContactosdToolStripMenuItem,
            this.famíliaToolStripMenuItem,
            this.amigosToolStripMenuItem,
            this.colegasToolStripMenuItem,
            this.negociosToolStripMenuItem,
            this.favoritosToolStripMenuItem,
            this.adicionarToolStripMenuItem1});
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // todosOsContactosdToolStripMenuItem
            // 
            this.todosOsContactosdToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.Todos;
            this.todosOsContactosdToolStripMenuItem.Name = "todosOsContactosdToolStripMenuItem";
            this.todosOsContactosdToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.todosOsContactosdToolStripMenuItem.Text = "Todos os Contactos";
            this.todosOsContactosdToolStripMenuItem.Click += new System.EventHandler(this.todosOsContactosdToolStripMenuItem_Click);
            // 
            // famíliaToolStripMenuItem
            // 
            this.famíliaToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.familia;
            this.famíliaToolStripMenuItem.Name = "famíliaToolStripMenuItem";
            this.famíliaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.famíliaToolStripMenuItem.Text = "Família";
            this.famíliaToolStripMenuItem.Click += new System.EventHandler(this.famíliaToolStripMenuItem_Click);
            // 
            // amigosToolStripMenuItem
            // 
            this.amigosToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.amigos;
            this.amigosToolStripMenuItem.Name = "amigosToolStripMenuItem";
            this.amigosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.amigosToolStripMenuItem.Text = "Amigos";
            this.amigosToolStripMenuItem.Click += new System.EventHandler(this.amigosToolStripMenuItem_Click);
            // 
            // colegasToolStripMenuItem
            // 
            this.colegasToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.workers_26px;
            this.colegasToolStripMenuItem.Name = "colegasToolStripMenuItem";
            this.colegasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.colegasToolStripMenuItem.Text = "Colegas";
            this.colegasToolStripMenuItem.Click += new System.EventHandler(this.colegasToolStripMenuItem_Click);
            // 
            // negociosToolStripMenuItem
            // 
            this.negociosToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.coins;
            this.negociosToolStripMenuItem.Name = "negociosToolStripMenuItem";
            this.negociosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.negociosToolStripMenuItem.Text = "Negocios";
            this.negociosToolStripMenuItem.Click += new System.EventHandler(this.negociosToolStripMenuItem_Click);
            // 
            // favoritosToolStripMenuItem
            // 
            this.favoritosToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.Star;
            this.favoritosToolStripMenuItem.Name = "favoritosToolStripMenuItem";
            this.favoritosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.favoritosToolStripMenuItem.Text = "Favoritos";
            this.favoritosToolStripMenuItem.Click += new System.EventHandler(this.favoritosToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.Image = global::ContactosApp.Properties.Resources.plus_26px;
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            this.adicionarToolStripMenuItem1.Click += new System.EventHandler(this.adicionarToolStripMenuItem1_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.adicionarToolStripMenuItem});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.empresas;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listarToolStripMenuItem.Text = "Listar empresas";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.plus_26px;
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.fecharTodasToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.janelasToolStripMenuItem.Text = "Dispor Janelas";
            this.janelasToolStripMenuItem.Click += new System.EventHandler(this.janelasToolStripMenuItem_Click);
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // fecharTodasToolStripMenuItem
            // 
            this.fecharTodasToolStripMenuItem.Name = "fecharTodasToolStripMenuItem";
            this.fecharTodasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fecharTodasToolStripMenuItem.Text = "Fechar Todas";
            this.fecharTodasToolStripMenuItem.Click += new System.EventHandler(this.fecharTodasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::ContactosApp.Properties.Resources.close1;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 734);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormApp";
            this.Text = "Fire Contacts";
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsContactosdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famíliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritosToolStripMenuItem;
    }
}

