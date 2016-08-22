using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class notificacion
    {
        public long notf_idnotificacion { get; set; }
        public string notf_fecha { get; set; }
        public string notf_recibida { get; set; }
        public long user_emisor { get; set; }
        public long user_destinatario { get; set; }
        public int tntf_idtiponotif { get; set; }

        Conexion conexion = new Conexion();

        public notificacion() { }

        public notificacion(long notf_idnotificacion, string notf_fecha, string notf_recibida, long user_emisor, long user_destinatario, int tntf_idtiponotif)
        {
            this.notf_idnotificacion = notf_idnotificacion;
            this.notf_fecha = notf_fecha;
            this.notf_recibida = notf_recibida;
            this.user_emisor = user_emisor;
            this.user_destinatario = user_destinatario;
            this.tntf_idtiponotif = tntf_idtiponotif;
        }

        public DataTable get_notificacion()
        {
            return conexion.realizarConsulta("PR_SELECT_NOTIFICACION ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(notificacion obj)
        {
            Parametro[] param = new Parametro[6];
            param[0] = new Parametro("NOTF_IDNOTIFICACION", obj.notf_idnotificacion);
            param[1] = new Parametro("NOTF_FECHA", obj.notf_fecha);
            param[2] = new Parametro("NOTF_RECIBIDA", obj.notf_recibida);
            param[3] = new Parametro("USER_EMISOR", obj.user_emisor);
            param[4] = new Parametro("USER_DESTINATARIO", obj.user_destinatario);
            param[5] = new Parametro("TNTF_IDTIPONOTIF", obj.tntf_idtiponotif);
            return param;
        }

        public bool insert_notificacion(notificacion obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_NOTIFICACION", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_notificacion(notificacion obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_NOTIFICACION", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
