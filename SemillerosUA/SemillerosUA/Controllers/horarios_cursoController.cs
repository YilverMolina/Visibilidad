using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class horarios_cursoController : ApiController
    {
        horarios_curso obj_horarios_curso = new horarios_curso();
        public DataRow[] allhorarios_curso()
        {
            DataTable dt = obj_horarios_curso.get_horarios_curso();
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
        public horarios_curso[] data()
        {
            DataTable dt = obj_horarios_curso.get_horarios_curso();
            DataRow row;
            horarios_curso[] horarios_cursos = null;
            if (dt.Rows.Count > 0)
            {
                horarios_cursos = new horarios_curso[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    horarios_cursos[i] = new horarios_curso(Convert.ToInt64(row["hcrs_idhorario"].ToString()), row["hcrs_dia"].ToString(), row["hcrs_horainicio"].ToString(), row["hcrs_horafin"].ToString(), row["hcrs_estado"].ToString(), Convert.ToInt32(row["curs_idcurso"].ToString()));
                }
            }
            return horarios_cursos;
        }
        public IEnumerable<horarios_curso> get_horarios_curso()
        {
            return data();
        }
        public IHttpActionResult get_horarios_curso(int id)
        {
            var obj = data().FirstOrDefault((o) => o.hcrs_idhorario == id);
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
        public string insert_horarios_curso(horarios_curso obj)
        {
            if (obj_horarios_curso.insert_horarios_curso(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_horarios_curso(horarios_curso obj)
        {
            if (obj_horarios_curso.update_horarios_curso(obj))
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
