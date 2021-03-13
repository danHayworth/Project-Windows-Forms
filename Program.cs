using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    static class Program
    {
        /* Student Id: 92060016
         * Name: Dan hayworth
         */
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //starting with login form to be able to access dashbord.
            Application.Run(new frmLogin());
        }
    }
}
