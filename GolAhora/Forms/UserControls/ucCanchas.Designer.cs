namespace GolAhora.Forms.UserControls;

partial class ucCanchas
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        cbFiltrar = new ComboBox();
        btnBuscar = new Button();
        tcCanchas = new TabControl();
        tabCanchas = new TabPage();
        scCanchas = new SplitContainer();
        listBoxCanchas = new ListBox();
        lblBloquearCancha = new Label();
        btnBloquearCancha = new Button();
        lblBajaCancha = new Label();
        btnBajaCancha = new Button();
        lblModificarCancha = new Label();
        btnModificarCancha = new Button();
        lblConsultarCancha = new Label();
        btnConsultarCancha = new Button();
        lblAgregarCancha = new Label();
        btnAgregarCancha = new Button();
        tabTiposCancha = new TabPage();
        scTipos = new SplitContainer();
        listBoxTiposCancha = new ListBox();
        lblReporteTipo = new Label();
        btnReporteTipos = new Button();
        lblEliminarTipo = new Label();
        btnEliminarTipo = new Button();
        lblModificarTipo = new Label();
        btnModificarTipo = new Button();
        lblConsultarTipo = new Label();
        btnConsultarTipo = new Button();
        lblAgregarTipo = new Label();
        btnAgregarTipo = new Button();
        cbEstados = new ComboBox();
        txtBusqueda = new TextBox();
        lblFiltrado = new Label();
        tcCanchas.SuspendLayout();
        tabCanchas.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)scCanchas).BeginInit();
        scCanchas.Panel1.SuspendLayout();
        scCanchas.Panel2.SuspendLayout();
        scCanchas.SuspendLayout();
        tabTiposCancha.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)scTipos).BeginInit();
        scTipos.Panel1.SuspendLayout();
        scTipos.Panel2.SuspendLayout();
        scTipos.SuspendLayout();
        SuspendLayout();
        // 
        // cbFiltrar
        // 
        cbFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
        cbFiltrar.FormattingEnabled = true;
        cbFiltrar.Items.AddRange(new object[] { "Tipo", "Todas" });
        cbFiltrar.Location = new Point(337, 5);
        cbFiltrar.Margin = new Padding(4, 3, 4, 3);
        cbFiltrar.Name = "cbFiltrar";
        cbFiltrar.Size = new Size(98, 23);
        cbFiltrar.TabIndex = 14;
        // 
        // btnBuscar
        // 
        btnBuscar.BackColor = SystemColors.ControlLight;
        btnBuscar.Location = new Point(625, 5);
        btnBuscar.Margin = new Padding(4, 3, 4, 3);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(88, 24);
        btnBuscar.TabIndex = 12;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = false;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // tcCanchas
        // 
        tcCanchas.Controls.Add(tabCanchas);
        tcCanchas.Controls.Add(tabTiposCancha);
        tcCanchas.Location = new Point(-4, 60);
        tcCanchas.Margin = new Padding(4, 3, 4, 3);
        tcCanchas.Name = "tcCanchas";
        tcCanchas.SelectedIndex = 0;
        tcCanchas.Size = new Size(731, 365);
        tcCanchas.TabIndex = 11;
        tcCanchas.Click += tcCanchas_Click;
        // 
        // tabCanchas
        // 
        tabCanchas.BackColor = SystemColors.ActiveCaption;
        tabCanchas.Controls.Add(scCanchas);
        tabCanchas.Location = new Point(4, 24);
        tabCanchas.Margin = new Padding(4, 3, 4, 3);
        tabCanchas.Name = "tabCanchas";
        tabCanchas.Padding = new Padding(4, 3, 4, 3);
        tabCanchas.Size = new Size(723, 337);
        tabCanchas.TabIndex = 2;
        tabCanchas.Text = "Canchas";
        // 
        // scCanchas
        // 
        scCanchas.Dock = DockStyle.Fill;
        scCanchas.Location = new Point(4, 3);
        scCanchas.Margin = new Padding(4, 3, 4, 3);
        scCanchas.Name = "scCanchas";
        // 
        // scCanchas.Panel1
        // 
        scCanchas.Panel1.Controls.Add(listBoxCanchas);
        scCanchas.Panel1.Padding = new Padding(10, 10, 10, 20);
        // 
        // scCanchas.Panel2
        // 
        scCanchas.Panel2.BackColor = Color.Transparent;
        scCanchas.Panel2.Controls.Add(lblBloquearCancha);
        scCanchas.Panel2.Controls.Add(btnBloquearCancha);
        scCanchas.Panel2.Controls.Add(lblBajaCancha);
        scCanchas.Panel2.Controls.Add(btnBajaCancha);
        scCanchas.Panel2.Controls.Add(lblModificarCancha);
        scCanchas.Panel2.Controls.Add(btnModificarCancha);
        scCanchas.Panel2.Controls.Add(lblConsultarCancha);
        scCanchas.Panel2.Controls.Add(btnConsultarCancha);
        scCanchas.Panel2.Controls.Add(lblAgregarCancha);
        scCanchas.Panel2.Controls.Add(btnAgregarCancha);
        scCanchas.Panel2.Padding = new Padding(10, 10, 10, 20);
        scCanchas.Size = new Size(715, 331);
        scCanchas.SplitterDistance = 462;
        scCanchas.SplitterWidth = 5;
        scCanchas.TabIndex = 5;
        // 
        // listBoxCanchas
        // 
        listBoxCanchas.BackColor = SystemColors.ActiveCaption;
        listBoxCanchas.BorderStyle = BorderStyle.FixedSingle;
        listBoxCanchas.Dock = DockStyle.Fill;
        listBoxCanchas.FormattingEnabled = true;
        listBoxCanchas.Items.AddRange(new object[] { "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200" });
        listBoxCanchas.Location = new Point(10, 10);
        listBoxCanchas.Name = "listBoxCanchas";
        listBoxCanchas.Size = new Size(442, 301);
        listBoxCanchas.TabIndex = 1;
        listBoxCanchas.SelectedIndexChanged += listBoxCanchas_SelectedIndexChanged;
        listBoxCanchas.MouseDown += listBoxCanchas_MouseDown;
        // 
        // lblBloquearCancha
        // 
        lblBloquearCancha.AutoSize = true;
        lblBloquearCancha.Location = new Point(8, 151);
        lblBloquearCancha.Margin = new Padding(4, 0, 4, 0);
        lblBloquearCancha.Name = "lblBloquearCancha";
        lblBloquearCancha.Size = new Size(101, 15);
        lblBloquearCancha.TabIndex = 20;
        lblBloquearCancha.Text = "Bloquear cancha:";
        // 
        // btnBloquearCancha
        // 
        btnBloquearCancha.BackColor = SystemColors.ControlLight;
        btnBloquearCancha.Enabled = false;
        btnBloquearCancha.Location = new Point(154, 145);
        btnBloquearCancha.Margin = new Padding(4, 3, 4, 3);
        btnBloquearCancha.Name = "btnBloquearCancha";
        btnBloquearCancha.Size = new Size(88, 27);
        btnBloquearCancha.TabIndex = 19;
        btnBloquearCancha.Text = "Bloquear";
        btnBloquearCancha.UseVisualStyleBackColor = false;
        btnBloquearCancha.Click += btnBloquearCancha_Click;
        // 
        // lblBajaCancha
        // 
        lblBajaCancha.AutoSize = true;
        lblBajaCancha.Location = new Point(8, 195);
        lblBajaCancha.Margin = new Padding(4, 0, 4, 0);
        lblBajaCancha.Name = "lblBajaCancha";
        lblBajaCancha.Size = new Size(113, 15);
        lblBajaCancha.TabIndex = 18;
        lblBajaCancha.Text = "Dar de baja cancha:";
        // 
        // btnBajaCancha
        // 
        btnBajaCancha.BackColor = SystemColors.ControlLight;
        btnBajaCancha.Enabled = false;
        btnBajaCancha.Location = new Point(154, 189);
        btnBajaCancha.Margin = new Padding(4, 3, 4, 3);
        btnBajaCancha.Name = "btnBajaCancha";
        btnBajaCancha.Size = new Size(88, 27);
        btnBajaCancha.TabIndex = 17;
        btnBajaCancha.Text = "Baja";
        btnBajaCancha.UseVisualStyleBackColor = false;
        btnBajaCancha.Click += btnBajaCancha_Click;
        // 
        // lblModificarCancha
        // 
        lblModificarCancha.AutoSize = true;
        lblModificarCancha.Location = new Point(8, 107);
        lblModificarCancha.Margin = new Padding(4, 0, 4, 0);
        lblModificarCancha.Name = "lblModificarCancha";
        lblModificarCancha.Size = new Size(134, 15);
        lblModificarCancha.TabIndex = 16;
        lblModificarCancha.Text = "Modificar propiedades:";
        // 
        // btnModificarCancha
        // 
        btnModificarCancha.BackColor = SystemColors.ControlLight;
        btnModificarCancha.Enabled = false;
        btnModificarCancha.Location = new Point(154, 101);
        btnModificarCancha.Margin = new Padding(4, 3, 4, 3);
        btnModificarCancha.Name = "btnModificarCancha";
        btnModificarCancha.Size = new Size(88, 27);
        btnModificarCancha.TabIndex = 15;
        btnModificarCancha.Text = "Modificar";
        btnModificarCancha.UseVisualStyleBackColor = false;
        btnModificarCancha.Click += btnModificarCancha_Click;
        // 
        // lblConsultarCancha
        // 
        lblConsultarCancha.AutoSize = true;
        lblConsultarCancha.Location = new Point(8, 63);
        lblConsultarCancha.Margin = new Padding(4, 0, 4, 0);
        lblConsultarCancha.Name = "lblConsultarCancha";
        lblConsultarCancha.Size = new Size(133, 15);
        lblConsultarCancha.TabIndex = 14;
        lblConsultarCancha.Text = "Consultar propiedades:";
        // 
        // btnConsultarCancha
        // 
        btnConsultarCancha.BackColor = SystemColors.ControlLight;
        btnConsultarCancha.Enabled = false;
        btnConsultarCancha.Location = new Point(154, 57);
        btnConsultarCancha.Margin = new Padding(4, 3, 4, 3);
        btnConsultarCancha.Name = "btnConsultarCancha";
        btnConsultarCancha.Size = new Size(88, 27);
        btnConsultarCancha.TabIndex = 13;
        btnConsultarCancha.Text = "Consultar";
        btnConsultarCancha.UseVisualStyleBackColor = false;
        btnConsultarCancha.Click += btnConsultarCancha_Click;
        // 
        // lblAgregarCancha
        // 
        lblAgregarCancha.AutoSize = true;
        lblAgregarCancha.Location = new Point(8, 19);
        lblAgregarCancha.Margin = new Padding(4, 0, 4, 0);
        lblAgregarCancha.Name = "lblAgregarCancha";
        lblAgregarCancha.Size = new Size(133, 15);
        lblAgregarCancha.TabIndex = 12;
        lblAgregarCancha.Text = "Agregar nueva cancha:";
        // 
        // btnAgregarCancha
        // 
        btnAgregarCancha.BackColor = SystemColors.ControlLight;
        btnAgregarCancha.Location = new Point(154, 13);
        btnAgregarCancha.Margin = new Padding(4, 3, 4, 3);
        btnAgregarCancha.Name = "btnAgregarCancha";
        btnAgregarCancha.Size = new Size(88, 27);
        btnAgregarCancha.TabIndex = 11;
        btnAgregarCancha.Text = "Agregar";
        btnAgregarCancha.UseVisualStyleBackColor = false;
        btnAgregarCancha.Click += btnAgregarCancha_Click;
        // 
        // tabTiposCancha
        // 
        tabTiposCancha.BackColor = SystemColors.ActiveCaption;
        tabTiposCancha.Controls.Add(scTipos);
        tabTiposCancha.Location = new Point(4, 24);
        tabTiposCancha.Margin = new Padding(4, 3, 4, 3);
        tabTiposCancha.Name = "tabTiposCancha";
        tabTiposCancha.Padding = new Padding(4, 3, 4, 3);
        tabTiposCancha.Size = new Size(723, 337);
        tabTiposCancha.TabIndex = 3;
        tabTiposCancha.Text = "Tipos de cancha";
        // 
        // scTipos
        // 
        scTipos.Dock = DockStyle.Fill;
        scTipos.Location = new Point(4, 3);
        scTipos.Margin = new Padding(4, 3, 4, 3);
        scTipos.Name = "scTipos";
        // 
        // scTipos.Panel1
        // 
        scTipos.Panel1.Controls.Add(listBoxTiposCancha);
        scTipos.Panel1.Padding = new Padding(10, 10, 10, 20);
        // 
        // scTipos.Panel2
        // 
        scTipos.Panel2.BackColor = Color.Transparent;
        scTipos.Panel2.Controls.Add(lblReporteTipo);
        scTipos.Panel2.Controls.Add(btnReporteTipos);
        scTipos.Panel2.Controls.Add(lblEliminarTipo);
        scTipos.Panel2.Controls.Add(btnEliminarTipo);
        scTipos.Panel2.Controls.Add(lblModificarTipo);
        scTipos.Panel2.Controls.Add(btnModificarTipo);
        scTipos.Panel2.Controls.Add(lblConsultarTipo);
        scTipos.Panel2.Controls.Add(btnConsultarTipo);
        scTipos.Panel2.Controls.Add(lblAgregarTipo);
        scTipos.Panel2.Controls.Add(btnAgregarTipo);
        scTipos.Size = new Size(715, 331);
        scTipos.SplitterDistance = 462;
        scTipos.SplitterWidth = 5;
        scTipos.TabIndex = 4;
        // 
        // listBoxTiposCancha
        // 
        listBoxTiposCancha.BackColor = SystemColors.ActiveCaption;
        listBoxTiposCancha.BorderStyle = BorderStyle.FixedSingle;
        listBoxTiposCancha.Dock = DockStyle.Fill;
        listBoxTiposCancha.FormattingEnabled = true;
        listBoxTiposCancha.Items.AddRange(new object[] { "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200", "id : AhSskAJems54ss4s - Tipo: cancha de 5 - estado : habilitada - capacidad : 200" });
        listBoxTiposCancha.Location = new Point(10, 10);
        listBoxTiposCancha.Name = "listBoxTiposCancha";
        listBoxTiposCancha.Size = new Size(442, 301);
        listBoxTiposCancha.TabIndex = 1;
        listBoxTiposCancha.SelectedIndexChanged += listBoxTiposCancha_SelectedIndexChanged;
        listBoxTiposCancha.MouseDown += listBoxTiposCancha_MouseDown;
        // 
        // lblReporteTipo
        // 
        lblReporteTipo.AutoSize = true;
        lblReporteTipo.Location = new Point(-2, 53);
        lblReporteTipo.Margin = new Padding(4, 0, 4, 0);
        lblReporteTipo.Name = "lblReporteTipo";
        lblReporteTipo.Size = new Size(149, 15);
        lblReporteTipo.TabIndex = 22;
        lblReporteTipo.Text = "Generar reporte de tipos:";
        // 
        // btnReporteTipos
        // 
        btnReporteTipos.BackColor = SystemColors.ControlLight;
        btnReporteTipos.Location = new Point(154, 47);
        btnReporteTipos.Margin = new Padding(4, 3, 4, 3);
        btnReporteTipos.Name = "btnReporteTipos";
        btnReporteTipos.Size = new Size(88, 27);
        btnReporteTipos.TabIndex = 21;
        btnReporteTipos.TabStop = false;
        btnReporteTipos.Text = "Generar";
        btnReporteTipos.UseVisualStyleBackColor = false;
        btnReporteTipos.Click += btnReporteTipos_Click;
        // 
        // lblEliminarTipo
        // 
        lblEliminarTipo.AutoSize = true;
        lblEliminarTipo.Location = new Point(-2, 185);
        lblEliminarTipo.Margin = new Padding(4, 0, 4, 0);
        lblEliminarTipo.Name = "lblEliminarTipo";
        lblEliminarTipo.Size = new Size(137, 15);
        lblEliminarTipo.TabIndex = 20;
        lblEliminarTipo.Text = "Eliminar tipo de cancha:";
        // 
        // btnEliminarTipo
        // 
        btnEliminarTipo.BackColor = SystemColors.ControlLight;
        btnEliminarTipo.Enabled = false;
        btnEliminarTipo.Location = new Point(154, 179);
        btnEliminarTipo.Margin = new Padding(4, 3, 4, 3);
        btnEliminarTipo.Name = "btnEliminarTipo";
        btnEliminarTipo.Size = new Size(88, 27);
        btnEliminarTipo.TabIndex = 19;
        btnEliminarTipo.Text = "Eliminar";
        btnEliminarTipo.UseVisualStyleBackColor = false;
        btnEliminarTipo.Click += btnEliminarTipo_Click;
        // 
        // lblModificarTipo
        // 
        lblModificarTipo.AutoSize = true;
        lblModificarTipo.Location = new Point(-2, 141);
        lblModificarTipo.Margin = new Padding(4, 0, 4, 0);
        lblModificarTipo.Name = "lblModificarTipo";
        lblModificarTipo.Size = new Size(134, 15);
        lblModificarTipo.TabIndex = 16;
        lblModificarTipo.Text = "Modificar propiedades:";
        // 
        // btnModificarTipo
        // 
        btnModificarTipo.BackColor = SystemColors.ControlLight;
        btnModificarTipo.Enabled = false;
        btnModificarTipo.Location = new Point(154, 135);
        btnModificarTipo.Margin = new Padding(4, 3, 4, 3);
        btnModificarTipo.Name = "btnModificarTipo";
        btnModificarTipo.Size = new Size(88, 27);
        btnModificarTipo.TabIndex = 15;
        btnModificarTipo.Text = "Modificar";
        btnModificarTipo.UseVisualStyleBackColor = false;
        btnModificarTipo.Click += btnModificarTipo_Click;
        // 
        // lblConsultarTipo
        // 
        lblConsultarTipo.AutoSize = true;
        lblConsultarTipo.Location = new Point(-2, 97);
        lblConsultarTipo.Margin = new Padding(4, 0, 4, 0);
        lblConsultarTipo.Name = "lblConsultarTipo";
        lblConsultarTipo.Size = new Size(133, 15);
        lblConsultarTipo.TabIndex = 14;
        lblConsultarTipo.Text = "Consultar propiedades:";
        // 
        // btnConsultarTipo
        // 
        btnConsultarTipo.BackColor = SystemColors.ControlLight;
        btnConsultarTipo.Enabled = false;
        btnConsultarTipo.Location = new Point(154, 91);
        btnConsultarTipo.Margin = new Padding(4, 3, 4, 3);
        btnConsultarTipo.Name = "btnConsultarTipo";
        btnConsultarTipo.Size = new Size(88, 27);
        btnConsultarTipo.TabIndex = 13;
        btnConsultarTipo.Text = "Consultar";
        btnConsultarTipo.UseVisualStyleBackColor = false;
        btnConsultarTipo.Click += btnConsultarTipo_Click;
        // 
        // lblAgregarTipo
        // 
        lblAgregarTipo.AutoSize = true;
        lblAgregarTipo.Location = new Point(-2, 9);
        lblAgregarTipo.Margin = new Padding(4, 0, 4, 0);
        lblAgregarTipo.Name = "lblAgregarTipo";
        lblAgregarTipo.Size = new Size(118, 15);
        lblAgregarTipo.TabIndex = 12;
        lblAgregarTipo.Text = "Agregar nuevo tipo:";
        // 
        // btnAgregarTipo
        // 
        btnAgregarTipo.BackColor = SystemColors.ControlLight;
        btnAgregarTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAgregarTipo.Location = new Point(154, 3);
        btnAgregarTipo.Margin = new Padding(4, 3, 4, 3);
        btnAgregarTipo.Name = "btnAgregarTipo";
        btnAgregarTipo.Size = new Size(88, 27);
        btnAgregarTipo.TabIndex = 11;
        btnAgregarTipo.Text = "Agregar";
        btnAgregarTipo.UseVisualStyleBackColor = false;
        btnAgregarTipo.Click += btnAgregarTipo_Click;
        // 
        // cbEstados
        // 
        cbEstados.DropDownStyle = ComboBoxStyle.DropDownList;
        cbEstados.FormattingEnabled = true;
        cbEstados.Items.AddRange(new object[] { "Activas", "Bloqueadas", "Todas" });
        cbEstados.Location = new Point(259, 5);
        cbEstados.Margin = new Padding(4, 3, 4, 3);
        cbEstados.Name = "cbEstados";
        cbEstados.Size = new Size(70, 23);
        cbEstados.TabIndex = 15;
        // 
        // txtBusqueda
        // 
        txtBusqueda.Location = new Point(444, 5);
        txtBusqueda.Name = "txtBusqueda";
        txtBusqueda.Size = new Size(174, 23);
        txtBusqueda.TabIndex = 16;
        // 
        // lblFiltrado
        // 
        lblFiltrado.AutoSize = true;
        lblFiltrado.Location = new Point(187, 10);
        lblFiltrado.Name = "lblFiltrado";
        lblFiltrado.Size = new Size(65, 15);
        lblFiltrado.TabIndex = 17;
        lblFiltrado.Text = "Filtrar por:";
        // 
        // ucCanchas
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        Controls.Add(lblFiltrado);
        Controls.Add(txtBusqueda);
        Controls.Add(cbEstados);
        Controls.Add(cbFiltrar);
        Controls.Add(btnBuscar);
        Controls.Add(tcCanchas);
        Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ucCanchas";
        Size = new Size(723, 421);
        Click += ucCanchas_Click;
        tcCanchas.ResumeLayout(false);
        tabCanchas.ResumeLayout(false);
        scCanchas.Panel1.ResumeLayout(false);
        scCanchas.Panel2.ResumeLayout(false);
        scCanchas.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)scCanchas).EndInit();
        scCanchas.ResumeLayout(false);
        tabTiposCancha.ResumeLayout(false);
        scTipos.Panel1.ResumeLayout(false);
        scTipos.Panel2.ResumeLayout(false);
        scTipos.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)scTipos).EndInit();
        scTipos.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbFiltrar;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.TabControl tcCanchas;
    private System.Windows.Forms.TabPage tabCanchas;
    private System.Windows.Forms.TabPage tabTiposCancha;
    private System.Windows.Forms.SplitContainer scTipos;
    private System.Windows.Forms.Label lblEliminarTipo;
    private System.Windows.Forms.Button btnEliminarTipo;
    private System.Windows.Forms.Label lblModificarTipo;
    private System.Windows.Forms.Button btnModificarTipo;
    private System.Windows.Forms.Label lblConsultarTipo;
    private System.Windows.Forms.Button btnConsultarTipo;
    private System.Windows.Forms.Label lblAgregarTipo;
    private System.Windows.Forms.Button btnAgregarTipo;
    private System.Windows.Forms.SplitContainer scCanchas;
    private System.Windows.Forms.Label lblBloquearCancha;
    private System.Windows.Forms.Button btnBloquearCancha;
    private System.Windows.Forms.Label lblBajaCancha;
    private System.Windows.Forms.Button btnBajaCancha;
    private System.Windows.Forms.Label lblModificarCancha;
    private System.Windows.Forms.Button btnModificarCancha;
    private System.Windows.Forms.Label lblConsultarCancha;
    private System.Windows.Forms.Button btnConsultarCancha;
    private System.Windows.Forms.Label lblAgregarCancha;
    private System.Windows.Forms.Button btnAgregarCancha;
    private System.Windows.Forms.Label lblReporteTipo;
    private System.Windows.Forms.Button btnReporteTipos;
    private ComboBox cbEstados;
    private ListBox listBoxCanchas;
    private ListBox listBoxTiposCancha;
    private TextBox txtBusqueda;
    private Label lblFiltrado;
}
