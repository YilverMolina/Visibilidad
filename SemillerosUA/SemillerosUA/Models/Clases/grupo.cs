using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class grupo
    {
        public long grup_idgrupo { get; set; }
        public string grup_nombre { get; set; }
        public string grup_usuario { get; set; }
        public string grup_password { get; set; }
        public string grup_estado { get; set; }
        public string grup_fechainscripcion { get; set; }
        public long cptc_idcompetencia { get; set; }

        Conexion conexion = new Conexion();

        public grupo() { }

        public grupo(long grup_idgrupo, string grup_nombre, string grup_usuario, string grup_password, string grup_estado, string grup_fechainscripcion, long cptc_idcompetencia)
        {
            this.grup_idgrupo = grup_idgrupo;
            this.grup_nombre = grup_nombre;
            this.grup_usuario = grup_usuario;
            this.grup_password = grup_password;
            this.grup_estado = grup_estado;
            this.grup_fechainscripcion = grup_fechainscripcion;
            this.cptc_idcompetencia = cptc_idcompetencia;
        }

        public DataTable get_grupo()
        {
            return conexion.realizarConsulta("PR_SELECT_GRUPO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(grupo obj)
        {
            Parametro[] param = new Parametro[7];
            param[0] = new Parametro("GRUP_IDGRUPO", obj.grup_idgrupo);
            param[1] = new Parametro("GRUP_NOMBRE", obj.grup_nombre);
            param[2] = new Parametro("GRUP_USUARIO", obj.grup_usuario);
            param[3] = new Parametro("GRUP_PASSWORD", obj.grup_password);
            param[4] = new Parametro("GRUP_ESTADO", obj.grup_estado);
            param[5] = new Parametro("GRUP_FECHAINSCRIPCION", obj.grup_fechainscripcion);
            param[6] = new Parametro("CPTC_IDCOMPETENCIA", obj.cptc_idcompetencia);
            return param;
        }

        public bool insert_grupo(grupo obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_GRUPO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_grupo(grupo obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_GRUPO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
