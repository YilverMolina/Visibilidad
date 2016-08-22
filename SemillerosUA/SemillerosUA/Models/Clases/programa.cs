using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class programa
    {
        public int prog_idprograma { get; set; }
        public string prog_nombre { get; set; }

        Conexion conexion = new Conexion();

        public programa() { }

        public programa(int prog_idprograma, string prog_nombre)
        {
            this.prog_idprograma = prog_idprograma;
            this.prog_nombre = prog_nombre;
        }

        public DataTable get_programa()
        {
            return conexion.realizarConsulta("PR_SELECT_PROGRAMA ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(programa obj)
        {
            Parametro[] param = new Parametro[2];
            param[0] = new Parametro("PROG_IDPROGRAMA", obj.prog_idprograma);
            param[1] = new Parametro("PROG_NOMBRE", obj.prog_nombre);
            return param;
        }

        public bool insert_programa(programa obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_PROGRAMA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_programa(programa obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_PROGRAMA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
