using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class estudiantes_cursosController : ApiController{
estudiantes_cursos obj_estudiantes_cursos= new estudiantes_cursos();
public estudiantes_cursos[] data(){
DataTable dt = obj_estudiantes_cursos.get_estudiantes_cursos();
DataRow row;
estudiantes_cursos[] estudiantes_cursoss = null;
if (dt.Rows.Count > 0){
estudiantes_cursoss = new estudiantes_cursos[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
estudiantes_cursoss[i]= new estudiantes_cursos(Convert.ToInt64(row["escr_idestcursos"].ToString()),Convert.ToInt64(row["user_idusuario"].ToString()),Convert.ToInt32(row["curs_idcurso"].ToString()),row["escr_fecharegistro"].ToString(),row["escr_fechaaprobado"].ToString(),row["escr_fechacancelado"].ToString(),row["escr_estado"].ToString());
}
}
return estudiantes_cursoss;
}
public IHttpActionResult get_estudiantes_cursos(){
return Json(obj_estudiantes_cursos.get_estudiantes_cursos());
}
public IHttpActionResult get_estudiantes_cursos(int id){
var obj = data().FirstOrDefault((o) => o.escr_idestcursos == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_estudiantes_cursos(estudiantes_cursos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_estudiantes_cursos.insert_estudiantes_cursos(obj)){
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
 public IHttpActionResult update_estudiantes_cursos(estudiantes_cursos obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_estudiantes_cursos.update_estudiantes_cursos(obj)){
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
