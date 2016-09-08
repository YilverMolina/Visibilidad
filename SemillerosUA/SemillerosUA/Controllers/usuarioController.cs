using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers
{
    public class usuarioController : ApiController
    {
        usuario obj_usuario = new usuario();
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
        public IHttpActionResult get_usuario()
        {
            return Json(obj_usuario.get_usuario());
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
        public IHttpActionResult insert_usuario(usuario obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_usuario.insert_usuario(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }
            }
        }
        public IHttpActionResult update_usuario(usuario obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (obj_usuario.update_usuario(obj))
                {
                    return Json(new
                    {
                        data = obj,
                        result = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        result = false
                    });
                }
            }
        }
    }
}
