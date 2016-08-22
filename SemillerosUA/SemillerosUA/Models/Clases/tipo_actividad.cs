using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class tipo_actividad
    {
        public int tact_idtipoactividad { get; set; }
        public string tact_nombre { get; set; }
        public string tact_descripcion { get; set; }
        public string tact_estado { get; set; }

        Conexion conexion = new Conexion();

        public tipo_actividad() { }

        public tipo_actividad(int tact_idtipoactividad, string tact_nombre, string tact_descripcion, string tact_estado)
        {
            this.tact_idtipoactividad = tact_idtipoactividad;
            this.tact_nombre = tact_nombre;
            this.tact_descripcion = tact_descripcion;
            this.tact_estado = tact_estado;
        }

        public DataTable get_tipo_actividad()
        {
            return conexion.realizarConsulta("PR_SELECT_TIPO_ACTIVIDAD ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(tipo_actividad obj)
        {
            Parametro[] param = new Parametro[4];
            param[0] = new Parametro("TACT_IDTIPOACTIVIDAD", obj.tact_idtipoactividad);
            param[1] = new Parametro("TACT_NOMBRE", obj.tact_nombre);
            param[2] = new Parametro("TACT_DESCRIPCION", obj.tact_descripcion);
            param[3] = new Parametro("TACT_ESTADO", obj.tact_estado);
            return param;
        }

        public bool insert_tipo_actividad(tipo_actividad obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_TIPO_ACTIVIDAD", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_tipo_actividad(tipo_actividad obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_TIPO_ACTIVIDAD", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
