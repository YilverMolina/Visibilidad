using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class programas_grupos_invController : ApiController
    {
        programas_grupos_inv obj_programas_grupos_inv = new programas_grupos_inv();
        public DataRow[] allprogramas_grupos_inv()
        {
            DataTable dt = obj_programas_grupos_inv.get_programas_grupos_inv();
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
        public programas_grupos_inv[] data()
        {
            DataTable dt = obj_programas_grupos_inv.get_programas_grupos_inv();
            DataRow row;
            programas_grupos_inv[] programas_grupos_invs = null;
            if (dt.Rows.Count > 0)
            {
                programas_grupos_invs = new programas_grupos_inv[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    programas_grupos_invs[i] = new programas_grupos_inv(Convert.ToInt32(row["griv_idgrupoinv"].ToString()), Convert.ToInt32(row["prog_idprograma"].ToString()), row["prgr_estado"].ToString());
                }
            }
            return programas_grupos_invs;
        }
        public IEnumerable<programas_grupos_inv> get_programas_grupos_inv()
        {
            return data();
        }
        public IHttpActionResult get_programas_grupos_inv(int id)
        {
            var obj = data().FirstOrDefault((o) => o.griv_idgrupoinv == id);
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
        public string insert_programas_grupos_inv(programas_grupos_inv obj)
        {
            if (obj_programas_grupos_inv.insert_programas_grupos_inv(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_programas_grupos_inv(programas_grupos_inv obj)
        {
            if (obj_programas_grupos_inv.update_programas_grupos_inv(obj))
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
