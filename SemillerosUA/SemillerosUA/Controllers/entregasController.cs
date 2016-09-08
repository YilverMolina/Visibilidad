using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class entregasController : ApiController
    {
        entregas obj_entregas = new entregas();
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
        public IHttpActionResult get_entregas()
        {
            return Json(obj_entregas.get_entregas());
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
        public IHttpActionResult insert_entregas(entregas obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_entregas.insert_entregas(obj))
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
        public IHttpActionResult update_entregas(entregas obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_entregas.update_entregas(obj))
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
