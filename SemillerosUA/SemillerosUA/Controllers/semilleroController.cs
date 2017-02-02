using SemillerosUA.Models.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
namespace SemillerosUA.Controllers
{
    public class semilleroController : ApiController
    {
        semillero obj_semillero = new semillero();


        public DataTable get_semillero()
        {
            return obj_semillero.get_semillero();
        }

        public IHttpActionResult get_semillero_programa(string id)
        {
            return Json(obj_semillero.get_semillero_programa(id));
        }

        public DataTable get_semillero_id(string id)
        {
            return obj_semillero.get_semillero_id(id);
        }
        public IHttpActionResult get_semillero_by_id(string id)
        {
            return Json(obj_semillero.get_semillero_id(id));
        }


        [HttpPost]
        public string insert_semillero(semillero obj)
        {
            if (obj_semillero.insert_semillero(obj))
            {
                return "I200";
            }
            else
            {
                return "I500";
            }
        }
        [HttpPost]
        public string update_semillero(semillero obj)
        {
            if (obj_semillero.update_semillero(obj))
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
