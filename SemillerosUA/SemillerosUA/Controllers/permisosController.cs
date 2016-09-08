using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class permisosController : ApiController{
permisos obj_permisos= new permisos();
public permisos[] data(){
DataTable dt = obj_permisos.get_permisos();
DataRow row;
permisos[] permisoss = null;
if (dt.Rows.Count > 0){
permisoss = new permisos[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
permisoss[i]= new permisos(Convert.ToInt32(row["prms_idpermiso"].ToString()),row["prms_nombrepermiso"].ToString(),row["prms_icono"].ToString());
}
}
return permisoss;
}
public IHttpActionResult get_permisos(){
return Json(obj_permisos.get_permisos());
}
public IHttpActionResult get_permisos(int id){
var obj = data().FirstOrDefault((o) => o.prms_idpermiso == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_permisos(permisos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_permisos.insert_permisos(obj)){
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
 public IHttpActionResult update_permisos(permisos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_permisos.update_permisos(obj)){
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
