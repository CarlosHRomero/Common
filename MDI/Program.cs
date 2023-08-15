using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ; ;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmLogOn f = new frmLogOn();
                f.Text = "ICBA - Ciencia";
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                    Application.Run(new MDIParent1());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ICBA MDI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
