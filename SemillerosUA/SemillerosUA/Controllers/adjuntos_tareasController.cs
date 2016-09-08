using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class adjuntos_tareasController : ApiController{
adjuntos_tareas obj_adjuntos_tareas= new adjuntos_tareas();
public adjuntos_tareas[] data(){
DataTable dt = obj_adjuntos_tareas.get_adjuntos_tareas();
DataRow row;
adjuntos_tareas[] adjuntos_tareass = null;
if (dt.Rows.Count > 0){
adjuntos_tareass = new adjuntos_tareas[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
adjuntos_tareass[i]= new adjuntos_tareas(Convert.ToInt64(row["adtr_idadjunto"].ToString()),row["adtr_fecha"].ToString(),row["adtr_estado"].ToString(),row["adtr_rutaarchivo"].ToString(),Convert.ToInt64(row["trea_idtarea"].ToString()));
}
}
return adjuntos_tareass;
}
public IHttpActionResult get_adjuntos_tareas(){
return Json(obj_adjuntos_tareas.get_adjuntos_tareas());
}
public IHttpActionResult get_adjuntos_tareas(int id){
var obj = data().FirstOrDefault((o) => o.adtr_idadjunto == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_adjuntos_tareas(adjuntos_tareas obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_adjuntos_tareas.insert_adjuntos_tareas(obj)){
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
 public IHttpActionResult update_adjuntos_tareas(adjuntos_tareas obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_adjuntos_tareas.update_adjuntos_tareas(obj)){
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
