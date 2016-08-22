using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class tipo_curso
    {
        public int tcrs_idtipocurso { get; set; }
        public string tcrs_descripcion { get; set; }

        Conexion conexion = new Conexion();

        public tipo_curso() { }

        public tipo_curso(int tcrs_idtipocurso, string tcrs_descripcion)
        {
            this.tcrs_idtipocurso = tcrs_idtipocurso;
            this.tcrs_descripcion = tcrs_descripcion;
        }

        public DataTable get_tipo_curso()
        {
            return conexion.realizarConsulta("PR_SELECT_TIPO_CURSO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(tipo_curso obj)
        {
            Parametro[] param = new Parametro[2];
            param[0] = new Parametro("TCRS_IDTIPOCURSO", obj.tcrs_idtipocurso);
            param[1] = new Parametro("TCRS_DESCRIPCION", obj.tcrs_descripcion);
            return param;
        }

        public bool insert_tipo_curso(tipo_curso obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_TIPO_CURSO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_tipo_curso(tipo_curso obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_TIPO_CURSO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
