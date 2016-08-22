using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class semillero
    {
        public int smlr_idsemillero { get; set; }
        public string smlr_nombre { get; set; }
        public string smlr_descripcion { get; set; }
        public string smlr_rutalogo { get; set; }
        public string smlr_mision { get; set; }
        public string smlr_vision { get; set; }
        public string smlr_ruta { get; set; }
        public int griv_idgrupoinv { get; set; }

        Conexion conexion = new Conexion();

        public semillero() { }

        public semillero(int smlr_idsemillero, string smlr_nombre, string smlr_descripcion, string smlr_rutalogo, string smlr_mision, string smlr_vision, string smlr_ruta, int griv_idgrupoinv)
        {
            this.smlr_idsemillero = smlr_idsemillero;
            this.smlr_nombre = smlr_nombre;
            this.smlr_descripcion = smlr_descripcion;
            this.smlr_rutalogo = smlr_rutalogo;
            this.smlr_mision = smlr_mision;
            this.smlr_vision = smlr_vision;
            this.smlr_ruta = smlr_ruta;
            this.griv_idgrupoinv = griv_idgrupoinv;
        }

        public DataTable get_semillero()
        {
            return conexion.realizarConsulta("PR_SELECT_SEMILLERO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(semillero obj)
        {
            Parametro[] param = new Parametro[8];
            param[0] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            param[1] = new Parametro("SMLR_NOMBRE", obj.smlr_nombre);
            param[2] = new Parametro("SMLR_DESCRIPCION", obj.smlr_descripcion);
            param[3] = new Parametro("SMLR_RUTALOGO", obj.smlr_rutalogo);
            param[4] = new Parametro("SMLR_MISION", obj.smlr_mision);
            param[5] = new Parametro("SMLR_VISION", obj.smlr_vision);
            param[6] = new Parametro("SMLR_RUTA", obj.smlr_ruta);
            param[7] = new Parametro("GRIV_IDGRUPOINV", obj.griv_idgrupoinv);
            return param;
        }

        public bool insert_semillero(semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_semillero(semillero obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_SEMILLERO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
