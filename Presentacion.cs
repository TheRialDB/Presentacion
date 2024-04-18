using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Presentacion : Form
    {
        public Alumno objEntAlum = new Alumno();
        public NegAlumnos objNegAlum = new NegAlumnos();
        public Asistencia objEntAsis = new Asistencia();
        public NegAsistencias objNegAsis = new NegAsistencias();

        public Presentacion()
        {
            InitializeComponent();
            CrearDgvs();
            LlenarDgvAlum();
            LlenarDgvAsis();
        }

        private void CrearDgvs()
        {
            #region alumnos
            dgvAlumnos.ColumnCount = 2;
            dgvAlumnos.Columns[0].HeaderText = "DNI";
            dgvAlumnos.Columns[1].HeaderText = "Nombre";

            dgvAlumnos.Columns[0].Width = 100;
            dgvAlumnos.Columns[1].Width = 100;
            #endregion

            #region asistencia
            dgvAsistencia.ColumnCount = 3;
            dgvAsistencia.Columns[0].HeaderText = "DNI";
            dgvAsistencia.Columns[1].HeaderText = "Fecha";
            dgvAsistencia.Columns[2].HeaderText = "Asistencia";

            dgvAsistencia.Columns[0].Width = 100;
            dgvAsistencia.Columns[1].Width = 100;
            dgvAsistencia.Columns[2].Width = 100;
            #endregion
        }

        private void LlenarDgvAlum()
        {
            dgvAlumnos.Rows.Clear();

            DataSet ds = new DataSet();
            ds = objNegAlum.listadoAlumnos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvAlumnos.Rows.Add(dr[0].ToString(), dr[1].ToString());
                }
            }
            else
            {
                lblMensaje.Text = "No hay alumnos cargados en la lista";
            }
        }

        private void txt_a_objAlum()
        {
            objEntAlum.Dni = int.Parse(txtDni.Text);
            objEntAlum.Nombre = txtNombre.Text;
        }

        private void ds_a_txtAlum(DataSet ds)
        {
            txtDni.Text = ds.Tables[0].Rows[0]["dni"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtDni.Enabled = false;
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();

            objEntAlum.Dni = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);

            ds = objNegAlum.listadoAlumnos(objEntAlum.Dni.ToString());

            if (ds.Tables[0].Rows.Count > 0)
            {
                ds_a_txtAlum(ds);
                btnCargarAlumn.Visible = false;
                lblMensaje.Text = string.Empty;
            }
        }

        private void LimpiarDgvAlum()
        {
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            btnCargarAlumn.Visible = true;
        }

        private void btnCargarAlumn_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            string dniAlum = txtDni.Text;

            if (DniNoCaracteres() && CamposAlumnos())
            {
                if (objNegAlum.ExisteDniAlumno(dniAlum))
                {
                    MessageBox.Show(this, "Error", "El Alumno ya existe.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txt_a_objAlum();

                    nGrabados = objNegAlum.abmAlumnos("Alta", objEntAlum);

                    if (nGrabados == -1)
                    {
                        lblMensaje.Text = "No se pudieron cargar alumnos en el sistema.";
                    }
                    else
                    {
                        lblMensaje.Text = "Se cargo el alumno correctamente.";
                        LlenarDgvAlum();
                        LimpiarDgvAlum();
                    }
                }
            }
        }
        private void btnModificarAlumn_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            txt_a_objAlum();
            nResultado = objNegAlum.abmAlumnos("Modificar", objEntAlum);

            if (nResultado != -1)
            {
                MessageBox.Show("Aviso", "El alumno fue modificado con exito");
                LimpiarDgvAlum();
                LlenarDgvAlum();
                txtDni.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error", "Se produjo un error al intentar modificar el alumno.");
            }
        }
        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el alumno con DNI " + int.Parse(txtDni.Text) + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                int nGrabados = -1;
                Alumno NuevoAlumno = new Alumno(int.Parse(txtDni.Text), txtNombre.Text);

                nGrabados = objNegAlum.abmAlumnos("Borrar", NuevoAlumno);
                LlenarDgvAlum();
                LimpiarDgvAlum();

                txtDni.Enabled = true;

            }
        }
        private void LlenarDgvAsis()

        {
            dgvAsistencia.Rows.Clear();

            DataSet ds = new DataSet();

            string documentoAlu = "Todos"; // Obtener todos los registros de asistencia
            //DateTime fecha = DateTime.Now; // Utilizar la fecha actual por defecto

            ds = objNegAsis.listadoAsistencias(documentoAlu);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvAsistencia.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            else
            {
                lblMensaje.Text = "No hay asistencias en el sistema.";
            }
        }
        private void ds_a_txtAsis(DataSet ds)
        {
            txtDniAlumno.Text = ds.Tables[0].Rows[0]["dni"].ToString();
            dateTimePicker1.Value = (DateTime)ds.Tables[0].Rows[0]["fecha"];
            rdbPresente.Checked = (bool)ds.Tables[0].Rows[0]["presentismo"];

            txtDniAlumno.Enabled = false;
        }
        private void dgvAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string documentoAlu = dgvAsistencia.CurrentRow.Cells[0].Value.ToString();
                DateTime fecha = Convert.ToDateTime(dgvAsistencia.CurrentRow.Cells[1].Value);
                DataSet ds = objNegAsis.listadoAsistencias(documentoAlu);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds_a_txtAsis(ds);
                    btnCargarAsistencia.Visible = false;
                    lblMensaje.Text = string.Empty;
                }
            }
        }
        private void LimpiarDGVAsis()
        {
            txtDniAlumno.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
            rdbPresente.Checked = false;
            btnCargarAsistencia.Visible = true;
        }
        private void btnCargarAsistencia_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            string documentoAlu = txtDniAlumno.Text;


            if (objNegAsis.ExisteDniAlumno(documentoAlu))
            {
                // Formatear la fecha en el formato esperado por la base de datos
                string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

                // Crear el objeto Asistencia
                Asistencia NuevaAsistencia = new Asistencia(int.Parse(txtDniAlumno.Text), DateTime.Parse(fechaFormateada), rdbPresente.Checked);

                nGrabados = objNegAsis.abmAsistencias("Alta", NuevaAsistencia);

                if (nGrabados == -1)
                {
                    lblMensaje.Text = "No se pudo cargar Alumnos en el sistema.";
                }
                else
                {
                    lblMensaje.Text = "Se cargo el Alumno con éxito.";
                    LlenarDgvAsis();
                    LimpiarDGVAsis();
                }
            }
            else
            {
                MessageBox.Show("El DNI ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void btnModificarAsistencia_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            // Obtener la fecha del DateTimePicker en el formato esperado por la base de datos
            DateTime fecha = dateTimePicker1.Value.Date; // Obtiene solo la parte de la fecha, sin la parte de la hora
            Asistencia NuevaAsistencia = new Asistencia(int.Parse(txtDniAlumno.Text), fecha, rdbPresente.Checked);

            DateTime nuevaFecha = fecha;
            nResultado = objNegAsis.abmAsistencias("Modificar", NuevaAsistencia); //invocar a la capa de negocio

            if (nResultado != -1)
            {
                MessageBox.Show("La cuota fue Modificada con éxito", "Aviso");
                LimpiarDGVAsis();
                LlenarDgvAsis();

                txtDniAlumno.Enabled = true;
            }
            else
            {
                MessageBox.Show("Se produjo un error al intentar modificar la cuota", "Error");
            }
        }
        private void btnBorrarAsistencia_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value.Date; // Obtiene solo la parte de la fecha, sin la parte de la hora

            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la asistencia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int nGrabados = -1;
                Asistencia NuevaAsistencia = new Asistencia(int.Parse(txtDniAlumno.Text), fecha, rdbPresente.Checked);

                nGrabados = objNegAsis.abmAsistencias("Borrar", NuevaAsistencia);
                LlenarDgvAsis();
                LimpiarDGVAsis();

            }
        }
        private bool CamposAlumnos()
        {
            // Agrega todos los campos que deseas validar aquí.
            Control[] campos = { txtDni, txtNombre };

            foreach (Control campo in campos)
            {
                if (campo is TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        MessageBox.Show(this, "Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está vacío, la validación falla.
                    }
                }
                else if (campo is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show(this, "Por favor, seleccione una opción en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Al menos un campo está sin selección, la validación falla.
                    }
                }
            }

            return true; // Todos los campos están completos, la validación pasa.
        }
        private bool DniNoCaracteres()
        {
            TextBox[] campos = { txtDni };

            foreach (TextBox campo in campos)
            {
                if (!EsNumero(campo.Text))
                {
                    //MessageBox.Show(this, "Por favor, numeros en el monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epvAlumnos.SetError(txtDni, "No se aceptan caracteres en este campo.");
                    return false; // Devuelve false si al menos uno de los campos contiene caracteres no numéricos.
                }
            }

            return true; // Devuelve true si ambos campos solo contienen números.
        }
        private bool EsNumero(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!char.IsDigit(caracter))
                {
                    return false; // Devuelve false si encuentra un carácter no numérico.
                }
            }
            return true; // Devuelve true si todos los caracteres son numéricos.
        }
    }
}
