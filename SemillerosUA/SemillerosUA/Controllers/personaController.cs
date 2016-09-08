using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class personaController : ApiController{
persona obj_persona= new persona();
public persona[] data(){
DataTable dt = obj_persona.get_persona();
DataRow row;
persona[] personas = null;
if (dt.Rows.Count > 0){
personas = new persona[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
personas[i]= new persona(Convert.ToInt64(row["idpersona"].ToString()),Convert.ToInt64(row["ndocumento"].ToString()),row["nombres"].ToString(),row["apellidos"].ToString(),Convert.ToInt64(row["telefono"].ToString()),row["correo"].ToString(),Convert.ToInt32(row["fk_idprograma"].ToString()),Convert.ToInt32(row["semestre"].ToString()));
}
}
return personas;
}
public IHttpActionResult get_persona(){
return Json(obj_persona.get_persona());
}
public IHttpActionResult get_persona(int id){
var obj = data().FirstOrDefault((o) => o.idpersona == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_persona(persona obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_persona.insert_persona(obj)){
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
 public IHttpActionResult update_persona(persona obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_persona.update_persona(obj)){
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
