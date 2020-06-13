using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiRuby
{
    public partial class frmPrincipal : Form
    {
        int contadorPaginascreadas = 1;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Menu
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contadorPaginascreadas++;

            TabPage TP = new TabPage();
            tabControl1.TabPages.Add(TP);
            TP.BackColor = Color.White;
            EditorTexto et = new EditorTexto();
            et.Name = "editorTexto" + contadorPaginascreadas;
            TP.Controls.Add(et);
            TP.Name = "tabPage" + contadorPaginascreadas;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreTabpageseleccionada = tabControl1.SelectedTab.Name.ToString();
            string indiceparacontroleditort = nombreTabpageseleccionada.Substring(nombreTabpageseleccionada.Length - 1, 1);

            var controles = tabControl1.Controls.OfType<TabPage>().Where(x => x.Name.StartsWith(nombreTabpageseleccionada));

            foreach (var ctrl in controles)
            {
                var controleseditor = ctrl.Controls.OfType<EditorTexto>().Where(x => x.Name.StartsWith("editorTexto" + indiceparacontroleditort));

                foreach (var ctrleditor in controleseditor)
                {

                    ctrleditor.Guardar();

                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreTabpageseleccionada = tabControl1.SelectedTab.Name.ToString();
            string indiceparacontroleditort = nombreTabpageseleccionada.Substring(nombreTabpageseleccionada.Length - 1, 1);

            var controles = tabControl1.Controls.OfType<TabPage>().Where(x => x.Name.StartsWith(nombreTabpageseleccionada));

            foreach (var ctrl in controles)
            {
                var controleseditor = ctrl.Controls.OfType<EditorTexto>().Where(x => x.Name.StartsWith("editorTexto" + indiceparacontroleditort));

                foreach (var ctrleditor in controleseditor)
                {
                    ctrleditor.Abir();

                }
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EjecutarAnalizadorLexico();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EjecutarAnalizadorLexico()
        {

        }
    }
}
