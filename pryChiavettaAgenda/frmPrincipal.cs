namespace pryChiavettaAgenda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        string vContacto = "";
        string vTelefono = "";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vTelefono = lstDatos.Text;
            lstDatos.Items.Add("vContacto: + " + vContacto);
            +" Telefono:" + vTelefono );

        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {


        }

        private void mskNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lsbDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
       