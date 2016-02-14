using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Query
{
    public abstract class Query
    {
        protected string query;
        public string GetQuery()
        {
            return query;
        }
    }
}
