using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class grupo_investigacion
    {
        public int griv_idgrupoinv { get; set; }
        public string griv_fechacreacion { get; set; }
        public string griv_nombre { get; set; }
        public string griv_descripcion { get; set; }
        public long user_director { get; set; }

        Conexion conexion = new Conexion();

        public grupo_investigacion() { }

        public grupo_investigacion(int griv_idgrupoinv, string griv_fechacreacion, string griv_nombre, string griv_descripcion, long user_director)
        {
            this.griv_idgrupoinv = griv_idgrupoinv;
            this.griv_fechacreacion = griv_fechacreacion;
            this.griv_nombre = griv_nombre;
            this.griv_descripcion = griv_descripcion;
            this.user_director = user_director;
        }

        public DataTable get_grupo_investigacion()
        {
            return conexion.realizarConsulta("PR_SELECT_GRUPO_INVESTIGACION ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(grupo_investigacion obj)
        {
            Parametro[] param = new Parametro[5];
            param[0] = new Parametro("GRIV_IDGRUPOINV", obj.griv_idgrupoinv);
            param[1] = new Parametro("GRIV_FECHACREACION", obj.griv_fechacreacion);
            param[2] = new Parametro("GRIV_NOMBRE", obj.griv_nombre);
            param[3] = new Parametro("GRIV_DESCRIPCION", obj.griv_descripcion);
            param[4] = new Parametro("USER_DIRECTOR", obj.user_director);
            return param;
        }

        public bool insert_grupo_investigacion(grupo_investigacion obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_GRUPO_INVESTIGACION", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_grupo_investigacion(grupo_investigacion obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_GRUPO_INVESTIGACION", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
