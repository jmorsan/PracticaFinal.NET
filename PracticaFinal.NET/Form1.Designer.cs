
namespace PracticaFinal.NET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AltaAlumnos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nifAlumno = new System.Windows.Forms.TextBox();
            this.apellidosAlumno = new System.Windows.Forms.TextBox();
            this.nombreAlumno = new System.Windows.Forms.TextBox();
            this.bajaAlumno = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListarAlumnos = new System.Windows.Forms.Panel();
            this.buttonEliminarAlumno = new System.Windows.Forms.Button();
            this.buttonModificarAlumno = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaDataSet = new PracticaFinal.NET.practicaDataSet();
            this.alumnosTableAdapter = new PracticaFinal.NET.practicaDataSetTableAdapters.AlumnosTableAdapter();
            this.ListarEvaluaciones = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEliminarEvaluacion = new System.Windows.Forms.Button();
            this.buttonModificarEvaluacion = new System.Windows.Forms.Button();
            this.evaluacionesTableAdapter = new PracticaFinal.NET.practicaDataSetTableAdapters.EvaluacionesTableAdapter();
            this.AltaEvaluaciones = new System.Windows.Forms.Panel();
            this.comboBoxEvaluaciones = new System.Windows.Forms.ComboBox();
            this.buttonGuardarEvaluacion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.ListarNotas = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvaluacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMDMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGuardarNotas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNotas = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasTableAdapter = new PracticaFinal.NET.practicaDataSetTableAdapters.NotasTableAdapter();
            this.alumnosNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AltaAlumnos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ListarAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).BeginInit();
            this.ListarEvaluaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).BeginInit();
            this.AltaEvaluaciones.SuspendLayout();
            this.ListarNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosNotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AltaAlumnos
            // 
            this.AltaAlumnos.Controls.Add(this.button1);
            this.AltaAlumnos.Controls.Add(this.nifAlumno);
            this.AltaAlumnos.Controls.Add(this.apellidosAlumno);
            this.AltaAlumnos.Controls.Add(this.nombreAlumno);
            this.AltaAlumnos.Controls.Add(this.bajaAlumno);
            this.AltaAlumnos.Controls.Add(this.label3);
            this.AltaAlumnos.Controls.Add(this.label2);
            this.AltaAlumnos.Controls.Add(this.label1);
            this.AltaAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AltaAlumnos.Location = new System.Drawing.Point(0, 24);
            this.AltaAlumnos.Name = "AltaAlumnos";
            this.AltaAlumnos.Size = new System.Drawing.Size(820, 446);
            this.AltaAlumnos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nifAlumno
            // 
            this.nifAlumno.Location = new System.Drawing.Point(176, 162);
            this.nifAlumno.Name = "nifAlumno";
            this.nifAlumno.Size = new System.Drawing.Size(143, 20);
            this.nifAlumno.TabIndex = 7;
            // 
            // apellidosAlumno
            // 
            this.apellidosAlumno.Location = new System.Drawing.Point(176, 108);
            this.apellidosAlumno.Name = "apellidosAlumno";
            this.apellidosAlumno.Size = new System.Drawing.Size(143, 20);
            this.apellidosAlumno.TabIndex = 6;
            // 
            // nombreAlumno
            // 
            this.nombreAlumno.Location = new System.Drawing.Point(176, 61);
            this.nombreAlumno.Name = "nombreAlumno";
            this.nombreAlumno.Size = new System.Drawing.Size(143, 20);
            this.nombreAlumno.TabIndex = 4;
            // 
            // bajaAlumno
            // 
            this.bajaAlumno.AutoSize = true;
            this.bajaAlumno.Location = new System.Drawing.Point(64, 211);
            this.bajaAlumno.Name = "bajaAlumno";
            this.bajaAlumno.Size = new System.Drawing.Size(47, 17);
            this.bajaAlumno.TabIndex = 3;
            this.bajaAlumno.Text = "Baja";
            this.bajaAlumno.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nif: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.evaluacionesToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // ListarAlumnos
            // 
            this.ListarAlumnos.Controls.Add(this.buttonEliminarAlumno);
            this.ListarAlumnos.Controls.Add(this.buttonModificarAlumno);
            this.ListarAlumnos.Controls.Add(this.dataGridView1);
            this.ListarAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListarAlumnos.Location = new System.Drawing.Point(0, 24);
            this.ListarAlumnos.Name = "ListarAlumnos";
            this.ListarAlumnos.Size = new System.Drawing.Size(820, 446);
            this.ListarAlumnos.TabIndex = 9;
            // 
            // buttonEliminarAlumno
            // 
            this.buttonEliminarAlumno.Location = new System.Drawing.Point(243, 343);
            this.buttonEliminarAlumno.Name = "buttonEliminarAlumno";
            this.buttonEliminarAlumno.Size = new System.Drawing.Size(132, 44);
            this.buttonEliminarAlumno.TabIndex = 2;
            this.buttonEliminarAlumno.Text = "Eliminar";
            this.buttonEliminarAlumno.UseVisualStyleBackColor = true;
            this.buttonEliminarAlumno.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonModificarAlumno
            // 
            this.buttonModificarAlumno.Location = new System.Drawing.Point(64, 343);
            this.buttonModificarAlumno.Name = "buttonModificarAlumno";
            this.buttonModificarAlumno.Size = new System.Drawing.Size(130, 45);
            this.buttonModificarAlumno.TabIndex = 1;
            this.buttonModificarAlumno.Text = "Guardar";
            this.buttonModificarAlumno.UseVisualStyleBackColor = true;
            this.buttonModificarAlumno.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.bajaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.alumnosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bajaDataGridViewCheckBoxColumn
            // 
            this.bajaDataGridViewCheckBoxColumn.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn.Name = "bajaDataGridViewCheckBoxColumn";
            this.bajaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.practicaDataSetBindingSource;
            // 
            // practicaDataSetBindingSource
            // 
            this.practicaDataSetBindingSource.DataSource = this.practicaDataSet;
            this.practicaDataSetBindingSource.Position = 0;
            // 
            // practicaDataSet
            // 
            this.practicaDataSet.DataSetName = "practicaDataSet";
            this.practicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // ListarEvaluaciones
            // 
            this.ListarEvaluaciones.Controls.Add(this.dataGridView2);
            this.ListarEvaluaciones.Location = new System.Drawing.Point(0, 27);
            this.ListarEvaluaciones.Name = "ListarEvaluaciones";
            this.ListarEvaluaciones.Size = new System.Drawing.Size(800, 396);
            this.ListarEvaluaciones.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.evaluacionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.evaluacionesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(800, 290);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // evaluacionDataGridViewTextBoxColumn
            // 
            this.evaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.Name = "evaluacionDataGridViewTextBoxColumn";
            this.evaluacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluacionesBindingSource
            // 
            this.evaluacionesBindingSource.DataMember = "Evaluaciones";
            this.evaluacionesBindingSource.DataSource = this.practicaDataSetBindingSource;
            // 
            // buttonEliminarEvaluacion
            // 
            this.buttonEliminarEvaluacion.Location = new System.Drawing.Point(315, 306);
            this.buttonEliminarEvaluacion.Name = "buttonEliminarEvaluacion";
            this.buttonEliminarEvaluacion.Size = new System.Drawing.Size(231, 53);
            this.buttonEliminarEvaluacion.TabIndex = 2;
            this.buttonEliminarEvaluacion.Text = "Eliminar";
            this.buttonEliminarEvaluacion.UseVisualStyleBackColor = true;
            this.buttonEliminarEvaluacion.Click += new System.EventHandler(this.buttonEliminarEvaluacion_Click);
            // 
            // buttonModificarEvaluacion
            // 
            this.buttonModificarEvaluacion.Location = new System.Drawing.Point(11, 306);
            this.buttonModificarEvaluacion.Name = "buttonModificarEvaluacion";
            this.buttonModificarEvaluacion.Size = new System.Drawing.Size(211, 53);
            this.buttonModificarEvaluacion.TabIndex = 1;
            this.buttonModificarEvaluacion.Text = "Guardar";
            this.buttonModificarEvaluacion.UseVisualStyleBackColor = true;
            this.buttonModificarEvaluacion.Click += new System.EventHandler(this.buttonModificarEvaluacion_Click);
            // 
            // evaluacionesTableAdapter
            // 
            this.evaluacionesTableAdapter.ClearBeforeFill = true;
            // 
            // AltaEvaluaciones
            // 
            this.AltaEvaluaciones.Controls.Add(this.comboBoxEvaluaciones);
            this.AltaEvaluaciones.Controls.Add(this.buttonGuardarEvaluacion);
            this.AltaEvaluaciones.Controls.Add(this.label4);
            this.AltaEvaluaciones.Controls.Add(this.textDescripcion);
            this.AltaEvaluaciones.Controls.Add(this.buttonModificarEvaluacion);
            this.AltaEvaluaciones.Controls.Add(this.buttonEliminarEvaluacion);
            this.AltaEvaluaciones.Location = new System.Drawing.Point(0, 24);
            this.AltaEvaluaciones.Name = "AltaEvaluaciones";
            this.AltaEvaluaciones.Size = new System.Drawing.Size(800, 426);
            this.AltaEvaluaciones.TabIndex = 3;
            // 
            // comboBoxEvaluaciones
            // 
            this.comboBoxEvaluaciones.DataSource = this.evaluacionesBindingSource;
            this.comboBoxEvaluaciones.DisplayMember = "Evaluacion";
            this.comboBoxEvaluaciones.FormattingEnabled = true;
            this.comboBoxEvaluaciones.Location = new System.Drawing.Point(195, 22);
            this.comboBoxEvaluaciones.Name = "comboBoxEvaluaciones";
            this.comboBoxEvaluaciones.Size = new System.Drawing.Size(447, 21);
            this.comboBoxEvaluaciones.TabIndex = 3;
            this.comboBoxEvaluaciones.ValueMember = "Id";
            // 
            // buttonGuardarEvaluacion
            // 
            this.buttonGuardarEvaluacion.Location = new System.Drawing.Point(266, 222);
            this.buttonGuardarEvaluacion.Name = "buttonGuardarEvaluacion";
            this.buttonGuardarEvaluacion.Size = new System.Drawing.Size(225, 63);
            this.buttonGuardarEvaluacion.TabIndex = 2;
            this.buttonGuardarEvaluacion.Text = "Guardar";
            this.buttonGuardarEvaluacion.UseVisualStyleBackColor = true;
            this.buttonGuardarEvaluacion.Click += new System.EventHandler(this.buttonGuardarEvaluacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripcion: ";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(195, 87);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(447, 20);
            this.textDescripcion.TabIndex = 0;
            // 
            // ListarNotas
            // 
            this.ListarNotas.Controls.Add(this.label6);
            this.ListarNotas.Controls.Add(this.comboBox1);
            this.ListarNotas.Controls.Add(this.dataGridView4);
            this.ListarNotas.Controls.Add(this.buttonGuardarNotas);
            this.ListarNotas.Controls.Add(this.label5);
            this.ListarNotas.Controls.Add(this.comboBoxNotas);
            this.ListarNotas.Controls.Add(this.dataGridView3);
            this.ListarNotas.Location = new System.Drawing.Point(0, 24);
            this.ListarNotas.Name = "ListarNotas";
            this.ListarNotas.Size = new System.Drawing.Size(820, 446);
            this.ListarNotas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Evaluaciones:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.evaluacionesBindingSource;
            this.comboBox1.DisplayMember = "Evaluacion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(547, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn1,
            this.idEvaluacionDataGridViewTextBoxColumn1,
            this.dIDataGridViewTextBoxColumn1,
            this.pMDMDataGridViewTextBoxColumn1,
            this.aDDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.notasBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(0, 28);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(540, 395);
            this.dataGridView4.TabIndex = 4;
            // 
            // idAlumnoDataGridViewTextBoxColumn1
            // 
            this.idAlumnoDataGridViewTextBoxColumn1.DataPropertyName = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn1.HeaderText = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn1.Name = "idAlumnoDataGridViewTextBoxColumn1";
            // 
            // idEvaluacionDataGridViewTextBoxColumn1
            // 
            this.idEvaluacionDataGridViewTextBoxColumn1.DataPropertyName = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn1.HeaderText = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn1.Name = "idEvaluacionDataGridViewTextBoxColumn1";
            // 
            // dIDataGridViewTextBoxColumn1
            // 
            this.dIDataGridViewTextBoxColumn1.DataPropertyName = "DI";
            this.dIDataGridViewTextBoxColumn1.HeaderText = "DI";
            this.dIDataGridViewTextBoxColumn1.Name = "dIDataGridViewTextBoxColumn1";
            // 
            // pMDMDataGridViewTextBoxColumn1
            // 
            this.pMDMDataGridViewTextBoxColumn1.DataPropertyName = "PMDM";
            this.pMDMDataGridViewTextBoxColumn1.HeaderText = "PMDM";
            this.pMDMDataGridViewTextBoxColumn1.Name = "pMDMDataGridViewTextBoxColumn1";
            // 
            // aDDataGridViewTextBoxColumn1
            // 
            this.aDDataGridViewTextBoxColumn1.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn1.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn1.Name = "aDDataGridViewTextBoxColumn1";
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.practicaDataSetBindingSource;
            // 
            // buttonGuardarNotas
            // 
            this.buttonGuardarNotas.Location = new System.Drawing.Point(566, 126);
            this.buttonGuardarNotas.Name = "buttonGuardarNotas";
            this.buttonGuardarNotas.Size = new System.Drawing.Size(219, 65);
            this.buttonGuardarNotas.TabIndex = 3;
            this.buttonGuardarNotas.Text = "Guardar";
            this.buttonGuardarNotas.UseVisualStyleBackColor = true;
            this.buttonGuardarNotas.Click += new System.EventHandler(this.buttonGuardarNotas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Alumno: ";
            // 
            // comboBoxNotas
            // 
            this.comboBoxNotas.DataSource = this.alumnosBindingSource;
            this.comboBoxNotas.DisplayMember = "NIF";
            this.comboBoxNotas.FormattingEnabled = true;
            this.comboBoxNotas.Location = new System.Drawing.Point(546, 49);
            this.comboBoxNotas.Name = "comboBoxNotas";
            this.comboBoxNotas.Size = new System.Drawing.Size(254, 21);
            this.comboBoxNotas.TabIndex = 1;
            this.comboBoxNotas.ValueMember = "Id";
            this.comboBoxNotas.SelectedIndexChanged += new System.EventHandler(this.comboBoxNotas_SelectedIndexChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.idEvaluacionDataGridViewTextBoxColumn,
            this.dIDataGridViewTextBoxColumn,
            this.pMDMDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.notasBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(540, 398);
            this.dataGridView3.TabIndex = 0;
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            // 
            // idEvaluacionDataGridViewTextBoxColumn
            // 
            this.idEvaluacionDataGridViewTextBoxColumn.DataPropertyName = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.HeaderText = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.Name = "idEvaluacionDataGridViewTextBoxColumn";
            // 
            // dIDataGridViewTextBoxColumn
            // 
            this.dIDataGridViewTextBoxColumn.DataPropertyName = "DI";
            this.dIDataGridViewTextBoxColumn.HeaderText = "DI";
            this.dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            // 
            // pMDMDataGridViewTextBoxColumn
            // 
            this.pMDMDataGridViewTextBoxColumn.DataPropertyName = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.HeaderText = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.Name = "pMDMDataGridViewTextBoxColumn";
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // alumnosNotasBindingSource
            // 
            this.alumnosNotasBindingSource.DataMember = "AlumnosNotas";
            this.alumnosNotasBindingSource.DataSource = this.alumnosBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 470);
            this.Controls.Add(this.ListarNotas);
            this.Controls.Add(this.AltaAlumnos);
            this.Controls.Add(this.AltaEvaluaciones);
            this.Controls.Add(this.ListarEvaluaciones);
            this.Controls.Add(this.ListarAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AltaAlumnos.ResumeLayout(false);
            this.AltaAlumnos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ListarAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).EndInit();
            this.ListarEvaluaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).EndInit();
            this.AltaEvaluaciones.ResumeLayout(false);
            this.AltaEvaluaciones.PerformLayout();
            this.ListarNotas.ResumeLayout(false);
            this.ListarNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosNotasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AltaAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bajaAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreAlumno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nifAlumno;
        private System.Windows.Forms.TextBox apellidosAlumno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Panel ListarAlumnos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource practicaDataSetBindingSource;
        private practicaDataSet practicaDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private practicaDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.Button buttonEliminarAlumno;
        private System.Windows.Forms.Button buttonModificarAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Panel ListarEvaluaciones;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource evaluacionesBindingSource;
        private practicaDataSetTableAdapters.EvaluacionesTableAdapter evaluacionesTableAdapter;
        private System.Windows.Forms.Button buttonModificarEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonEliminarEvaluacion;
        private System.Windows.Forms.Panel AltaEvaluaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Panel ListarNotas;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private practicaDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNotas;
        private System.Windows.Forms.BindingSource alumnosNotasBindingSource;
        private System.Windows.Forms.Button buttonGuardarEvaluacion;
        private System.Windows.Forms.ComboBox comboBoxEvaluaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonGuardarNotas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMDMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label6;
    }
}

