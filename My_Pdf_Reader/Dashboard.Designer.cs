namespace My_Pdf_Reader
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.Reader = new AxAcroPDFLib.AxAcroPDF();
            this.gunaGradient2Panel2.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reader)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.BackButton);
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.Blue;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(3, 3);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Radius = 18;
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(866, 47);
            this.gunaGradient2Panel2.TabIndex = 1;
            // 
            // BackButton
            // 
            this.BackButton.Animated = true;
            this.BackButton.BorderRadius = 10;
            this.BackButton.BorderThickness = 5;
            this.BackButton.CheckedState.Parent = this.BackButton;
            this.BackButton.CustomImages.Parent = this.BackButton;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.HoverState.Parent = this.BackButton;
            this.BackButton.Location = new System.Drawing.Point(800, 5);
            this.BackButton.Name = "BackButton";
            this.BackButton.ShadowDecoration.Parent = this.BackButton;
            this.BackButton.Size = new System.Drawing.Size(60, 38);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.Reader);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.SystemColors.Control;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.SystemColors.Control;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(3, 49);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 18;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(863, 416);
            this.gunaGradient2Panel1.TabIndex = 2;
            // 
            // Reader
            // 
            this.Reader.Enabled = true;
            this.Reader.Location = new System.Drawing.Point(3, 7);
            this.Reader.Name = "Reader";
            this.Reader.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reader.OcxState")));
            this.Reader.Size = new System.Drawing.Size(863, 416);
            this.Reader.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(872, 468);
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Reader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        public AxAcroPDFLib.AxAcroPDF Reader;
    }
}
