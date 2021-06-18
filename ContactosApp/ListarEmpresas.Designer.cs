
namespace ContactosApp
{
    partial class ListarEmpresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarEmpresas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.lstViewEmpresas = new System.Windows.Forms.ListView();
            this.clHNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHContacto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHMorada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEmpresaEditar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRefreshEmpresas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Todos os contactos de empresas: ";
            // 
            // lstViewEmpresas
            // 
            this.lstViewEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clHNome,
            this.clHContacto,
            this.clHMorada});
            this.lstViewEmpresas.FullRowSelect = true;
            this.lstViewEmpresas.GridLines = true;
            this.lstViewEmpresas.HideSelection = false;
            this.lstViewEmpresas.Location = new System.Drawing.Point(1, 142);
            this.lstViewEmpresas.MultiSelect = false;
            this.lstViewEmpresas.Name = "lstViewEmpresas";
            this.lstViewEmpresas.Size = new System.Drawing.Size(449, 307);
            this.lstViewEmpresas.TabIndex = 17;
            this.lstViewEmpresas.UseCompatibleStateImageBehavior = false;
            this.lstViewEmpresas.View = System.Windows.Forms.View.Details;
            // 
            // clHNome
            // 
            this.clHNome.Text = "Nome";
            this.clHNome.Width = 146;
            // 
            // clHContacto
            // 
            this.clHContacto.Text = "Contacto";
            this.clHContacto.Width = 116;
            // 
            // clHMorada
            // 
            this.clHMorada.Text = "Morada";
            this.clHMorada.Width = 183;
            // 
            // btnEmpresaEditar
            // 
            this.btnEmpresaEditar.AllowAnimations = true;
            this.btnEmpresaEditar.AllowMouseEffects = true;
            this.btnEmpresaEditar.AllowToggling = false;
            this.btnEmpresaEditar.AnimationSpeed = 200;
            this.btnEmpresaEditar.AutoGenerateColors = false;
            this.btnEmpresaEditar.AutoRoundBorders = false;
            this.btnEmpresaEditar.AutoSizeLeftIcon = true;
            this.btnEmpresaEditar.AutoSizeRightIcon = true;
            this.btnEmpresaEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpresaEditar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnEmpresaEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpresaEditar.BackgroundImage")));
            this.btnEmpresaEditar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpresaEditar.ButtonText = "Editar";
            this.btnEmpresaEditar.ButtonTextMarginLeft = 0;
            this.btnEmpresaEditar.ColorContrastOnClick = 45;
            this.btnEmpresaEditar.ColorContrastOnHover = 45;
            this.btnEmpresaEditar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnEmpresaEditar.CustomizableEdges = borderEdges1;
            this.btnEmpresaEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmpresaEditar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmpresaEditar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmpresaEditar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmpresaEditar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEmpresaEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmpresaEditar.ForeColor = System.Drawing.Color.White;
            this.btnEmpresaEditar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresaEditar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmpresaEditar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEmpresaEditar.IconMarginLeft = 11;
            this.btnEmpresaEditar.IconPadding = 10;
            this.btnEmpresaEditar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpresaEditar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEmpresaEditar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEmpresaEditar.IconSize = 25;
            this.btnEmpresaEditar.IdleBorderColor = System.Drawing.Color.Black;
            this.btnEmpresaEditar.IdleBorderRadius = 1;
            this.btnEmpresaEditar.IdleBorderThickness = 1;
            this.btnEmpresaEditar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnEmpresaEditar.IdleIconLeftImage = global::ContactosApp.Properties.Resources.Editar;
            this.btnEmpresaEditar.IdleIconRightImage = null;
            this.btnEmpresaEditar.IndicateFocus = false;
            this.btnEmpresaEditar.Location = new System.Drawing.Point(342, 97);
            this.btnEmpresaEditar.Name = "btnEmpresaEditar";
            this.btnEmpresaEditar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEmpresaEditar.OnDisabledState.BorderRadius = 1;
            this.btnEmpresaEditar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpresaEditar.OnDisabledState.BorderThickness = 1;
            this.btnEmpresaEditar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEmpresaEditar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEmpresaEditar.OnDisabledState.IconLeftImage = null;
            this.btnEmpresaEditar.OnDisabledState.IconRightImage = null;
            this.btnEmpresaEditar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEmpresaEditar.onHoverState.BorderRadius = 1;
            this.btnEmpresaEditar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpresaEditar.onHoverState.BorderThickness = 1;
            this.btnEmpresaEditar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEmpresaEditar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEmpresaEditar.onHoverState.IconLeftImage = null;
            this.btnEmpresaEditar.onHoverState.IconRightImage = null;
            this.btnEmpresaEditar.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnEmpresaEditar.OnIdleState.BorderRadius = 1;
            this.btnEmpresaEditar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpresaEditar.OnIdleState.BorderThickness = 1;
            this.btnEmpresaEditar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnEmpresaEditar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEmpresaEditar.OnIdleState.IconLeftImage = global::ContactosApp.Properties.Resources.Editar;
            this.btnEmpresaEditar.OnIdleState.IconRightImage = null;
            this.btnEmpresaEditar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEmpresaEditar.OnPressedState.BorderRadius = 1;
            this.btnEmpresaEditar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEmpresaEditar.OnPressedState.BorderThickness = 1;
            this.btnEmpresaEditar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEmpresaEditar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEmpresaEditar.OnPressedState.IconLeftImage = null;
            this.btnEmpresaEditar.OnPressedState.IconRightImage = null;
            this.btnEmpresaEditar.Size = new System.Drawing.Size(108, 39);
            this.btnEmpresaEditar.TabIndex = 22;
            this.btnEmpresaEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmpresaEditar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmpresaEditar.TextMarginLeft = 0;
            this.btnEmpresaEditar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEmpresaEditar.UseDefaultRadiusAndThickness = true;
            this.btnEmpresaEditar.Click += new System.EventHandler(this.btnEmpresaEditar_Click);
            // 
            // btnRefreshEmpresas
            // 
            this.btnRefreshEmpresas.AllowAnimations = true;
            this.btnRefreshEmpresas.AllowMouseEffects = true;
            this.btnRefreshEmpresas.AllowToggling = false;
            this.btnRefreshEmpresas.AnimationSpeed = 200;
            this.btnRefreshEmpresas.AutoGenerateColors = false;
            this.btnRefreshEmpresas.AutoRoundBorders = false;
            this.btnRefreshEmpresas.AutoSizeLeftIcon = true;
            this.btnRefreshEmpresas.AutoSizeRightIcon = true;
            this.btnRefreshEmpresas.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshEmpresas.BackColor1 = System.Drawing.Color.Silver;
            this.btnRefreshEmpresas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshEmpresas.BackgroundImage")));
            this.btnRefreshEmpresas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnRefreshEmpresas.ButtonText = "Refresh";
            this.btnRefreshEmpresas.ButtonTextMarginLeft = 0;
            this.btnRefreshEmpresas.ColorContrastOnClick = 45;
            this.btnRefreshEmpresas.ColorContrastOnHover = 45;
            this.btnRefreshEmpresas.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRefreshEmpresas.CustomizableEdges = borderEdges2;
            this.btnRefreshEmpresas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefreshEmpresas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefreshEmpresas.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefreshEmpresas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefreshEmpresas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRefreshEmpresas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshEmpresas.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEmpresas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshEmpresas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefreshEmpresas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRefreshEmpresas.IconMarginLeft = 11;
            this.btnRefreshEmpresas.IconPadding = 10;
            this.btnRefreshEmpresas.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefreshEmpresas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRefreshEmpresas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRefreshEmpresas.IconSize = 25;
            this.btnRefreshEmpresas.IdleBorderColor = System.Drawing.Color.Black;
            this.btnRefreshEmpresas.IdleBorderRadius = 1;
            this.btnRefreshEmpresas.IdleBorderThickness = 1;
            this.btnRefreshEmpresas.IdleFillColor = System.Drawing.Color.Silver;
            this.btnRefreshEmpresas.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshEmpresas.IdleIconLeftImage")));
            this.btnRefreshEmpresas.IdleIconRightImage = null;
            this.btnRefreshEmpresas.IndicateFocus = false;
            this.btnRefreshEmpresas.Location = new System.Drawing.Point(228, 97);
            this.btnRefreshEmpresas.Name = "btnRefreshEmpresas";
            this.btnRefreshEmpresas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRefreshEmpresas.OnDisabledState.BorderRadius = 1;
            this.btnRefreshEmpresas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshEmpresas.OnDisabledState.BorderThickness = 1;
            this.btnRefreshEmpresas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRefreshEmpresas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRefreshEmpresas.OnDisabledState.IconLeftImage = null;
            this.btnRefreshEmpresas.OnDisabledState.IconRightImage = null;
            this.btnRefreshEmpresas.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRefreshEmpresas.onHoverState.BorderRadius = 1;
            this.btnRefreshEmpresas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshEmpresas.onHoverState.BorderThickness = 1;
            this.btnRefreshEmpresas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRefreshEmpresas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEmpresas.onHoverState.IconLeftImage = null;
            this.btnRefreshEmpresas.onHoverState.IconRightImage = null;
            this.btnRefreshEmpresas.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshEmpresas.OnIdleState.BorderRadius = 1;
            this.btnRefreshEmpresas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnRefreshEmpresas.OnIdleState.BorderThickness = 1;
            this.btnRefreshEmpresas.OnIdleState.FillColor = System.Drawing.Color.Silver;
            this.btnRefreshEmpresas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEmpresas.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshEmpresas.OnIdleState.IconLeftImage")));
            this.btnRefreshEmpresas.OnIdleState.IconRightImage = null;
            this.btnRefreshEmpresas.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefreshEmpresas.OnPressedState.BorderRadius = 1;
            this.btnRefreshEmpresas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRefreshEmpresas.OnPressedState.BorderThickness = 1;
            this.btnRefreshEmpresas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRefreshEmpresas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRefreshEmpresas.OnPressedState.IconLeftImage = null;
            this.btnRefreshEmpresas.OnPressedState.IconRightImage = null;
            this.btnRefreshEmpresas.Size = new System.Drawing.Size(108, 39);
            this.btnRefreshEmpresas.TabIndex = 21;
            this.btnRefreshEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefreshEmpresas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefreshEmpresas.TextMarginLeft = 0;
            this.btnRefreshEmpresas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRefreshEmpresas.UseDefaultRadiusAndThickness = true;
            this.btnRefreshEmpresas.Click += new System.EventHandler(this.bunifuButton4_Click);
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowAnimations = true;
            this.bunifuButton3.AllowMouseEffects = true;
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.AutoRoundBorders = false;
            this.bunifuButton3.AutoSizeLeftIcon = true;
            this.bunifuButton3.AutoSizeRightIcon = true;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.Coral;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.bunifuButton3.ButtonText = "      Adicionar";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges3;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton3.IconSize = 25;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.Black;
            this.bunifuButton3.IdleBorderRadius = 1;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.Coral;
            this.bunifuButton3.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.IdleIconLeftImage")));
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(115, 97);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.OnDisabledState.BorderRadius = 1;
            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
            this.bunifuButton3.OnDisabledState.IconRightImage = null;
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.BorderRadius = 1;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.bunifuButton3.OnIdleState.BorderRadius = 1;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.Coral;
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.OnIdleState.IconLeftImage")));
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.BorderRadius = 1;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(108, 39);
            this.bunifuButton3.TabIndex = 20;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DarkSlateGray;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.bunifuButton1.ButtonText = "Apagar";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges4;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.White;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuButton1.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.IdleIconLeftImage")));
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(0, 97);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.OnIdleState.IconLeftImage")));
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(108, 39);
            this.bunifuButton1.TabIndex = 19;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // ListarEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.btnEmpresaEditar);
            this.Controls.Add(this.btnRefreshEmpresas);
            this.Controls.Add(this.bunifuButton3);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViewEmpresas);
            this.Name = "ListarEmpresas";
            this.Text = "ListarEmpresas";
            this.Load += new System.EventHandler(this.ListarEmpresas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEmpresaEditar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRefreshEmpresas;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewEmpresas;
        private System.Windows.Forms.ColumnHeader clHNome;
        private System.Windows.Forms.ColumnHeader clHContacto;
        private System.Windows.Forms.ColumnHeader clHMorada;
    }
}