using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class programaController : ApiController
    {
        programa obj_programa = new programa();
        
        public IHttpActionResult get_programa()
        {
            return Json(obj_programa.get_programa());
        }

        [HttpPost]
        public string insert_programa(programa obj)
        {
            if (obj_programa.insert_programa(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_programa(programa obj)
        {
            if (obj_programa.update_programa(obj))
            {
                return "U200";
            }
            else
            {
                return "U500";
            }
        }
    }
}
