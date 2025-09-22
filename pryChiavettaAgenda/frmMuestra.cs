using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pryChiavettaAgenda
{
    public partial class frmMuestra : Form
    {
        public frmMuestra()
        {
            InitializeComponent();
        }
        //Declaracion de variables  
       public string[] vecContacto = new string[5];
        
        public string[] PasarDatos;
        int indice = 0;



        //accion del vector 
        private void lblContactoss_Click(object sender, EventArgs e)
        {


        }

        private void btnSigiente_Click(object sender, EventArgs e)
        {

            if (indice < 5)
            {
                btnAtras.Enabled = true;
                lblContactoss.Text = PasarDatos[indice];
                indice++;
            }
            else
            {
                btnSigiente.Enabled = false;
                indice--;
            }

        }

        private void frmMuestra_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (indice >= 0)
            {
                btnSigiente.Enabled = true;

                lblContactoss.Text = PasarDatos[indice];
                indice--;
            }
            else
            {
                btnAtras.Enabled = false;
                indice++;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal volverForm = new frmPrincipal();
            volverForm.Show();
            this.Close(); // Cierra el formulario actual
        }
    }


}
