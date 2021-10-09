using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repositories;
using Entity.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        Context context = new Context();

        public List<Blog> GetListWithCategory()
        {
            return context.Blogs.Include(x => x.Category).ToList();
        }
    }
}
