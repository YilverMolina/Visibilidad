using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class repositorio
    {
        public int repo_idrepositorio { get; set; }
        public string repo_nombre { get; set; }
        public string repo_descripcion { get; set; }
        public string repo_ruta { get; set; }
        public string repo_estado { get; set; }
        public int smlr_idsemillero { get; set; }

        Conexion conexion = new Conexion();

        public repositorio() { }

        public repositorio(int repo_idrepositorio, string repo_nombre, string repo_descripcion, string repo_ruta, string repo_estado, int smlr_idsemillero)
        {
            this.repo_idrepositorio = repo_idrepositorio;
            this.repo_nombre = repo_nombre;
            this.repo_descripcion = repo_descripcion;
            this.repo_ruta = repo_ruta;
            this.repo_estado = repo_estado;
            this.smlr_idsemillero = smlr_idsemillero;
        }

        public DataTable get_repositorio()
        {
            return conexion.realizarConsulta("PR_SELECT_REPOSITORIO ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(repositorio obj)
        {
            Parametro[] param = new Parametro[6];
            param[0] = new Parametro("REPO_IDREPOSITORIO", obj.repo_idrepositorio);
            param[1] = new Parametro("REPO_NOMBRE", obj.repo_nombre);
            param[2] = new Parametro("REPO_DESCRIPCION", obj.repo_descripcion);
            param[3] = new Parametro("REPO_RUTA", obj.repo_ruta);
            param[4] = new Parametro("REPO_ESTADO", obj.repo_estado);
            param[5] = new Parametro("SMLR_IDSEMILLERO", obj.smlr_idsemillero);
            return param;
        }

        public bool insert_repositorio(repositorio obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_REPOSITORIO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_repositorio(repositorio obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_REPOSITORIO", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
