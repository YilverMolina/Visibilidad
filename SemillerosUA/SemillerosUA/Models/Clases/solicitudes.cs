using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class solicitudes
    {
        public int slct_idsolicitud { get; set; }
        public int curs_idcurso { get; set; }
        public long user_estudiante { get; set; }
        public long user_admin { get; set; }
        public string slct_fechasolicitud { get; set; }
        public string slct_fecharespuesta { get; set; }
        public string slct_estado { get; set; }
        public string slct_comentario { get; set; }

        Conexion conexion = new Conexion();

        public solicitudes() { }

        public solicitudes(int slct_idsolicitud, int curs_idcurso, long user_estudiante, long user_admin, string slct_fechasolicitud, string slct_fecharespuesta, string slct_estado, string slct_comentario)
        {
            this.slct_idsolicitud = slct_idsolicitud;
            this.curs_idcurso = curs_idcurso;
            this.user_estudiante = user_estudiante;
            this.user_admin = user_admin;
            this.slct_fechasolicitud = slct_fechasolicitud;
            this.slct_fecharespuesta = slct_fecharespuesta;
            this.slct_estado = slct_estado;
            this.slct_comentario = slct_comentario;
        }

        public DataTable get_solicitudes()
        {
            return conexion.realizarConsulta("PR_SELECT_SOLICITUDES ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(solicitudes obj)
        {
            Parametro[] param = new Parametro[8];
            param[0] = new Parametro("SLCT_IDSOLICITUD", obj.slct_idsolicitud);
            param[1] = new Parametro("CURS_IDCURSO", obj.curs_idcurso);
            param[2] = new Parametro("USER_ESTUDIANTE", obj.user_estudiante);
            param[3] = new Parametro("USER_ADMIN", obj.user_admin);
            param[4] = new Parametro("SLCT_FECHASOLICITUD", obj.slct_fechasolicitud);
            param[5] = new Parametro("SLCT_FECHARESPUESTA", obj.slct_fecharespuesta);
            param[6] = new Parametro("SLCT_ESTADO", obj.slct_estado);
            param[7] = new Parametro("SLCT_COMENTARIO", obj.slct_comentario);
            return param;
        }

        public bool insert_solicitudes(solicitudes obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_SOLICITUDES", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_solicitudes(solicitudes obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_SOLICITUDES", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
