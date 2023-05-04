using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO10
{
    public class Universidad
    {
        string nombreuniversidad;
        List<Alumno> alumnos;

        public string Nombreuniversidad { get => nombreuniversidad; set => nombreuniversidad = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }

        public Universidad()
        {
            Alumnos = new List<Alumno>();
        }
    }
}