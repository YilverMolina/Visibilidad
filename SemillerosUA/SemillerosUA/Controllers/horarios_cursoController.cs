using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class horarios_cursoController : ApiController{
horarios_curso obj_horarios_curso= new horarios_curso();
public horarios_curso[] data(){
DataTable dt = obj_horarios_curso.get_horarios_curso();
DataRow row;
horarios_curso[] horarios_cursos = null;
if (dt.Rows.Count > 0){
horarios_cursos = new horarios_curso[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
horarios_cursos[i]= new horarios_curso(Convert.ToInt64(row["hcrs_idhorario"].ToString()),row["hcrs_dia"].ToString(),row["hcrs_horainicio"].ToString(),row["hcrs_horafin"].ToString(),row["hcrs_estado"].ToString(),Convert.ToInt32(row["curs_idcurso"].ToString()));
}
}
return horarios_cursos;
}
public IHttpActionResult get_horarios_curso(){
return Json(obj_horarios_curso.get_horarios_curso());
}
public IHttpActionResult get_horarios_curso(int id){
var obj = data().FirstOrDefault((o) => o.hcrs_idhorario == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_horarios_curso(horarios_curso obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_horarios_curso.insert_horarios_curso(obj)){
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
 public IHttpActionResult update_horarios_curso(horarios_curso obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_horarios_curso.update_horarios_curso(obj)){
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
