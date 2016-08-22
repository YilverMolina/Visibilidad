using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class permisosController : ApiController
    {
        permisos obj_permisos = new permisos();
        public DataRow[] allpermisos()
        {
            DataTable dt = obj_permisos.get_permisos();
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
        public permisos[] data()
        {
            DataTable dt = obj_permisos.get_permisos();
            DataRow row;
            permisos[] permisoss = null;
            if (dt.Rows.Count > 0)
            {
                permisoss = new permisos[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    permisoss[i] = new permisos(Convert.ToInt32(row["prms_idpermiso"].ToString()), row["prms_nombrepermiso"].ToString(), row["prms_icono"].ToString());
                }
            }
            return permisoss;
        }
        public IEnumerable<permisos> get_permisos()
        {
            return data();
        }
        public IHttpActionResult get_permisos(int id)
        {
            var obj = data().FirstOrDefault((o) => o.prms_idpermiso == id);
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
        public string insert_permisos(permisos obj)
        {
            if (obj_permisos.insert_permisos(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_permisos(permisos obj)
        {
            if (obj_permisos.update_permisos(obj))
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
