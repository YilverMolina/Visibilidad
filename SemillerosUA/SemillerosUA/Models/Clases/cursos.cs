using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class cursos
    {
        public int curs_idcurso { get; set; }
        public string curs_nombre { get; set; }
        public string curs_fechacreacion { get; set; }
        public int curs_cupos { get; set; }
        public string curs_fechainicio { get; set; }
        public string curs_fechafin { get; set; }
        public string curs_estado { get; set; }
        public string curs_fechapublicacion { get; set; }
        public string curs_mostrardesde { get; set; }
        public string curs_mostrarhasta { get; set; }
        public int tcrs_idtipocurso { get; set; }
        public int smlr_idsemillero { get; set; }

        Conexion conexion = new Conexion();

        public cursos() { }

        public cursos(int curs_idcurso, string curs_nombre, string curs_fechacreacion, int curs_cupos, string curs_fechainicio, string curs_fechafin, string curs_estado, string curs_fechapublicacion, string curs_mostrardesde, string curs_mostrarhasta, int tcrs_idtipocurso, int smlr_idsemillero)
        {
            this.curs_idcurso = curs_idcurso;
            this.curs_nombre = curs_nombre;
            this.curs_fechacreacion = curs_fechacreacion;
            this.curs_cupos = curs_cupos;
            this.curs_fechainicio = curs_fechainicio;
            this.curs_fechafin = curs_fechafin;
            this.curs_estado = curs_estado;
            this.curs_fechapublicacion = curs_fechapublicacion;
            this.curs_mostrardesde = curs_mostrardesde;
            this.curs_mostrarhasta = curs_mostrarhasta;
            this.tcrs_idtipocurso = tcrs_idtipocurso;
            this.smlr_idsemillero = smlr_idsemillero;
        }

        //SELECT
        public DataTable get_cursos()
        {
            return conexion.realizarConsulta("PR_SELECT_CURSOS ", "CR_RESULT ", null);
        }

        public DataTable get_cursos_por_usuario()
        {
            return conexion.realizarConsulta("PR_SELECT_CURSOS ", "CR_RESULT ", null);
        }

        public DataTable get_cursos_activos()
        {
            return conexion.realizarConsulta("PR_SELECT_CURSOS ", "CR_RESULT ", null);
        }

        //TRANSACTIONS
        public Parametro[] getParameters(cursos obj)
        {
            Parametro[] param = new Parametro[12];
            param[0] = new Parametro("CURS_IDCURSO", obj.curs_idcurso);
            param[1] = new Parametro("CURS_NOMBRE", obj.curs_nombre);
            param[2] = new Parametro("CURS_FECHACREACION", obj.curs_fechacreacion);
            param[3] = new Parametro("CURS_CUPOS", obj.curs_cupos);
            param[4] = new Parametro("CURS_FECHAINICIO", obj.curs_fechainicio);
            param[5] = new Parametro("CURS_FECHAFIN", obj.curs_fechafin);
            param[6] = new Parametro("CURS_ESTADO", obj.curs_estado);
            param[7] = new Parametro("CURS_FECHAPUBLICACION", obj.curs_fechapublicacion);
            param[8] = new Parametro("CURS_MOSTRARDESDE", obj.curs_mostrardesde);
            param[9] = new Parametro("CURS_MOSTRARHASTA", obj.curs_mostrarhasta);
            param[10] = new Parametro("TCRS_IDTIPOCURSO", obj.tcrs_idtipocurso);
            param[11] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            return param;
        }

        public bool insert_cursos(cursos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_CURSOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_cursos(cursos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_CURSOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }
    }
}