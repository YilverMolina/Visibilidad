using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class lider_semilleroController : ApiController
    {
        lider_semillero obj_lider_semillero = new lider_semillero();
        public DataRow[] alllider_semillero()
        {
            DataTable dt = obj_lider_semillero.get_lider_semillero();
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
        public lider_semillero[] data()
        {
            DataTable dt = obj_lider_semillero.get_lider_semillero();
            DataRow row;
            lider_semillero[] lider_semilleros = null;
            if (dt.Rows.Count > 0)
            {
                lider_semilleros = new lider_semillero[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    lider_semilleros[i] = new lider_semillero(Convert.ToInt64(row["user_fk_idusuario"].ToString()), Convert.ToInt32(row["smlr_fk_idsemillero"].ToString()), row["lsml_fecha"].ToString(), row["lsml_estado"].ToString());
                }
            }
            return lider_semilleros;
        }
        public IEnumerable<lider_semillero> get_lider_semillero()
        {
            return data();
        }
        public IHttpActionResult get_lider_semillero(int id)
        {
            var obj = data().FirstOrDefault((o) => o.user_fk_idusuario == id);
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
        public string insert_lider_semillero(lider_semillero obj)
        {
            if (obj_lider_semillero.insert_lider_semillero(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_lider_semillero(lider_semillero obj)
        {
            if (obj_lider_semillero.update_lider_semillero(obj))
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
