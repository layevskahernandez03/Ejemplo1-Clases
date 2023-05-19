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
    public partial class FrmsListaCliente : Form
    {
        public FrmsListaCliente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmsListaCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.Centros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult c = MessageBox.Show("¿Estas seguro que quiere cancelar", "Confirmar", MessageBoxButtons.YesNo);
            if (c == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
