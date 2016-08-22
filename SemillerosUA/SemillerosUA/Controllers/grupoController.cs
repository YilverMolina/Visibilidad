using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class grupoController : ApiController
    {
        grupo obj_grupo = new grupo();
        public DataRow[] allgrupo()
        {
            DataTable dt = obj_grupo.get_grupo();
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
        public grupo[] data()
        {
            DataTable dt = obj_grupo.get_grupo();
            DataRow row;
            grupo[] grupos = null;
            if (dt.Rows.Count > 0)
            {
                grupos = new grupo[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    grupos[i] = new grupo(Convert.ToInt64(row["grup_idgrupo"].ToString()), row["grup_nombre"].ToString(), row["grup_usuario"].ToString(), row["grup_password"].ToString(), row["grup_estado"].ToString(), row["grup_fechainscripcion"].ToString(), Convert.ToInt64(row["cptc_idcompetencia"].ToString()));
                }
            }
            return grupos;
        }
        public IEnumerable<grupo> get_grupo()
        {
            return data();
        }
        public IHttpActionResult get_grupo(int id)
        {
            var obj = data().FirstOrDefault((o) => o.grup_idgrupo == id);
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
        public string insert_grupo(grupo obj)
        {
            if (obj_grupo.insert_grupo(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_grupo(grupo obj)
        {
            if (obj_grupo.update_grupo(obj))
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
