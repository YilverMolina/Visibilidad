using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class nivelController : ApiController{
nivel obj_nivel= new nivel();
public nivel[] data(){
DataTable dt = obj_nivel.get_nivel();
DataRow row;
nivel[] nivels = null;
if (dt.Rows.Count > 0){
nivels = new nivel[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
nivels[i]= new nivel(Convert.ToInt32(row["nvel_idnivel"].ToString()),row["nvel_nombre"].ToString(),row["nvel_descripcion"].ToString(),row["nvel_estado"].ToString());
}
}
return nivels;
}
public IHttpActionResult get_nivel(){
return Json(obj_nivel.get_nivel());
}
public IHttpActionResult get_nivel(int id){
var obj = data().FirstOrDefault((o) => o.nvel_idnivel == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_nivel(nivel obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_nivel.insert_nivel(obj)){
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
 public IHttpActionResult update_nivel(nivel obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_nivel.update_nivel(obj)){
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
