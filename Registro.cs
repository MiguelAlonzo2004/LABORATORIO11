using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO10
{
    public class Registro
    {
        Alumno alumno;
        List<Curso> cursos;

        public Alumno Alumno { get => alumno; set => alumno = value; }
        public List<Curso> Cursos { get => cursos; set => cursos = value; }
        public Registro()
        {
            cursos = new List<Curso>();
            alumno = new Alumno();
        }
    }
}