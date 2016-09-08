using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class semilleroController : ApiController{
semillero obj_semillero= new semillero();
public semillero[] data(){
DataTable dt = obj_semillero.get_semillero();
DataRow row;
semillero[] semilleros = null;
if (dt.Rows.Count > 0){
semilleros = new semillero[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
semilleros[i]= new semillero(Convert.ToInt32(row["smlr_idsemillero"].ToString()),row["smlr_nombre"].ToString(),row["smlr_descripcion"].ToString(),row["smlr_rutalogo"].ToString(),row["smlr_mision"].ToString(),row["smlr_vision"].ToString(),row["smlr_ruta"].ToString(),Convert.ToInt32(row["griv_idgrupoinv"].ToString()));
}
}
return semilleros;
}
public IHttpActionResult get_semillero(){
return Json(obj_semillero.get_semillero());
}
public IHttpActionResult get_semillero(int id){
var obj = data().FirstOrDefault((o) => o.smlr_idsemillero == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_semillero(semillero obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_semillero.insert_semillero(obj)){
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
 public IHttpActionResult update_semillero(semillero obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_semillero.update_semillero(obj)){
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
