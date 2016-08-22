using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class horarios_curso
    {
        public long hcrs_idhorario { get; set; }
        public string hcrs_dia { get; set; }
        public string hcrs_horainicio { get; set; }
        public string hcrs_horafin { get; set; }
        public string hcrs_estado { get; set; }
        public int curs_idcurso { get; set; }

        Conexion conexion = new Conexion();

        public horarios_curso() { }

        public horarios_curso(long hcrs_idhorario, string hcrs_dia, string hcrs_horainicio, string hcrs_horafin, string hcrs_estado, int curs_idcurso)
        {
            this.hcrs_idhorario = hcrs_idhorario;
            this.hcrs_dia = hcrs_dia;
            this.hcrs_horainicio = hcrs_horainicio;
            this.hcrs_horafin = hcrs_horafin;
            this.hcrs_estado = hcrs_estado;
            this.curs_idcurso = curs_idcurso;
        }

        public DataTable get_horarios_curso()
        {
            return conexion.realizarConsulta("PR_SELECT_HORARIOS_CURSO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(horarios_curso obj)
        {
            Parametro[] param = new Parametro[6];
            param[0] = new Parametro("HCRS_IDHORARIO", obj.hcrs_idhorario);
            param[1] = new Parametro("HCRS_DIA", obj.hcrs_dia);
            param[2] = new Parametro("HCRS_HORAINICIO", obj.hcrs_horainicio);
            param[3] = new Parametro("HCRS_HORAFIN", obj.hcrs_horafin);
            param[4] = new Parametro("HCRS_ESTADO", obj.hcrs_estado);
            param[5] = new Parametro("CURS_IDCURSO", obj.curs_idcurso);
            return param;
        }

        public bool insert_horarios_curso(horarios_curso obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_HORARIOS_CURSO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_horarios_curso(horarios_curso obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_HORARIOS_CURSO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
