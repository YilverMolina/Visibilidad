using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class nivel
    {
        public int nvel_idnivel { get; set; }
        public string nvel_nombre { get; set; }
        public string nvel_descripcion { get; set; }
        public string nvel_estado { get; set; }

        Conexion conexion = new Conexion();

        public nivel() { }

        public nivel(int nvel_idnivel, string nvel_nombre, string nvel_descripcion, string nvel_estado)
        {
            this.nvel_idnivel = nvel_idnivel;
            this.nvel_nombre = nvel_nombre;
            this.nvel_descripcion = nvel_descripcion;
            this.nvel_estado = nvel_estado;
        }

        public DataTable get_nivel()
        {
            return conexion.realizarConsulta("PR_SELECT_NIVEL ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(nivel obj)
        {
            Parametro[] param = new Parametro[4];
            param[0] = new Parametro("NVEL_IDNIVEL", obj.nvel_idnivel);
            param[1] = new Parametro("NVEL_NOMBRE", obj.nvel_nombre);
            param[2] = new Parametro("NVEL_DESCRIPCION", obj.nvel_descripcion);
            param[3] = new Parametro("NVEL_ESTADO", obj.nvel_estado);
            return param;
        }

        public bool insert_nivel(nivel obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_NIVEL", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_nivel(nivel obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_NIVEL", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
