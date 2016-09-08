using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class integrantes_grupoController : ApiController{
integrantes_grupo obj_integrantes_grupo= new integrantes_grupo();
public integrantes_grupo[] data(){
DataTable dt = obj_integrantes_grupo.get_integrantes_grupo();
DataRow row;
integrantes_grupo[] integrantes_grupos = null;
if (dt.Rows.Count > 0){
integrantes_grupos = new integrantes_grupo[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
integrantes_grupos[i]= new integrantes_grupo(Convert.ToInt64(row["igrp_idintegrantes"].ToString()),Convert.ToInt64(row["grup_idgrupo"].ToString()),Convert.ToInt64(row["user_idusuario"].ToString()),row["igrp_estado"].ToString());
}
}
return integrantes_grupos;
}
public IHttpActionResult get_integrantes_grupo(){
return Json(obj_integrantes_grupo.get_integrantes_grupo());
}
public IHttpActionResult get_integrantes_grupo(int id){
var obj = data().FirstOrDefault((o) => o.igrp_idintegrantes == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_integrantes_grupo(integrantes_grupo obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_integrantes_grupo.insert_integrantes_grupo(obj)){
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
 public IHttpActionResult update_integrantes_grupo(integrantes_grupo obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_integrantes_grupo.update_integrantes_grupo(obj)){
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
