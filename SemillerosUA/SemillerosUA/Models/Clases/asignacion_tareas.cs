using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class asignacion_tareas
    {
        public long astr_idasignacion { get; set; }
        public string astr_estado { get; set; }
        public string astr_fecha { get; set; }
        public long user_idusuario { get; set; }
        public int dtar_iddetalletarea { get; set; }

        Conexion conexion = new Conexion();

        public asignacion_tareas() { }

        public asignacion_tareas(long astr_idasignacion, string astr_estado, string astr_fecha, long user_idusuario, int dtar_iddetalletarea)
        {
            this.astr_idasignacion = astr_idasignacion;
            this.astr_estado = astr_estado;
            this.astr_fecha = astr_fecha;
            this.user_idusuario = user_idusuario;
            this.dtar_iddetalletarea = dtar_iddetalletarea;
        }

        public DataTable get_asignacion_tareas()
        {
            return conexion.realizarConsulta("PR_SELECT_ASIGNACION_TAREAS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(asignacion_tareas obj)
        {
            Parametro[] param = new Parametro[5];
            param[0] = new Parametro("ASTR_IDASIGNACION", obj.astr_idasignacion);
            param[1] = new Parametro("ASTR_ESTADO", obj.astr_estado);
            param[2] = new Parametro("ASTR_FECHA", obj.astr_fecha);
            param[3] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[4] = new Parametro("DTAR_IDDETALLETAREA", obj.dtar_iddetalletarea);
            return param;
        }

        public bool insert_asignacion_tareas(asignacion_tareas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ASIGNACION_TAREAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_asignacion_tareas(asignacion_tareas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ASIGNACION_TAREAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
