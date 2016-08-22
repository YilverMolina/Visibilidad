using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class asignacion_tareasController : ApiController
    {
        asignacion_tareas obj_asignacion_tareas = new asignacion_tareas();
        public DataRow[] allasignacion_tareas()
        {
            DataTable dt = obj_asignacion_tareas.get_asignacion_tareas();
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
        public asignacion_tareas[] data()
        {
            DataTable dt = obj_asignacion_tareas.get_asignacion_tareas();
            DataRow row;
            asignacion_tareas[] asignacion_tareass = null;
            if (dt.Rows.Count > 0)
            {
                asignacion_tareass = new asignacion_tareas[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    asignacion_tareass[i] = new asignacion_tareas(Convert.ToInt64(row["astr_idasignacion"].ToString()), row["astr_estado"].ToString(), row["astr_fecha"].ToString(), Convert.ToInt64(row["user_idusuario"].ToString()), Convert.ToInt32(row["dtar_iddetalletarea"].ToString()));
                }
            }
            return asignacion_tareass;
        }
        public IEnumerable<asignacion_tareas> get_asignacion_tareas()
        {
            return data();
        }
        public IHttpActionResult get_asignacion_tareas(int id)
        {
            var obj = data().FirstOrDefault((o) => o.astr_idasignacion == id);
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
        public string insert_asignacion_tareas(asignacion_tareas obj)
        {
            if (obj_asignacion_tareas.insert_asignacion_tareas(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_asignacion_tareas(asignacion_tareas obj)
        {
            if (obj_asignacion_tareas.update_asignacion_tareas(obj))
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
