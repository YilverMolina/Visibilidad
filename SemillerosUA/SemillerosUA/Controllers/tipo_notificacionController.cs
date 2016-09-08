using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class tipo_notificacionController : ApiController{
tipo_notificacion obj_tipo_notificacion= new tipo_notificacion();
public tipo_notificacion[] data(){
DataTable dt = obj_tipo_notificacion.get_tipo_notificacion();
DataRow row;
tipo_notificacion[] tipo_notificacions = null;
if (dt.Rows.Count > 0){
tipo_notificacions = new tipo_notificacion[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
tipo_notificacions[i]= new tipo_notificacion(Convert.ToInt32(row["tntf_idtiponotif"].ToString()),row["tntf_nombre"].ToString(),row["tntf_descripcion"].ToString());
}
}
return tipo_notificacions;
}
public IHttpActionResult get_tipo_notificacion(){
return Json(obj_tipo_notificacion.get_tipo_notificacion());
}
public IHttpActionResult get_tipo_notificacion(int id){
var obj = data().FirstOrDefault((o) => o.tntf_idtiponotif == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_tipo_notificacion(tipo_notificacion obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_tipo_notificacion.insert_tipo_notificacion(obj)){
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
 public IHttpActionResult update_tipo_notificacion(tipo_notificacion obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_tipo_notificacion.update_tipo_notificacion(obj)){
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
