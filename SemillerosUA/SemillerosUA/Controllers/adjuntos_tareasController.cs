using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class adjuntos_tareasController : ApiController
    {
        adjuntos_tareas obj_adjuntos_tareas = new adjuntos_tareas();
        public DataRow[] alladjuntos_tareas()
        {
            DataTable dt = obj_adjuntos_tareas.get_adjuntos_tareas();
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
        public adjuntos_tareas[] data()
        {
            DataTable dt = obj_adjuntos_tareas.get_adjuntos_tareas();
            DataRow row;
            adjuntos_tareas[] adjuntos_tareass = null;
            if (dt.Rows.Count > 0)
            {
                adjuntos_tareass = new adjuntos_tareas[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    adjuntos_tareass[i] = new adjuntos_tareas(Convert.ToInt64(row["adtr_idadjunto"].ToString()), row["adtr_fecha"].ToString(), row["adtr_estado"].ToString(), row["adtr_rutaarchivo"].ToString(), Convert.ToInt64(row["trea_idtarea"].ToString()));
                }
            }
            return adjuntos_tareass;
        }
        public IEnumerable<adjuntos_tareas> get_adjuntos_tareas()
        {
            return data();
        }
        public IHttpActionResult get_adjuntos_tareas(int id)
        {
            var obj = data().FirstOrDefault((o) => o.adtr_idadjunto == id);
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
        public string insert_adjuntos_tareas(adjuntos_tareas obj)
        {
            if (obj_adjuntos_tareas.insert_adjuntos_tareas(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_adjuntos_tareas(adjuntos_tareas obj)
        {
            if (obj_adjuntos_tareas.update_adjuntos_tareas(obj))
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
