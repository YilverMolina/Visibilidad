using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class eventoController : ApiController
    {
        evento obj_evento = new evento();
        public DataRow[] allevento()
        {
            DataTable dt = obj_evento.get_evento();
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
        public IEnumerable<evento> get_evento()
        {
            return data();
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
        [HttpPost]
        public string insert_evento(evento obj)
        {
            if (obj_evento.insert_evento(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_evento(evento obj)
        {
            if (obj_evento.update_evento(obj))
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
