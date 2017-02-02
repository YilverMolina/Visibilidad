using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class tipo_cursoController : ApiController
    {
        tipo_curso obj_tipo_curso = new tipo_curso();
        public DataRow[] alltipo_curso()
        {
            DataTable dt = obj_tipo_curso.get_tipo_curso();
            DataRow[] rows = null;
            if (dt.Rows.Count > 0)
            {
                rows = new DataRow[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    rows[i] = dt.Rows[i];
                }
            }
            return rows;
        }
        public tipo_curso[] data()
        {
            DataTable dt = obj_tipo_curso.get_tipo_curso();
            DataRow row;
            tipo_curso[] tipo_cursos = null;
            if (dt.Rows.Count > 0)
            {
                tipo_cursos = new tipo_curso[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    tipo_cursos[i] = new tipo_curso(Convert.ToInt32(row["tcrs_idtipocurso"].ToString()), row["tcrs_descripcion"].ToString());
                }
            }
            return tipo_cursos;
        }
        public IEnumerable<tipo_curso> get_tipo_curso()
        {
            return data();
        }
        public IHttpActionResult get_tipo_curso(int id)
        {
            var obj = data().FirstOrDefault((o) => o.tcrs_idtipocurso == id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public string insert_tipo_curso(tipo_curso obj)
        {
            if (obj_tipo_curso.insert_tipo_curso(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_tipo_curso(tipo_curso obj)
        {
            if (obj_tipo_curso.update_tipo_curso(obj))
            {
                return "U200";
            }
            else
            {
                return "U500";
            }
        }
    }
}
