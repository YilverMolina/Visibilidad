using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class tipo_noticiaController : ApiController
    {
        tipo_noticia obj_tipo_noticia = new tipo_noticia();
        public tipo_noticia[] data()
        {
            DataTable dt = obj_tipo_noticia.get_tipo_noticia();
            DataRow row;
            tipo_noticia[] tipo_noticias = null;
            if (dt.Rows.Count > 0)
            {
                tipo_noticias = new tipo_noticia[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    tipo_noticias[i] = new tipo_noticia(Convert.ToInt32(row["tntc_idnoticia"].ToString()), row["tntc_nombre"].ToString(), row["tntc_descripcion"].ToString(), row["tntc_estado"].ToString());
                }
            }
            return tipo_noticias;
        }
        public IHttpActionResult get_tipo_noticia()
        {
            return Json(obj_tipo_noticia.get_tipo_noticia());
        }
        public IHttpActionResult get_tipo_noticia(int id)
        {
            var obj = data().FirstOrDefault((o) => o.tntc_idnoticia == id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult insert_tipo_noticia(tipo_noticia obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_tipo_noticia.insert_tipo_noticia(obj))
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
        public IHttpActionResult update_tipo_noticia(tipo_noticia obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_tipo_noticia.update_tipo_noticia(obj))
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
