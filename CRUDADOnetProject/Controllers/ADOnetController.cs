using CRUDADOnetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDADOnetProject.Controllers
{
    public class ADOnetController : Controller
    {
        // GET: ADOnet
        public ActionResult ADOIndex()
        {
            return View();
        }
        public ActionResult SaveEmp(ADOModel model)
        {
            try
            {
                return Json(new { message = new ADOModel().SaveEmployee(model) }, JsonRequestBehavior.AllowGet);
            }

            catch (Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}