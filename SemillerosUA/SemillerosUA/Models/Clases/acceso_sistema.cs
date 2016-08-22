using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class acceso_sistema
    {
        public long astm_idacceso { get; set; }
        public string astm_fecha { get; set; }
        public string astm_ip { get; set; }
        public long user_idusuario { get; set; }

        Conexion conexion = new Conexion();

        public acceso_sistema() { }

        public acceso_sistema(long astm_idacceso, string astm_fecha, string astm_ip, long user_idusuario)
        {
            this.astm_idacceso = astm_idacceso;
            this.astm_fecha = astm_fecha;
            this.astm_ip = astm_ip;
            this.user_idusuario = user_idusuario;
        }

        public DataTable get_acceso_sistema()
        {
            return conexion.realizarConsulta("PR_SELECT_ACCESO_SISTEMA ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(acceso_sistema obj)
        {
            Parametro[] param = new Parametro[4];
            param[0] = new Parametro("ASTM_IDACCESO", obj.astm_idacceso);
            param[1] = new Parametro("ASTM_FECHA", obj.astm_fecha);
            param[2] = new Parametro("ASTM_IP", obj.astm_ip);
            param[3] = new Parametro("USER_IDUSUARIO", obj.user_idusuario);
            return param;
        }

        public bool insert_acceso_sistema(acceso_sistema obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_ACCESO_SISTEMA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_acceso_sistema(acceso_sistema obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_ACCESO_SISTEMA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
