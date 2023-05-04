using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO10
{
    public class Alumno : Persona
    {
        int carnet;
        int numnotas;
        List<Curso> cursos;
        public int Carnet { get => carnet; set => carnet = value; }
        public int Numnotas { get => numnotas; set => numnotas = value; }
        public List<Curso> Cursos { get => cursos; set => cursos = value; }

        public Alumno()
        {
            Cursos = new List<Curso>();
        }
    }
}