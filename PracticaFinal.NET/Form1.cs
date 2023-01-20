using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinal.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cerrarVentanas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.practicaDataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Evaluaciones' Puede moverla o quitarla según sea necesario.
            this.evaluacionesTableAdapter.Fill(this.practicaDataSet.Evaluaciones);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.practicaDataSet.Alumnos);
            


        }

        //*************CONSULTAS************************
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            AltaAlumnos.Visible = true;


        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            AltaEvaluaciones.Visible = true;

        }

        //*************LISTADOS************************

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ListarAlumnos.Visible = true;

            button2.Visible = false;
            button3.Visible = false;

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ListarEvaluaciones.Visible = true;

            button4.Visible = false;
            button5.Visible = false;

        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ListarNotas.Visible = true;


        }

        private void cerrarVentanas()
        {
            ListarEvaluaciones.Visible = false;
            ListarAlumnos.Visible = false;
            ListarNotas.Visible = false;
            AltaEvaluaciones.Visible = false;
            AltaAlumnos.Visible = false;
            


        }

        //*************MODIFICAR************************
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
