namespace GolAhora.Forms.UserControls
{
    partial class ucRecibos
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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            btnRealizar = new Button();
            btnListar = new Button();
            label7 = new Label();
            label1 = new Label();
            lbCobros = new ListBox();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Clase", "Entrenamiento" });
            comboBox2.Location = new Point(354, 5);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(98, 23);
            comboBox2.TabIndex = 16;
            comboBox2.Text = "Filtrar por";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(460, 5);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(600, 5);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 24);
            button2.TabIndex = 18;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnRealizar
            // 
            btnRealizar.BackColor = SystemColors.ControlLight;
            btnRealizar.Location = new Point(600, 92);
            btnRealizar.Margin = new Padding(4, 3, 4, 3);
            btnRealizar.Name = "btnRealizar";
            btnRealizar.Size = new Size(88, 27);
            btnRealizar.TabIndex = 19;
            btnRealizar.Text = "Registrar";
            btnRealizar.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            btnListar.BackColor = SystemColors.ControlLight;
            btnListar.Location = new Point(600, 218);
            btnListar.Margin = new Padding(4, 3, 4, 3);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(88, 27);
            btnListar.TabIndex = 20;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(474, 98);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 21;
            label7.Text = "Registrar Recibo :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 224);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 22;
            label1.Text = "Listar Recibo Pagos:";
            // 
            // lbCobros
            // 
            lbCobros.BackColor = SystemColors.ActiveCaption;
            lbCobros.BorderStyle = BorderStyle.FixedSingle;
            lbCobros.FormattingEnabled = true;
            lbCobros.Location = new Point(3, 92);
            lbCobros.Name = "lbCobros";
            lbCobros.Size = new Size(464, 317);
            lbCobros.TabIndex = 25;
            // 
            // ucRecibos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lbCobros);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnListar);
            Controls.Add(btnRealizar);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucRecibos";
            Size = new Size(723, 421);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private ListBox lbCobros;
    }
}
