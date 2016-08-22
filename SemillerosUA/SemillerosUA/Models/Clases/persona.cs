using System;
using System.Collections.Generic;
using System.Data;
using SemillerosUA.Models.BD;

namespace SemillerosUA.Models.Clases
{
    public class persona
    {
        public long idpersona { get; set; }
        public long ndocumento { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public long telefono { get; set; }
        public string correo { get; set; }
        public int fk_idprograma { get; set; }
        public int semestre { get; set; }

        Conexion conexion = new Conexion();

        public persona() { }

        public persona(long idpersona, long ndocumento, string nombres, string apellidos, long telefono, string correo, int fk_idprograma, int semestre)
        {
            this.idpersona = idpersona;
            this.ndocumento = ndocumento;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.correo = correo;
            this.fk_idprograma = fk_idprograma;
            this.semestre = semestre;
        }

        public DataTable get_persona()
        {
            return conexion.realizarConsulta("PR_SELECT_PERSONA ", "CR_RESULT ", null);
        }

        public Parametro[] getParameters(persona obj)
        {
            Parametro[] param = new Parametro[8];
            param[0] = new Parametro("IDPERSONA", obj.idpersona);
            param[1] = new Parametro("NDOCUMENTO", obj.ndocumento);
            param[2] = new Parametro("NOMBRES", obj.nombres);
            param[3] = new Parametro("APELLIDOS", obj.apellidos);
            param[4] = new Parametro("TELEFONO", obj.telefono);
            param[5] = new Parametro("CORREO", obj.correo);
            param[6] = new Parametro("FK_IDPROGRAMA", obj.fk_idprograma);
            param[7] = new Parametro("SEMESTRE", obj.semestre);
            return param;
        }

        public bool insert_persona(persona obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_INSERT_PERSONA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

        public bool update_persona(persona obj)
        {
            Transaction[] list = new Transaction[1];
            list[0] = new Transaction("PR_UPDATE_PERSONA", getParameters(obj));
            return conexion.realizarTransaccion(list);
        }

    }
}
