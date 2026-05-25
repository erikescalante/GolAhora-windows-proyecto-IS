namespace GolAhora.Forms.UserControls
{
    partial class ucHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHome));
            imageListIcon = new ImageList(components);
            lbIcon = new Label();
            SuspendLayout();
            // 
            // imageListIcon
            // 
            imageListIcon.ColorDepth = ColorDepth.Depth8Bit;
            imageListIcon.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcon.ImageStream");
            imageListIcon.TransparentColor = Color.Transparent;
            imageListIcon.Images.SetKeyName(0, "icon.png");
            // 
            // lbIcon
            // 
            lbIcon.ImageKey = "icon.png";
            lbIcon.ImageList = imageListIcon;
            lbIcon.Location = new Point(154, 39);
            lbIcon.Margin = new Padding(4, 0, 4, 0);
            lbIcon.Name = "lbIcon";
            lbIcon.Size = new Size(373, 291);
            lbIcon.TabIndex = 0;
            // 
            // ucHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lbIcon);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucHome";
            Size = new Size(723, 421);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.Label lbIcon;
    }
}
