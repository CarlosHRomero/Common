using System;
using System.Windows.Forms;
using  Ciencia;
using  Cardiologia;
using System.Configuration;
using Ciencia.BLL;

namespace MDI
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Ventana " + childFormNumber++
            };
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void cardiologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCardioPac f = new frmCardioPac {MdiParent = this};
            f.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void procesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciencia.Formularios.fMenu.AbrirProceso();
        }
        

        private void selectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciencia.Formularios.fMenu.AbrirSelector();
        }

        private void complementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ciencia.Formularios.fMenu.AbrirComplemento();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            var entry = ConfigurationManager.ConnectionStrings["ICBA.Properties.Settings.ConnStr"];
            StatusLabel.Text = entry.ConnectionString.Split(';')[0];
            Ciencia.Formularios.fMenu.MdiParent = this;
            Ciencia.Formularios.fMenu.StartPosition = FormStartPosition.CenterScreen;
            Ciencia.Formularios.fMenu.Show();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
