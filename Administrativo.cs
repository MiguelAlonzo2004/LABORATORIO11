using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO10
{
    public class Administrativo : Persona
    {
        string profesion;
        int igss;

        public string Profesion { get => profesion; set => profesion = value; }
        public int Igss { get => igss; set => igss = value; }
    }
}