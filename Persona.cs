using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO10
{
    public class Persona
    {
        string nombre;
        string apellido;
        string direccion;
        DateTime fecha;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}