using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class notificacionController : ApiController
    {
        notificacion obj_notificacion = new notificacion();
        public DataRow[] allnotificacion()
        {
            DataTable dt = obj_notificacion.get_notificacion();
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
        public notificacion[] data()
        {
            DataTable dt = obj_notificacion.get_notificacion();
            DataRow row;
            notificacion[] notificacions = null;
            if (dt.Rows.Count > 0)
            {
                notificacions = new notificacion[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    notificacions[i] = new notificacion(Convert.ToInt64(row["notf_idnotificacion"].ToString()), row["notf_fecha"].ToString(), row["notf_recibida"].ToString(), Convert.ToInt64(row["user_emisor"].ToString()), Convert.ToInt64(row["user_destinatario"].ToString()), Convert.ToInt32(row["tntf_idtiponotif"].ToString()));
                }
            }
            return notificacions;
        }
        public IEnumerable<notificacion> get_notificacion()
        {
            return data();
        }
        public IHttpActionResult get_notificacion(int id)
        {
            var obj = data().FirstOrDefault((o) => o.notf_idnotificacion == id);
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
        public string insert_notificacion(notificacion obj)
        {
            if (obj_notificacion.insert_notificacion(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_notificacion(notificacion obj)
        {
            if (obj_notificacion.update_notificacion(obj))
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
