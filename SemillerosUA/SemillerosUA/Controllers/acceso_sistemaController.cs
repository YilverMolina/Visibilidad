using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class acceso_sistemaController : ApiController
    {
        acceso_sistema obj_acceso_sistema = new acceso_sistema();
        public acceso_sistema[] data()
        {
            DataTable dt = obj_acceso_sistema.get_acceso_sistema();
            DataRow row;
            acceso_sistema[] acceso_sistemas = null;
            if (dt.Rows.Count > 0)
            {
                acceso_sistemas = new acceso_sistema[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    acceso_sistemas[i] = new acceso_sistema(Convert.ToInt64(row["astm_idacceso"].ToString()), row["astm_fecha"].ToString(), row["astm_ip"].ToString(), Convert.ToInt64(row["user_idusuario"].ToString()));
                }
            }
            return acceso_sistemas;
        }
        public IHttpActionResult get_acceso_sistema()
        {
            return Json(obj_acceso_sistema.get_acceso_sistema());
        }
        public IHttpActionResult get_acceso_sistema(int id)
        {
            var obj = data().FirstOrDefault((o) => o.astm_idacceso == id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult insert_acceso_sistema(acceso_sistema obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_acceso_sistema.insert_acceso_sistema(obj))
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
        public IHttpActionResult update_acceso_sistema(acceso_sistema obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_acceso_sistema.update_acceso_sistema(obj))
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
