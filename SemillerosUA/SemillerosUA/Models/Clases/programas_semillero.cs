using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class programas_semillero
    {
        public int prog_idprograma { get; set; }
        public int smlr_idsemillero { get; set; }
        public string prsm_estado { get; set; }

        Conexion conexion = new Conexion();

        public programas_semillero() { }

        public programas_semillero(int prog_idprograma, int smlr_idsemillero, string prsm_estado)
        {
            this.prog_idprograma = prog_idprograma;
            this.smlr_idsemillero = smlr_idsemillero;
            this.prsm_estado = prsm_estado;
        }

        public DataTable get_programas_semillero()
        {
            return conexion.realizarConsulta("PR_SELECT_PROGRAMAS_SEMILLERO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(programas_semillero obj)
        {
            Parametro[] param = new Parametro[3];
            param[0] = new Parametro("PROG_IDPROGRAMA", obj.prog_idprograma);
            param[1] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            param[2] = new Parametro("PRSM_ESTADO", obj.prsm_estado);
            return param;
        }

        public bool insert_programas_semillero(programas_semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_PROGRAMAS_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_programas_semillero(programas_semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_PROGRAMAS_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
