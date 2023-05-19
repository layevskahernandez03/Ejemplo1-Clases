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
    public partial class FrmsPersonal : Form
    {
        public FrmsPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Veruni() && Vercate())
            {
                DialogResult x = MessageBox.Show("¿Estas seguros que los datos estan Correcto?", "Confirmar", MessageBoxButtons.YesNo);
                {
                    Datos.Personanles.Add(new Personal(TextUnidad.Text, TextCategoria.Text));
                }
                if (x == DialogResult.Yes)
                {
                    DialogResult r = MessageBox.Show("Sean ingresado correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }
            }
        }
        private bool Veruni()
        {
            if (string.IsNullOrEmpty(TextUnidad.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool Vercate()
        {
            if (string.IsNullOrEmpty(TextCategoria.Text))
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
