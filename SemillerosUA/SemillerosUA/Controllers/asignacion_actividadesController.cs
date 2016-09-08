using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class asignacion_actividadesController : ApiController{
asignacion_actividades obj_asignacion_actividades= new asignacion_actividades();
public asignacion_actividades[] data(){
DataTable dt = obj_asignacion_actividades.get_asignacion_actividades();
DataRow row;
asignacion_actividades[] asignacion_actividadess = null;
if (dt.Rows.Count > 0){
asignacion_actividadess = new asignacion_actividades[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
asignacion_actividadess[i]= new asignacion_actividades(Convert.ToInt64(row["user_responsable"].ToString()),Convert.ToInt64(row["actv_idactividad"].ToString()),row["aact_estado"].ToString(),row["aact_fechaasignacion"].ToString(),row["aact_invitado"].ToString());
}
}
return asignacion_actividadess;
}
public IHttpActionResult get_asignacion_actividades(){
return Json(obj_asignacion_actividades.get_asignacion_actividades());
}
public IHttpActionResult get_asignacion_actividades(int id){
var obj = data().FirstOrDefault((o) => o.user_responsable == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_asignacion_actividades(asignacion_actividades obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_asignacion_actividades.insert_asignacion_actividades(obj)){
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
 public IHttpActionResult update_asignacion_actividades(asignacion_actividades obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_asignacion_actividades.update_asignacion_actividades(obj)){
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
