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
    public partial class SignUpAndSignIn : UserControl
    {
        PDF_Libary Libary = new PDF_Libary();
        public SignUpAndSignIn()
        {
            InitializeComponent();
        }

        //disabling & enabling bottons for user to delete an acct
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SignupPanel.Visible = false;
            signinButton.Visible = false;
            DeletePanel.Visible = true;
            signupButton.Visible = false;
            gunaButton1.Visible = false;
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            Userdatabase.DeleteUser(UserToBeDeletedbox.Text);
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            
        }
        private void addusercontrol(UserControl Newcontrol, Panel newpanel)
        {
            Newcontrol.Dock = DockStyle.Fill;
            Newcontrol.BringToFront();
            newpanel.Controls.Clear();
            newpanel.Controls.Add(Newcontrol);
        }



        private void signupButton_Click_1(object sender, EventArgs e)
        {
            Userdatabase.AddUser(new User(FirstnameTextBox1.Text, LastnameTextBox2.Text,
            PasswordTextBox.Text, usernameTextBox.Text, (gender)numericUpDown1.Value));
            addusercontrol(Libary, panel1);

        }

        private void signinButton_Click_1(object sender, EventArgs e)
        {
          Userdatabase.signingIn(new User(usernameTextBox.Text, PasswordTextBox.Text));
        }
    }
}
