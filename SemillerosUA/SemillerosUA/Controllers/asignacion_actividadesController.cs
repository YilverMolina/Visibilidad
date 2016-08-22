using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class asignacion_actividadesController : ApiController
    {
        asignacion_actividades obj_asignacion_actividades = new asignacion_actividades();
        public DataRow[] allasignacion_actividades()
        {
            DataTable dt = obj_asignacion_actividades.get_asignacion_actividades();
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
        public asignacion_actividades[] data()
        {
            DataTable dt = obj_asignacion_actividades.get_asignacion_actividades();
            DataRow row;
            asignacion_actividades[] asignacion_actividadess = null;
            if (dt.Rows.Count > 0)
            {
                asignacion_actividadess = new asignacion_actividades[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    asignacion_actividadess[i] = new asignacion_actividades(Convert.ToInt64(row["user_responsable"].ToString()), Convert.ToInt64(row["actv_idactividad"].ToString()), row["aact_estado"].ToString(), row["aact_fechaasignacion"].ToString(), row["aact_invitado"].ToString());
                }
            }
            return asignacion_actividadess;
        }
        public IEnumerable<asignacion_actividades> get_asignacion_actividades()
        {
            return data();
        }
        public IHttpActionResult get_asignacion_actividades(int id)
        {
            var obj = data().FirstOrDefault((o) => o.user_responsable == id);
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
        public string insert_asignacion_actividades(asignacion_actividades obj)
        {
            if (obj_asignacion_actividades.insert_asignacion_actividades(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_asignacion_actividades(asignacion_actividades obj)
        {
            if (obj_asignacion_actividades.update_asignacion_actividades(obj))
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
