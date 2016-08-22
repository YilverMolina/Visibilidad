using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class actividad
    {
        public long actv_idactividad { get; set; }
        public string actv_descripcion { get; set; }
        public string actv_fechainicio { get; set; }
        public string actv_fechafin { get; set; }
        public string actv_lugar { get; set; }
        public string actv_estado { get; set; }
        public int tact_idtipoact { get; set; }
        public long evto_idevento { get; set; }
        public string actv_rutaadjunto { get; set; }

        Conexion conexion = new Conexion();

        public actividad() { }

        public actividad(long actv_idactividad, string actv_descripcion, string actv_fechainicio, string actv_fechafin, string actv_lugar, string actv_estado, int tact_idtipoact, long evto_idevento, string actv_rutaadjunto)
        {
            this.actv_idactividad = actv_idactividad;
            this.actv_descripcion = actv_descripcion;
            this.actv_fechainicio = actv_fechainicio;
            this.actv_fechafin = actv_fechafin;
            this.actv_lugar = actv_lugar;
            this.actv_estado = actv_estado;
            this.tact_idtipoact = tact_idtipoact;
            this.evto_idevento = evto_idevento;
            this.actv_rutaadjunto = actv_rutaadjunto;
        }

        public DataTable get_actividad()
        {
            return conexion.realizarConsulta("PR_SELECT_ACTIVIDAD ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(actividad obj)
        {
            Parametro[] param = new Parametro[9];
            param[0] = new Parametro("ACTV_IDACTIVIDAD", obj.actv_idactividad);
            param[1] = new Parametro("ACTV_DESCRIPCION", obj.actv_descripcion);
            param[2] = new Parametro("ACTV_FECHAINICIO", obj.actv_fechainicio);
            param[3] = new Parametro("ACTV_FECHAFIN", obj.actv_fechafin);
            param[4] = new Parametro("ACTV_LUGAR", obj.actv_lugar);
            param[5] = new Parametro("ACTV_ESTADO", obj.actv_estado);
            param[6] = new Parametro("TACT_IDTIPOACT", obj.tact_idtipoact);
            param[7] = new Parametro("EVTO_IDEVENTO", obj.evto_idevento);
            param[8] = new Parametro("ACTV_RUTAADJUNTO", obj.actv_rutaadjunto);
            return param;
        }

        public bool insert_actividad(actividad obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ACTIVIDAD", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_actividad(actividad obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ACTIVIDAD", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
