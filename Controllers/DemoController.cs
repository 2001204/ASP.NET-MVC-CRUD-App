using Azure.Core;
using Microsoft.AspNetCore.Mvc;

namespace MyMVCDemo1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DemoRazor() 
        {
            //ViewData    : It store into Dictionary key value pair 
            //ViewBag
            //here Cdac is key 
            ViewData["Cdac"] = "CDAC";

            //here Address is key and we can use in cdhtml page by @View.Address and whole address you can store in one key
            ViewData["Address1"] = new Address { Id = 1, City = "Jalgaon", Streetname = "Bhusawal Road" };
            
            
             ViewBag.Address = new Address()
            {
                Id = 1,
                Streetname = "Bhusawal Road",
                City = "Jalgaon"
            };
            return View();
        }
        public IActionResult ShowDetails()
        {
            ViewBag.FirstName = "Dipak";
            ViewBag.LastName = "Wani";
            ViewBag.Add1 = new Address { Id = 101, City = "Mumbai", Streetname = "Jalgaon Road", Country = "India"  };
            return View(); 
        }

        public IActionResult PartialDemo()
        {
            return View();
        }

        public IActionResult MyMethod()   //not work
        {
            return View();
        }

        public IActionResult MyPartiaView() 
        {
            return PartialDemo();
        }
    }

    internal class Address
    {
        public Address()
        {

        }
        public int Id { get; set; }
        public string Streetname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
