using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class rol_semillero
    {
        public int rsml_idrolsemillero { get; set; }
        public string rsml_permisos { get; set; }
        public string rsml_estado { get; set; }
        public long user_idusuario { get; set; }
        public int smlr_idsemillero { get; set; }

        Conexion conexion = new Conexion();

        public rol_semillero() { }

        public rol_semillero(int rsml_idrolsemillero, string rsml_permisos, string rsml_estado, long user_idusuario, int smlr_idsemillero)
        {
            this.rsml_idrolsemillero = rsml_idrolsemillero;
            this.rsml_permisos = rsml_permisos;
            this.rsml_estado = rsml_estado;
            this.user_idusuario = user_idusuario;
            this.smlr_idsemillero = smlr_idsemillero;
        }

        public DataTable get_rol_semillero()
        {
            return conexion.realizarConsulta("PR_SELECT_ROL_SEMILLERO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(rol_semillero obj)
        {
            Parametro[] param = new Parametro[5];
            param[0] = new Parametro("RSML_IDROLSEMILLERO", obj.rsml_idrolsemillero);
            param[1] = new Parametro("RSML_PERMISOS", obj.rsml_permisos);
            param[2] = new Parametro("RSML_ESTADO", obj.rsml_estado);
            param[3] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[4] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            return param;
        }

        public bool insert_rol_semillero(rol_semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ROL_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_rol_semillero(rol_semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ROL_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
