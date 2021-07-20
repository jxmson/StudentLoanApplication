using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentLoan.Models;
using StudentLoan.Models.Entities;
using StudentLoan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Controllers
{
    public class ApplyController : Controller
    {
        private readonly IRepositoryWrapper _repository;

        public ApplyController(IRepositoryWrapper wrapper)
        {
            _repository = wrapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admins")]
        public IActionResult ApplicationDetails(int id)
        {

            return View(_repository.Application.GetById(id));
        }
        [Authorize(Roles="Admins")]
        public IActionResult List()
        {
            return View(_repository.Application.FindAll());
        }
        private void PopulateGender()
        {
            ViewBag.Gender = new SelectList(_repository.Gender.FindAll(), "GenderName", "GenderName",null);

        }
        private void PopulateOccupation()
        {
            ViewBag.Occupation = new SelectList(_repository.Occupation.FindAll(),"OccupationName", "OccupationName",null);
        }
        private void PopulateMarital()
        {
            ViewBag.Marital = new SelectList(_repository.MaritalStatus.FindAll(), "MaritlStatusName", "MaritlStatusName", null);

        }
        private void PopulateCourse()
        {
            ViewBag.Course = new SelectList(_repository.Course.FindAll(), "Course", "Course", null);
        }
        private void PopulateUni()
        {
            ViewBag.Uni = new SelectList(_repository.University.FindAll(), "Name", "Name", null);
        }

        [Authorize(Roles="Applicant")]
        public IActionResult Apply()
        {
            PopulateCourse();
            PopulateGender();
            PopulateMarital();
            PopulateOccupation();
            PopulateUni();

            return View();
        }
        [HttpPost]
        public IActionResult Apply(Application app)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Application.Create(app);
                    _repository.Application.Save();
                    return RedirectToAction("ApplicationComplete");
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to submit application. Try again and if the problem persists, send an email to nobody@example.com");
                }
            }

            PopulateCourse();
            PopulateGender();
            PopulateMarital();
            PopulateOccupation();
            PopulateUni();

            return View();
            
        }
        [HttpPost]
        public IActionResult Delete(Application app)
        {
            if (app != null)
            {

                _repository.Application.Delete(app);
                _repository.Application.Save();

                return RedirectToAction("List");
            }
            else
            {
                ViewBag.ErrorMessage = "Unable to Delete Application";
                return View(app);
            }
        }
                      
        public IActionResult  ApplicationComplete()
        {
            return View();
        }
    }
}
