using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class usuario
    {
        public long user_idusuario { get; set; }
        public string user_nusuario { get; set; }
        public string user_contrasenia { get; set; }
        public int rol_fk_idrol { get; set; }
        public long pers_fk_idpersona { get; set; }
        public string user_fecharegistro { get; set; }
        public string user_estado { get; set; }

        Conexion conexion = new Conexion();

        public usuario() { }

        public usuario(long user_idusuario, string user_nusuario, string user_contrasenia, int rol_fk_idrol, long pers_fk_idpersona, string user_fecharegistro, string user_estado)
        {
            this.user_idusuario = user_idusuario;
            this.user_nusuario = user_nusuario;
            this.user_contrasenia = user_contrasenia;
            this.rol_fk_idrol = rol_fk_idrol;
            this.pers_fk_idpersona = pers_fk_idpersona;
            this.user_fecharegistro = user_fecharegistro;
            this.user_estado = user_estado;
        }

        public DataTable get_usuario()
        {
            return conexion.realizarConsulta("PR_SELECT_USUARIO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(usuario obj)
        {
            Parametro[] param = new Parametro[7];
            param[0] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            param[1] = new Parametro("USER_NUSUARIO", obj.user_nusuario);
            param[2] = new Parametro("USER_CONTRASENIA", obj.user_contrasenia);
            param[3] = new Parametro("ROL_FK_IDROL", obj.rol_fk_idrol);
            param[4] = new Parametro("PERS_FK_IDPERSONA", obj.pers_fk_idpersona);
            param[5] = new Parametro("USER_FECHAREGISTRO", obj.user_fecharegistro);
            param[6] = new Parametro("USER_ESTADO", obj.user_estado);
            return param;
        }

        public bool insert_usuario(usuario obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_USUARIO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_usuario(usuario obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_USUARIO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
