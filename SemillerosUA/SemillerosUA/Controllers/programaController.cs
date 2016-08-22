using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class programaController : ApiController
    {
        programa obj_programa = new programa();
        public DataRow[] allprograma()
        {
            DataTable dt = obj_programa.get_programa();
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
        public programa[] data()
        {
            DataTable dt = obj_programa.get_programa();
            DataRow row;
            programa[] programas = null;
            if (dt.Rows.Count > 0)
            {
                programas = new programa[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    programas[i] = new programa(Convert.ToInt32(row["prog_idprograma"].ToString()), row["prog_nombre"].ToString());
                }
            }
            return programas;
        }
        public IEnumerable<programa> get_programa()
        {
            return data();
        }
        public IHttpActionResult get_programa(int id)
        {
            var obj = data().FirstOrDefault((o) => o.prog_idprograma == id);
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
        public string insert_programa(programa obj)
        {
            if (obj_programa.insert_programa(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_programa(programa obj)
        {
            if (obj_programa.update_programa(obj))
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
