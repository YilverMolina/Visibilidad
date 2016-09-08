using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace CongresoTIC.Controllers {
public class noticiaController : ApiController{
noticia obj_noticia= new noticia();
public noticia[] data(){
DataTable dt = obj_noticia.get_noticia();
DataRow row;
noticia[] noticias = null;
if (dt.Rows.Count > 0){
noticias = new noticia[dt.Rows.Count];
for (int i = 0; i < dt.Rows.Count; i++){
row = dt.Rows[i];
noticias[i]= new noticia(Convert.ToInt64(row["ncia_idnoticia"].ToString()),row["ncia_titulo"].ToString(),row["ncia_rutaimagen"].ToString(),row["ncia_descripcion"].ToString(),row["ncia_fechapublicacion"].ToString(),row["ncia_mostrardesde"].ToString(),row["ncia_mostrarhasta"].ToString(),row["ncia_estado"].ToString(),Convert.ToInt32(row["smlr_idsemillero"].ToString()),Convert.ToInt64(row["user_idusuario"].ToString()),row["ncia_linkvideo"].ToString(),Convert.ToInt32(row["tntc_idtipo_noticia"].ToString()),row["ncia_rutaadjunto"].ToString());
}
}
return noticias;
}
public IHttpActionResult get_noticia(){
return Json(obj_noticia.get_noticia());
}
public IHttpActionResult get_noticia(int id){
var obj = data().FirstOrDefault((o) => o.ncia_idnoticia == id);
if (obj != null){
return Ok(obj);
}
else {
return NotFound();
}
}
 public IHttpActionResult insert_noticia(noticia obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_noticia.insert_noticia(obj)){
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
 public IHttpActionResult update_noticia(noticia obj){
if (!ModelState.IsValid){
return BadRequest(ModelState);
}
else{
if (obj_noticia.update_noticia(obj)){
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
