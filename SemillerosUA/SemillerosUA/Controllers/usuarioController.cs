using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class usuarioController : ApiController
    {
        usuario obj_usuario = new usuario();
        public DataRow[] allusuario()
        {
            DataTable dt = obj_usuario.get_usuario();
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
        public usuario[] data()
        {
            DataTable dt = obj_usuario.get_usuario();
            DataRow row;
            usuario[] usuarios = null;
            if (dt.Rows.Count > 0)
            {
                usuarios = new usuario[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    usuarios[i] = new usuario(Convert.ToInt64(row["user_idusuario"].ToString()), row["user_nusuario"].ToString(), row["user_contrasenia"].ToString(), Convert.ToInt32(row["rol_fk_idrol"].ToString()), Convert.ToInt64(row["pers_fk_idpersona"].ToString()), row["user_fecharegistro"].ToString(), row["user_estado"].ToString());
                }
            }
            return usuarios;
        }
        public IEnumerable<usuario> get_usuario()
        {
            return data();
        }
        public IHttpActionResult get_usuario(int id)
        {
            var obj = data().FirstOrDefault((o) => o.user_idusuario == id);
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
        public string insert_usuario(usuario obj)
        {
            if (obj_usuario.insert_usuario(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_usuario(usuario obj)
        {
            if (obj_usuario.update_usuario(obj))
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
