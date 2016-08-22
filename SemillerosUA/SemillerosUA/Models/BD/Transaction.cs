using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemillerosUA.Models.BD
{
    public class Transaction
    {
        public string Procedure { get; set; }
        public Parametro[] Parameters { get; set; }

        public Transaction(string Procedure, Parametro[] Parameters)
        {
            this.Procedure = Procedure;
            this.Parameters = Parameters;
        }
    }
}