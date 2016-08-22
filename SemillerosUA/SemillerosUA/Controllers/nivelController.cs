using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class nivelController : ApiController
    {
        nivel obj_nivel = new nivel();
        public DataRow[] allnivel()
        {
            DataTable dt = obj_nivel.get_nivel();
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
        public nivel[] data()
        {
            DataTable dt = obj_nivel.get_nivel();
            DataRow row;
            nivel[] nivels = null;
            if (dt.Rows.Count > 0)
            {
                nivels = new nivel[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    nivels[i] = new nivel(Convert.ToInt32(row["nvel_idnivel"].ToString()), row["nvel_nombre"].ToString(), row["nvel_descripcion"].ToString(), row["nvel_estado"].ToString());
                }
            }
            return nivels;
        }
        public IEnumerable<nivel> get_nivel()
        {
            return data();
        }
        public IHttpActionResult get_nivel(int id)
        {
            var obj = data().FirstOrDefault((o) => o.nvel_idnivel == id);
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
        public string insert_nivel(nivel obj)
        {
            if (obj_nivel.insert_nivel(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_nivel(nivel obj)
        {
            if (obj_nivel.update_nivel(obj))
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
