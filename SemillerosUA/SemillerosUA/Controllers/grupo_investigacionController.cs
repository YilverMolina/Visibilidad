using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class grupo_investigacionController : ApiController
    {
        grupo_investigacion obj_grupo_investigacion = new grupo_investigacion();
        public DataRow[] allgrupo_investigacion()
        {
            DataTable dt = obj_grupo_investigacion.get_grupo_investigacion();
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
        public grupo_investigacion[] data()
        {
            DataTable dt = obj_grupo_investigacion.get_grupo_investigacion();
            DataRow row;
            grupo_investigacion[] grupo_investigacions = null;
            if (dt.Rows.Count > 0)
            {
                grupo_investigacions = new grupo_investigacion[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    grupo_investigacions[i] = new grupo_investigacion(Convert.ToInt32(row["griv_idgrupoinv"].ToString()), row["griv_fechacreacion"].ToString(), row["griv_nombre"].ToString(), row["griv_descripcion"].ToString(), Convert.ToInt64(row["user_director"].ToString()));
                }
            }
            return grupo_investigacions;
        }
        public IEnumerable<grupo_investigacion> get_grupo_investigacion()
        {
            return data();
        }
        public IHttpActionResult get_grupo_investigacion(int id)
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
        public string insert_grupo_investigacion(grupo_investigacion obj)
        {
            if (obj_grupo_investigacion.insert_grupo_investigacion(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_grupo_investigacion(grupo_investigacion obj)
        {
            if (obj_grupo_investigacion.update_grupo_investigacion(obj))
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
