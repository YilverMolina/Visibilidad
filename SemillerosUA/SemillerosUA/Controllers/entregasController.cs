using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class entregasController : ApiController
    {
        entregas obj_entregas = new entregas();
        public DataRow[] allentregas()
        {
            DataTable dt = obj_entregas.get_entregas();
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
        public entregas[] data()
        {
            DataTable dt = obj_entregas.get_entregas();
            DataRow row;
            entregas[] entregass = null;
            if (dt.Rows.Count > 0)
            {
                entregass = new entregas[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    entregass[i] = new entregas(Convert.ToInt64(row["entr_identrega"].ToString()), row["entr_descripcion"].ToString(), row["entr_rutaarchivo"].ToString(), row["entr_calificado"].ToString(), row["entr_respuesta"].ToString(), row["entr_valoracion"].ToString(), Convert.ToInt64(row["user_idusuario"].ToString()), Convert.ToInt64(row["astr_idasignacion"].ToString()));
                }
            }
            return entregass;
        }
        public IEnumerable<entregas> get_entregas()
        {
            return data();
        }
        public IHttpActionResult get_entregas(int id)
        {
            var obj = data().FirstOrDefault((o) => o.entr_identrega == id);
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
        public string insert_entregas(entregas obj)
        {
            if (obj_entregas.insert_entregas(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_entregas(entregas obj)
        {
            if (obj_entregas.update_entregas(obj))
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
