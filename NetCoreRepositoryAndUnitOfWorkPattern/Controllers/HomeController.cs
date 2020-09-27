using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Dapper;
using NetCoreRepositoryAndUnitOfWorkPattern.Data.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Models;
using NetCoreRepositoryAndUnitOfWorkPattern.Service.Services;

namespace NetCoreRepositoryAndUnitOfWorkPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerService _customerService;
        private readonly IUserService _userService;
        private readonly IDapper _dapper;

        public HomeController(ILogger<HomeController> logger, ICustomerService customerService, IUserService userService, IDapper dapper)
        {
            _logger = logger;
            _customerService = customerService;
            _userService = userService;
            _dapper = dapper;
        }

        public  IActionResult Index()
        {
            /*var allCustomer = _customerService.GetAllCustomer();
            var first = allCustomer.FirstOrDefault();
            first.FirstName = "monir";
            _customerService.UpdateCustomer(first);*/

            /*var allCustomer = _userService.GetAllUsers();
              var first = allCustomer.FirstOrDefault();
              first.UserName = "monir";
              _userService.UpdateUser(first);*/

            //var user =  _customerService.Add(new Customer() {FirstName = "abc"});
            var user =  _customerService.Add(new Customer() {FirstName = "abc",Age = 10,LastName = "sadfa"});
            //var customer = _dapper.Get<Customer>("select * from Customer");
            //_dapper.Insert<Customer>("insert into Customer (Id,FirstName) Values ('2','monira')");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
