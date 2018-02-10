using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.Models.ViewModels;

namespace WebApplication.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Random()
        {
            var customers = new List<Customer>
            {
                    new Customer  { Name = "John Smith"},
                    new Customer  { Name = "Mary Williams"}
            };

            var viewModel = new RandomCustomerViewModel
            {
                Customers = customers
            };
                
            
            return  View(viewModel);
        }
    }
}