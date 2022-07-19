using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Log4NetLogging.Controllers
{
    [System.Web.Http.RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        log4net.ILog logger = log4net.LogManager.GetLogger(typeof(EmployeeController));  //Declaring Log4Net  

        [System.Web.Http.Route("Message")]
        public string GetMessage()
        {
            //  https://gorest.co.in/public/v2/users
            logger.Error("Grade 4 method call");

            return "Grade 4 method call";
        }
    }
}