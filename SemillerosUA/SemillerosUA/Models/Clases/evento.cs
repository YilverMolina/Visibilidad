using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class evento
    {
        public long evto_idevento { get; set; }
        public string evto_nombre { get; set; }
        public string evto_descripcion { get; set; }
        public string evto_lugar { get; set; }
        public string evto_estado { get; set; }
        public string evto_realizado { get; set; }
        public int smlr_idsemillero { get; set; }
        public string evto_fechapublicacion { get; set; }
        public string evto_fechainicio { get; set; }
        public string evto_fechafin { get; set; }
        public string evto_mostrardesde { get; set; }
        public string evto_mostrarhasta { get; set; }
        public string evto_rutaadjunto { get; set; }

        Conexion conexion = new Conexion();

        public evento() { }

        public evento(long evto_idevento, string evto_nombre, string evto_descripcion, string evto_lugar, string evto_estado, string evto_realizado, int smlr_idsemillero, string evto_fechapublicacion, string evto_fechainicio, string evto_fechafin, string evto_mostrardesde, string evto_mostrarhasta, string evto_rutaadjunto)
        {
            this.evto_idevento = evto_idevento;
            this.evto_nombre = evto_nombre;
            this.evto_descripcion = evto_descripcion;
            this.evto_lugar = evto_lugar;
            this.evto_estado = evto_estado;
            this.evto_realizado = evto_realizado;
            this.smlr_idsemillero = smlr_idsemillero;
            this.evto_fechapublicacion = evto_fechapublicacion;
            this.evto_fechainicio = evto_fechainicio;
            this.evto_fechafin = evto_fechafin;
            this.evto_mostrardesde = evto_mostrardesde;
            this.evto_mostrarhasta = evto_mostrarhasta;
            this.evto_rutaadjunto = evto_rutaadjunto;
        }

        public DataTable get_evento()
        {
            return conexion.realizarConsulta("PR_SELECT_EVENTO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(evento obj)
        {
            Parametro[] param = new Parametro[13];
            param[0] = new Parametro("EVTO_IDEVENTO", obj.evto_idevento);
            param[1] = new Parametro("EVTO_NOMBRE", obj.evto_nombre);
            param[2] = new Parametro("EVTO_DESCRIPCION", obj.evto_descripcion);
            param[3] = new Parametro("EVTO_LUGAR", obj.evto_lugar);
            param[4] = new Parametro("EVTO_ESTADO", obj.evto_estado);
            param[5] = new Parametro("EVTO_REALIZADO", obj.evto_realizado);
            param[6] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            param[7] = new Parametro("EVTO_FECHAPUBLICACION", obj.evto_fechapublicacion);
            param[8] = new Parametro("EVTO_FECHAINICIO", obj.evto_fechainicio);
            param[9] = new Parametro("EVTO_FECHAFIN", obj.evto_fechafin);
            param[10] = new Parametro("EVTO_MOSTRARDESDE", obj.evto_mostrardesde);
            param[11] = new Parametro("EVTO_MOSTRARHASTA", obj.evto_mostrarhasta);
            param[12] = new Parametro("EVTO_RUTAADJUNTO", obj.evto_rutaadjunto);
            return param;
        }

        public bool insert_evento(evento obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_EVENTO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_evento(evento obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_EVENTO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
