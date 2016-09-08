using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class proyectosController : ApiController{
proyectos obj_proyectos= new proyectos();
public proyectos[] data(){
DataTable dt = obj_proyectos.get_proyectos();
DataRow row;
proyectos[] proyectoss = null;
if (dt.Rows.Count > 0){
proyectoss = new proyectos[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
proyectoss[i]= new proyectos(Convert.ToInt32(row["proy_idproyecto"].ToString()),row["proy_nombre"].ToString(),row["proy_descripcion"].ToString(),row["proy_estado"].ToString(),Convert.ToInt32(row["smlr_idsemillero"].ToString()));
}
}
return proyectoss;
}
public IHttpActionResult get_proyectos(){
return Json(obj_proyectos.get_proyectos());
}
public IHttpActionResult get_proyectos(int id){
var obj = data().FirstOrDefault((o) => o.proy_idproyecto == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_proyectos(proyectos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_proyectos.insert_proyectos(obj)){
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
 public IHttpActionResult update_proyectos(proyectos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_proyectos.update_proyectos(obj)){
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
