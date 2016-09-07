using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class rolController : ApiController
    {
        rol obj_rol = new rol();
        public DataRow[] allrol()
        {
            DataTable dt = obj_rol.get_rol();
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
        public rol[] data()
        {
            DataTable dt = obj_rol.get_rol();
            DataRow row;
            rol[] rols = null;
            if (dt.Rows.Count > 0)
            {
                rols = new rol[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    rols[i] = new rol(Convert.ToInt32(row["rol_idrol"].ToString()), row["rol_nombrerol"].ToString());
                }
            }
            return rols;
        }
        public IEnumerable<rol> get_rol()
        {
            return data();
        }

        public IEnumerable<DataRow> get_rols()
        {
            DataTable dt = obj_rol.get_rol();
            List<DataRow> dtList = dt.AsEnumerable().ToList();
            return dtList;
        }

        public IHttpActionResult get_rol(int id)
        {
            var obj = data().FirstOrDefault((o) => o.rol_idrol == id);
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
        public string insert_rol(rol obj)
        {
            if (obj_rol.insert_rol(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_rol(rol obj)
        {
            if (obj_rol.update_rol(obj))
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
