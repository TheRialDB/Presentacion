using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Asistencia
    {
        #region Atributos

        private long dni;
        private bool presentismo;
        private DateTime fecha;
        #endregion

        #region Contructor
        public Asistencia()
        {
            
        }
        public Asistencia(long dniAlu)
        {
                dni = dniAlu;
        }
        public Asistencia (long dniAlu, DateTime fech)
        {
           
            dni = dniAlu;
            fecha = fech;
        }
        public Asistencia(long dniAlu, DateTime fech, bool pres)
        {
           
            dni = dniAlu;
            fecha = fech;
            presentismo = pres;
        }
        #endregion

        #region Propiedades
        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public bool Presentismo
        {
            get { return presentismo; }
            set { presentismo = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        #endregion
    }
}
