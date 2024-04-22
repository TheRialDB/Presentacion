using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades
{
    public class Alumno
    {
        #region atributos

        private long dni;
        private string nombre;
        private char activo;

        #endregion

        #region constructor

        public Alumno()
        {
            
        }

        public Alumno(int doc, string name)
        {
            dni = doc;
            nombre = name;
        }

        public Alumno(int doc, string name, char act)
        {
            dni = doc;
            nombre = name;
            activo = act;
        }
        #endregion

        #region propiedades

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public char Activo
        {
            get { return activo; } 
            set { activo = value; }
        }
        #endregion
    }
}
