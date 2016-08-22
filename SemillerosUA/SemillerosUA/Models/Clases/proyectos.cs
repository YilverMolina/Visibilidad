using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class proyectos
    {
        public int proy_idproyecto { get; set; }
        public string proy_nombre { get; set; }
        public string proy_descripcion { get; set; }
        public string proy_estado { get; set; }
        public int smlr_idsemillero { get; set; }

        Conexion conexion = new Conexion();

        public proyectos() { }

        public proyectos(int proy_idproyecto, string proy_nombre, string proy_descripcion, string proy_estado, int smlr_idsemillero)
        {
            this.proy_idproyecto = proy_idproyecto;
            this.proy_nombre = proy_nombre;
            this.proy_descripcion = proy_descripcion;
            this.proy_estado = proy_estado;
            this.smlr_idsemillero = smlr_idsemillero;
        }

        public DataTable get_proyectos()
        {
            return conexion.realizarConsulta("PR_SELECT_PROYECTOS ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(proyectos obj)
        {
            Parametro[] param = new Parametro[5];
            param[0] = new Parametro("PROY_IDPROYECTO", obj.proy_idproyecto);
            param[1] = new Parametro("PROY_NOMBRE", obj.proy_nombre);
            param[2] = new Parametro("PROY_DESCRIPCION", obj.proy_descripcion);
            param[3] = new Parametro("PROY_ESTADO", obj.proy_estado);
            param[4] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            return param;
        }

        public bool insert_proyectos(proyectos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_PROYECTOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_proyectos(proyectos obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_PROYECTOS", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
