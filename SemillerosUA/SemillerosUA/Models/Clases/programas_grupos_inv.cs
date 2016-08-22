using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class programas_grupos_inv
    {
        public int griv_idgrupoinv { get; set; }
        public int prog_idprograma { get; set; }
        public string prgr_estado { get; set; }

        Conexion conexion = new Conexion();

        public programas_grupos_inv() { }

        public programas_grupos_inv(int griv_idgrupoinv, int prog_idprograma, string prgr_estado)
        {
            this.griv_idgrupoinv = griv_idgrupoinv;
            this.prog_idprograma = prog_idprograma;
            this.prgr_estado = prgr_estado;
        }

        public DataTable get_programas_grupos_inv()
        {
            return conexion.realizarConsulta("PR_SELECT_PROGRAMAS_GRUPOS_INV ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(programas_grupos_inv obj)
        {
            Parametro[] param = new Parametro[3];
            param[0] = new Parametro("GRIV_IDGRUPOINV", obj.griv_idgrupoinv);
            param[1] = new Parametro("PROG_IDPROGRAMA", obj.prog_idprograma);
            param[2] = new Parametro("PRGR_ESTADO", obj.prgr_estado);
            return param;
        }

        public bool insert_programas_grupos_inv(programas_grupos_inv obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_PROGRAMAS_GRUPOS_INV", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_programas_grupos_inv(programas_grupos_inv obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_PROGRAMAS_GRUPOS_INV", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
