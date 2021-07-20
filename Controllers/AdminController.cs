using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentLoan.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentLoan.Controllers
{
    [Authorize(Roles = "Admins")]
    public class AdminController : Controller
    {
        // GET: /<controller>/
        private IRepositoryWrapper repository;
        public AdminController(IRepositoryWrapper _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
