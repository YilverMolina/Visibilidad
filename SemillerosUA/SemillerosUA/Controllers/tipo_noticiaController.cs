using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class tipo_noticiaController : ApiController
    {
        tipo_noticia obj_tipo_noticia = new tipo_noticia();
        public DataRow[] alltipo_noticia()
        {
            DataTable dt = obj_tipo_noticia.get_tipo_noticia();
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
        public IEnumerable<tipo_noticia> get_tipo_noticia()
        {
            return data();
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
        [HttpPost]
        public string insert_tipo_noticia(tipo_noticia obj)
        {
            if (obj_tipo_noticia.insert_tipo_noticia(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_tipo_noticia(tipo_noticia obj)
        {
            if (obj_tipo_noticia.update_tipo_noticia(obj))
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
