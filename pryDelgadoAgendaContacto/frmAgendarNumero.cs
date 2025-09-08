namespace pryDelgadoAgendaContacto
{
    public partial class frmAgendarNumero : Form
    {
        public frmAgendarNumero()
        {
            InitializeComponent();
        }
        string vContacto = "";
        string vNumero = "";
        int vContador = 0;
        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                mskNumero.Enabled = false;
            }
            else
            {
                mskNumero.Enabled = true;
            }
        }

        private void mskNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mskNumero.Text == "")
            {
                cmdRegistrar.Enabled = false;
            }
            else
            {
                cmdRegistrar.Enabled = true;
            }
        }
        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mskNumero.Text;
            lstbLista.Items.Add("Contacto:" + vContacto
                + "Número:" + vNumero);
            txtContacto.Text = "";
            mskNumero.Text = "";
            vContador = vContador + 1;
            lblCantidadCon.Text = "Cantidad de Contactos: "+vContador;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mskNumero.Text = "";
        }
    }
}
