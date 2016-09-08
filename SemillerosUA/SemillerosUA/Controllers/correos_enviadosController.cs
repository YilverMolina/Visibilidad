using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class correos_enviadosController : ApiController{
correos_enviados obj_correos_enviados= new correos_enviados();
public correos_enviados[] data(){
DataTable dt = obj_correos_enviados.get_correos_enviados();
DataRow row;
correos_enviados[] correos_enviadoss = null;
if (dt.Rows.Count > 0){
correos_enviadoss = new correos_enviados[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
correos_enviadoss[i]= new correos_enviados(Convert.ToInt32(row["crnv_idcorreoenviado"].ToString()),row["crnv_tipo"].ToString(),row["crnv_descripcion"].ToString(),row["crnv_estadoenvio"].ToString(),row["crnv_fechaenvio"].ToString(),Convert.ToInt32(row["smlr_idsemillero"].ToString()),Convert.ToInt64(row["user_destinatario"].ToString()));
}
}
return correos_enviadoss;
}
public IHttpActionResult get_correos_enviados(){
return Json(obj_correos_enviados.get_correos_enviados());
}
public IHttpActionResult get_correos_enviados(int id){
var obj = data().FirstOrDefault((o) => o.crnv_idcorreoenviado == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_correos_enviados(correos_enviados obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_correos_enviados.insert_correos_enviados(obj)){
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
 public IHttpActionResult update_correos_enviados(correos_enviados obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_correos_enviados.update_correos_enviados(obj)){
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
