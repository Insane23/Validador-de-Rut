using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLogIn : Form
    {
        string rut = "19654048", pass = "1234qwer";
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtRut.Text==rut && txtContraseña.Text == pass)
            {
                MessageBox.Show("Bueeena ctm");
            }
            else
            {
                MessageBox.Show("Te equivocaste zangano");
                txtContraseña.Text = "";
            }
        }
        private void ValidarRut()
        {

            int mult = 0, suma = 0, cont = 2;
            //MessageBox.Show(numero);
            string numero;
            for (int i = txtRut.Text.Length - 2; i >= 0; i--)
            {
                numero = txtRut.Text.Substring(i, 1);
                if (cont > 7)
                {
                    cont = 2;
                }
                mult = int.Parse(numero) * cont;
                suma = suma + mult;
                cont++;
            }
            MessageBox.Show("La suma es: " + suma);
            string digito = "";
            int resto = suma % 11, resta = 11 - resto;
            if (resta == 10)
            {
                digito = "k";
            }
            else
            {
                if (resta == 11)
                {
                    digito = "0";
                }
                else
                {
                    digito = resta.ToString();
                }
            }
            if (digito == txtRut.Text.ToLower().Substring(txtRut.Text.Length - 1))
            {
                MessageBox.Show("El rut es valido");
            }
            else
            {
                MessageBox.Show("RUT FALSO");
            }
        }
        private void txtRut_Leave(object sender, EventArgs e)
        {
            
            
            if (txtRut.Text == "")
            {
                return;
            }
            ValidarRut();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtRut.Text = "";
            txtContraseña.Text = "";
        }
    }
}
