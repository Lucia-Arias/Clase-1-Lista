using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_1_Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDNI.Text == "")
            {
                lbError.Text = "Se deben rellenar todos los datos";
            }
            else
            {
                lbError.Text = "";
                lbRegistro1.Text = lbRegistro1.Text + "\n" + txtDNI.Text
                + " - " + txtNombre.Text + " - " + txtApellido.Text;

                txtApellido.Text = "";
                txtNombre.Text = "";
                txtDNI.Text = "";
            }

        }

        private void btFin_Click(object sender, EventArgs e)
        {
            lbTitulo.Visible = false;
            lbNombre.Visible = false;
            lbApellido.Visible = false;
            lbDNI.Visible= false;
            txtNombre.Visible=false;
            txtApellido.Visible=false;
            txtDNI.Visible=false;
            btRegistrar.Visible=false;
            btFin.Visible=false;
        }
    }
}
