using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class lider_semilleroController : ApiController{
lider_semillero obj_lider_semillero= new lider_semillero();
public lider_semillero[] data(){
DataTable dt = obj_lider_semillero.get_lider_semillero();
DataRow row;
lider_semillero[] lider_semilleros = null;
if (dt.Rows.Count > 0){
lider_semilleros = new lider_semillero[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
lider_semilleros[i]= new lider_semillero(Convert.ToInt64(row["user_fk_idusuario"].ToString()),Convert.ToInt32(row["smlr_fk_idsemillero"].ToString()),row["lsml_fecha"].ToString(),row["lsml_estado"].ToString());
}
}
return lider_semilleros;
}
public IHttpActionResult get_lider_semillero(){
return Json(obj_lider_semillero.get_lider_semillero());
}
public IHttpActionResult get_lider_semillero(int id){
var obj = data().FirstOrDefault((o) => o.user_fk_idusuario == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_lider_semillero(lider_semillero obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_lider_semillero.insert_lider_semillero(obj)){
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
 public IHttpActionResult update_lider_semillero(lider_semillero obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_lider_semillero.update_lider_semillero(obj)){
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
