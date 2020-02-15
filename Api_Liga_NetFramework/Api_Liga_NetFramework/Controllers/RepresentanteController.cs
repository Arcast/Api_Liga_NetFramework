using Services;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Api_Liga_NetFramework.Controllers
{
    //[Route("api/[controller]")]
    public class RepresentanteController : Controller
    {

        [HttpPost]
        //[Route("GuardarRepresentante")]
        public JsonResult Guardar( VM_RepresentanteLiga representanteLiga)
        {
            var resp = RepresentanteService.GuardarRepresentante(representanteLiga);
            if (resp) 
            {
                return Json(resp,JsonRequestBehavior.AllowGet);
            }
            else
            {
               return Json(resp, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
