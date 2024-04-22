using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegAsistencias
    {
        DatosAsistencias objDatosAsist = new DatosAsistencias();

        public int abmAsistencias(string accion, Asistencia objAsistencias)
        {
            return objDatosAsist.abmAsistencias(accion, objAsistencias);
        }

        public DataSet listadoAsistencias(string cual)
        {
            return objDatosAsist.listadoAsistencias(cual);

        }

        public bool ExisteDniAlumno(string documentoAlu)
        {
            return objDatosAsist.ExisteDniAlumno(documentoAlu);
        }

        public bool ExisteAsistencia(string asistenciaAlu)
        {
            return objDatosAsist.ExisteAsistencia(asistenciaAlu);
        }

        public bool ExisteAsistenciaFecha(int asistenciaAlu, DateTime fecha)
        {
            return objDatosAsist.ExisteAsistenciaFecha(asistenciaAlu, fecha);
        }
    }
}
