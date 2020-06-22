using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace My_Pdf_Reader
{
     class User
    {
       public TextBox TBOX;
        public string GetUsername { get; private set; }
        public string Getpassword { get; private set; }
        public gender GetGender;
        public string yournames;
        private FileReader files;
        private string[] filecontent;
        private string path;
        public Dictionary<string, FileReader> Getfiles { get; private set; }
        public User(string firstname, string lastname, string password, string username, gender yoursex)
        {
            this.yournames = lastname + " " + firstname;
            this.Getpassword = password;
            this.GetGender = yoursex;
            this.GetUsername = username;
            WriteSignup();
        }
        public User(string username, string password)
        {
            ReadSignedUpData();
            if ((filecontent[0].Equals(username)) && (filecontent[1].Equals(password)))
            {
                RESTOREsAVEDfiles();
            }
            else
                MessageBox.Show("Wrong password or Username", "Invalid Input",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
        }
        private void WriteSignup()
        {
            string currentDirs = Directory.GetCurrentDirectory();
            string customDIRS = currentDirs + @"\signupDetails";
            if (!Directory.Exists(customDIRS))
            {
                Directory.CreateDirectory(customDIRS);
            }
           
            using (StreamWriter writer = new StreamWriter(customDIRS + @"\SignUps.txt"))
            {
                path = customDIRS + @"\SignUps.txt";
                writer.WriteLine("{0},\r\n {1},\r\n{2},\r\n{3}", GetUsername, Getpassword, yournames, GetGender);
               
            }
        }

        private void ReadSignedUpData()
        {
 //           if (File.Exists(path))
                using (StreamReader Readfile = new StreamReader(path))
                {
                    filecontent = new string[] { };
                    filecontent[0] = Readfile.ReadLine();
                    if (!Readfile.EndOfStream)
                        filecontent[1] = Readfile.ReadLine();
                    else if (!Readfile.EndOfStream)
                        filecontent[2] = Readfile.ReadLine();
                    else if (!Readfile.EndOfStream)
                        filecontent[3] = Readfile.ReadLine();
                    else if (!Readfile.EndOfStream)
                        filecontent[4] = Readfile.ReadLine();
                    else
                        MessageBox.Show("No data to read", "Done reading data");
                }
        }
        public void AddPDF(string pdfFilename, string pdfSafefileName)
        {
            Getfiles = new Dictionary<string, FileReader>();
            Getfiles.Add(pdfSafefileName, new FileReader(pdfFilename, pdfSafefileName));
        }

        public void RESTOREsAVEDfiles()
        {
            files = new FileReader();
            foreach (var item in Getfiles)
            {
                TBOX = new TextBox();
                TBOX.Text = item.Value.getPdfnames.Text;
            }
        }
    }
}
