using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class tipo_actividadController : ApiController
    {
        tipo_actividad obj_tipo_actividad = new tipo_actividad();
        public DataRow[] alltipo_actividad()
        {
            DataTable dt = obj_tipo_actividad.get_tipo_actividad();
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
        public tipo_actividad[] data()
        {
            DataTable dt = obj_tipo_actividad.get_tipo_actividad();
            DataRow row;
            tipo_actividad[] tipo_actividads = null;
            if (dt.Rows.Count > 0)
            {
                tipo_actividads = new tipo_actividad[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    tipo_actividads[i] = new tipo_actividad(Convert.ToInt32(row["tact_idtipoactividad"].ToString()), row["tact_nombre"].ToString(), row["tact_descripcion"].ToString(), row["tact_estado"].ToString());
                }
            }
            return tipo_actividads;
        }
        public IEnumerable<tipo_actividad> get_tipo_actividad()
        {
            return data();
        }
        public IHttpActionResult get_tipo_actividad(int id)
        {
            var obj = data().FirstOrDefault((o) => o.tact_idtipoactividad == id);
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
        public string insert_tipo_actividad(tipo_actividad obj)
        {
            if (obj_tipo_actividad.insert_tipo_actividad(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_tipo_actividad(tipo_actividad obj)
        {
            if (obj_tipo_actividad.update_tipo_actividad(obj))
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
