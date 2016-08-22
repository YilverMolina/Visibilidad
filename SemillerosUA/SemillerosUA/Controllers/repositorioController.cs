using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class repositorioController : ApiController
    {
        repositorio obj_repositorio = new repositorio();
        public DataRow[] allrepositorio()
        {
            DataTable dt = obj_repositorio.get_repositorio();
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
        public repositorio[] data()
        {
            DataTable dt = obj_repositorio.get_repositorio();
            DataRow row;
            repositorio[] repositorios = null;
            if (dt.Rows.Count > 0)
            {
                repositorios = new repositorio[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    repositorios[i] = new repositorio(Convert.ToInt32(row["repo_idrepositorio"].ToString()), row["repo_nombre"].ToString(), row["repo_descripcion"].ToString(), row["repo_ruta"].ToString(), row["repo_estado"].ToString(), Convert.ToInt32(row["smlr_idsemillero"].ToString()));
                }
            }
            return repositorios;
        }
        public IEnumerable<repositorio> get_repositorio()
        {
            return data();
        }
        public IHttpActionResult get_repositorio(int id)
        {
            var obj = data().FirstOrDefault((o) => o.repo_idrepositorio == id);
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
        public string insert_repositorio(repositorio obj)
        {
            if (obj_repositorio.insert_repositorio(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_repositorio(repositorio obj)
        {
            if (obj_repositorio.update_repositorio(obj))
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
