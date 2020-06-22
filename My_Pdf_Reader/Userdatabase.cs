using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pdf_Reader
{
     static class Userdatabase
    { public static TextBox yourPdfFiles;
        public static User TheUser;
        static Dictionary<string,User> Users = new Dictionary<string, User>();

        public static void AddUser( User userToBeAdded)
        {
            TheUser = userToBeAdded;
           Users.Add(userToBeAdded.GetUsername, TheUser);
            MessageBox.Show(userToBeAdded.yournames + " " + "you have sucessfully created an account ", "SUCESSFULL");
        }

        public static void DeleteUser(string usernameToDeleted)
        {
            Users.Remove(usernameToDeleted);
            MessageBox.Show(usernameToDeleted + " " + "have been sucessfully remove ", "SUCESSFULL");
        }

        public static void addpdfs(string pdfFilename, string pdfsafeFileName)
        {
            TheUser.AddPDF(pdfFilename, pdfsafeFileName);
        }

        public static void mypdfs()
        {
            yourPdfFiles = TheUser.TBOX;
        }
        public static void signingIn(User userToSignIn)
        {
            TheUser = userToSignIn;
        }
    }
}
