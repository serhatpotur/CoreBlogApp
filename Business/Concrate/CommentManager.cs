using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetList();
        }
        public List<Comment> GetList(int id)
        {
            return _commentDal.GetList(x => x.BlogID == id);
        }
    }
}
