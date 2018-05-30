using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class HenryController : ApiController
    {

        public HttpResponseMessage Get()
        {

            List<Employee2> employeeList = new List<Employee2>();

            using (WebApiDbEntities dc = new WebApiDbEntities())
            {
                employeeList = dc.Employee2.OrderBy(x => x.FirstName).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, employeeList);
                return response;


            }

        }

    }
}
