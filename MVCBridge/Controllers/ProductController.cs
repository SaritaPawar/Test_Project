using MVCBridge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCBridge.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            IEnumerable<MVCProductModel> ProdLst;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Product").Result;
            ProdLst=response.Content.ReadAsAsync<IEnumerable<MVCProductModel>>().Result;

            return View(ProdLst);
        }

        public ActionResult AddorEdit( int id=0)
        {
            if (id == 0)
                return View(new MVCProductModel());
            else {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Product/" +id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MVCProductModel>().Result);
            
            }
        }

        [HttpPost]
        public ActionResult AddorEdit( MVCProductModel prod)
        {
            if (prod.ID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Product", prod).Result;
            }
            else {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Product/"+prod.ID,prod).Result;
            
            }
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int ID)
        {

            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Product/" + ID.ToString()).Result;

            return RedirectToAction("Index");

        }
	}
}