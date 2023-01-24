using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PracticaFinal.NET
{
    public partial class Form1 : Form
    {
        private string connetion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\practica.mdb";

        OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            cerrarVentanas();
            connection = new OleDbConnection(connetion);
            connection.Open();
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

        //*************ALTAS************************
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            AltaAlumnos.Visible = true;

            button1.Visible = true;


        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            AltaEvaluaciones.Visible = true;

            textDescripcion.Visible = true;
            label4.Visible = true;
            comboBoxEvaluaciones.Visible = true;

            buttonGuardarEvaluacion.Visible = true;

        }

        //*************LISTADOS************************

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ListarAlumnos.Visible = true;
            dataGridView1.ReadOnly = true;



        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ListarEvaluaciones.Visible = true;

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

            button1.Visible = false;
            buttonModificarAlumno.Visible = false;
            buttonEliminarAlumno.Visible = false;

            buttonGuardarEvaluacion.Visible = false;
            buttonModificarEvaluacion.Visible = false;
            buttonEliminarEvaluacion.Visible = false;

            comboBox1.Visible = false;
            comboBoxEvaluaciones.Visible = false;

            textDescripcion.Visible = false;
            label4.Visible = false;

        }

        //*************MODIFICAR************************
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ListarAlumnos.Visible = true;
            dataGridView1.ReadOnly = false;

            

            buttonModificarAlumno.Visible = true;
            

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            AltaEvaluaciones.Visible = true;
            

            buttonModificarEvaluacion.Visible = true;
            comboBoxEvaluaciones.Visible = true;

            textDescripcion.Visible = true;
            label4.Visible = true;
            

        }

        //*************ELIMINAR************************
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            ListarAlumnos.Visible = true;
            dataGridView1.ReadOnly = false;
            buttonEliminarAlumno.Visible = true;

        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarVentanas();
            AltaEvaluaciones.Visible = true;

           
            buttonEliminarEvaluacion.Visible = true;
            comboBoxEvaluaciones.Visible = true;


        }

        //*************ACCION BOTONES ALUMNO************************
        //Crear Alumnos
        private void button1_Click(object sender, EventArgs e)
        {
            string sentencia = "INSERT INTO `Alumnos` (`Nombre`, `Apellidos`, `NIF`, `baja`) VALUES ( \'" + nombreAlumno.Text.ToString() + "\' , \'" + apellidosAlumno.Text.ToString() + "\' , \'" + nifAlumno.Text.ToString() + "\' ,  " + bajaAlumno.Checked + " )"; ;

            OleDbCommand miCmd = new OleDbCommand(sentencia, connection);

            miCmd.ExecuteNonQuery();

            cerrarVentanas();
            ListarAlumnos.Visible = true;
        }

        //Modificar Alumnos
        private void button2_Click(object sender, EventArgs e)
        {

            alumnosTableAdapter.Update(practicaDataSet.Alumnos);

            cerrarVentanas();

            ListarAlumnos.Visible = true;


        }

        //Eliminar Alumno
        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count!=0)
            {
                if (MessageBox.Show("Borrar el Alumno seleccionado?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    alumnosTableAdapter.Update(practicaDataSet.Alumnos);

                }

            }
            else
            {
                MessageBox.Show("Seleccione la columna entera","Error", MessageBoxButtons.OK);
            }
        }

        //*************ACCION BOTONES EVALUACIONES************************
        //Boton Guardar Evaluaciones
        private void buttonGuardarEvaluacion_Click(object sender, EventArgs e)
        {
            string sentencia = "INSERT INTO `Evaluaciones` (`Evaluacion`) VALUES ( \'" + textDescripcion.Text.ToString() + "\' )"; 

            OleDbCommand miCmd = new OleDbCommand(sentencia, connection);

            miCmd.ExecuteNonQuery();

            cerrarVentanas();
            ListarEvaluaciones.Visible = true;

        }

        //Boton Modificar Evaluaciones
        private void buttonModificarEvaluacion_Click(object sender, EventArgs e)
        {
            string sentencia = "UPDATE Evaluaciones SET Evaluacion = \'" + textDescripcion.Text.ToString() + "\' WHERE Id = " + comboBoxEvaluaciones.SelectedValue.ToString() ;
            
            OleDbCommand miCmd = new OleDbCommand(sentencia, connection);

            miCmd.ExecuteNonQuery();

            cerrarVentanas();
            ListarEvaluaciones.Visible = true;
        }

        //Boton Eliminar Evaluaciones
        private void buttonEliminarEvaluacion_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Borrar la evaluacion seleccionada?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sentencia = "DELETE FROM Evaluaciones  WHERE Id = " + comboBoxEvaluaciones.SelectedValue.ToString();

                OleDbCommand miCmd = new OleDbCommand(sentencia, connection);

                miCmd.ExecuteNonQuery();

                cerrarVentanas();
                ListarEvaluaciones.Visible = true;
            }
            

        }

        private void AltaEvaluaciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
