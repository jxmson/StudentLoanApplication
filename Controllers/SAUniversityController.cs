using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentLoan.Models;
using StudentLoan.Models.ViewModels;
using StudentLoan.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentLoan.Controllers
{
    [Authorize(Roles = "Admins")]
    public class SAUniversityController : Controller
    {
        private readonly IRepositoryWrapper _repository;
        private string message{get;set;}

        public SAUniversityController(IRepositoryWrapper wrapper)
        {
            _repository = wrapper;
           
        }
        [AllowAnonymous]
        public IActionResult PriorityAreas()
        {
            ViewData["Message"] = message;
            return View(_repository.University.FindAll().OrderBy(p => p.Name));
        }
        [AllowAnonymous]
        public IActionResult Courses(int id, string search)
        {
            ViewData["CurrentFilter"] = search;

            if (search == null)
                search = "";

            SAUniversity uni = _repository.University.GetById(id);
            IEnumerable<SAUniCourse> i =_repository.University.GetVarsityCourseList(id,search);

            UniversityCoursesViewModel viewModel = new UniversityCoursesViewModel
            {
                Items = i,
                SAUniversity = uni
            };

                return View(viewModel);
        }
        
        public IActionResult Add()
        {
            List<SACourses> list = new List<SACourses>();
            list = _repository.Course.FindAll().ToList();
            ViewBag.List = list;
            return View();

        }
        [HttpPost]
        public IActionResult Add(SAUniversity varsity)
        {           
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.University.Create(varsity);
                    _repository.University.Save();
                    message = "University successfully added.";
                    return RedirectToAction("PriorityAreas");
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to add University. Try again and if the problem persists, see your system administrator.");
                }
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            List<SACourses> list = new List<SACourses>();
            list = _repository.Course.FindAll().ToList();
            ViewBag.List = list;
            var u = _repository.University.GetById(id);
            return View(u);
        }
        [HttpPost]
        public IActionResult Edit(SAUniversity varsity)
        {  
            
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.University.Update(varsity);                
                    _repository.University.Save();
                    message = "University successfully updated.";
                    return RedirectToAction("PriorityAreas");
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(varsity);
        }
 
        public IActionResult Delete(int id)
        {
            return View(_repository.University.GetById(id));
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteUni(SAUniversity varsity)
        {
            if(varsity !=null)
            {
                _repository.University.Delete(varsity);
                _repository.University.Save();
                message = "University successfully deleted.";
                return RedirectToAction("PriorityAreas");
            }
            else
            {
                ViewBag.ErrorMessage = "Unable to Delete university";
                return View(varsity);
            }
        }

    }
}
