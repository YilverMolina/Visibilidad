using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class documento
    {
        public int docu_iddocumento { get; set; }
        public string docu_nombre { get; set; }
        public string docu_ruta { get; set; }
        public string docu_fecha { get; set; }
        public string docu_estado { get; set; }
        public long user_idusuario { get; set; }
        public int repo_idrepositorio { get; set; }

        Conexion conexion = new Conexion();

        public documento() { }

        public documento(int docu_iddocumento, string docu_nombre, string docu_ruta, string docu_fecha, string docu_estado, long user_idusuario, int repo_idrepositorio)
        {
            this.docu_iddocumento = docu_iddocumento;
            this.docu_nombre = docu_nombre;
            this.docu_ruta = docu_ruta;
            this.docu_fecha = docu_fecha;
            this.docu_estado = docu_estado;
            this.user_idusuario = user_idusuario;
            this.repo_idrepositorio = repo_idrepositorio;
        }

        public DataTable get_documento()
        {
            return conexion.realizarConsulta("PR_SELECT_DOCUMENTO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(documento obj)
        {
            Parametro[] param = new Parametro[7];
            param[0] = new Parametro("DOCU_IDDOCUMENTO", obj.docu_iddocumento);
            param[1] = new Parametro("DOCU_NOMBRE", obj.docu_nombre);
            param[2] = new Parametro("DOCU_RUTA", obj.docu_ruta);
            param[3] = new Parametro("DOCU_FECHA", obj.docu_fecha);
            param[4] = new Parametro("DOCU_ESTADO", obj.docu_estado);
            param[5] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[6] = new Parametro("REPO_IDREPOSITORIO", obj.repo_idrepositorio);
            return param;
        }

        public bool insert_documento(documento obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_DOCUMENTO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_documento(documento obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_DOCUMENTO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
