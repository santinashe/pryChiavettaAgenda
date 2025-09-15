namespace pryChiavettaAgenda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //variables
        string vContacto = "";
        string vTelefono = "";



        //vectores


        //indice
        int indice = 0;
        int vContador = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vTelefono = mtbNumero.Text;
            lstDatos.Items.Add("Contacto: " + vContacto + " Telefono: " + vTelefono);

            indice++;
            txtContacto.Focus();
            vContador++;
            lblContador.Text = Convert.ToString(vContador);
            txtContacto.Text = "";
            mtbNumero.Text = "";


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
            txtContacto.Text = "";
            mtbNumero.Text = "";

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

        private void mtbNumero_TextChanged(object sender, EventArgs e)
        {
            if (mtbNumero.MaskFull == true)
            {
                btnAceptar.Enabled = true;

            }
            else
            {
                btnAceptar.Enabled = false;

            }
        }

        private void lblCant_Click(object sender, EventArgs e)
        {

        }

        private void btnVercontactos_Click(object sender, EventArgs e)
        {
            frmMuestra nuevoFormulario = new frmMuestra();
            nuevoFormulario.Show();     // Abre el nuevo formulario
            this.Hide();                // Oculta el formulario actual (opcional
        }
    }
}
       