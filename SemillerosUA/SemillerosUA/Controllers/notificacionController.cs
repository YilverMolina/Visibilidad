using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class notificacionController : ApiController{
notificacion obj_notificacion= new notificacion();
public notificacion[] data(){
DataTable dt = obj_notificacion.get_notificacion();
DataRow row;
notificacion[] notificacions = null;
if (dt.Rows.Count > 0){
notificacions = new notificacion[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
notificacions[i]= new notificacion(Convert.ToInt64(row["notf_idnotificacion"].ToString()),row["notf_fecha"].ToString(),row["notf_recibida"].ToString(),Convert.ToInt64(row["user_emisor"].ToString()),Convert.ToInt64(row["user_destinatario"].ToString()),Convert.ToInt32(row["tntf_idtiponotif"].ToString()));
}
}
return notificacions;
}
public IHttpActionResult get_notificacion(){
return Json(obj_notificacion.get_notificacion());
}
public IHttpActionResult get_notificacion(int id){
var obj = data().FirstOrDefault((o) => o.notf_idnotificacion == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_notificacion(notificacion obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_notificacion.insert_notificacion(obj)){
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
 public IHttpActionResult update_notificacion(notificacion obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_notificacion.update_notificacion(obj)){
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
