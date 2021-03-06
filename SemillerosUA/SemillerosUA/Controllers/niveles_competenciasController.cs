using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class niveles_competenciasController : ApiController
    {
        niveles_competencias obj_niveles_competencias = new niveles_competencias();
        public DataRow[] allniveles_competencias()
        {
            DataTable dt = obj_niveles_competencias.get_niveles_competencias();
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
        public niveles_competencias[] data()
        {
            DataTable dt = obj_niveles_competencias.get_niveles_competencias();
            DataRow row;
            niveles_competencias[] niveles_competenciass = null;
            if (dt.Rows.Count > 0)
            {
                niveles_competenciass = new niveles_competencias[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    niveles_competenciass[i] = new niveles_competencias(Convert.ToInt64(row["cptc_idcompetencia"].ToString()), Convert.ToInt32(row["nvel_idnivel"].ToString()), row["nvcp_estado"].ToString());
                }
            }
            return niveles_competenciass;
        }
        public IEnumerable<niveles_competencias> get_niveles_competencias()
        {
            return data();
        }
        public IHttpActionResult get_niveles_competencias(int id)
        {
            var obj = data().FirstOrDefault((o) => o.cptc_idcompetencia == id);
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
        public string insert_niveles_competencias(niveles_competencias obj)
        {
            if (obj_niveles_competencias.insert_niveles_competencias(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_niveles_competencias(niveles_competencias obj)
        {
            if (obj_niveles_competencias.update_niveles_competencias(obj))
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
