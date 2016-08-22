using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class tareas
    {
        public long trea_idtarea { get; set; }
        public string trea_fechapublicacion { get; set; }
        public string trea_fechainicio { get; set; }
        public string trea_fechafin { get; set; }
        public string trea_estado { get; set; }
        public int smlr_idsemillero { get; set; }

        Conexion conexion = new Conexion();

        public tareas() { }

        public tareas(long trea_idtarea, string trea_fechapublicacion, string trea_fechainicio, string trea_fechafin, string trea_estado, int smlr_idsemillero)
        {
            this.trea_idtarea = trea_idtarea;
            this.trea_fechapublicacion = trea_fechapublicacion;
            this.trea_fechainicio = trea_fechainicio;
            this.trea_fechafin = trea_fechafin;
            this.trea_estado = trea_estado;
            this.smlr_idsemillero = smlr_idsemillero;
        }

        public DataTable get_tareas()
        {
            return conexion.realizarConsulta("PR_SELECT_TAREAS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(tareas obj)
        {
            Parametro[] param = new Parametro[6];
            param[0] = new Parametro("TREA_IDTAREA", obj.trea_idtarea);
            param[1] = new Parametro("TREA_FECHAPUBLICACION", obj.trea_fechapublicacion);
            param[2] = new Parametro("TREA_FECHAINICIO", obj.trea_fechainicio);
            param[3] = new Parametro("TREA_FECHAFIN", obj.trea_fechafin);
            param[4] = new Parametro("TREA_ESTADO", obj.trea_estado);
            param[5] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            return param;
        }

        public bool insert_tareas(tareas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_TAREAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_tareas(tareas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_TAREAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
