using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningForms.Controllers
{
    public class FormController : Controller
    {

        // GET: Form
        public ActionResult Index()
        {
            return View();
        }


        //Weakly typed synchronous form
        [HttpPost]
        public ActionResult FormOne(string textBoxStringData, int textBoxIntData, string checkboxData)
        {
            //redirects to a new page after receiving the form's values
            return RedirectToAction("NewPage");
        }


        // Strongly-typed sychnronous form
        [HttpPost]
        public void FormTwo(Models.FormData formData)
        {
            //Do something with formData
        }


        // Strongly-typed asynchronous form
        [HttpPost]
        public void FormThree(Models.FormData formData)
        {
            //Do something with formData
        }


        // jQuery AJAX post
        [HttpPost]
        public void FormFour(Models.FormData formData)
        {
            //Do something with formData
        }


        // Called by FormOne 
        public ActionResult NewPage()
        {
            return View();
        }
    }
}