using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.IO;

namespace My_Pdf_Reader
{
    public partial class Form1 : Form
    {
        SignUpAndSignIn USERsignPANEL = new SignUpAndSignIn();
        public Form1()
        {
            InitializeComponent();

           
        }

        private void ImageMover(object sender)
        {
            GunaButton c = (GunaButton)sender;
            SlidePicture.Location = new Point(c.Location.X +27, c.Location.Y -8);
            SlidePicture.SendToBack();
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            ImageMover(sender);
        }
        private void addusercontrol(UserControl Newcontrol, Panel newpanel)
        {
            Newcontrol.Dock = DockStyle.Fill;
            Newcontrol.BringToFront();
            newpanel.Controls.Clear();
            newpanel.Controls.Add(Newcontrol);
        }


        private void SignUpButton_Click(object sender, EventArgs e)
        {
            USERsignPANEL.signinButton.Visible = false;
            addusercontrol(USERsignPANEL, panel3);
          
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            USERsignPANEL.SignupPanel.Visible = false;
            USERsignPANEL.signupButton.Visible = false;
            addusercontrol(USERsignPANEL,panel3);
        }


    }
}
