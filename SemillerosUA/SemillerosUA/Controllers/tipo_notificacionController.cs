using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class tipo_notificacionController : ApiController
    {
        tipo_notificacion obj_tipo_notificacion = new tipo_notificacion();
        public DataRow[] alltipo_notificacion()
        {
            DataTable dt = obj_tipo_notificacion.get_tipo_notificacion();
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
        public tipo_notificacion[] data()
        {
            DataTable dt = obj_tipo_notificacion.get_tipo_notificacion();
            DataRow row;
            tipo_notificacion[] tipo_notificacions = null;
            if (dt.Rows.Count > 0)
            {
                tipo_notificacions = new tipo_notificacion[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    tipo_notificacions[i] = new tipo_notificacion(Convert.ToInt32(row["tntf_idtiponotif"].ToString()), row["tntf_nombre"].ToString(), row["tntf_descripcion"].ToString());
                }
            }
            return tipo_notificacions;
        }
        public IEnumerable<tipo_notificacion> get_tipo_notificacion()
        {
            return data();
        }
        public IHttpActionResult get_tipo_notificacion(int id)
        {
            var obj = data().FirstOrDefault((o) => o.tntf_idtiponotif == id);
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
        public string insert_tipo_notificacion(tipo_notificacion obj)
        {
            if (obj_tipo_notificacion.insert_tipo_notificacion(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_tipo_notificacion(tipo_notificacion obj)
        {
            if (obj_tipo_notificacion.update_tipo_notificacion(obj))
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
