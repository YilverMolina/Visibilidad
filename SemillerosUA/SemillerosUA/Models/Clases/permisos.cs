using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class permisos
    {
        public int prms_idpermiso { get; set; }
        public string prms_nombrepermiso { get; set; }
        public string prms_icono { get; set; }

        Conexion conexion = new Conexion();

        public permisos() { }

        public permisos(int prms_idpermiso, string prms_nombrepermiso, string prms_icono)
        {
            this.prms_idpermiso = prms_idpermiso;
            this.prms_nombrepermiso = prms_nombrepermiso;
            this.prms_icono = prms_icono;
        }

        public DataTable get_permisos()
        {
            return conexion.realizarConsulta("PR_SELECT_PERMISOS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(permisos obj)
        {
            Parametro[] param = new Parametro[3];
            param[0] = new Parametro("PRMS_IDPERMISO", obj.prms_idpermiso);
            param[1] = new Parametro("PRMS_NOMBREPERMISO", obj.prms_nombrepermiso);
            param[2] = new Parametro("PRMS_ICONO", obj.prms_icono);
            return param;
        }

        public bool insert_permisos(permisos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_PERMISOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_permisos(permisos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_PERMISOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
