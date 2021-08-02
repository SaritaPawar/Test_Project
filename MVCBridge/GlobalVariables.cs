using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MVCBridge
{
    public static class GlobalVariables
    {
      public  static HttpClient WebApiClient = new HttpClient();
        
     static   GlobalVariables() {
         WebApiClient.BaseAddress = new Uri("http://localhost:59044/api/");
         //String ApiPath = HttpContext.Current.Server.MapPath(System.Web.Configuration.WebConfigurationManager.AppSettings["WebAPIPath"]);

             //WebApiClient.BaseAddress = new Uri("http://localhost:287/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}