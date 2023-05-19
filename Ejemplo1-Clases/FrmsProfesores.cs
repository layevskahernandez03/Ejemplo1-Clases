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
    public partial class FrmsProfesores : Form
    {
        public FrmsProfesores()
        {
            InitializeComponent();
        }

        private void FrmsProfesores_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Verinss() && Vertsal())
            {
                DialogResult x = MessageBox.Show("¿Estas seguros que los datos estan Correcto?", "Confirmar", MessageBoxButtons.YesNo);
                {
                    Datos.Profesores.Add(new Profesor(Textinss.Text, double.Parse (Textsal.Text)));
                }
                if (x == DialogResult.Yes)
                {
                    DialogResult r = MessageBox.Show("Sean ingresado correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }
            }
        }
        private bool Verinss()
        {
            if (string.IsNullOrEmpty(Textinss.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool Vertsal()
        {
            if (string.IsNullOrEmpty(Textsal.Text))
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
