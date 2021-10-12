using Business.Concrate;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogApp.ViewComponents.Blog
{
    public class GetLastBlogsByWriter : ViewComponent
    {

        BlogManager blogManager = new BlogManager(new EfBlogDal());
        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetBlogListByWriter(1);
            return View(values);
        }
    }
}
