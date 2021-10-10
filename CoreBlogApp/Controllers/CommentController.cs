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
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment(Comment comment)
        {
            commentManager.Add(comment);
            return PartialView();
        }

        public PartialViewResult PartialCommentListByBlog(int id)
        {
            var values = commentManager.GetList(id);
            return PartialView(values);
        }
    }
}
