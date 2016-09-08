using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Common
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmLogOn f = new frmLogOn();
            //f.ShowDialog();
            //if (f.DialogResult == DialogResult.OK)
            //    Application.Run(new MDIParent1());
        }
    }
}
