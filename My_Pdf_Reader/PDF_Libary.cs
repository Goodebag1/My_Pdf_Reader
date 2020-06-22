using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pdf_Reader
{
    public partial class PDF_Libary : UserControl
    {
       // FileReader File;
        string GetFileName;
        string Getfilesafename;
        public PDF_Libary()
        {
            InitializeComponent();
        }

        private void addusercontrol(UserControl Newcontrol, Panel newpanel)
        {
            Newcontrol.Dock = DockStyle.Fill;
            Newcontrol.BringToFront();
            newpanel.Controls.Clear();
            newpanel.Controls.Add(Newcontrol);
        }

        private void AddToLibaryButton_Click_1(object sender, EventArgs e)
        {
            if (ChooseFileToOpen.ShowDialog().Equals(DialogResult.OK))
            {
                ChooseFileToOpen.Filter = "(PDF)|*.Pdf";
                GetFileName = ChooseFileToOpen.FileName;
                Getfilesafename = ChooseFileToOpen.SafeFileName;
                Userdatabase.addpdfs(GetFileName, Getfilesafename);
                Dashboard readerpanel = new Dashboard();
                addusercontrol(readerpanel, panel2);
                readerpanel.Reader.src = ChooseFileToOpen.FileName;
            
            }
        }
        public void GetallPdfs()
        {
            Userdatabase.mypdfs();
            if (!string.IsNullOrEmpty(Userdatabase.yourPdfFiles.Text))
            {
                foreach (var item in Userdatabase.yourPdfFiles.Lines)
                {
                    Point pt = new Point(6, 21);
                    PdfDisplayGroupBox.Controls.Add(pdfPicsPanel);
                    pdfPicsPanel.Visible = true;
                    pdfPicsPanel.Location = pt;
                    pdfNameLabel.Text = item;
                    defualtpicture.Image = defualtpicture.InitialImage;
                    for (int i = 0; i < Userdatabase.yourPdfFiles.Lines.Length; i++)
                    {
                        pt.X += 146;
                    }
                }
                
            }
        }

        private void defualtpicture_Click(object sender, EventArgs e)
        {
            Dashboard readerpanel = new Dashboard();
            addusercontrol(readerpanel, panel2);
            readerpanel.Reader.src = pdfNameLabel.Text;
        }

    }
    public class pdfFormart<T,T2,T3>
    {
        public T VAL { get; set; }
        public T2 VAL1 { get; set; }
        public T3 VAL2{ get; set; }
        public override string ToString()
        {
            return VAL+VAL1.ToString()+VAL2.ToString();
        }
    }
}
