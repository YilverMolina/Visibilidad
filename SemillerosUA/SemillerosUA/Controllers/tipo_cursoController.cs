using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class tipo_cursoController : ApiController
    {
        tipo_curso obj_tipo_curso = new tipo_curso();
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
        public IHttpActionResult get_tipo_curso()
        {
            return Json(obj_tipo_curso.get_tipo_curso());
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
        public IHttpActionResult insert_tipo_curso(tipo_curso obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_tipo_curso.insert_tipo_curso(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }
            }
        }
        public IHttpActionResult update_tipo_curso(tipo_curso obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_tipo_curso.update_tipo_curso(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }
            }
        }
    }
}
