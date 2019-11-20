using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace Layer2appWin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           Negocio Logica = new Negocio();  
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                errorProvider1.SetError(txtCodigo, "Debe sumistre un código al registro");
                txtCodigo.Focus();
                return;
            }
            errorProvider1.SetError(txtCodigo, "");

            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Debe sumistre nombre (s) al registro");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");
            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe sumistre apellido (s) al registro");
                txtApellidos.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidos, "");

            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (!Regex.IsMatch(txtEmail.Text, sFormato))
            {
                errorProvider1.SetError(txtEmail, "Sumistre una Dirección de Correo válido");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            decimal Sueldo;
            if (!Decimal.TryParse(txtSueldo.Text, out Sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Sumistre una cantidad númerica al Sueldo");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (!(Sueldo > 0))
            {
                errorProvider1.SetError(txtSueldo, "Sumistre una cantidad númerica positiva al Sueldo");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            //DataGridView
            Logica.CrearPersona(txtCodigo.Text, txtNombres.Text, txtApellidos.Text,txtEmail.Text, dtpFechaNacimiento.Value, txtSueldo.Text);
            dgvListaPersonas.DataSource=Logica.actualizarListaPersonas();
        }

       
    }
}
