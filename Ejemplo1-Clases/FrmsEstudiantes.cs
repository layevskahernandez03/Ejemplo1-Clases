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
    public partial class FrmsEstudiantes : Form
    {
        public FrmsEstudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ( Verexp() && Vertitu())
            {
                DialogResult x = MessageBox.Show("¿Estas seguros que los datos estan Correcto?", "Confirmar", MessageBoxButtons.YesNo);
                {
                    Datos.Alumnos.Add(new Alumno(TextExp.Text,TexTitu.Text));
                }
                if (x == DialogResult.Yes)
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
       
        private bool Verexp()
        {
            if (string.IsNullOrEmpty(TextExp.Text))
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        private bool Vertitu()
        {
            if (string.IsNullOrEmpty(TexTitu.Text))
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
            if (c == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
