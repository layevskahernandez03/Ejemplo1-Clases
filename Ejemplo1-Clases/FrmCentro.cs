using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(VefNom() && VerDirec() && VerTel() && VerEmail())
            {
                DialogResult x = MessageBox.Show("¿Estas seguros que los datos estan Correcto?", "Confirmar", MessageBoxButtons.YesNo);
                {
                    Datos.Centros.Add(new Centro(TextNombre.Text, TextDireccion.Text, TextTelefono.Text, TextEmail.Text));
                }
                if(x== DialogResult.Yes)
                {
                    DialogResult r = MessageBox.Show("Sean ingresado correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }
                
            }
            else
            {
                DialogResult r = MessageBox.Show("Por favor Llenar todos los campos", "Confirmar", MessageBoxButtons.OK);
            }
        }
        private bool VefNom()
        {
            if (string.IsNullOrEmpty(TextNombre.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerDirec()
        {
            if (string.IsNullOrEmpty(TextDireccion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerTel()
        {
            if (string.IsNullOrEmpty(TextTelefono.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerEmail()
        {
            if (string.IsNullOrEmpty(TextEmail.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("¿Estas seguro que quiere cancelar", "Confirmar", MessageBoxButtons.YesNo);
            if(c== DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
