using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class tipo_noticia
    {
        public int tntc_idnoticia { get; set; }
        public string tntc_nombre { get; set; }
        public string tntc_descripcion { get; set; }
        public string tntc_estado { get; set; }

        Conexion conexion = new Conexion();

        public tipo_noticia() { }

        public tipo_noticia(int tntc_idnoticia, string tntc_nombre, string tntc_descripcion, string tntc_estado)
        {
            this.tntc_idnoticia = tntc_idnoticia;
            this.tntc_nombre = tntc_nombre;
            this.tntc_descripcion = tntc_descripcion;
            this.tntc_estado = tntc_estado;
        }

        public DataTable get_tipo_noticia()
        {
            return conexion.realizarConsulta("PR_SELECT_TIPO_NOTICIA ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(tipo_noticia obj)
        {
            Parametro[] param = new Parametro[4];
            param[0] = new Parametro("TNTC_IDNOTICIA", obj.tntc_idnoticia);
            param[1] = new Parametro("TNTC_NOMBRE", obj.tntc_nombre);
            param[2] = new Parametro("TNTC_DESCRIPCION", obj.tntc_descripcion);
            param[3] = new Parametro("TNTC_ESTADO", obj.tntc_estado);
            return param;
        }

        public bool insert_tipo_noticia(tipo_noticia obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_TIPO_NOTICIA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_tipo_noticia(tipo_noticia obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_TIPO_NOTICIA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
