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
    public class DatosAsistencias : DatosConexionBD
    {
        public int abmAsistencias(string accion, Asistencia objAsistencia)
        {
            #region abm vieja
            //int resultado = -1;  // controlar que se realize la operacion con exito
            //string orden = string.Empty; // para guardar consulta sql

            //if (accion == "Alta") // para agregar un producto nuevo
            //{
            //    //orden = $"insert into asistencias (Dni, Presentismo, Fecha) values ('{objAsistencia.Dni}', '{objAsistencia.Presentismo}', '{objAsistencia.Fecha}');";
            //    orden = $"insert into asistencias (Dni, Presentismo, Fecha) values ('{objAsistencia.Dni}', '{objAsistencia.Presentismo}', '{objAsistencia.Fecha}');";
            //}

            //if (accion == "Modificar") // para modificar un existente
            //{
            //    orden = $"update asistencias set Dni='{objAsistencia.Dni}', Presentismo='{objAsistencia.Presentismo}', Fecha='{objAsistencia.Fecha}';";
            //}

            //if (accion == "Borrar") // para borrar un existente
            //{
            //    orden = $"delete from asistencias where Dni =  '{objAsistencia.Dni}';";
            //}


            //SqlCommand cmd = new SqlCommand(orden, conexion);
            //try
            //{
            //    Abrirconexion();
            //    resultado = cmd.ExecuteNonQuery();
            //}
            //catch (Exception e)
            //{
            //    throw new Exception($"Errror al tratar de guardar, borrar o modificar alguna asistencia.", e);
            //}
            //finally
            //{
            //    Cerrarconexion();
            //    cmd.Dispose();
            //}
            //return resultado;
            #endregion

            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO asistencias ( dni, fecha,presentismo) VALUES ( @Dni, @Fecha, @Presentismo)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE asistencias SET fecha = @Fecha, presentismo = @Presentismo ";
            }
            else if (accion == "Borrar")
            {
                orden = "DELETE FROM asistencias WHERE dni = @Dni and fecha = @Fecha";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            
            cmd.Parameters.AddWithValue("@Dni", objAsistencia.Dni);
            cmd.Parameters.AddWithValue("@Fecha", objAsistencia.Fecha);
            cmd.Parameters.AddWithValue("@Presentismo", objAsistencia.Presentismo);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar las asistencias de los alumnos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }

        public DataSet listadoAsistencias(string dni)
        {
            string orden = string.Empty;

            if (dni != "Todos")
                orden = $"select * from asistencias where dni = {int.Parse(dni)}";
            else
                orden = "select * from asistencias;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            //cmd.Parameters.AddWithValue("@fecha", fecha);

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
                throw new Exception("Error al listar asistencias", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        public bool ExisteDniAlumno(string documentoAlu)
        {
            string consulta = "SELECT COUNT(*) FROM alumnos WHERE dni = @documentoAlu";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@documentoAlu", documentoAlu);

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
        public bool ExisteAsistencia(string asistenciaAlu)
        {
            string consulta = "SELECT COUNT(*) FROM asistencias WHERE Dni = @Dni";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@Dni", asistenciaAlu);

            try
            {
                Abrirconexion();
                int count = (int)cmd.ExecuteScalar(); // Obtenemos el resultado del conteo de filas
                return count > 0; // Devolvemos true si el código de socio existe en la tabla
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia del la asistencia del Alumno.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
        }
        public bool ExisteAsistenciaFecha(int documentoAlu, DateTime fecha)
        {
            string consulta = "SELECT COUNT(*) FROM Asistencias WHERE Dni = @Dni AND Fecha = @Fecha";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            cmd.Parameters.AddWithValue("@Dni", documentoAlu);
            cmd.Parameters.AddWithValue("@Fecha", fecha);

            try
            {
                Abrirconexion();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Devuelve true si ya existe una asistencia para el alumno en la fecha especificada
            }
            catch (Exception e)
            {
                throw new Exception("Error al verificar la existencia de la asistencia del alumno.", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
        }
    }
}
