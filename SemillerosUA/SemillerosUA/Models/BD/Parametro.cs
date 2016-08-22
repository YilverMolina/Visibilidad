using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemillerosUA.Models.BD
{
    public class Parametro
    {

        public string Nombre { get; set; }
        public Object Value { get; set; }

        public Parametro(string Nombre, Object Value)
        {
            this.Nombre = Nombre;
            this.Value = Value;
        }
    }
}