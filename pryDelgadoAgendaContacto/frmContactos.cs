using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDelgadoAgendaContacto
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string[] vecNombre = new string[3];
        int indice = 0;
        private void frmContactos_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "Guadalupe";
            vecNombre[1] = "Martina";
            vecNombre[2] = "Leandro";
            lblDato.Text = vecNombre[0];
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            indice++;
            lblDato.Text = vecNombre[indice];
            if (vecNombre.Length <= (indice + 1))
            {
                cmdSiguiente.Enabled = false;
            }
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            indice--;
            lblDato.Text = vecNombre[indice];
        }   
    }
}
