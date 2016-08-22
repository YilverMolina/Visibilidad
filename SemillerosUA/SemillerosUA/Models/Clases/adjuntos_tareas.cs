using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class adjuntos_tareas
    {
        public long adtr_idadjunto { get; set; }
        public string adtr_fecha { get; set; }
        public string adtr_estado { get; set; }
        public string adtr_rutaarchivo { get; set; }
        public long trea_idtarea { get; set; }

        Conexion conexion = new Conexion();

        public adjuntos_tareas() { }

        public adjuntos_tareas(long adtr_idadjunto, string adtr_fecha, string adtr_estado, string adtr_rutaarchivo, long trea_idtarea)
        {
            this.adtr_idadjunto = adtr_idadjunto;
            this.adtr_fecha = adtr_fecha;
            this.adtr_estado = adtr_estado;
            this.adtr_rutaarchivo = adtr_rutaarchivo;
            this.trea_idtarea = trea_idtarea;
        }

        public DataTable get_adjuntos_tareas()
        {
            return conexion.realizarConsulta("PR_SELECT_ADJUNTOS_TAREAS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(adjuntos_tareas obj)
        {
            Parametro[] param = new Parametro[5];
            param[0] = new Parametro("ADTR_IDADJUNTO", obj.adtr_idadjunto);
            param[1] = new Parametro("ADTR_FECHA", obj.adtr_fecha);
            param[2] = new Parametro("ADTR_ESTADO", obj.adtr_estado);
            param[3] = new Parametro("ADTR_RUTAARCHIVO", obj.adtr_rutaarchivo);
            param[4] = new Parametro("TREA_IDTAREA", obj.trea_idtarea);
            return param;
        }

        public bool insert_adjuntos_tareas(adjuntos_tareas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ADJUNTOS_TAREAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_adjuntos_tareas(adjuntos_tareas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ADJUNTOS_TAREAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
