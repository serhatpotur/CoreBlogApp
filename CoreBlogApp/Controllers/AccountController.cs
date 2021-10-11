using Business.Concrate;
using DataAccess.EntityFramework;
using Entity.Concrate;
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

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer writer)
        {
            writer.WriterStatus = true;
            writerManager.Add(writer);
            return RedirectToAction("Index","Blog");
        }
    }
}
