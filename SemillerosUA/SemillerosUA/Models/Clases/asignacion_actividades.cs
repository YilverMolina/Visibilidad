using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class asignacion_actividades
    {
        public long user_responsable { get; set; }
        public long actv_idactividad { get; set; }
        public string aact_estado { get; set; }
        public string aact_fechaasignacion { get; set; }
        public string aact_invitado { get; set; }

        Conexion conexion = new Conexion();

        public asignacion_actividades() { }

        public asignacion_actividades(long user_responsable, long actv_idactividad, string aact_estado, string aact_fechaasignacion, string aact_invitado)
        {
            this.user_responsable = user_responsable;
            this.actv_idactividad = actv_idactividad;
            this.aact_estado = aact_estado;
            this.aact_fechaasignacion = aact_fechaasignacion;
            this.aact_invitado = aact_invitado;
        }

        public DataTable get_asignacion_actividades()
        {
            return conexion.realizarConsulta("PR_SELECT_ASIGNACION_ACTIVIDADES ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(asignacion_actividades obj)
        {
            Parametro[] param = new Parametro[5];
            param[0] = new Parametro("USER_RESPONSABLE", obj.user_responsable);
            param[1] = new Parametro("ACTV_IDACTIVIDAD", obj.actv_idactividad);
            param[2] = new Parametro("AACT_ESTADO", obj.aact_estado);
            param[3] = new Parametro("AACT_FECHAASIGNACION", obj.aact_fechaasignacion);
            param[4] = new Parametro("AACT_INVITADO", obj.aact_invitado);
            return param;
        }

        public bool insert_asignacion_actividades(asignacion_actividades obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ASIGNACION_ACTIVIDADES", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_asignacion_actividades(asignacion_actividades obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ASIGNACION_ACTIVIDADES", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
