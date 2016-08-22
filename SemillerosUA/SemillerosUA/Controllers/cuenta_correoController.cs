using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class cuenta_correoController : ApiController
    {
        cuenta_correo obj_cuenta_correo = new cuenta_correo();
        public DataRow[] allcuenta_correo()
        {
            DataTable dt = obj_cuenta_correo.get_cuenta_correo();
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
        public cuenta_correo[] data()
        {
            DataTable dt = obj_cuenta_correo.get_cuenta_correo();
            DataRow row;
            cuenta_correo[] cuenta_correos = null;
            if (dt.Rows.Count > 0)
            {
                cuenta_correos = new cuenta_correo[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    cuenta_correos[i] = new cuenta_correo(Convert.ToInt32(row["ccrr_idcorreo"].ToString()), row["ccrr_nombrecorreo"].ToString(), row["ccrr_estado"].ToString(), Convert.ToInt32(row["smlr_idsemillero"].ToString()));
                }
            }
            return cuenta_correos;
        }
        public IEnumerable<cuenta_correo> get_cuenta_correo()
        {
            return data();
        }
        public IHttpActionResult get_cuenta_correo(int id)
        {
            var obj = data().FirstOrDefault((o) => o.ccrr_idcorreo == id);
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
        public string insert_cuenta_correo(cuenta_correo obj)
        {
            if (obj_cuenta_correo.insert_cuenta_correo(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_cuenta_correo(cuenta_correo obj)
        {
            if (obj_cuenta_correo.update_cuenta_correo(obj))
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
