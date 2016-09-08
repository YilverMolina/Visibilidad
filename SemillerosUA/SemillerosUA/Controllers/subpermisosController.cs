using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class subpermisosController : ApiController{
subpermisos obj_subpermisos= new subpermisos();
public subpermisos[] data(){
DataTable dt = obj_subpermisos.get_subpermisos();
DataRow row;
subpermisos[] subpermisoss = null;
if (dt.Rows.Count > 0){
subpermisoss = new subpermisos[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
subpermisoss[i]= new subpermisos(Convert.ToInt32(row["spms_idsubpermiso"].ToString()),row["spms_nombresubpermiso"].ToString(),row["spms_icono"].ToString(),row["spms_url"].ToString(),Convert.ToInt32(row["prms_fk_idpermiso"].ToString()));
}
}
return subpermisoss;
}
public IHttpActionResult get_subpermisos(){
return Json(obj_subpermisos.get_subpermisos());
}
public IHttpActionResult get_subpermisos(int id){
var obj = data().FirstOrDefault((o) => o.spms_idsubpermiso == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_subpermisos(subpermisos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_subpermisos.insert_subpermisos(obj)){
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
 public IHttpActionResult update_subpermisos(subpermisos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_subpermisos.update_subpermisos(obj)){
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
