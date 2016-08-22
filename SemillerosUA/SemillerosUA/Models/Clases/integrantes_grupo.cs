using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class integrantes_grupo
    {
        public long igrp_idintegrantes { get; set; }
        public long grup_idgrupo { get; set; }
        public long user_idusuario { get; set; }
        public string igrp_estado { get; set; }

        Conexion conexion = new Conexion();

        public integrantes_grupo() { }

        public integrantes_grupo(long igrp_idintegrantes, long grup_idgrupo, long user_idusuario, string igrp_estado)
        {
            this.igrp_idintegrantes = igrp_idintegrantes;
            this.grup_idgrupo = grup_idgrupo;
            this.user_idusuario = user_idusuario;
            this.igrp_estado = igrp_estado;
        }

        public DataTable get_integrantes_grupo()
        {
            return conexion.realizarConsulta("PR_SELECT_INTEGRANTES_GRUPO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(integrantes_grupo obj)
        {
            Parametro[] param = new Parametro[4];
            param[0] = new Parametro("IGRP_IDINTEGRANTES", obj.igrp_idintegrantes);
            param[1] = new Parametro("GRUP_IDGRUPO", obj.grup_idgrupo);
            param[2] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[3] = new Parametro("IGRP_ESTADO", obj.igrp_estado);
            return param;
        }

        public bool insert_integrantes_grupo(integrantes_grupo obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_INTEGRANTES_GRUPO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_integrantes_grupo(integrantes_grupo obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_INTEGRANTES_GRUPO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
