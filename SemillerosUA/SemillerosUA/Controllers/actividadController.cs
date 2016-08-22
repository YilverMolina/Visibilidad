using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class actividadController : ApiController
    {
        actividad obj_actividad = new actividad();
        public DataRow[] allactividad()
        {
            DataTable dt = obj_actividad.get_actividad();
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
        public actividad[] data()
        {
            DataTable dt = obj_actividad.get_actividad();
            DataRow row;
            actividad[] actividads = null;
            if (dt.Rows.Count > 0)
            {
                actividads = new actividad[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    actividads[i] = new actividad(Convert.ToInt64(row["actv_idactividad"].ToString()), row["actv_descripcion"].ToString(), row["actv_fechainicio"].ToString(), row["actv_fechafin"].ToString(), row["actv_lugar"].ToString(), row["actv_estado"].ToString(), Convert.ToInt32(row["tact_idtipoact"].ToString()), Convert.ToInt64(row["evto_idevento"].ToString()), row["actv_rutaadjunto"].ToString());
                }
            }
            return actividads;
        }
        public IEnumerable<actividad> get_actividad()
        {
            return data();
        }
        public IHttpActionResult get_actividad(int id)
        {
            var obj = data().FirstOrDefault((o) => o.actv_idactividad == id);
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
        public string insert_actividad(actividad obj)
        {
            if (obj_actividad.insert_actividad(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_actividad(actividad obj)
        {
            if (obj_actividad.update_actividad(obj))
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
