using DataAbd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAbd.Controllers
{
    public class UserController : Controller
    {
        // we use Contructor
        private AppDbContext context;

        public UserController(AppDbContext _context)
        {
            context = _context;
        }
        // GET: EmployeeController
        public IActionResult Index()
        {
            return View();
        }

        //this is get all record Method
        public ActionResult GetData()
        {
            
            var emp = context.employees.ToList();
            return Json(new { data = emp });
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Employee employee , int id)
        {
            try
            {
                if(id!=0)
                {
                    context.employees.Add(employee);
                    context.SaveChanges();
                    return Json(new { success = true, message = "Saved Successfully!" });
                }
                else
                {
                    context.employees.Update(employee);
                    context.SaveChanges();
                    return Json(new { success = true, message = "Updated Successfully!" });
                }
               
            }
            catch (Exception ex)
            {
               
                throw;
            }
            
        }

        [HttpPost]

        public ActionResult Edit(Employee employee)
        {
            try
            {
                context.employees.Update(employee);
                context.SaveChanges();
                return Json(new { success = true, message = "Updated Successfully!" });
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    } 
}
