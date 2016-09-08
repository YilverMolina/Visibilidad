using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class menu_usuarioController : ApiController{
menu_usuario obj_menu_usuario= new menu_usuario();
public menu_usuario[] data(){
DataTable dt = obj_menu_usuario.get_menu_usuario();
DataRow row;
menu_usuario[] menu_usuarios = null;
if (dt.Rows.Count > 0){
menu_usuarios = new menu_usuario[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
menu_usuarios[i]= new menu_usuario(Convert.ToInt32(row["rol_fk_idrol"].ToString()),Convert.ToInt32(row["spms_fk_idsubpermiso"].ToString()),row["musr_estado"].ToString());
}
}
return menu_usuarios;
}
public IHttpActionResult get_menu_usuario(){
return Json(obj_menu_usuario.get_menu_usuario());
}
public IHttpActionResult get_menu_usuario(int id){
var obj = data().FirstOrDefault((o) => o.rol_fk_idrol == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_menu_usuario(menu_usuario obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_menu_usuario.insert_menu_usuario(obj)){
return Json(new {
data = obj,
result = true
});
}else {
return Json(new {
result = false
});
}
}
}
 public IHttpActionResult update_menu_usuario(menu_usuario obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_menu_usuario.update_menu_usuario(obj)){
return Json(new {
data = obj,
result = true
});
}else {
return Json(new {
result = false
});
}
}
}
}
}
