using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class CustomerController : Controller
    {
        //This is an action method
        //each action method is going to correspond to one "URL" for our website
        //(if there are parameters in that URL, we can handle many values in one action method)
        public IActionResult Index()
        {
            //every action method's job is to fetch data/ push data/ whatever 
            //"action" is represented by this URL that the user is sending a request to
            //and then return some "result"
            // a result is something that ASP.NET Core can "render" into an HTTP response
            // within the MVC world, our results are either View Result or some kind of redirect result

            //views are the kind of result that renders into html
            //"VIEW()" is a helper method from the base class that looks for
            //a view matching the name of this action method for this controller
            return View();
        }
    }
}