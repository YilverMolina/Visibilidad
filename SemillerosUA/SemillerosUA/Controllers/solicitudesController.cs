using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class solicitudesController : ApiController
    {
        solicitudes obj_solicitudes = new solicitudes();
        public DataRow[] allsolicitudes()
        {
            DataTable dt = obj_solicitudes.get_solicitudes();
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
        public solicitudes[] data()
        {
            DataTable dt = obj_solicitudes.get_solicitudes();
            DataRow row;
            solicitudes[] solicitudess = null;
            if (dt.Rows.Count > 0)
            {
                solicitudess = new solicitudes[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    solicitudess[i] = new solicitudes(Convert.ToInt32(row["slct_idsolicitud"].ToString()), Convert.ToInt32(row["curs_idcurso"].ToString()), Convert.ToInt64(row["user_estudiante"].ToString()), Convert.ToInt64(row["user_admin"].ToString()), row["slct_fechasolicitud"].ToString(), row["slct_fecharespuesta"].ToString(), row["slct_estado"].ToString(), row["slct_comentario"].ToString());
                }
            }
            return solicitudess;
        }
        public IEnumerable<solicitudes> get_solicitudes()
        {
            return data();
        }
        public IHttpActionResult get_solicitudes(int id)
        {
            var obj = data().FirstOrDefault((o) => o.slct_idsolicitud == id);
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
        public string insert_solicitudes(solicitudes obj)
        {
            if (obj_solicitudes.insert_solicitudes(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_solicitudes(solicitudes obj)
        {
            if (obj_solicitudes.update_solicitudes(obj))
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
