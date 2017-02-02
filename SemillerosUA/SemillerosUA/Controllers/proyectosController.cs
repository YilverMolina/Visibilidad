using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class proyectosController : ApiController
    {
        proyectos obj_proyectos = new proyectos();
        public DataRow[] allproyectos()
        {
            DataTable dt = obj_proyectos.get_proyectos();
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
        public proyectos[] data()
        {
            DataTable dt = obj_proyectos.get_proyectos();
            DataRow row;
            proyectos[] proyectoss = null;
            if (dt.Rows.Count > 0)
            {
                proyectoss = new proyectos[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    proyectoss[i] = new proyectos(Convert.ToInt32(row["proy_idproyecto"].ToString()), row["proy_nombre"].ToString(), row["proy_descripcion"].ToString(), row["proy_estado"].ToString(), Convert.ToInt32(row["smlr_idsemillero"].ToString()));
                }
            }
            return proyectoss;
        }
        public IEnumerable<proyectos> get_proyectos()
        {
            return data();
        }
        public IHttpActionResult get_proyectos(int id)
        {
            var obj = data().FirstOrDefault((o) => o.proy_idproyecto == id);
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
        public string insert_proyectos(proyectos obj)
        {
            if (obj_proyectos.insert_proyectos(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_proyectos(proyectos obj)
        {
            if (obj_proyectos.update_proyectos(obj))
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
