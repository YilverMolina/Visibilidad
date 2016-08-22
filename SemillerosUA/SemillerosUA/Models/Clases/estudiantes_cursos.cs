using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class estudiantes_cursos
    {
        public long escr_idestcursos { get; set; }
        public long user_idusuario { get; set; }
        public int curs_idcurso { get; set; }
        public string escr_fecharegistro { get; set; }
        public string escr_fechaaprobado { get; set; }
        public string escr_fechacancelado { get; set; }
        public string escr_estado { get; set; }

        Conexion conexion = new Conexion();

        public estudiantes_cursos() { }

        public estudiantes_cursos(long escr_idestcursos, long user_idusuario, int curs_idcurso, string escr_fecharegistro, string escr_fechaaprobado, string escr_fechacancelado, string escr_estado)
        {
            this.escr_idestcursos = escr_idestcursos;
            this.user_idusuario = user_idusuario;
            this.curs_idcurso = curs_idcurso;
            this.escr_fecharegistro = escr_fecharegistro;
            this.escr_fechaaprobado = escr_fechaaprobado;
            this.escr_fechacancelado = escr_fechacancelado;
            this.escr_estado = escr_estado;
        }

        public DataTable get_estudiantes_cursos()
        {
            return conexion.realizarConsulta("PR_SELECT_ESTUDIANTES_CURSOS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(estudiantes_cursos obj)
        {
            Parametro[] param = new Parametro[7];
            param[0] = new Parametro("ESCR_IDESTCURSOS", obj.escr_idestcursos);
            param[1] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[2] = new Parametro("CURS_IDCURSO", obj.curs_idcurso);
            param[3] = new Parametro("ESCR_FECHAREGISTRO", obj.escr_fecharegistro);
            param[4] = new Parametro("ESCR_FECHAAPROBADO", obj.escr_fechaaprobado);
            param[5] = new Parametro("ESCR_FECHACANCELADO", obj.escr_fechacancelado);
            param[6] = new Parametro("ESCR_ESTADO", obj.escr_estado);
            return param;
        }

        public bool insert_estudiantes_cursos(estudiantes_cursos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ESTUDIANTES_CURSOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_estudiantes_cursos(estudiantes_cursos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ESTUDIANTES_CURSOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
