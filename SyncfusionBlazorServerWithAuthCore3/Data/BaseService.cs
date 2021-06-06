using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncfusionBlazorServerWithAuthCore3.Data
{
    public class BaseService
    {
        protected Sql5040Site4nowNetContext dbcontext = new Sql5040Site4nowNetContext();
        public BaseService()
        {

        }
        public BaseService(Sql5040Site4nowNetContext DBContext)
        {
            dbcontext = DBContext;
        }
    }
}
