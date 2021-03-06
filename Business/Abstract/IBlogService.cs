using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetList();
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int id);
        Blog GetById(int id);
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);

    }
}
