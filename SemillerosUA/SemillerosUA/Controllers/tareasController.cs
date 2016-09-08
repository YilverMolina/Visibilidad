using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class tareasController : ApiController
    {
        tareas obj_tareas = new tareas();
        public tareas[] data()
        {
            DataTable dt = obj_tareas.get_tareas();
            DataRow row;
            tareas[] tareass = null;
            if (dt.Rows.Count > 0)
            {
                tareass = new tareas[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    tareass[i] = new tareas(Convert.ToInt64(row["trea_idtarea"].ToString()), row["trea_fechapublicacion"].ToString(), row["trea_fechainicio"].ToString(), row["trea_fechafin"].ToString(), row["trea_estado"].ToString(), Convert.ToInt32(row["smlr_idsemillero"].ToString()));
                }
            }
            return tareass;
        }
        public IHttpActionResult get_tareas()
        {
            return Json(obj_tareas.get_tareas());
        }
        public IHttpActionResult get_tareas(int id)
        {
            var obj = data().FirstOrDefault((o) => o.trea_idtarea == id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult insert_tareas(tareas obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_tareas.insert_tareas(obj))
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
        public IHttpActionResult update_tareas(tareas obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_tareas.update_tareas(obj))
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
