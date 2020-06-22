namespace My_Pdf_Reader
{
    partial class PDF_Libary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_Libary));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PdfDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.pdfPicsPanel = new System.Windows.Forms.Panel();
            this.pdfNameLabel = new System.Windows.Forms.Label();
            this.defualtpicture = new System.Windows.Forms.PictureBox();
            this.UploadButton = new Guna.UI.WinForms.GunaButton();
            this.AddToLibaryButton = new Guna.UI.WinForms.GunaButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ChooseFileToOpen = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.PdfDisplayGroupBox.SuspendLayout();
            this.pdfPicsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defualtpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.PdfDisplayGroupBox);
            this.panel2.Controls.Add(this.UploadButton);
            this.panel2.Controls.Add(this.AddToLibaryButton);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 468);
            this.panel2.TabIndex = 5;
            // 
            // PdfDisplayGroupBox
            // 
            this.PdfDisplayGroupBox.Controls.Add(this.pdfPicsPanel);
            this.PdfDisplayGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfDisplayGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.PdfDisplayGroupBox.Location = new System.Drawing.Point(3, 3);
            this.PdfDisplayGroupBox.Name = "PdfDisplayGroupBox";
            this.PdfDisplayGroupBox.Size = new System.Drawing.Size(866, 403);
            this.PdfDisplayGroupBox.TabIndex = 7;
            this.PdfDisplayGroupBox.TabStop = false;
            this.PdfDisplayGroupBox.Text = "Welcome to your libary";
            // 
            // pdfPicsPanel
            // 
            this.pdfPicsPanel.Controls.Add(this.pdfNameLabel);
            this.pdfPicsPanel.Controls.Add(this.defualtpicture);
            this.pdfPicsPanel.Location = new System.Drawing.Point(6, 21);
            this.pdfPicsPanel.Name = "pdfPicsPanel";
            this.pdfPicsPanel.Size = new System.Drawing.Size(124, 72);
            this.pdfPicsPanel.TabIndex = 6;
            this.pdfPicsPanel.Visible = false;
            this.pdfPicsPanel.Click += new System.EventHandler(this.defualtpicture_Click);
            // 
            // pdfNameLabel
            // 
            this.pdfNameLabel.AutoSize = true;
            this.pdfNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfNameLabel.Location = new System.Drawing.Point(10, 56);
            this.pdfNameLabel.Name = "pdfNameLabel";
            this.pdfNameLabel.Size = new System.Drawing.Size(88, 13);
            this.pdfNameLabel.TabIndex = 6;
            this.pdfNameLabel.Text = "pdfNameLabel";
            this.pdfNameLabel.Click += new System.EventHandler(this.defualtpicture_Click);
            // 
            // defualtpicture
            // 
            this.defualtpicture.Image = ((System.Drawing.Image)(resources.GetObject("defualtpicture.Image")));
            this.defualtpicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("defualtpicture.InitialImage")));
            this.defualtpicture.Location = new System.Drawing.Point(13, 3);
            this.defualtpicture.Name = "defualtpicture";
            this.defualtpicture.Size = new System.Drawing.Size(100, 50);
            this.defualtpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defualtpicture.TabIndex = 5;
            this.defualtpicture.TabStop = false;
            this.defualtpicture.Click += new System.EventHandler(this.defualtpicture_Click);
            // 
            // UploadButton
            // 
            this.UploadButton.AnimationHoverSpeed = 0.07F;
            this.UploadButton.AnimationSpeed = 0.03F;
            this.UploadButton.BackColor = System.Drawing.Color.Transparent;
            this.UploadButton.BaseColor = System.Drawing.Color.Blue;
            this.UploadButton.BorderColor = System.Drawing.Color.Black;
            this.UploadButton.BorderSize = 3;
            this.UploadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UploadButton.FocusedColor = System.Drawing.Color.Empty;
            this.UploadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UploadButton.ForeColor = System.Drawing.Color.White;
            this.UploadButton.Image = ((System.Drawing.Image)(resources.GetObject("UploadButton.Image")));
            this.UploadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.UploadButton.Location = new System.Drawing.Point(9, 412);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.UploadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.UploadButton.OnHoverForeColor = System.Drawing.Color.White;
            this.UploadButton.OnHoverImage = null;
            this.UploadButton.OnPressedColor = System.Drawing.Color.Black;
            this.UploadButton.Radius = 10;
            this.UploadButton.Size = new System.Drawing.Size(102, 44);
            this.UploadButton.TabIndex = 1;
            this.UploadButton.Text = "Upload";
            // 
            // AddToLibaryButton
            // 
            this.AddToLibaryButton.AnimationHoverSpeed = 0.07F;
            this.AddToLibaryButton.AnimationSpeed = 0.03F;
            this.AddToLibaryButton.BackColor = System.Drawing.Color.Transparent;
            this.AddToLibaryButton.BaseColor = System.Drawing.Color.Blue;
            this.AddToLibaryButton.BorderColor = System.Drawing.Color.Black;
            this.AddToLibaryButton.BorderSize = 3;
            this.AddToLibaryButton.CausesValidation = false;
            this.AddToLibaryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddToLibaryButton.FocusedColor = System.Drawing.Color.Empty;
            this.AddToLibaryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddToLibaryButton.ForeColor = System.Drawing.Color.White;
            this.AddToLibaryButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToLibaryButton.Image")));
            this.AddToLibaryButton.ImageSize = new System.Drawing.Size(25, 25);
            this.AddToLibaryButton.Location = new System.Drawing.Point(729, 412);
            this.AddToLibaryButton.Name = "AddToLibaryButton";
            this.AddToLibaryButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.AddToLibaryButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.AddToLibaryButton.OnHoverForeColor = System.Drawing.Color.White;
            this.AddToLibaryButton.OnHoverImage = null;
            this.AddToLibaryButton.OnPressedColor = System.Drawing.Color.Black;
            this.AddToLibaryButton.Radius = 10;
            this.AddToLibaryButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddToLibaryButton.Size = new System.Drawing.Size(129, 44);
            this.AddToLibaryButton.TabIndex = 2;
            this.AddToLibaryButton.Text = "Add To Libary";
            this.AddToLibaryButton.Click += new System.EventHandler(this.AddToLibaryButton_Click_1);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 393);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(872, 22);
            this.guna2Separator1.TabIndex = 3;
            // 
            // ChooseFileToOpen
            // 
            this.ChooseFileToOpen.FileName = "openFileDialog1";
            // 
            // PDF_Libary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "PDF_Libary";
            this.Size = new System.Drawing.Size(872, 468);
            this.panel2.ResumeLayout(false);
            this.PdfDisplayGroupBox.ResumeLayout(false);
            this.pdfPicsPanel.ResumeLayout(false);
            this.pdfPicsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defualtpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton UploadButton;
        private Guna.UI.WinForms.GunaButton AddToLibaryButton;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.OpenFileDialog ChooseFileToOpen;
        internal System.Windows.Forms.Panel pdfPicsPanel;
        internal System.Windows.Forms.PictureBox defualtpicture;
        internal System.Windows.Forms.Label pdfNameLabel;
        internal System.Windows.Forms.GroupBox PdfDisplayGroupBox;
        public System.Windows.Forms.Panel panel2;
    }
}
