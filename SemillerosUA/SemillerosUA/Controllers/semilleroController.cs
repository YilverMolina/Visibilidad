using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class semilleroController : ApiController
    {
        semillero obj_semillero = new semillero();
        public DataRow[] allsemillero()
        {
            DataTable dt = obj_semillero.get_semillero();
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
        public semillero[] data()
        {
            DataTable dt = obj_semillero.get_semillero();
            DataRow row;
            semillero[] semilleros = null;
            if (dt.Rows.Count > 0)
            {
                semilleros = new semillero[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    semilleros[i] = new semillero(Convert.ToInt32(row["smlr_idsemillero"].ToString()), row["smlr_nombre"].ToString(), row["smlr_descripcion"].ToString(), row["smlr_rutalogo"].ToString(), row["smlr_mision"].ToString(), row["smlr_vision"].ToString(), row["smlr_ruta"].ToString(), Convert.ToInt32(row["griv_idgrupoinv"].ToString()));
                }
            }
            return semilleros;
        }
        public IEnumerable<semillero> get_semillero()
        {
            return data();
        }
        public IHttpActionResult get_semillero(int id)
        {
            var obj = data().FirstOrDefault((o) => o.smlr_idsemillero == id);
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
        public string insert_semillero(semillero obj)
        {
            if (obj_semillero.insert_semillero(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_semillero(semillero obj)
        {
            if (obj_semillero.update_semillero(obj))
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
