using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class menu_usuario
    {
        public int rol_fk_idrol { get; set; }
        public int spms_fk_idsubpermiso { get; set; }
        public string musr_estado { get; set; }

        Conexion conexion = new Conexion();

        public menu_usuario() { }

        public menu_usuario(int rol_fk_idrol, int spms_fk_idsubpermiso, string musr_estado)
        {
            this.rol_fk_idrol = rol_fk_idrol;
            this.spms_fk_idsubpermiso = spms_fk_idsubpermiso;
            this.musr_estado = musr_estado;
        }

        public DataTable get_menu_usuario()
        {
            return conexion.realizarConsulta("PR_SELECT_MENU_USUARIO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(menu_usuario obj)
        {
            Parametro[] param = new Parametro[3];
            param[0] = new Parametro("ROL_FK_IDROL", obj.rol_fk_idrol);
            param[1] = new Parametro("SPMS_FK_IDSUBPERMISO", obj.spms_fk_idsubpermiso);
            param[2] = new Parametro("MUSR_ESTADO", obj.musr_estado);
            return param;
        }

        public bool insert_menu_usuario(menu_usuario obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_MENU_USUARIO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_menu_usuario(menu_usuario obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_MENU_USUARIO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
