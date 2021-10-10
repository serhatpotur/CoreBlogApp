using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        List<Comment> GetList();
        List<Comment> GetList(int id);

    }
}
