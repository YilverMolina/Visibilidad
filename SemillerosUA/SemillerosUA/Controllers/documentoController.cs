using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class documentoController : ApiController
    {
        documento obj_documento = new documento();
        public DataRow[] alldocumento()
        {
            DataTable dt = obj_documento.get_documento();
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
        public documento[] data()
        {
            DataTable dt = obj_documento.get_documento();
            DataRow row;
            documento[] documentos = null;
            if (dt.Rows.Count > 0)
            {
                documentos = new documento[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    documentos[i] = new documento(Convert.ToInt32(row["docu_iddocumento"].ToString()), row["docu_nombre"].ToString(), row["docu_ruta"].ToString(), row["docu_fecha"].ToString(), row["docu_estado"].ToString(), Convert.ToInt64(row["user_idusuario"].ToString()), Convert.ToInt32(row["repo_idrepositorio"].ToString()));
                }
            }
            return documentos;
        }
        public IEnumerable<documento> get_documento()
        {
            return data();
        }
        public IHttpActionResult get_documento(int id)
        {
            var obj = data().FirstOrDefault((o) => o.docu_iddocumento == id);
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
        public string insert_documento(documento obj)
        {
            if (obj_documento.insert_documento(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_documento(documento obj)
        {
            if (obj_documento.update_documento(obj))
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
