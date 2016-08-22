using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class detalle_tareaController : ApiController
    {
        detalle_tarea obj_detalle_tarea = new detalle_tarea();
        public DataRow[] alldetalle_tarea()
        {
            DataTable dt = obj_detalle_tarea.get_detalle_tarea();
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
        public detalle_tarea[] data()
        {
            DataTable dt = obj_detalle_tarea.get_detalle_tarea();
            DataRow row;
            detalle_tarea[] detalle_tareas = null;
            if (dt.Rows.Count > 0)
            {
                detalle_tareas = new detalle_tarea[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    detalle_tareas[i] = new detalle_tarea(Convert.ToInt32(row["dtar_iddetalletarea"].ToString()), Convert.ToInt64(row["trea_idtarea"].ToString()), row["dtar_comentario"].ToString());
                }
            }
            return detalle_tareas;
        }
        public IEnumerable<detalle_tarea> get_detalle_tarea()
        {
            return data();
        }
        public IHttpActionResult get_detalle_tarea(int id)
        {
            var obj = data().FirstOrDefault((o) => o.dtar_iddetalletarea == id);
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
        public string insert_detalle_tarea(detalle_tarea obj)
        {
            if (obj_detalle_tarea.insert_detalle_tarea(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_detalle_tarea(detalle_tarea obj)
        {
            if (obj_detalle_tarea.update_detalle_tarea(obj))
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
