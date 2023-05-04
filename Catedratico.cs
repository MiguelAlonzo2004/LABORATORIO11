using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO10
{
    public class Catedratico : Persona
    {
        string titulo;
        int colegiado;

        public string Titulo { get => titulo; set => titulo = value; }
        public int Colegiado { get => colegiado; set => colegiado = value; }
    }
}