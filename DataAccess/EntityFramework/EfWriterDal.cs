using DataAccess.Abstract;
using DataAccess.Concrate;
using DataAccess.Repositories;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        Context context = new Context();
        public Writer GetWriterMailPassword(string mail, string password)
        {
            return context.Writers.Where(x => x.WriterMail == mail && x.WriterPassword == password).FirstOrDefault();
        }
    }
}
