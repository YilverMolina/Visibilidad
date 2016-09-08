using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class eventoController : ApiController
    {
        evento obj_evento = new evento();
        public evento[] data()
        {
            DataTable dt = obj_evento.get_evento();
            DataRow row;
            evento[] eventos = null;
            if (dt.Rows.Count > 0)
            {
                eventos = new evento[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    eventos[i] = new evento(Convert.ToInt64(row["evto_idevento"].ToString()), row["evto_nombre"].ToString(), row["evto_descripcion"].ToString(), row["evto_lugar"].ToString(), row["evto_estado"].ToString(), row["evto_realizado"].ToString(), Convert.ToInt32(row["smlr_idsemillero"].ToString()), row["evto_fechapublicacion"].ToString(), row["evto_fechainicio"].ToString(), row["evto_fechafin"].ToString(), row["evto_mostrardesde"].ToString(), row["evto_mostrarhasta"].ToString(), row["evto_rutaadjunto"].ToString());
                }
            }
            return eventos;
        }
        public IHttpActionResult get_evento()
        {
            return Json(obj_evento.get_evento());
        }
        public IHttpActionResult get_evento(int id)
        {
            var obj = data().FirstOrDefault((o) => o.evto_idevento == id);
            if (obj != null)
            {
                return Ok(obj);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult insert_evento(evento obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_evento.insert_evento(obj))
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
        public IHttpActionResult update_evento(evento obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_evento.update_evento(obj))
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
