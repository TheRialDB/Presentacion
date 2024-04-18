using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DatosAlumnos : DatosConexionBD
    {
        public int abmAlumnos(string accion, Alumno objAlumno)
        {
            int resultado = -1;  // controlar que se realize la operacion con exito
            string orden = string.Empty; // para guardar consulta sql

            if (accion == "Alta") // para agregar un producto nuevo
            {
                //orden = $"insert into alumnos (Dni, Nombre) values ('{objAlumno.Dni}', '{objAlumno.Nombre}');";
                orden = $"insert into alumnos (Dni, Nombre) values ('{objAlumno.Dni}', '{objAlumno.Nombre}');";
            }

            if (accion == "Modificar") // para modificar un existente
            {
                orden = $"update alumnos set Dni='{objAlumno.Dni}', Nombre='{objAlumno.Nombre}';";
            }

            if (accion == "Borrar") // para borrar un existente
            {
                orden = $"delete from alumnos where dni =  '{objAlumno.Dni}';";
            }


            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar, borrar o modificar algun alumno.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoAlumnos(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from alumnos where Dni = " + int.Parse(cual) + ";";
            else
                orden = "select * from alumnos;";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar alumnos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public bool ExisteCodigoAlumno(string codigoAlumno)
        {
            string consulta = "SELECT COUNT(*) FROM alumnos WHERE dni = @dni";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@dni", codigoAlumno);

            try
            {
                Abrirconexion();
                int count = (int)cmd.ExecuteScalar(); // Obtenemos el resultado del conteo de filas
                return count > 0; // Devolvemos true si el código de alumno existe en la tabla
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia del código de alumno.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

        }
        public bool ExisteDniAlumno(string dniAlum)
        {
            string consulta = "SELECT COUNT(*) FROM alumnos WHERE dni = @dniAlum";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@dniAlum", dniAlum);

            try
            {
                Abrirconexion();
                int count = (int)cmd.ExecuteScalar(); // Obtenemos el resultado del conteo de filas
                return count > 0; // Devolvemos true si el código de socio existe en la tabla
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia del DNI del Alumno.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
        }

    }
}
