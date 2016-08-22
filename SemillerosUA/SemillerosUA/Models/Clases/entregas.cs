using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class entregas
    {
        public long entr_identrega { get; set; }
        public string entr_descripcion { get; set; }
        public string entr_rutaarchivo { get; set; }
        public string entr_calificado { get; set; }
        public string entr_respuesta { get; set; }
        public string entr_valoracion { get; set; }
        public long user_idusuario { get; set; }
        public long astr_idasignacion { get; set; }

        Conexion conexion = new Conexion();

        public entregas() { }

        public entregas(long entr_identrega, string entr_descripcion, string entr_rutaarchivo, string entr_calificado, string entr_respuesta, string entr_valoracion, long user_idusuario, long astr_idasignacion)
        {
            this.entr_identrega = entr_identrega;
            this.entr_descripcion = entr_descripcion;
            this.entr_rutaarchivo = entr_rutaarchivo;
            this.entr_calificado = entr_calificado;
            this.entr_respuesta = entr_respuesta;
            this.entr_valoracion = entr_valoracion;
            this.user_idusuario = user_idusuario;
            this.astr_idasignacion = astr_idasignacion;
        }

        public DataTable get_entregas()
        {
            return conexion.realizarConsulta("PR_SELECT_ENTREGAS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(entregas obj)
        {
            Parametro[] param = new Parametro[8];
            param[0] = new Parametro("ENTR_IDENTREGA", obj.entr_identrega);
            param[1] = new Parametro("ENTR_DESCRIPCION", obj.entr_descripcion);
            param[2] = new Parametro("ENTR_RUTAARCHIVO", obj.entr_rutaarchivo);
            param[3] = new Parametro("ENTR_CALIFICADO", obj.entr_calificado);
            param[4] = new Parametro("ENTR_RESPUESTA", obj.entr_respuesta);
            param[5] = new Parametro("ENTR_VALORACION", obj.entr_valoracion);
            param[6] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[7] = new Parametro("ASTR_IDASIGNACION", obj.astr_idasignacion);
            return param;
        }

        public bool insert_entregas(entregas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ENTREGAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_entregas(entregas obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ENTREGAS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
