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
        string[] vecContacto = new string[3];
        int indice = 0;


        //accion del vector 
        private void lblContactoss_Click(object sender, EventArgs e)
        {
            vecContacto[0] = "Juan Perez";
            vecContacto[1] = "Lautaro Mendez";
            vecContacto[2] = "Edgar Rodriguez";
            vecContacto[3] = "Lucas Devalle";

            lblContactoss.Text = vecContacto[0];

        }

        private void btnSigiente_Click(object sender, EventArgs e)
        {
            indice++;
            lblContactoss.Text = vecContacto[indice];

            if (vecContacto.Length <= (indice + 1))
            {
                btnSigiente.Enabled = false;

            }
        }

        private void frmMuestra_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            lblContactoss.Text = vecContacto[indice];
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal volverForm = new frmPrincipal();
            volverForm.Show();
            this.Close(); // Cierra el formulario actual
        }
    }


}
