using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class detalle_tarea
    {
        public int dtar_iddetalletarea { get; set; }
        public long trea_idtarea { get; set; }
        public string dtar_comentario { get; set; }

        Conexion conexion = new Conexion();

        public detalle_tarea() { }

        public detalle_tarea(int dtar_iddetalletarea, long trea_idtarea, string dtar_comentario)
        {
            this.dtar_iddetalletarea = dtar_iddetalletarea;
            this.trea_idtarea = trea_idtarea;
            this.dtar_comentario = dtar_comentario;
        }

        public DataTable get_detalle_tarea()
        {
            return conexion.realizarConsulta("PR_SELECT_DETALLE_TAREA ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(detalle_tarea obj)
        {
            Parametro[] param = new Parametro[3];
            param[0] = new Parametro("DTAR_IDDETALLETAREA", obj.dtar_iddetalletarea);
            param[1] = new Parametro("TREA_IDTAREA", obj.trea_idtarea);
            param[2] = new Parametro("DTAR_COMENTARIO", obj.dtar_comentario);
            return param;
        }

        public bool insert_detalle_tarea(detalle_tarea obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_DETALLE_TAREA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_detalle_tarea(detalle_tarea obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_DETALLE_TAREA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
