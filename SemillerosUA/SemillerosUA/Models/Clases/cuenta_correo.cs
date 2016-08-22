using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class cuenta_correo
    {
        public int ccrr_idcorreo { get; set; }
        public string ccrr_nombrecorreo { get; set; }
        public string ccrr_estado { get; set; }
        public int smlr_idsemillero { get; set; }

        Conexion conexion = new Conexion();

        public cuenta_correo() { }

        public cuenta_correo(int ccrr_idcorreo, string ccrr_nombrecorreo, string ccrr_estado, int smlr_idsemillero)
        {
            this.ccrr_idcorreo = ccrr_idcorreo;
            this.ccrr_nombrecorreo = ccrr_nombrecorreo;
            this.ccrr_estado = ccrr_estado;
            this.smlr_idsemillero = smlr_idsemillero;
        }

        public DataTable get_cuenta_correo()
        {
            return conexion.realizarConsulta("PR_SELECT_CUENTA_CORREO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(cuenta_correo obj)
        {
            Parametro[] param = new Parametro[4];
            param[0] = new Parametro("CCRR_IDCORREO", obj.ccrr_idcorreo);
            param[1] = new Parametro("CCRR_NOMBRECORREO", obj.ccrr_nombrecorreo);
            param[2] = new Parametro("CCRR_ESTADO", obj.ccrr_estado);
            param[3] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            return param;
        }

        public bool insert_cuenta_correo(cuenta_correo obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_CUENTA_CORREO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_cuenta_correo(cuenta_correo obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_CUENTA_CORREO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
