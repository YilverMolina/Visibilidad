using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class competenciaController : ApiController
    {
        competencia obj_competencia = new competencia();
        public DataRow[] allcompetencia()
        {
            DataTable dt = obj_competencia.get_competencia();
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
        public competencia[] data()
        {
            DataTable dt = obj_competencia.get_competencia();
            DataRow row;
            competencia[] competencias = null;
            if (dt.Rows.Count > 0)
            {
                competencias = new competencia[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    competencias[i] = new competencia(Convert.ToInt64(row["cptc_idcompetencia"].ToString()), row["cptc_nombre"].ToString(), row["cptc_descripcion"].ToString(), row["cptc_fechainicio"].ToString(), row["cptc_limiteinscripciones"].ToString(), Convert.ToInt32(row["cptc_participantes"].ToString()), Convert.ToInt32(row["cptc_cupos"].ToString()), Convert.ToInt32(row["smlr_idsemillero"].ToString()), row["cptc_fechafin"].ToString(), row["cptc_fechapublicacion"].ToString(), row["cptc_mostrardesde"].ToString(), row["cptc_mostrarhasta"].ToString());
                }
            }
            return competencias;
        }
        public IEnumerable<competencia> get_competencia()
        {
            return data();
        }
        public IHttpActionResult get_competencia(int id)
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
        public string insert_competencia(competencia obj)
        {
            if (obj_competencia.insert_competencia(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_competencia(competencia obj)
        {
            if (obj_competencia.update_competencia(obj))
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
