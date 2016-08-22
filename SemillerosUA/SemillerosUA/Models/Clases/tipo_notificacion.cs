using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class tipo_notificacion
    {
        public int tntf_idtiponotif { get; set; }
        public string tntf_nombre { get; set; }
        public string tntf_descripcion { get; set; }

        Conexion conexion = new Conexion();

        public tipo_notificacion() { }

        public tipo_notificacion(int tntf_idtiponotif, string tntf_nombre, string tntf_descripcion)
        {
            this.tntf_idtiponotif = tntf_idtiponotif;
            this.tntf_nombre = tntf_nombre;
            this.tntf_descripcion = tntf_descripcion;
        }

        public DataTable get_tipo_notificacion()
        {
            return conexion.realizarConsulta("PR_SELECT_TIPO_NOTIFICACION ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(tipo_notificacion obj)
        {
            Parametro[] param = new Parametro[3];
            param[0] = new Parametro("TNTF_IDTIPONOTIF", obj.tntf_idtiponotif);
            param[1] = new Parametro("TNTF_NOMBRE", obj.tntf_nombre);
            param[2] = new Parametro("TNTF_DESCRIPCION", obj.tntf_descripcion);
            return param;
        }

        public bool insert_tipo_notificacion(tipo_notificacion obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_TIPO_NOTIFICACION", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_tipo_notificacion(tipo_notificacion obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_TIPO_NOTIFICACION", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
