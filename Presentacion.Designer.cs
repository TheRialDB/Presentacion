namespace Presentacion
{
    partial class Presentacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumn = new System.Windows.Forms.Button();
            this.btnCargarAlumn = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnBorrarAsistencia = new System.Windows.Forms.Button();
            this.btnModificarAsistencia = new System.Windows.Forms.Button();
            this.btnCargarAsistencia = new System.Windows.Forms.Button();
            this.lblDniAsistencia = new System.Windows.Forms.Label();
            this.gpbAsistencia = new System.Windows.Forms.GroupBox();
            this.rdbAusente = new System.Windows.Forms.RadioButton();
            this.rdbPresente = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDniAlumno = new System.Windows.Forms.MaskedTextBox();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.epvAlumnos = new System.Windows.Forms.ErrorProvider(this.components);
            this.epvAsistencias = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gpbAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDni);
            this.tabPage1.Controls.Add(this.btnBorrarAlumno);
            this.tabPage1.Controls.Add(this.btnModificarAlumn);
            this.tabPage1.Controls.Add(this.btnCargarAlumn);
            this.tabPage1.Controls.Add(this.dgvAlumnos);
            this.tabPage1.Controls.Add(this.lblDni);
            this.tabPage1.Controls.Add(this.lblAlumno);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumnos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(43, 142);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 8;
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.Location = new System.Drawing.Point(43, 318);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarAlumno.TabIndex = 7;
            this.btnBorrarAlumno.Text = "Borrar";
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // btnModificarAlumn
            // 
            this.btnModificarAlumn.Location = new System.Drawing.Point(43, 263);
            this.btnModificarAlumn.Name = "btnModificarAlumn";
            this.btnModificarAlumn.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAlumn.TabIndex = 6;
            this.btnModificarAlumn.Text = "Modificar";
            this.btnModificarAlumn.UseVisualStyleBackColor = true;
            this.btnModificarAlumn.Click += new System.EventHandler(this.btnModificarAlumn_Click);
            // 
            // btnCargarAlumn
            // 
            this.btnCargarAlumn.Location = new System.Drawing.Point(43, 208);
            this.btnCargarAlumn.Name = "btnCargarAlumn";
            this.btnCargarAlumn.Size = new System.Drawing.Size(75, 23);
            this.btnCargarAlumn.TabIndex = 5;
            this.btnCargarAlumn.Text = "Cargar";
            this.btnCargarAlumn.UseVisualStyleBackColor = true;
            this.btnCargarAlumn.Click += new System.EventHandler(this.btnCargarAlumn_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(268, 6);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(375, 360);
            this.dgvAlumnos.TabIndex = 4;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(40, 101);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(40, 26);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(44, 13);
            this.lblAlumno.TabIndex = 2;
            this.lblAlumno.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(43, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblMensaje);
            this.tabPage2.Controls.Add(this.btnBorrarAsistencia);
            this.tabPage2.Controls.Add(this.btnModificarAsistencia);
            this.tabPage2.Controls.Add(this.btnCargarAsistencia);
            this.tabPage2.Controls.Add(this.lblDniAsistencia);
            this.tabPage2.Controls.Add(this.gpbAsistencia);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.txtDniAlumno);
            this.tabPage2.Controls.Add(this.dgvAsistencia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asistencia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(283, 384);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 8;
            // 
            // btnBorrarAsistencia
            // 
            this.btnBorrarAsistencia.Location = new System.Drawing.Point(25, 345);
            this.btnBorrarAsistencia.Name = "btnBorrarAsistencia";
            this.btnBorrarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarAsistencia.TabIndex = 7;
            this.btnBorrarAsistencia.Text = "Borrar";
            this.btnBorrarAsistencia.UseVisualStyleBackColor = true;
            this.btnBorrarAsistencia.Click += new System.EventHandler(this.btnBorrarAsistencia_Click);
            // 
            // btnModificarAsistencia
            // 
            this.btnModificarAsistencia.Location = new System.Drawing.Point(25, 316);
            this.btnModificarAsistencia.Name = "btnModificarAsistencia";
            this.btnModificarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAsistencia.TabIndex = 6;
            this.btnModificarAsistencia.Text = "Modificar";
            this.btnModificarAsistencia.UseVisualStyleBackColor = true;
            this.btnModificarAsistencia.Click += new System.EventHandler(this.btnModificarAsistencia_Click);
            // 
            // btnCargarAsistencia
            // 
            this.btnCargarAsistencia.Location = new System.Drawing.Point(25, 286);
            this.btnCargarAsistencia.Name = "btnCargarAsistencia";
            this.btnCargarAsistencia.Size = new System.Drawing.Size(75, 23);
            this.btnCargarAsistencia.TabIndex = 5;
            this.btnCargarAsistencia.Text = "Cargar";
            this.btnCargarAsistencia.UseVisualStyleBackColor = true;
            this.btnCargarAsistencia.Click += new System.EventHandler(this.btnCargarAsistencia_Click);
            // 
            // lblDniAsistencia
            // 
            this.lblDniAsistencia.AutoSize = true;
            this.lblDniAsistencia.Location = new System.Drawing.Point(22, 28);
            this.lblDniAsistencia.Name = "lblDniAsistencia";
            this.lblDniAsistencia.Size = new System.Drawing.Size(61, 13);
            this.lblDniAsistencia.TabIndex = 4;
            this.lblDniAsistencia.Text = "Dni Alumno";
            // 
            // gpbAsistencia
            // 
            this.gpbAsistencia.Controls.Add(this.rdbAusente);
            this.gpbAsistencia.Controls.Add(this.rdbPresente);
            this.gpbAsistencia.Location = new System.Drawing.Point(25, 157);
            this.gpbAsistencia.Name = "gpbAsistencia";
            this.gpbAsistencia.Size = new System.Drawing.Size(200, 100);
            this.gpbAsistencia.TabIndex = 3;
            this.gpbAsistencia.TabStop = false;
            this.gpbAsistencia.Text = "Asistencia";
            // 
            // rdbAusente
            // 
            this.rdbAusente.AutoSize = true;
            this.rdbAusente.Location = new System.Drawing.Point(15, 64);
            this.rdbAusente.Name = "rdbAusente";
            this.rdbAusente.Size = new System.Drawing.Size(64, 17);
            this.rdbAusente.TabIndex = 1;
            this.rdbAusente.TabStop = true;
            this.rdbAusente.Text = "Ausente";
            this.rdbAusente.UseVisualStyleBackColor = true;
            // 
            // rdbPresente
            // 
            this.rdbPresente.AutoSize = true;
            this.rdbPresente.Location = new System.Drawing.Point(15, 29);
            this.rdbPresente.Name = "rdbPresente";
            this.rdbPresente.Size = new System.Drawing.Size(67, 17);
            this.rdbPresente.TabIndex = 0;
            this.rdbPresente.TabStop = true;
            this.rdbPresente.Text = "Presente";
            this.rdbPresente.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(25, 53);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtDniAlumno.TabIndex = 1;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(291, 6);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(352, 350);
            this.dgvAsistencia.TabIndex = 0;
            this.dgvAsistencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellClick);
            // 
            // epvAlumnos
            // 
            this.epvAlumnos.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvAlumnos.ContainerControl = this;
            // 
            // epvAsistencias
            // 
            this.epvAsistencias.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epvAsistencias.ContainerControl = this;
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Presentacion";
            this.Text = "Asistencia";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gpbAsistencia.ResumeLayout(false);
            this.gpbAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epvAsistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBorrarAlumno;
        private System.Windows.Forms.Button btnModificarAlumn;
        private System.Windows.Forms.Button btnCargarAlumn;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.GroupBox gpbAsistencia;
        private System.Windows.Forms.RadioButton rdbPresente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox txtDniAlumno;
        private System.Windows.Forms.RadioButton rdbAusente;
        private System.Windows.Forms.Label lblDniAsistencia;
        private System.Windows.Forms.Button btnBorrarAsistencia;
        private System.Windows.Forms.Button btnModificarAsistencia;
        private System.Windows.Forms.Button btnCargarAsistencia;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ErrorProvider epvAlumnos;
        private System.Windows.Forms.ErrorProvider epvAsistencias;
    }
}

