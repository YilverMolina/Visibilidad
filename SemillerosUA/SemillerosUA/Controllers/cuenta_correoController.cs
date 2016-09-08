using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class cuenta_correoController : ApiController
    {
        cuenta_correo obj_cuenta_correo = new cuenta_correo();
        public cuenta_correo[] data()
        {
            DataTable dt = obj_cuenta_correo.get_cuenta_correo();
            DataRow row;
            cuenta_correo[] cuenta_correos = null;
            if (dt.Rows.Count > 0)
            {
                cuenta_correos = new cuenta_correo[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    cuenta_correos[i] = new cuenta_correo(Convert.ToInt32(row["ccrr_idcorreo"].ToString()), row["ccrr_nombrecorreo"].ToString(), row["ccrr_estado"].ToString(), Convert.ToInt32(row["smlr_idsemillero"].ToString()));
                }
            }
            return cuenta_correos;
        }
        public IHttpActionResult get_cuenta_correo()
        {
            return Json(obj_cuenta_correo.get_cuenta_correo());
        }
        public IHttpActionResult get_cuenta_correo(int id)
        {
            var obj = data().FirstOrDefault((o) => o.ccrr_idcorreo == id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult insert_cuenta_correo(cuenta_correo obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_cuenta_correo.insert_cuenta_correo(obj))
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
        public IHttpActionResult update_cuenta_correo(cuenta_correo obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_cuenta_correo.update_cuenta_correo(obj))
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
