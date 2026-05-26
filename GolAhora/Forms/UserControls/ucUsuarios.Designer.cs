namespace GolAhora.Forms.UserControls
{
    partial class ucUsuarios
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
            btnBuscar = new Button();
            cbFiltrado = new ComboBox();
            tabAdministradores = new TabPage();
            scAdministradores = new SplitContainer();
            listBoxAdministradores = new ListBox();
            label16 = new Label();
            btnImprimirAdmin = new Button();
            label17 = new Label();
            btnBajaAdmin = new Button();
            label18 = new Label();
            btnModificarAdmin = new Button();
            label19 = new Label();
            btnConsultarAdmin = new Button();
            label20 = new Label();
            btnRegistrarAdmin = new Button();
            tabEntrenadores = new TabPage();
            scEntrenadores = new SplitContainer();
            listBoxEntrenadores = new ListBox();
            label11 = new Label();
            btnImprimirEntrenador = new Button();
            label12 = new Label();
            btnBajaEntrenador = new Button();
            label13 = new Label();
            btnModificarEntrenador = new Button();
            label14 = new Label();
            btnConsultarEntrenador = new Button();
            label15 = new Label();
            btnRegistrarEntrenador = new Button();
            tabProfesores = new TabPage();
            scProfesores = new SplitContainer();
            listBoxProfesores = new ListBox();
            label6 = new Label();
            btnImprimirProfesor = new Button();
            label7 = new Label();
            btnBajaProfesor = new Button();
            label8 = new Label();
            btnModificarProfesor = new Button();
            label9 = new Label();
            btnConsultarProfesor = new Button();
            label10 = new Label();
            btnRegistrarProfesor = new Button();
            tabClientes = new TabPage();
            scClientes = new SplitContainer();
            listBoxClientes = new ListBox();
            label1 = new Label();
            btnImprimirCliente = new Button();
            label2 = new Label();
            btnBajaCliente = new Button();
            label3 = new Label();
            btnModificarCliente = new Button();
            label4 = new Label();
            btnConsultarCliente = new Button();
            label5 = new Label();
            btnRegistrarCliente = new Button();
            tbTodos = new TabPage();
            panelUsuarios = new Panel();
            listBoxUsuarios = new ListBox();
            tcUsuarios = new TabControl();
            txtBusqueda = new TextBox();
            tabAdministradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scAdministradores).BeginInit();
            scAdministradores.Panel1.SuspendLayout();
            scAdministradores.Panel2.SuspendLayout();
            scAdministradores.SuspendLayout();
            tabEntrenadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scEntrenadores).BeginInit();
            scEntrenadores.Panel1.SuspendLayout();
            scEntrenadores.Panel2.SuspendLayout();
            scEntrenadores.SuspendLayout();
            tabProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scProfesores).BeginInit();
            scProfesores.Panel1.SuspendLayout();
            scProfesores.Panel2.SuspendLayout();
            scProfesores.SuspendLayout();
            tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scClientes).BeginInit();
            scClientes.Panel1.SuspendLayout();
            scClientes.Panel2.SuspendLayout();
            scClientes.SuspendLayout();
            tbTodos.SuspendLayout();
            panelUsuarios.SuspendLayout();
            tcUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLight;
            btnBuscar.FlatStyle = FlatStyle.System;
            btnBuscar.Location = new Point(625, 6);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 24);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbFiltrado
            // 
            cbFiltrado.FormattingEnabled = true;
            cbFiltrado.Items.AddRange(new object[] { "dni", "Nombre", "Email" });
            cbFiltrado.Location = new Point(339, 6);
            cbFiltrado.Margin = new Padding(4, 3, 4, 3);
            cbFiltrado.Name = "cbFiltrado";
            cbFiltrado.Size = new Size(98, 23);
            cbFiltrado.TabIndex = 6;
            cbFiltrado.Text = "Filtrar por";
            // 
            // tabAdministradores
            // 
            tabAdministradores.BackColor = SystemColors.ActiveCaption;
            tabAdministradores.Controls.Add(scAdministradores);
            tabAdministradores.Location = new Point(4, 24);
            tabAdministradores.Name = "tabAdministradores";
            tabAdministradores.Padding = new Padding(3);
            tabAdministradores.Size = new Size(723, 337);
            tabAdministradores.TabIndex = 4;
            tabAdministradores.Text = "Administradores";
            // 
            // scAdministradores
            // 
            scAdministradores.BackColor = SystemColors.ActiveCaption;
            scAdministradores.Dock = DockStyle.Fill;
            scAdministradores.Location = new Point(3, 3);
            scAdministradores.Margin = new Padding(4, 3, 4, 3);
            scAdministradores.Name = "scAdministradores";
            // 
            // scAdministradores.Panel1
            // 
            scAdministradores.Panel1.Controls.Add(listBoxAdministradores);
            scAdministradores.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scAdministradores.Panel2
            // 
            scAdministradores.Panel2.Controls.Add(label16);
            scAdministradores.Panel2.Controls.Add(btnImprimirAdmin);
            scAdministradores.Panel2.Controls.Add(label17);
            scAdministradores.Panel2.Controls.Add(btnBajaAdmin);
            scAdministradores.Panel2.Controls.Add(label18);
            scAdministradores.Panel2.Controls.Add(btnModificarAdmin);
            scAdministradores.Panel2.Controls.Add(label19);
            scAdministradores.Panel2.Controls.Add(btnConsultarAdmin);
            scAdministradores.Panel2.Controls.Add(label20);
            scAdministradores.Panel2.Controls.Add(btnRegistrarAdmin);
            scAdministradores.Panel2.Padding = new Padding(10, 10, 10, 20);
            scAdministradores.Size = new Size(717, 331);
            scAdministradores.SplitterDistance = 463;
            scAdministradores.SplitterWidth = 5;
            scAdministradores.TabIndex = 3;
            // 
            // listBoxAdministradores
            // 
            listBoxAdministradores.BackColor = SystemColors.ActiveCaption;
            listBoxAdministradores.BorderStyle = BorderStyle.FixedSingle;
            listBoxAdministradores.FormattingEnabled = true;
            listBoxAdministradores.Items.AddRange(new object[] { "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador" });
            listBoxAdministradores.Location = new Point(4, 3);
            listBoxAdministradores.Name = "listBoxAdministradores";
            listBoxAdministradores.Size = new Size(455, 317);
            listBoxAdministradores.TabIndex = 1;
            listBoxAdministradores.SelectedIndexChanged += listBoxAdministradores_SelectedIndexChanged;
            listBoxAdministradores.MouseDown += listBoxAdministradores_MouseDown;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 151);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(92, 15);
            label16.TabIndex = 20;
            label16.Text = "Imprimir datos:";
            // 
            // btnImprimirAdmin
            // 
            btnImprimirAdmin.BackColor = SystemColors.ControlLight;
            btnImprimirAdmin.Enabled = false;
            btnImprimirAdmin.Location = new Point(154, 145);
            btnImprimirAdmin.Margin = new Padding(4, 3, 4, 3);
            btnImprimirAdmin.Name = "btnImprimirAdmin";
            btnImprimirAdmin.Size = new Size(88, 27);
            btnImprimirAdmin.TabIndex = 19;
            btnImprimirAdmin.Text = "Imprimir";
            btnImprimirAdmin.UseVisualStyleBackColor = false;
            btnImprimirAdmin.Click += btnImprimirAdmin_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 195);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(152, 15);
            label17.TabIndex = 18;
            label17.Text = "Dar de baja administrador:";
            // 
            // btnBajaAdmin
            // 
            btnBajaAdmin.BackColor = SystemColors.ControlLight;
            btnBajaAdmin.Enabled = false;
            btnBajaAdmin.Location = new Point(154, 189);
            btnBajaAdmin.Margin = new Padding(4, 3, 4, 3);
            btnBajaAdmin.Name = "btnBajaAdmin";
            btnBajaAdmin.Size = new Size(88, 27);
            btnBajaAdmin.TabIndex = 17;
            btnBajaAdmin.Text = "Baja";
            btnBajaAdmin.UseVisualStyleBackColor = false;
            btnBajaAdmin.Click += btnBajaAdmin_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 107);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(96, 15);
            label18.TabIndex = 16;
            label18.Text = "Modificar datos:";
            // 
            // btnModificarAdmin
            // 
            btnModificarAdmin.BackColor = SystemColors.ControlLight;
            btnModificarAdmin.Enabled = false;
            btnModificarAdmin.Location = new Point(154, 101);
            btnModificarAdmin.Margin = new Padding(4, 3, 4, 3);
            btnModificarAdmin.Name = "btnModificarAdmin";
            btnModificarAdmin.Size = new Size(88, 27);
            btnModificarAdmin.TabIndex = 15;
            btnModificarAdmin.Text = "Modificar";
            btnModificarAdmin.UseVisualStyleBackColor = false;
            btnModificarAdmin.Click += btnModificarAdmin_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 63);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(95, 15);
            label19.TabIndex = 14;
            label19.Text = "Consultar datos:";
            // 
            // btnConsultarAdmin
            // 
            btnConsultarAdmin.BackColor = SystemColors.ControlLight;
            btnConsultarAdmin.Enabled = false;
            btnConsultarAdmin.Location = new Point(154, 57);
            btnConsultarAdmin.Margin = new Padding(4, 3, 4, 3);
            btnConsultarAdmin.Name = "btnConsultarAdmin";
            btnConsultarAdmin.Size = new Size(88, 27);
            btnConsultarAdmin.TabIndex = 13;
            btnConsultarAdmin.Text = "Consultar";
            btnConsultarAdmin.UseVisualStyleBackColor = false;
            btnConsultarAdmin.Click += btnConsultarAdmin_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 19);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(141, 15);
            label20.TabIndex = 12;
            label20.Text = "Registrar administrador:";
            // 
            // btnRegistrarAdmin
            // 
            btnRegistrarAdmin.BackColor = SystemColors.ControlLight;
            btnRegistrarAdmin.Location = new Point(154, 13);
            btnRegistrarAdmin.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarAdmin.Name = "btnRegistrarAdmin";
            btnRegistrarAdmin.Size = new Size(88, 27);
            btnRegistrarAdmin.TabIndex = 11;
            btnRegistrarAdmin.Text = "Registrar ";
            btnRegistrarAdmin.UseVisualStyleBackColor = false;
            btnRegistrarAdmin.Click += btnRegistrarAdmin_Click;
            // 
            // tabEntrenadores
            // 
            tabEntrenadores.BackColor = SystemColors.ActiveCaption;
            tabEntrenadores.Controls.Add(scEntrenadores);
            tabEntrenadores.Location = new Point(4, 24);
            tabEntrenadores.Margin = new Padding(4, 3, 4, 3);
            tabEntrenadores.Name = "tabEntrenadores";
            tabEntrenadores.Padding = new Padding(4, 3, 4, 3);
            tabEntrenadores.Size = new Size(723, 337);
            tabEntrenadores.TabIndex = 2;
            tabEntrenadores.Text = "Entrenadores";
            // 
            // scEntrenadores
            // 
            scEntrenadores.BackColor = SystemColors.ActiveCaption;
            scEntrenadores.Dock = DockStyle.Fill;
            scEntrenadores.Location = new Point(4, 3);
            scEntrenadores.Margin = new Padding(4, 3, 4, 3);
            scEntrenadores.Name = "scEntrenadores";
            // 
            // scEntrenadores.Panel1
            // 
            scEntrenadores.Panel1.Controls.Add(listBoxEntrenadores);
            // 
            // scEntrenadores.Panel2
            // 
            scEntrenadores.Panel2.Controls.Add(label11);
            scEntrenadores.Panel2.Controls.Add(btnImprimirEntrenador);
            scEntrenadores.Panel2.Controls.Add(label12);
            scEntrenadores.Panel2.Controls.Add(btnBajaEntrenador);
            scEntrenadores.Panel2.Controls.Add(label13);
            scEntrenadores.Panel2.Controls.Add(btnModificarEntrenador);
            scEntrenadores.Panel2.Controls.Add(label14);
            scEntrenadores.Panel2.Controls.Add(btnConsultarEntrenador);
            scEntrenadores.Panel2.Controls.Add(label15);
            scEntrenadores.Panel2.Controls.Add(btnRegistrarEntrenador);
            scEntrenadores.Panel2.Padding = new Padding(10, 10, 10, 20);
            scEntrenadores.Size = new Size(715, 331);
            scEntrenadores.SplitterDistance = 462;
            scEntrenadores.SplitterWidth = 5;
            scEntrenadores.TabIndex = 2;
            // 
            // listBoxEntrenadores
            // 
            listBoxEntrenadores.BackColor = SystemColors.ActiveCaption;
            listBoxEntrenadores.BorderStyle = BorderStyle.FixedSingle;
            listBoxEntrenadores.FormattingEnabled = true;
            listBoxEntrenadores.Items.AddRange(new object[] { "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador" });
            listBoxEntrenadores.Location = new Point(4, 3);
            listBoxEntrenadores.Name = "listBoxEntrenadores";
            listBoxEntrenadores.Size = new Size(455, 317);
            listBoxEntrenadores.TabIndex = 1;
            listBoxEntrenadores.SelectedIndexChanged += listBoxEntrenadores_SelectedIndexChanged;
            listBoxEntrenadores.MouseDown += listBoxEntrenadores_MouseDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 151);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 20;
            label11.Text = "Imprimir datos:";
            // 
            // btnImprimirEntrenador
            // 
            btnImprimirEntrenador.BackColor = SystemColors.ControlLight;
            btnImprimirEntrenador.Enabled = false;
            btnImprimirEntrenador.Location = new Point(154, 145);
            btnImprimirEntrenador.Margin = new Padding(4, 3, 4, 3);
            btnImprimirEntrenador.Name = "btnImprimirEntrenador";
            btnImprimirEntrenador.Size = new Size(88, 27);
            btnImprimirEntrenador.TabIndex = 19;
            btnImprimirEntrenador.Text = "Imprimir";
            btnImprimirEntrenador.UseVisualStyleBackColor = false;
            btnImprimirEntrenador.Click += btnImprimirEntrenador_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(8, 195);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(138, 15);
            label12.TabIndex = 18;
            label12.Text = "Dar de baja entrenador:";
            // 
            // btnBajaEntrenador
            // 
            btnBajaEntrenador.BackColor = SystemColors.ControlLight;
            btnBajaEntrenador.Enabled = false;
            btnBajaEntrenador.Location = new Point(154, 189);
            btnBajaEntrenador.Margin = new Padding(4, 3, 4, 3);
            btnBajaEntrenador.Name = "btnBajaEntrenador";
            btnBajaEntrenador.Size = new Size(88, 27);
            btnBajaEntrenador.TabIndex = 17;
            btnBajaEntrenador.Text = "Baja";
            btnBajaEntrenador.UseVisualStyleBackColor = false;
            btnBajaEntrenador.Click += btnBajaEntrenador_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(8, 107);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 16;
            label13.Text = "Modificar datos:";
            // 
            // btnModificarEntrenador
            // 
            btnModificarEntrenador.BackColor = SystemColors.ControlLight;
            btnModificarEntrenador.Enabled = false;
            btnModificarEntrenador.Location = new Point(154, 101);
            btnModificarEntrenador.Margin = new Padding(4, 3, 4, 3);
            btnModificarEntrenador.Name = "btnModificarEntrenador";
            btnModificarEntrenador.Size = new Size(88, 27);
            btnModificarEntrenador.TabIndex = 15;
            btnModificarEntrenador.Text = "Modificar";
            btnModificarEntrenador.UseVisualStyleBackColor = false;
            btnModificarEntrenador.Click += btnModificarEntrenador_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 63);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(95, 15);
            label14.TabIndex = 14;
            label14.Text = "Consultar datos:";
            // 
            // btnConsultarEntrenador
            // 
            btnConsultarEntrenador.BackColor = SystemColors.ControlLight;
            btnConsultarEntrenador.Enabled = false;
            btnConsultarEntrenador.Location = new Point(154, 57);
            btnConsultarEntrenador.Margin = new Padding(4, 3, 4, 3);
            btnConsultarEntrenador.Name = "btnConsultarEntrenador";
            btnConsultarEntrenador.Size = new Size(88, 27);
            btnConsultarEntrenador.TabIndex = 13;
            btnConsultarEntrenador.Text = "Consultar";
            btnConsultarEntrenador.UseVisualStyleBackColor = false;
            btnConsultarEntrenador.Click += btnConsultarEntrenador_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 19);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(127, 15);
            label15.TabIndex = 12;
            label15.Text = "Registrar entrenador:";
            // 
            // btnRegistrarEntrenador
            // 
            btnRegistrarEntrenador.BackColor = SystemColors.ControlLight;
            btnRegistrarEntrenador.Location = new Point(154, 13);
            btnRegistrarEntrenador.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            btnRegistrarEntrenador.Size = new Size(88, 27);
            btnRegistrarEntrenador.TabIndex = 11;
            btnRegistrarEntrenador.Text = "Registrar ";
            btnRegistrarEntrenador.UseVisualStyleBackColor = false;
            btnRegistrarEntrenador.Click += btnRegistrarEntrenador_Click;
            // 
            // tabProfesores
            // 
            tabProfesores.BackColor = SystemColors.ActiveCaption;
            tabProfesores.Controls.Add(scProfesores);
            tabProfesores.Location = new Point(4, 24);
            tabProfesores.Margin = new Padding(4, 3, 4, 3);
            tabProfesores.Name = "tabProfesores";
            tabProfesores.Padding = new Padding(4, 3, 4, 3);
            tabProfesores.Size = new Size(723, 337);
            tabProfesores.TabIndex = 1;
            tabProfesores.Text = "Profesores";
            // 
            // scProfesores
            // 
            scProfesores.Dock = DockStyle.Fill;
            scProfesores.Location = new Point(4, 3);
            scProfesores.Margin = new Padding(4, 3, 4, 3);
            scProfesores.Name = "scProfesores";
            // 
            // scProfesores.Panel1
            // 
            scProfesores.Panel1.Controls.Add(listBoxProfesores);
            scProfesores.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scProfesores.Panel2
            // 
            scProfesores.Panel2.BackColor = Color.Transparent;
            scProfesores.Panel2.Controls.Add(label6);
            scProfesores.Panel2.Controls.Add(btnImprimirProfesor);
            scProfesores.Panel2.Controls.Add(label7);
            scProfesores.Panel2.Controls.Add(btnBajaProfesor);
            scProfesores.Panel2.Controls.Add(label8);
            scProfesores.Panel2.Controls.Add(btnModificarProfesor);
            scProfesores.Panel2.Controls.Add(label9);
            scProfesores.Panel2.Controls.Add(btnConsultarProfesor);
            scProfesores.Panel2.Controls.Add(label10);
            scProfesores.Panel2.Controls.Add(btnRegistrarProfesor);
            scProfesores.Panel2.Padding = new Padding(10, 10, 10, 20);
            scProfesores.Size = new Size(715, 331);
            scProfesores.SplitterDistance = 462;
            scProfesores.SplitterWidth = 5;
            scProfesores.TabIndex = 4;
            // 
            // listBoxProfesores
            // 
            listBoxProfesores.BackColor = SystemColors.ActiveCaption;
            listBoxProfesores.BorderStyle = BorderStyle.FixedSingle;
            listBoxProfesores.FormattingEnabled = true;
            listBoxProfesores.Items.AddRange(new object[] { "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor" });
            listBoxProfesores.Location = new Point(4, 3);
            listBoxProfesores.Name = "listBoxProfesores";
            listBoxProfesores.Size = new Size(455, 317);
            listBoxProfesores.TabIndex = 1;
            listBoxProfesores.SelectedIndexChanged += listBoxProfesores_SelectedIndexChanged;
            listBoxProfesores.MouseDown += listBoxProfesores_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 151);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 20;
            label6.Text = "Imprimir datos:";
            // 
            // btnImprimirProfesor
            // 
            btnImprimirProfesor.BackColor = SystemColors.ControlLight;
            btnImprimirProfesor.Enabled = false;
            btnImprimirProfesor.Location = new Point(146, 145);
            btnImprimirProfesor.Margin = new Padding(4, 3, 4, 3);
            btnImprimirProfesor.Name = "btnImprimirProfesor";
            btnImprimirProfesor.Size = new Size(88, 27);
            btnImprimirProfesor.TabIndex = 19;
            btnImprimirProfesor.Text = "Imprimir";
            btnImprimirProfesor.UseVisualStyleBackColor = false;
            btnImprimirProfesor.Click += btnImprimirProfesor_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 195);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 18;
            label7.Text = "Dar de baja profesor:";
            // 
            // btnBajaProfesor
            // 
            btnBajaProfesor.BackColor = SystemColors.ControlLight;
            btnBajaProfesor.Enabled = false;
            btnBajaProfesor.Location = new Point(146, 189);
            btnBajaProfesor.Margin = new Padding(4, 3, 4, 3);
            btnBajaProfesor.Name = "btnBajaProfesor";
            btnBajaProfesor.Size = new Size(88, 27);
            btnBajaProfesor.TabIndex = 17;
            btnBajaProfesor.Text = "Baja";
            btnBajaProfesor.UseVisualStyleBackColor = false;
            btnBajaProfesor.Click += btnBajaProfesor_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 107);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 15);
            label8.TabIndex = 16;
            label8.Text = "Modificar datos:";
            // 
            // btnModificarProfesor
            // 
            btnModificarProfesor.BackColor = SystemColors.ControlLight;
            btnModificarProfesor.Enabled = false;
            btnModificarProfesor.Location = new Point(146, 101);
            btnModificarProfesor.Margin = new Padding(4, 3, 4, 3);
            btnModificarProfesor.Name = "btnModificarProfesor";
            btnModificarProfesor.Size = new Size(88, 27);
            btnModificarProfesor.TabIndex = 15;
            btnModificarProfesor.Text = "Modificar";
            btnModificarProfesor.UseVisualStyleBackColor = false;
            btnModificarProfesor.Click += btnModificarProfesor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 63);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 14;
            label9.Text = "Consultar datos:";
            // 
            // btnConsultarProfesor
            // 
            btnConsultarProfesor.BackColor = SystemColors.ControlLight;
            btnConsultarProfesor.Enabled = false;
            btnConsultarProfesor.Location = new Point(146, 57);
            btnConsultarProfesor.Margin = new Padding(4, 3, 4, 3);
            btnConsultarProfesor.Name = "btnConsultarProfesor";
            btnConsultarProfesor.Size = new Size(88, 27);
            btnConsultarProfesor.TabIndex = 13;
            btnConsultarProfesor.Text = "Consultar";
            btnConsultarProfesor.UseVisualStyleBackColor = false;
            btnConsultarProfesor.Click += btnConsultarProfesor_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 19);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 15);
            label10.TabIndex = 12;
            label10.Text = "Registrar profesor:";
            // 
            // btnRegistrarProfesor
            // 
            btnRegistrarProfesor.BackColor = SystemColors.ControlLight;
            btnRegistrarProfesor.Location = new Point(146, 13);
            btnRegistrarProfesor.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarProfesor.Name = "btnRegistrarProfesor";
            btnRegistrarProfesor.Size = new Size(88, 27);
            btnRegistrarProfesor.TabIndex = 11;
            btnRegistrarProfesor.Text = "Registrar ";
            btnRegistrarProfesor.UseVisualStyleBackColor = false;
            btnRegistrarProfesor.Click += btnRegistrarProfesor_Click;
            // 
            // tabClientes
            // 
            tabClientes.BackColor = SystemColors.ActiveCaption;
            tabClientes.Controls.Add(scClientes);
            tabClientes.Location = new Point(4, 24);
            tabClientes.Margin = new Padding(4, 3, 4, 3);
            tabClientes.Name = "tabClientes";
            tabClientes.Padding = new Padding(4, 3, 4, 3);
            tabClientes.Size = new Size(723, 337);
            tabClientes.TabIndex = 0;
            tabClientes.Text = "Clientes";
            // 
            // scClientes
            // 
            scClientes.Dock = DockStyle.Fill;
            scClientes.Location = new Point(4, 3);
            scClientes.Margin = new Padding(4, 3, 4, 3);
            scClientes.Name = "scClientes";
            // 
            // scClientes.Panel1
            // 
            scClientes.Panel1.Controls.Add(listBoxClientes);
            scClientes.Panel1.Padding = new Padding(10, 10, 10, 20);
            // 
            // scClientes.Panel2
            // 
            scClientes.Panel2.BackColor = Color.Transparent;
            scClientes.Panel2.Controls.Add(label1);
            scClientes.Panel2.Controls.Add(btnImprimirCliente);
            scClientes.Panel2.Controls.Add(label2);
            scClientes.Panel2.Controls.Add(btnBajaCliente);
            scClientes.Panel2.Controls.Add(label3);
            scClientes.Panel2.Controls.Add(btnModificarCliente);
            scClientes.Panel2.Controls.Add(label4);
            scClientes.Panel2.Controls.Add(btnConsultarCliente);
            scClientes.Panel2.Controls.Add(label5);
            scClientes.Panel2.Controls.Add(btnRegistrarCliente);
            scClientes.Panel2.Padding = new Padding(10);
            scClientes.Size = new Size(715, 331);
            scClientes.SplitterDistance = 462;
            scClientes.SplitterWidth = 5;
            scClientes.TabIndex = 3;
            // 
            // listBoxClientes
            // 
            listBoxClientes.BackColor = SystemColors.ActiveCaption;
            listBoxClientes.BorderStyle = BorderStyle.FixedSingle;
            listBoxClientes.Dock = DockStyle.Fill;
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.Items.AddRange(new object[] { "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente" });
            listBoxClientes.Location = new Point(10, 10);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(442, 301);
            listBoxClientes.TabIndex = 2;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            listBoxClientes.MouseDown += listBoxClientes_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 151);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 20;
            label1.Text = "Imprimir datos:";
            // 
            // btnImprimirCliente
            // 
            btnImprimirCliente.BackColor = SystemColors.ControlLight;
            btnImprimirCliente.Enabled = false;
            btnImprimirCliente.Location = new Point(146, 145);
            btnImprimirCliente.Margin = new Padding(4, 3, 4, 3);
            btnImprimirCliente.Name = "btnImprimirCliente";
            btnImprimirCliente.Size = new Size(88, 27);
            btnImprimirCliente.TabIndex = 19;
            btnImprimirCliente.Text = "Imprimir";
            btnImprimirCliente.UseVisualStyleBackColor = false;
            btnImprimirCliente.Click += btnImprimirCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 195);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 18;
            label2.Text = "Dar de baja cliente:";
            // 
            // btnBajaCliente
            // 
            btnBajaCliente.BackColor = SystemColors.ControlLight;
            btnBajaCliente.Enabled = false;
            btnBajaCliente.Location = new Point(146, 189);
            btnBajaCliente.Margin = new Padding(4, 3, 4, 3);
            btnBajaCliente.Name = "btnBajaCliente";
            btnBajaCliente.Size = new Size(88, 27);
            btnBajaCliente.TabIndex = 17;
            btnBajaCliente.Text = "Baja";
            btnBajaCliente.UseVisualStyleBackColor = false;
            btnBajaCliente.Click += btnBajaCliente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 16;
            label3.Text = "Modificar datos:";
            // 
            // btnModificarCliente
            // 
            btnModificarCliente.BackColor = SystemColors.ControlLight;
            btnModificarCliente.Enabled = false;
            btnModificarCliente.Location = new Point(146, 101);
            btnModificarCliente.Margin = new Padding(4, 3, 4, 3);
            btnModificarCliente.Name = "btnModificarCliente";
            btnModificarCliente.Size = new Size(88, 27);
            btnModificarCliente.TabIndex = 15;
            btnModificarCliente.Text = "Modificar";
            btnModificarCliente.UseVisualStyleBackColor = false;
            btnModificarCliente.Click += btnModificarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 14;
            label4.Text = "Consultar datos:";
            // 
            // btnConsultarCliente
            // 
            btnConsultarCliente.BackColor = SystemColors.ControlLight;
            btnConsultarCliente.Enabled = false;
            btnConsultarCliente.Location = new Point(146, 57);
            btnConsultarCliente.Margin = new Padding(4, 3, 4, 3);
            btnConsultarCliente.Name = "btnConsultarCliente";
            btnConsultarCliente.Size = new Size(88, 27);
            btnConsultarCliente.TabIndex = 13;
            btnConsultarCliente.Text = "Consultar";
            btnConsultarCliente.UseVisualStyleBackColor = false;
            btnConsultarCliente.Click += btnConsultarCliente_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 19);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 12;
            label5.Text = "Registrar cliente:";
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = SystemColors.ControlLight;
            btnRegistrarCliente.Location = new Point(146, 13);
            btnRegistrarCliente.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(88, 27);
            btnRegistrarCliente.TabIndex = 11;
            btnRegistrarCliente.Text = "Registrar ";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // tbTodos
            // 
            tbTodos.BackColor = SystemColors.ActiveCaption;
            tbTodos.Controls.Add(panelUsuarios);
            tbTodos.Location = new Point(4, 24);
            tbTodos.Name = "tbTodos";
            tbTodos.Padding = new Padding(3);
            tbTodos.Size = new Size(723, 337);
            tbTodos.TabIndex = 3;
            tbTodos.Text = "Todos";
            // 
            // panelUsuarios
            // 
            panelUsuarios.Controls.Add(listBoxUsuarios);
            panelUsuarios.Location = new Point(6, 3);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Padding = new Padding(10, 10, 10, 20);
            panelUsuarios.Size = new Size(714, 328);
            panelUsuarios.TabIndex = 0;
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.BackColor = SystemColors.ActiveCaption;
            listBoxUsuarios.BorderStyle = BorderStyle.FixedSingle;
            listBoxUsuarios.Dock = DockStyle.Fill;
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.Items.AddRange(new object[] { "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador", "nombre: erik Escalante - dni: 46628150 - genero: hombre - edad: 21- tipo: cliente", "nombre: robert smith - dni: 05182664 - genero: hombre - edad: 67 - tipo: profesor", "nombre: isaac asimov - dni: 36390146 - genero: robot - edad: 72 - tipo: entrenador", "nombre: agustina cepeda - dni 46109363 - genero: mujer - edad 21 - tipo: administrador" });
            listBoxUsuarios.Location = new Point(10, 10);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(694, 298);
            listBoxUsuarios.TabIndex = 4;
            // 
            // tcUsuarios
            // 
            tcUsuarios.Controls.Add(tbTodos);
            tcUsuarios.Controls.Add(tabClientes);
            tcUsuarios.Controls.Add(tabProfesores);
            tcUsuarios.Controls.Add(tabEntrenadores);
            tcUsuarios.Controls.Add(tabAdministradores);
            tcUsuarios.Location = new Point(-4, 60);
            tcUsuarios.Margin = new Padding(4, 3, 4, 3);
            tcUsuarios.Name = "tcUsuarios";
            tcUsuarios.SelectedIndex = 0;
            tcUsuarios.Size = new Size(731, 365);
            tcUsuarios.TabIndex = 0;
            tcUsuarios.Click += tcUsuarios_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(444, 6);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(174, 23);
            txtBusqueda.TabIndex = 7;
            // 
            // ucUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtBusqueda);
            Controls.Add(cbFiltrado);
            Controls.Add(btnBuscar);
            Controls.Add(tcUsuarios);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucUsuarios";
            Size = new Size(723, 421);
            Click += ucUsuarios_Click;
            tabAdministradores.ResumeLayout(false);
            scAdministradores.Panel1.ResumeLayout(false);
            scAdministradores.Panel2.ResumeLayout(false);
            scAdministradores.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scAdministradores).EndInit();
            scAdministradores.ResumeLayout(false);
            tabEntrenadores.ResumeLayout(false);
            scEntrenadores.Panel1.ResumeLayout(false);
            scEntrenadores.Panel2.ResumeLayout(false);
            scEntrenadores.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scEntrenadores).EndInit();
            scEntrenadores.ResumeLayout(false);
            tabProfesores.ResumeLayout(false);
            scProfesores.Panel1.ResumeLayout(false);
            scProfesores.Panel2.ResumeLayout(false);
            scProfesores.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scProfesores).EndInit();
            scProfesores.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            scClientes.Panel1.ResumeLayout(false);
            scClientes.Panel2.ResumeLayout(false);
            scClientes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scClientes).EndInit();
            scClientes.ResumeLayout(false);
            tbTodos.ResumeLayout(false);
            panelUsuarios.ResumeLayout(false);
            tcUsuarios.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbFiltrado;
        private TabPage tabAdministradores;
        private TabPage tabEntrenadores;
        private SplitContainer scEntrenadores;
        private Label label11;
        private Button btnImprimirEntrenador;
        private Label label12;
        private Button btnBajaEntrenador;
        private Label label13;
        private Button btnModificarEntrenador;
        private Label label14;
        private Button btnConsultarEntrenador;
        private Label label15;
        private Button btnRegistrarEntrenador;
        private TabPage tabProfesores;
        private TabPage tabClientes;
        private SplitContainer scClientes;
        private Label label1;
        private Button btnImprimirCliente;
        private Label label2;
        private Button btnBajaCliente;
        private Label label3;
        private Button btnModificarCliente;
        private Label label4;
        private Button btnConsultarCliente;
        private Label label5;
        private Button btnRegistrarCliente;
        private TabPage tbTodos;
        private TabControl tcUsuarios;
        private SplitContainer scProfesores;
        private Label label6;
        private Button btnImprimirProfesor;
        private Label label7;
        private Button btnBajaProfesor;
        private Label label8;
        private Button btnModificarProfesor;
        private Label label9;
        private Button btnConsultarProfesor;
        private Label label10;
        private Button btnRegistrarProfesor;
        private SplitContainer scAdministradores;
        private Label label16;
        private Button btnImprimirAdmin;
        private Label label17;
        private Button btnBajaAdmin;
        private Label label18;
        private Button btnModificarAdmin;
        private Label label19;
        private Button btnConsultarAdmin;
        private Label label20;
        private Button btnRegistrarAdmin;
        private DataGridView dgvTodos;
        private ListBox listBoxAdministradores;
        private ListBox listBoxEntrenadores;
        private ListBox listBoxProfesores;
        private ListBox listBoxClientes;
        private Panel panelUsuarios;
        private ListBox listBoxUsuarios;
        private TextBox txtBusqueda;
    }
}
