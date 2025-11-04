namespace pryDelgadoAgendaContacto
{
    public partial class frmAgendarNumero : Form
    {
        public frmAgendarNumero()
        {
            InitializeComponent();
        }

        public static class DatosAgenda
        {
            public static string[] Nombres = new string[20];
            public static string[] Numeros = new string[20];
            public static int Cantidad = 0;
        }

        string vContacto = "";
        string vNumero = "";
        int vContador = 0;
        DateTime vFecha = DateTime.Now;


        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            mskNumero.Enabled = txtContacto.TextLength > 0;
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
            cmdRegistrar.Enabled = mskNumero.MaskFull;
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


            if (DatosAgenda.Cantidad < DatosAgenda.Nombres.Length)
            {
                DatosAgenda.Nombres[DatosAgenda.Cantidad] = vContacto;
                DatosAgenda.Numeros[DatosAgenda.Cantidad] = vNumero;
                DatosAgenda.Cantidad++;
            }

            lstbLista.Items.Add($"Contacto: {vContacto} - Número: {vNumero}");


            vContador++;
            lblCantidadCon.Text = $"Cantidad de Contactos: {vContador}";
            lblFechaHora.Text = $"Fecha y Hora: {vFecha}";


            frmContactos ventanaBienvenida = new frmContactos();
            ventanaBienvenida.ShowDialog();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mskNumero.Text = "";
        }

        private void frmAgendarNumero_Load(object sender, EventArgs e)
        {

        }
    }
}
