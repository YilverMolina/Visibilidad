using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class cursosController : ApiController
    {
        cursos obj_cursos = new cursos();
        public DataRow[] allcursos()
        {
            DataTable dt = obj_cursos.get_cursos();
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
        public cursos[] data()
        {
            DataTable dt = obj_cursos.get_cursos();
            DataRow row;
            cursos[] cursoss = null;
            if (dt.Rows.Count > 0)
            {
                cursoss = new cursos[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    cursoss[i] = new cursos(Convert.ToInt32(row["curs_idcurso"].ToString()), row["curs_nombre"].ToString(), row["curs_fechacreacion"].ToString(), Convert.ToInt32(row["curs_cupos"].ToString()), row["curs_fechainicio"].ToString(), row["curs_fechafin"].ToString(), row["curs_estado"].ToString(), row["curs_fechapublicacion"].ToString(), row["curs_mostrardesde"].ToString(), row["curs_mostrarhasta"].ToString(), Convert.ToInt32(row["tcrs_idtipocurso"].ToString()), Convert.ToInt32(row["smlr_idsemillero"].ToString()));
                }
            }
            return cursoss;
        }
        public IEnumerable<cursos> get_cursos()
        {
            return data();
        }

        public IEnumerable<cursos> get_cursos_activos()
        {
            return data();
        }

        public IHttpActionResult get_cursos(int id)
        {
            var obj = data().FirstOrDefault((o) => o.curs_idcurso == id);
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
        public string insert_cursos(cursos obj)
        {
            if (obj_cursos.insert_cursos(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }

        [HttpPost]
        public string update_cursos(cursos obj)
        {
            if (obj_cursos.update_cursos(obj))
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
