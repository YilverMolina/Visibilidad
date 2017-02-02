using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class menu_usuarioController : ApiController
    {
        menu_usuario obj_menu_usuario = new menu_usuario();
        public DataRow[] allmenu_usuario()
        {
            DataTable dt = obj_menu_usuario.get_menu_usuario();
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
        public menu_usuario[] data()
        {
            DataTable dt = obj_menu_usuario.get_menu_usuario();
            DataRow row;
            menu_usuario[] menu_usuarios = null;
            if (dt.Rows.Count > 0)
            {
                menu_usuarios = new menu_usuario[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    row = dt.Rows[i];
                    menu_usuarios[i] = new menu_usuario(Convert.ToInt32(row["rol_fk_idrol"].ToString()), Convert.ToInt32(row["spms_fk_idsubpermiso"].ToString()), row["musr_estado"].ToString());
                }
            }
            return menu_usuarios;
        }
        public IEnumerable<menu_usuario> get_menu_usuario()
        {
            return data();
        }
        public IHttpActionResult get_menu_usuario(int id)
        {
            var obj = data().FirstOrDefault((o) => o.rol_fk_idrol == id);
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
        public string insert_menu_usuario(menu_usuario obj)
        {
            if (obj_menu_usuario.insert_menu_usuario(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_menu_usuario(menu_usuario obj)
        {
            if (obj_menu_usuario.update_menu_usuario(obj))
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
