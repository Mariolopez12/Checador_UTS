using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
        }
        private void AbrirFomlarioPanel(object Formhijo)
        {
            if (this.PanelPrinsipal.Controls.Count > 0)
                this.PanelPrinsipal.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrinsipal.Controls.Add(fh);
            this.PanelPrinsipal.Tag = fh;
            fh.Show();
        }
        public void adaptarFormulario(Form formulario)
        {
            formulario.Location = Screen.PrimaryScreen.WorkingArea.Location;
            formulario.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        private void FmrMenu_Load(object sender, EventArgs e)
        {
            adaptarFormulario(this);
        }



        private void admitrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFomlarioPanel(new FrmUsuario());
        }
    }
}
