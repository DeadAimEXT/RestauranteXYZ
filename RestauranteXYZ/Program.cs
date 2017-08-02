using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteXYZ.Formularios
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login Login = new Login();
            DialogResult res = new DialogResult();
            string username;
            res = Login.ShowDialog();
            username = Login.userName;
            if (res == DialogResult.OK)
            {
                Application.Run(new frmMenu(username));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
