using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Query
{
    public class InsertNewTask:Query
    {
        private readonly string INSERT_NEW_TASK_QUERY = "insert into TASKS(ID, TITLE, DESCRIPTION, CREATION_DATE) VALUES('{0}', '{1}', '{2}', '{3}')";
        public InsertNewTask(Model.Task task)
        {
            query = string.Format(INSERT_NEW_TASK_QUERY, task.ID, task.Title, task.Description, task.CreationDate.ToString());
        }
    }
}
