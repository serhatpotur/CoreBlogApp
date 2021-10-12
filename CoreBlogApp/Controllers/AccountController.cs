using Business.Concrate;
using Business.ValidationRules.FluentValidation;
using DataAccess.EntityFramework;
using Entity.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.Controllers
{
    public class AccountController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        WriterValidator validationRules = new WriterValidator();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Writer writer)
        {
            writerManager.GetWriterMailPassword(writer.WriterMail, writer.WriterPassword);
            return RedirectToAction("Index", "Blog");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer writer)
        {
            ValidationResult result = validationRules.Validate(writer);
            if (result.IsValid)
            {

                writer.WriterStatus = true;
                writerManager.Add(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(writer);
            }
        }
    }
}
