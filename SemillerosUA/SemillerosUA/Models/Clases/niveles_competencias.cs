using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class niveles_competencias
    {
        public long cptc_idcompetencia { get; set; }
        public int nvel_idnivel { get; set; }
        public string nvcp_estado { get; set; }

        Conexion conexion = new Conexion();

        public niveles_competencias() { }

        public niveles_competencias(long cptc_idcompetencia, int nvel_idnivel, string nvcp_estado)
        {
            this.cptc_idcompetencia = cptc_idcompetencia;
            this.nvel_idnivel = nvel_idnivel;
            this.nvcp_estado = nvcp_estado;
        }

        public DataTable get_niveles_competencias()
        {
            return conexion.realizarConsulta("PR_SELECT_NIVELES_COMPETENCIAS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(niveles_competencias obj)
        {
            Parametro[] param = new Parametro[3];
            param[0] = new Parametro("CPTC_IDCOMPETENCIA", obj.cptc_idcompetencia);
            param[1] = new Parametro("NVEL_IDNIVEL", obj.nvel_idnivel);
            param[2] = new Parametro("NVCP_ESTADO", obj.nvcp_estado);
            return param;
        }

        public bool insert_niveles_competencias(niveles_competencias obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_NIVELES_COMPETENCIAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_niveles_competencias(niveles_competencias obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_NIVELES_COMPETENCIAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
