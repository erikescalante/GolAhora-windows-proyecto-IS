namespace GolAhora.Forms.UserControls
{
    partial class ucCompetencias
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
            tabLigas = new TabPage();
            scLigas = new SplitContainer();
            listBoxLigas = new ListBox();
            dataGridView1 = new DataGridView();
            columnName = new DataGridViewTextBoxColumn();
            columnType = new DataGridViewTextBoxColumn();
            columnFechaInicio = new DataGridViewTextBoxColumn();
            columnFechaFin = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnRegistrarResultadosLiga = new Button();
            label2 = new Label();
            btnBajaLiga = new Button();
            label3 = new Label();
            btnConfigurarLiga = new Button();
            label4 = new Label();
            btnInscribirEquipoLiga = new Button();
            label5 = new Label();
            btnRegistrarLiga = new Button();
            tcCompetencias = new TabControl();
            tabTorneos = new TabPage();
            scTorneos = new SplitContainer();
            listBoxTorneos = new ListBox();
            label6 = new Label();
            btnRegistrarResultadosTorneo = new Button();
            label7 = new Label();
            btnBajaTorneo = new Button();
            label8 = new Label();
            btnConfigurarTorneo = new Button();
            label9 = new Label();
            btnInscribirEquipoTorneo = new Button();
            label10 = new Label();
            btnRegistrarTorneo = new Button();
            cbFiltrado = new ComboBox();
            txtBusqueda = new ComboBox();
            btnBuscar = new Button();
            cbEstado = new ComboBox();
            tabLigas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scLigas).BeginInit();
            scLigas.Panel1.SuspendLayout();
            scLigas.Panel2.SuspendLayout();
            scLigas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tcCompetencias.SuspendLayout();
            tabTorneos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scTorneos).BeginInit();
            scTorneos.Panel1.SuspendLayout();
            scTorneos.Panel2.SuspendLayout();
            scTorneos.SuspendLayout();
            SuspendLayout();
            // 
            // tabLigas
            // 
            tabLigas.BackColor = SystemColors.ActiveCaption;
            tabLigas.Controls.Add(scLigas);
            tabLigas.Location = new Point(4, 24);
            tabLigas.Margin = new Padding(4, 3, 4, 3);
            tabLigas.Name = "tabLigas";
            tabLigas.Padding = new Padding(4, 3, 4, 3);
            tabLigas.Size = new Size(724, 337);
            tabLigas.TabIndex = 2;
            tabLigas.Text = "Ligas";
            // 
            // scLigas
            // 
            scLigas.Dock = DockStyle.Fill;
            scLigas.Location = new Point(4, 3);
            scLigas.Margin = new Padding(4, 3, 4, 3);
            scLigas.Name = "scLigas";
            // 
            // scLigas.Panel1
            // 
            scLigas.Panel1.Controls.Add(listBoxLigas);
            scLigas.Panel1.Controls.Add(dataGridView1);
            // 
            // scLigas.Panel2
            // 
            scLigas.Panel2.BackColor = Color.Transparent;
            scLigas.Panel2.Controls.Add(label1);
            scLigas.Panel2.Controls.Add(btnRegistrarResultadosLiga);
            scLigas.Panel2.Controls.Add(label2);
            scLigas.Panel2.Controls.Add(btnBajaLiga);
            scLigas.Panel2.Controls.Add(label3);
            scLigas.Panel2.Controls.Add(btnConfigurarLiga);
            scLigas.Panel2.Controls.Add(label4);
            scLigas.Panel2.Controls.Add(btnInscribirEquipoLiga);
            scLigas.Panel2.Controls.Add(label5);
            scLigas.Panel2.Controls.Add(btnRegistrarLiga);
            scLigas.Size = new Size(716, 331);
            scLigas.SplitterDistance = 462;
            scLigas.SplitterWidth = 5;
            scLigas.TabIndex = 5;
            // 
            // listBoxLigas
            // 
            listBoxLigas.BackColor = SystemColors.ActiveCaption;
            listBoxLigas.BorderStyle = BorderStyle.FixedSingle;
            listBoxLigas.FormattingEnabled = true;
            listBoxLigas.Items.AddRange(new object[] { "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse", "id: 0szX0ñpzA - tipo: torneo - nombre: world cup - estado: a jugarse" });
            listBoxLigas.Location = new Point(4, 3);
            listBoxLigas.Name = "listBoxLigas";
            listBoxLigas.Size = new Size(455, 317);
            listBoxLigas.TabIndex = 3;
            listBoxLigas.SelectedIndexChanged += listBoxLigas_SelectedIndexChanged;
            listBoxLigas.MouseDown += listBoxLigas_MouseDown;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnName, columnType, columnFechaInicio, columnFechaFin });
            dataGridView1.Location = new Point(5, 3);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 314);
            dataGridView1.TabIndex = 2;
            // 
            // columnName
            // 
            columnName.HeaderText = "nombre";
            columnName.Name = "columnName";
            // 
            // columnType
            // 
            columnType.HeaderText = "tipo de competencia";
            columnType.Name = "columnType";
            // 
            // columnFechaInicio
            // 
            columnFechaInicio.HeaderText = "fecha de inicio";
            columnFechaInicio.Name = "columnFechaInicio";
            // 
            // columnFechaFin
            // 
            columnFechaFin.HeaderText = "fecha de fin";
            columnFechaFin.Name = "columnFechaFin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 141);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 20;
            label1.Text = "Registrar resultados:";
            // 
            // btnRegistrarResultadosLiga
            // 
            btnRegistrarResultadosLiga.BackColor = SystemColors.ControlLight;
            btnRegistrarResultadosLiga.Enabled = false;
            btnRegistrarResultadosLiga.Location = new Point(154, 135);
            btnRegistrarResultadosLiga.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarResultadosLiga.Name = "btnRegistrarResultadosLiga";
            btnRegistrarResultadosLiga.Size = new Size(88, 27);
            btnRegistrarResultadosLiga.TabIndex = 19;
            btnRegistrarResultadosLiga.Text = "Registrar";
            btnRegistrarResultadosLiga.UseVisualStyleBackColor = false;
            btnRegistrarResultadosLiga.Click += btnRegistrarResultadosLiga_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-2, 185);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 18;
            label2.Text = "Dar de baja liga:";
            // 
            // btnBajaLiga
            // 
            btnBajaLiga.BackColor = SystemColors.ControlLight;
            btnBajaLiga.Enabled = false;
            btnBajaLiga.Location = new Point(154, 179);
            btnBajaLiga.Margin = new Padding(4, 3, 4, 3);
            btnBajaLiga.Name = "btnBajaLiga";
            btnBajaLiga.Size = new Size(88, 27);
            btnBajaLiga.TabIndex = 17;
            btnBajaLiga.Text = "Baja";
            btnBajaLiga.UseVisualStyleBackColor = false;
            btnBajaLiga.Click += btnBajaLiga_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 16;
            label3.Text = "Configurar liga:";
            // 
            // btnConfigurarLiga
            // 
            btnConfigurarLiga.BackColor = SystemColors.ControlLight;
            btnConfigurarLiga.Enabled = false;
            btnConfigurarLiga.Location = new Point(154, 91);
            btnConfigurarLiga.Margin = new Padding(4, 3, 4, 3);
            btnConfigurarLiga.Name = "btnConfigurarLiga";
            btnConfigurarLiga.Size = new Size(88, 27);
            btnConfigurarLiga.TabIndex = 15;
            btnConfigurarLiga.Text = "Configurar";
            btnConfigurarLiga.UseVisualStyleBackColor = false;
            btnConfigurarLiga.Click += btnConfigurarLiga_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-2, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 14;
            label4.Text = "Inscribir equipo:";
            // 
            // btnInscribirEquipoLiga
            // 
            btnInscribirEquipoLiga.BackColor = SystemColors.ControlLight;
            btnInscribirEquipoLiga.Enabled = false;
            btnInscribirEquipoLiga.Location = new Point(154, 47);
            btnInscribirEquipoLiga.Margin = new Padding(4, 3, 4, 3);
            btnInscribirEquipoLiga.Name = "btnInscribirEquipoLiga";
            btnInscribirEquipoLiga.Size = new Size(88, 27);
            btnInscribirEquipoLiga.TabIndex = 13;
            btnInscribirEquipoLiga.Text = "Inscribir";
            btnInscribirEquipoLiga.UseVisualStyleBackColor = false;
            btnInscribirEquipoLiga.Click += btnInscribirEquipoLiga_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-2, 9);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 12;
            label5.Text = "Registrar nueva liga:";
            // 
            // btnRegistrarLiga
            // 
            btnRegistrarLiga.BackColor = SystemColors.ControlLight;
            btnRegistrarLiga.Location = new Point(154, 3);
            btnRegistrarLiga.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarLiga.Name = "btnRegistrarLiga";
            btnRegistrarLiga.Size = new Size(88, 27);
            btnRegistrarLiga.TabIndex = 11;
            btnRegistrarLiga.Text = "Registrar ";
            btnRegistrarLiga.UseVisualStyleBackColor = false;
            btnRegistrarLiga.Click += btnRegistrarLiga_Click;
            // 
            // tcCompetencias
            // 
            tcCompetencias.Controls.Add(tabLigas);
            tcCompetencias.Controls.Add(tabTorneos);
            tcCompetencias.Location = new Point(-4, 60);
            tcCompetencias.Margin = new Padding(4, 3, 4, 3);
            tcCompetencias.Name = "tcCompetencias";
            tcCompetencias.SelectedIndex = 0;
            tcCompetencias.Size = new Size(732, 365);
            tcCompetencias.TabIndex = 2;
            tcCompetencias.Click += tcCompetencias_Click;
            // 
            // tabTorneos
            // 
            tabTorneos.BackColor = SystemColors.ActiveCaption;
            tabTorneos.Controls.Add(scTorneos);
            tabTorneos.Location = new Point(4, 24);
            tabTorneos.Margin = new Padding(4, 3, 4, 3);
            tabTorneos.Name = "tabTorneos";
            tabTorneos.Padding = new Padding(4, 3, 4, 3);
            tabTorneos.Size = new Size(724, 337);
            tabTorneos.TabIndex = 3;
            tabTorneos.Text = "Torneos";
            // 
            // scTorneos
            // 
            scTorneos.Dock = DockStyle.Fill;
            scTorneos.Location = new Point(4, 3);
            scTorneos.Margin = new Padding(4, 3, 4, 3);
            scTorneos.Name = "scTorneos";
            // 
            // scTorneos.Panel1
            // 
            scTorneos.Panel1.Controls.Add(listBoxTorneos);
            // 
            // scTorneos.Panel2
            // 
            scTorneos.Panel2.BackColor = Color.Transparent;
            scTorneos.Panel2.Controls.Add(label6);
            scTorneos.Panel2.Controls.Add(btnRegistrarResultadosTorneo);
            scTorneos.Panel2.Controls.Add(label7);
            scTorneos.Panel2.Controls.Add(btnBajaTorneo);
            scTorneos.Panel2.Controls.Add(label8);
            scTorneos.Panel2.Controls.Add(btnConfigurarTorneo);
            scTorneos.Panel2.Controls.Add(label9);
            scTorneos.Panel2.Controls.Add(btnInscribirEquipoTorneo);
            scTorneos.Panel2.Controls.Add(label10);
            scTorneos.Panel2.Controls.Add(btnRegistrarTorneo);
            scTorneos.Size = new Size(716, 331);
            scTorneos.SplitterDistance = 462;
            scTorneos.SplitterWidth = 5;
            scTorneos.TabIndex = 4;
            // 
            // listBoxTorneos
            // 
            listBoxTorneos.BackColor = SystemColors.ActiveCaption;
            listBoxTorneos.BorderStyle = BorderStyle.FixedSingle;
            listBoxTorneos.FormattingEnabled = true;
            listBoxTorneos.Items.AddRange(new object[] { "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada", "id: sZX0sAhh8 - tipo: liga - nombre: champions league - estado: jugada" });
            listBoxTorneos.Location = new Point(4, 3);
            listBoxTorneos.Name = "listBoxTorneos";
            listBoxTorneos.Size = new Size(455, 317);
            listBoxTorneos.TabIndex = 2;
            listBoxTorneos.SelectedIndexChanged += listBoxTorneos_SelectedIndexChanged;
            listBoxTorneos.MouseDown += listBoxTorneos_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-2, 141);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 20;
            label6.Text = "Registrar resultados:";
            // 
            // btnRegistrarResultadosTorneo
            // 
            btnRegistrarResultadosTorneo.BackColor = SystemColors.ControlLight;
            btnRegistrarResultadosTorneo.Enabled = false;
            btnRegistrarResultadosTorneo.Location = new Point(154, 135);
            btnRegistrarResultadosTorneo.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarResultadosTorneo.Name = "btnRegistrarResultadosTorneo";
            btnRegistrarResultadosTorneo.Size = new Size(88, 27);
            btnRegistrarResultadosTorneo.TabIndex = 19;
            btnRegistrarResultadosTorneo.Text = "Registrar";
            btnRegistrarResultadosTorneo.UseVisualStyleBackColor = false;
            btnRegistrarResultadosTorneo.Click += btnRegistrarResultadosTorneo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-2, 185);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 18;
            label7.Text = "Dar de baja torneo:";
            // 
            // btnBajaTorneo
            // 
            btnBajaTorneo.BackColor = SystemColors.ControlLight;
            btnBajaTorneo.Enabled = false;
            btnBajaTorneo.Location = new Point(154, 179);
            btnBajaTorneo.Margin = new Padding(4, 3, 4, 3);
            btnBajaTorneo.Name = "btnBajaTorneo";
            btnBajaTorneo.Size = new Size(88, 27);
            btnBajaTorneo.TabIndex = 17;
            btnBajaTorneo.Text = "Baja";
            btnBajaTorneo.UseVisualStyleBackColor = false;
            btnBajaTorneo.Click += btnBajaTorneo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(-2, 97);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 16;
            label8.Text = "Configurar torneo:";
            // 
            // btnConfigurarTorneo
            // 
            btnConfigurarTorneo.BackColor = SystemColors.ControlLight;
            btnConfigurarTorneo.Enabled = false;
            btnConfigurarTorneo.Location = new Point(154, 91);
            btnConfigurarTorneo.Margin = new Padding(4, 3, 4, 3);
            btnConfigurarTorneo.Name = "btnConfigurarTorneo";
            btnConfigurarTorneo.Size = new Size(88, 27);
            btnConfigurarTorneo.TabIndex = 15;
            btnConfigurarTorneo.Text = "Configurar";
            btnConfigurarTorneo.UseVisualStyleBackColor = false;
            btnConfigurarTorneo.Click += btnConfigurarTorneo_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(-2, 53);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 14;
            label9.Text = "Inscribir equipo:";
            // 
            // btnInscribirEquipoTorneo
            // 
            btnInscribirEquipoTorneo.BackColor = SystemColors.ControlLight;
            btnInscribirEquipoTorneo.Enabled = false;
            btnInscribirEquipoTorneo.Location = new Point(154, 47);
            btnInscribirEquipoTorneo.Margin = new Padding(4, 3, 4, 3);
            btnInscribirEquipoTorneo.Name = "btnInscribirEquipoTorneo";
            btnInscribirEquipoTorneo.Size = new Size(88, 27);
            btnInscribirEquipoTorneo.TabIndex = 13;
            btnInscribirEquipoTorneo.Text = "Inscribir";
            btnInscribirEquipoTorneo.UseVisualStyleBackColor = false;
            btnInscribirEquipoTorneo.Click += btnInscribirEquipoTorneo_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(-2, 9);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(140, 15);
            label10.TabIndex = 12;
            label10.Text = "Registrar nuevo torneo:";
            // 
            // btnRegistrarTorneo
            // 
            btnRegistrarTorneo.BackColor = SystemColors.ControlLight;
            btnRegistrarTorneo.Location = new Point(154, 3);
            btnRegistrarTorneo.Margin = new Padding(4, 3, 4, 3);
            btnRegistrarTorneo.Name = "btnRegistrarTorneo";
            btnRegistrarTorneo.Size = new Size(88, 27);
            btnRegistrarTorneo.TabIndex = 11;
            btnRegistrarTorneo.Text = "Registrar ";
            btnRegistrarTorneo.UseVisualStyleBackColor = false;
            btnRegistrarTorneo.Click += btnRegistrarTorneo_Click;
            // 
            // cbFiltrado
            // 
            cbFiltrado.FormattingEnabled = true;
            cbFiltrado.Items.AddRange(new object[] { "nombre", "id" });
            cbFiltrado.Location = new Point(337, 6);
            cbFiltrado.Margin = new Padding(4, 3, 4, 3);
            cbFiltrado.Name = "cbFiltrado";
            cbFiltrado.Size = new Size(98, 23);
            cbFiltrado.TabIndex = 10;
            cbFiltrado.Text = "Filtrar por";
            // 
            // txtBusqueda
            // 
            txtBusqueda.FormattingEnabled = true;
            txtBusqueda.Location = new Point(443, 6);
            txtBusqueda.Margin = new Padding(4, 3, 4, 3);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(174, 23);
            txtBusqueda.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ControlLight;
            btnBuscar.FlatStyle = FlatStyle.System;
            btnBuscar.Location = new Point(625, 6);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 24);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Todos", "En juego", "Jugados", "Por jugar" });
            cbEstado.Location = new Point(259, 6);
            cbEstado.Margin = new Padding(4, 3, 4, 3);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(70, 23);
            cbEstado.TabIndex = 12;
            cbEstado.Text = "Todos";
            // 
            // ucCompetencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(cbEstado);
            Controls.Add(cbFiltrado);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(tcCompetencias);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucCompetencias";
            Size = new Size(723, 421);
            Click += ucCompetencias_Click;
            tabLigas.ResumeLayout(false);
            scLigas.Panel1.ResumeLayout(false);
            scLigas.Panel2.ResumeLayout(false);
            scLigas.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scLigas).EndInit();
            scLigas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tcCompetencias.ResumeLayout(false);
            tabTorneos.ResumeLayout(false);
            scTorneos.Panel1.ResumeLayout(false);
            scTorneos.Panel2.ResumeLayout(false);
            scTorneos.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scTorneos).EndInit();
            scTorneos.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabLigas;
        private System.Windows.Forms.TabControl tcCompetencias;
        private System.Windows.Forms.ComboBox cbFiltrado;
        private System.Windows.Forms.ComboBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabTorneos;
        private System.Windows.Forms.SplitContainer scTorneos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarResultadosTorneo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBajaTorneo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfigurarTorneo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInscribirEquipoTorneo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegistrarTorneo;
        private System.Windows.Forms.SplitContainer scLigas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarResultadosLiga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBajaLiga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfigurarLiga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInscribirEquipoLiga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarLiga;
        private ComboBox cbEstado;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnFechaInicio;
        private DataGridViewTextBoxColumn columnFechaFin;
        private ListBox listBoxLigas;
        private ListBox listBoxTorneos;
    }
}
