using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class rol
    {
        public int rol_idrol { get; set; }
        public string rol_nombrerol { get; set; }

        Conexion conexion = new Conexion();

        public rol() { }

        public rol(int rol_idrol, string rol_nombrerol)
        {
            this.rol_idrol = rol_idrol;
            this.rol_nombrerol = rol_nombrerol;
        }

        public DataTable get_rol()
        {
            return conexion.realizarConsulta("PR_SELECT_ROL ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(rol obj)
        {
            Parametro[] param = new Parametro[2];
            param[0] = new Parametro("ROL_IDROL", obj.rol_idrol);
            param[1] = new Parametro("ROL_NOMBREROL", obj.rol_nombrerol);
            return param;
        }

        public bool insert_rol(rol obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ROL", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_rol(rol obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ROL", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
