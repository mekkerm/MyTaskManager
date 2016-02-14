using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Query
{
    public class InsertNewTaskTime:Query
    {
        private readonly string INSERT_NEW_TASKTIME_QUERY = "insert into TASKTIMES VALUES(NULL, '{0}', '{1}', '{2}')";
        public InsertNewTaskTime(Model.TaskTime taskTime)
        {
            query = string.Format(INSERT_NEW_TASKTIME_QUERY, taskTime.TaskID, taskTime.StartTime.ToString(), taskTime.EndTime.ToString());
        }
    }
}
