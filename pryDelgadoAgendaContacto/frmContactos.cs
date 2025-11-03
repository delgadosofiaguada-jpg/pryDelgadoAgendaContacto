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
            if (indice < vecNombre.Length - 1)
            {
                indice++;
                lblDato.Text = vecNombre[indice];
            }

            // Actualizar estados de botones
            cmdSiguiente.Enabled = (indice < vecNombre.Length - 1);
            cmdAnterior.Enabled = (indice > 0);
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                lblDato.Text = vecNombre[indice];
            }

            // Actualizar estados de botones
            cmdAnterior.Enabled = (indice > 0);
            cmdSiguiente.Enabled = (indice < vecNombre.Length - 1);
        }   
    }
}
