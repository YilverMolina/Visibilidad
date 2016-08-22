using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class lider_semillero
    {
        public long user_fk_idusuario { get; set; }
        public int smlr_fk_idsemillero { get; set; }
        public string lsml_fecha { get; set; }
        public string lsml_estado { get; set; }

        Conexion conexion = new Conexion();

        public lider_semillero() { }

        public lider_semillero(long user_fk_idusuario, int smlr_fk_idsemillero, string lsml_fecha, string lsml_estado)
        {
            this.user_fk_idusuario = user_fk_idusuario;
            this.smlr_fk_idsemillero = smlr_fk_idsemillero;
            this.lsml_fecha = lsml_fecha;
            this.lsml_estado = lsml_estado;
        }

        public DataTable get_lider_semillero()
        {
            return conexion.realizarConsulta("PR_SELECT_LIDER_SEMILLERO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(lider_semillero obj)
        {
            Parametro[] param = new Parametro[4];
            param[0] = new Parametro("USER_FK_IDUSUARIO", obj.user_fk_idusuario);
            param[1] = new Parametro("SMLR_FK_IDSEMILLERO", obj.smlr_fk_idsemillero);
            param[2] = new Parametro("LSML_FECHA", obj.lsml_fecha);
            param[3] = new Parametro("LSML_ESTADO", obj.lsml_estado);
            return param;
        }

        public bool insert_lider_semillero(lider_semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_LIDER_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_lider_semillero(lider_semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_LIDER_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
