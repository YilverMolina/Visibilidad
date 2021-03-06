using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class rol_semilleroController : ApiController
    {
        rol_semillero obj_rol_semillero = new rol_semillero();
        public DataRow[] allrol_semillero()
        {
            DataTable dt = obj_rol_semillero.get_rol_semillero();
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
        public rol_semillero[] data()
        {
            DataTable dt = obj_rol_semillero.get_rol_semillero();
            DataRow row;
            rol_semillero[] rol_semilleros = null;
            if (dt.Rows.Count > 0)
            {
                rol_semilleros = new rol_semillero[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    rol_semilleros[i] = new rol_semillero(Convert.ToInt32(row["rsml_idrolsemillero"].ToString()), row["rsml_permisos"].ToString(), row["rsml_estado"].ToString(), Convert.ToInt64(row["user_idusuario"].ToString()), Convert.ToInt32(row["smlr_idsemillero"].ToString()));
                }
            }
            return rol_semilleros;
        }
        public IEnumerable<rol_semillero> get_rol_semillero()
        {
            return data();
        }
        public IHttpActionResult get_rol_semillero(int id)
        {
            var obj = data().FirstOrDefault((o) => o.rsml_idrolsemillero == id);
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
        public string insert_rol_semillero(rol_semillero obj)
        {
            if (obj_rol_semillero.insert_rol_semillero(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_rol_semillero(rol_semillero obj)
        {
            if (obj_rol_semillero.update_rol_semillero(obj))
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
