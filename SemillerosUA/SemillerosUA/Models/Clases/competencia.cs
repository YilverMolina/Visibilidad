using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class competencia
    {
        public long cptc_idcompetencia { get; set; }
        public string cptc_nombre { get; set; }
        public string cptc_descripcion { get; set; }
        public string cptc_fechainicio { get; set; }
        public string cptc_limiteinscripciones { get; set; }
        public int cptc_participantes { get; set; }
        public int cptc_cupos { get; set; }
        public int smlr_idsemillero { get; set; }
        public string cptc_fechafin { get; set; }
        public string cptc_fechapublicacion { get; set; }
        public string cptc_mostrardesde { get; set; }
        public string cptc_mostrarhasta { get; set; }

        Conexion conexion = new Conexion();

        public competencia() { }

        public competencia(long cptc_idcompetencia, string cptc_nombre, string cptc_descripcion, string cptc_fechainicio, string cptc_limiteinscripciones, int cptc_participantes, int cptc_cupos, int smlr_idsemillero, string cptc_fechafin, string cptc_fechapublicacion, string cptc_mostrardesde, string cptc_mostrarhasta)
        {
            this.cptc_idcompetencia = cptc_idcompetencia;
            this.cptc_nombre = cptc_nombre;
            this.cptc_descripcion = cptc_descripcion;
            this.cptc_fechainicio = cptc_fechainicio;
            this.cptc_limiteinscripciones = cptc_limiteinscripciones;
            this.cptc_participantes = cptc_participantes;
            this.cptc_cupos = cptc_cupos;
            this.smlr_idsemillero = smlr_idsemillero;
            this.cptc_fechafin = cptc_fechafin;
            this.cptc_fechapublicacion = cptc_fechapublicacion;
            this.cptc_mostrardesde = cptc_mostrardesde;
            this.cptc_mostrarhasta = cptc_mostrarhasta;
        }

        public DataTable get_competencia()
        {
            return conexion.realizarConsulta("PR_SELECT_COMPETENCIA ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(competencia obj)
        {
            Parametro[] param = new Parametro[12];
            param[0] = new Parametro("CPTC_IDCOMPETENCIA", obj.cptc_idcompetencia);
            param[1] = new Parametro("CPTC_NOMBRE", obj.cptc_nombre);
            param[2] = new Parametro("CPTC_DESCRIPCION", obj.cptc_descripcion);
            param[3] = new Parametro("CPTC_FECHAINICIO", obj.cptc_fechainicio);
            param[4] = new Parametro("CPTC_LIMITEINSCRIPCIONES", obj.cptc_limiteinscripciones);
            param[5] = new Parametro("CPTC_PARTICIPANTES", obj.cptc_participantes);
            param[6] = new Parametro("CPTC_CUPOS", obj.cptc_cupos);
            param[7] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            param[8] = new Parametro("CPTC_FECHAFIN", obj.cptc_fechafin);
            param[9] = new Parametro("CPTC_FECHAPUBLICACION", obj.cptc_fechapublicacion);
            param[10] = new Parametro("CPTC_MOSTRARDESDE", obj.cptc_mostrardesde);
            param[11] = new Parametro("CPTC_MOSTRARHASTA", obj.cptc_mostrarhasta);
            return param;
        }

        public bool insert_competencia(competencia obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_COMPETENCIA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_competencia(competencia obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_COMPETENCIA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
