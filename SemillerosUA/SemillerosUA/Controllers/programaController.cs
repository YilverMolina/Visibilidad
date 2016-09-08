using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class programaController : ApiController
    {
        programa obj_programa = new programa();
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
        public IHttpActionResult get_programa()
        {
            return Json(obj_programa.get_programa());
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
        public IHttpActionResult insert_programa(programa obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_programa.insert_programa(obj))
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
        public IHttpActionResult update_programa(programa obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_programa.update_programa(obj))
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
