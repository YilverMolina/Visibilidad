using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class programas_semilleroController : ApiController{
programas_semillero obj_programas_semillero= new programas_semillero();
public programas_semillero[] data(){
DataTable dt = obj_programas_semillero.get_programas_semillero();
DataRow row;
programas_semillero[] programas_semilleros = null;
if (dt.Rows.Count > 0){
programas_semilleros = new programas_semillero[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
programas_semilleros[i]= new programas_semillero(Convert.ToInt32(row["prog_idprograma"].ToString()),Convert.ToInt32(row["smlr_idsemillero"].ToString()),row["prsm_estado"].ToString());
}
}
return programas_semilleros;
}
public IHttpActionResult get_programas_semillero(){
return Json(obj_programas_semillero.get_programas_semillero());
}
public IHttpActionResult get_programas_semillero(int id){
var obj = data().FirstOrDefault((o) => o.prog_idprograma == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_programas_semillero(programas_semillero obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_programas_semillero.insert_programas_semillero(obj)){
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
 public IHttpActionResult update_programas_semillero(programas_semillero obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_programas_semillero.update_programas_semillero(obj)){
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
