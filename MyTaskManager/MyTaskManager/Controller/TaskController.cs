using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Controller
{
    public class TaskController
    {
        public List<Model.Task> taskList { get; }

        public TaskController()
        {
            taskList = new List<Model.Task>();
            //TODO read the tasks from a file or an XML...
            Model.Task task1 = new Model.Task("Task1");
            Model.Task task2 = new Model.Task("Task2", "Task2Description");
            taskList.Add(task1);
            taskList.Add(task2);
        }

        public string ValueMember()
        {
            return "ID";
        }
        public string DisplayMember()
        {
            return "Title";
        }
    }
}
