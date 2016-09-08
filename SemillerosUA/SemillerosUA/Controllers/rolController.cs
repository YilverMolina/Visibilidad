using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class rolController : ApiController
    {
        rol obj_rol = new rol();
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
        public IHttpActionResult get_rol()
        {
            return Json(obj_rol.get_rol());
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
        public IHttpActionResult insert_rol(rol obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_rol.insert_rol(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }
            }
        }
        public IHttpActionResult update_rol(rol obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_rol.update_rol(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }
            }
        }
    }
}
