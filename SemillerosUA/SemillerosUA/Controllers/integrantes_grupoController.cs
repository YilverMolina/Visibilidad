using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class integrantes_grupoController : ApiController
    {
        integrantes_grupo obj_integrantes_grupo = new integrantes_grupo();
        public DataRow[] allintegrantes_grupo()
        {
            DataTable dt = obj_integrantes_grupo.get_integrantes_grupo();
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
        public integrantes_grupo[] data()
        {
            DataTable dt = obj_integrantes_grupo.get_integrantes_grupo();
            DataRow row;
            integrantes_grupo[] integrantes_grupos = null;
            if (dt.Rows.Count > 0)
            {
                integrantes_grupos = new integrantes_grupo[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    integrantes_grupos[i] = new integrantes_grupo(Convert.ToInt64(row["igrp_idintegrantes"].ToString()), Convert.ToInt64(row["grup_idgrupo"].ToString()), Convert.ToInt64(row["user_idusuario"].ToString()), row["igrp_estado"].ToString());
                }
            }
            return integrantes_grupos;
        }
        public IEnumerable<integrantes_grupo> get_integrantes_grupo()
        {
            return data();
        }
        public IHttpActionResult get_integrantes_grupo(int id)
        {
            var obj = data().FirstOrDefault((o) => o.igrp_idintegrantes == id);
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
        public string insert_integrantes_grupo(integrantes_grupo obj)
        {
            if (obj_integrantes_grupo.insert_integrantes_grupo(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_integrantes_grupo(integrantes_grupo obj)
        {
            if (obj_integrantes_grupo.update_integrantes_grupo(obj))
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
