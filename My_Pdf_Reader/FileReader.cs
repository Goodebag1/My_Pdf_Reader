using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Pdf_Reader
{
    class FileReader
    {
        public TextBox getPdfnames;
        public string GetFilename;
        public string GetFileSafeName;
        string path;
        public FileReader(string filename, string safefilename)
        {
            this.GetFilename = filename;
            this.GetFileSafeName =safefilename;
            WritePDFfiles();
        }
        public FileReader()
        {
            ReadPDFfiles();
        }
        private void WritePDFfiles()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string customDIR = currentDir + @"\PdfFiles";
            if (!Directory.Exists(customDIR))
            {
                Directory.CreateDirectory(customDIR);
            }
            using (StreamWriter writer = new StreamWriter(customDIR + @"\usersfile.txt"))
            {
                path = customDIR + @"\usersfile.txt";
                writer.WriteLine(GetFilename);
            }
            if (File.Exists((customDIR + @"\usersfile.txt")))
            {
                MessageBox.Show(GetFileSafeName + "have been added to Libary", "PDF Sucessfully added");
            }
        }
        public void ReadPDFfiles()
        {
            if (File.Exists(path))
                using (StreamReader Readfile = new StreamReader(path))
                {
                    getPdfnames = new TextBox();
                     getPdfnames.Text += Readfile.ReadLine();
                    if (!Readfile.EndOfStream)
                        getPdfnames.Text += Readfile.ReadLine();
                    else if (!Readfile.EndOfStream)
                        getPdfnames.Text += Readfile.ReadLine();
                    else if (!Readfile.EndOfStream)
                        getPdfnames.Text += Readfile.ReadLine();
                    else if (!Readfile.EndOfStream)
                        getPdfnames.Text += Readfile.ReadLine();
                    else
                        MessageBox.Show("No data to read", "Done reading data");
                }
        }
    }



    enum gender
    {
      none,
      Male,
      Female
   
    }

}

