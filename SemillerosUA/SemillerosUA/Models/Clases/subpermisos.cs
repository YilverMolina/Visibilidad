using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class subpermisos
    {
        public int spms_idsubpermiso { get; set; }
        public string spms_nombresubpermiso { get; set; }
        public string spms_icono { get; set; }
        public string spms_url { get; set; }
        public int prms_fk_idpermiso { get; set; }

        Conexion conexion = new Conexion();

        public subpermisos() { }

        public subpermisos(int spms_idsubpermiso, string spms_nombresubpermiso, string spms_icono, string spms_url, int prms_fk_idpermiso)
        {
            this.spms_idsubpermiso = spms_idsubpermiso;
            this.spms_nombresubpermiso = spms_nombresubpermiso;
            this.spms_icono = spms_icono;
            this.spms_url = spms_url;
            this.prms_fk_idpermiso = prms_fk_idpermiso;
        }

        public DataTable get_subpermisos()
        {
            return conexion.realizarConsulta("PR_SELECT_SUBPERMISOS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(subpermisos obj)
        {
            Parametro[] param = new Parametro[5];
            param[0] = new Parametro("SPMS_IDSUBPERMISO", obj.spms_idsubpermiso);
            param[1] = new Parametro("SPMS_NOMBRESUBPERMISO", obj.spms_nombresubpermiso);
            param[2] = new Parametro("SPMS_ICONO", obj.spms_icono);
            param[3] = new Parametro("SPMS_URL", obj.spms_url);
            param[4] = new Parametro("PRMS_FK_IDPERMISO", obj.prms_fk_idpermiso);
            return param;
        }

        public bool insert_subpermisos(subpermisos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_SUBPERMISOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_subpermisos(subpermisos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_SUBPERMISOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
