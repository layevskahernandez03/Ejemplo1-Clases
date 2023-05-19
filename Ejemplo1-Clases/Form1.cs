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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro centro = new FrmCentro();
            centro.ShowDialog();

        }

        private void listaDeCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmsListaCliente centro = new FrmsListaCliente();
            centro.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmsProfesores profesores = new FrmsProfesores();
            profesores.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmsEstudiantes Estu = new FrmsEstudiantes();
            Estu.ShowDialog();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmsPersonal personal = new FrmsPersonal();
            personal.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmsListaProfesores profesores = new FrmsListaProfesores();
            profesores.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmsListaEstdiante Estu = new FrmsListaEstdiante();
            Estu.ShowDialog();
        }

        private void listasDeTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
