using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Query
{
    public class SelectAllTasks:Query
    {
        private readonly string SELECT_ALL_TASKS_QUERY = "select ID, TITLE, DESCRIPTION, CAST(CREATION_DATE as TEXT) from TASKS";
        public SelectAllTasks()
        {
            query = SELECT_ALL_TASKS_QUERY;
        }
    }
}
