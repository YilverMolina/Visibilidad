using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class correos_enviados
    {
        public int crnv_idcorreoenviado { get; set; }
        public string crnv_tipo { get; set; }
        public string crnv_descripcion { get; set; }
        public string crnv_estadoenvio { get; set; }
        public string crnv_fechaenvio { get; set; }
        public int smlr_idsemillero { get; set; }
        public long user_destinatario { get; set; }

        Conexion conexion = new Conexion();

        public correos_enviados() { }

        public correos_enviados(int crnv_idcorreoenviado, string crnv_tipo, string crnv_descripcion, string crnv_estadoenvio, string crnv_fechaenvio, int smlr_idsemillero, long user_destinatario)
        {
            this.crnv_idcorreoenviado = crnv_idcorreoenviado;
            this.crnv_tipo = crnv_tipo;
            this.crnv_descripcion = crnv_descripcion;
            this.crnv_estadoenvio = crnv_estadoenvio;
            this.crnv_fechaenvio = crnv_fechaenvio;
            this.smlr_idsemillero = smlr_idsemillero;
            this.user_destinatario = user_destinatario;
        }

        public DataTable get_correos_enviados()
        {
            return conexion.realizarConsulta("PR_SELECT_CORREOS_ENVIADOS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(correos_enviados obj)
        {
            Parametro[] param = new Parametro[7];
            param[0] = new Parametro("CRNV_IDCORREOENVIADO", obj.crnv_idcorreoenviado);
            param[1] = new Parametro("CRNV_TIPO", obj.crnv_tipo);
            param[2] = new Parametro("CRNV_DESCRIPCION", obj.crnv_descripcion);
            param[3] = new Parametro("CRNV_ESTADOENVIO", obj.crnv_estadoenvio);
            param[4] = new Parametro("CRNV_FECHAENVIO", obj.crnv_fechaenvio);
            param[5] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            param[6] = new Parametro("USER_DESTINATARIO", obj.user_destinatario);
            return param;
        }

        public bool insert_correos_enviados(correos_enviados obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_CORREOS_ENVIADOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_correos_enviados(correos_enviados obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_CORREOS_ENVIADOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
