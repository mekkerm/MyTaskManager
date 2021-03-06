﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager.Model;
using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;

namespace MyTaskManager.Controller
{
    public class TaskController
    {
        public BindingList<Model.Task> taskList { get; }

        private static TaskController _Instance;

        private Model.Task runningTask = null;
        private Model.TaskTime runningTaskTime = null;
        private System.Timers.Timer taskTimer = null;

        private RefreshCallback callback;

        public static TaskController Instance{ get
            {
                if(_Instance == null)
                {
                    _Instance = new TaskController();
                }
                return _Instance;
            }
        }

        private TaskController()
        {
            taskList = new BindingList<Model.Task>();
            //TODO read the tasks from a file or an XML...
            //Model.Task task1 = new Model.Task("Task1");
            //Model.Task task2 = new Model.Task("Task2", "Task2Description");
            //Model.Task task3 = new Model.Task("Task3", "Task2Description");
            //Model.Task task4 = new Model.Task("Task4", "Task2Description");
            //Model.Task task5 = new Model.Task("Task5", "Task2Description");
            //Model.Task task6 = new Model.Task("Task6", "Task2Description");
            //taskList.Add(task1);
            //taskList.Add(task2);
            //taskList.Add(task3);
            //taskList.Add(task4);
            //taskList.Add(task5);
            //taskList.Add(task6);
            foreach (var task in DBController.Instance.GetSavedTasks())
            {
                taskList.Add(task);
            }
        }
        

        public string ValueMember()
        {
            return "ID";
        }
        public string DisplayMember()
        {
            return "Title";
        }

        public bool Add(Model.Task t)
        {
            var result = DBController.Instance.AddNewTask(t);
            if (result)
            {
                taskList.Add(t);
            }
            return result;
        }

        public Model.Task ActiveTask {
            get {
                return runningTask;
            }
        }

        /// <summary>
        /// Starts the given task!
        /// </summary>
        /// <param name="task">The task to start</param>
        /// <param name="control">The control object, which will be synced with the timer</param>
        /// <param name="callback">A callback function which will be called wheneber the given task have been modified</param>
        /// <returns>Return TRUE if the task has started</returns>
        public Boolean StartTask(Model.Task task, Control control, RefreshCallback callback)
        {
            if (runningTask != null) return false;

            this.callback = callback;

            runningTask = taskList.Where(t => t.ID == task.ID).First();
            taskTimer = new System.Timers.Timer();
            taskTimer.Interval = 1000;
            taskTimer.Elapsed += TaskTimer_Elapsed;
            taskTimer.SynchronizingObject = control;
            taskTimer.Start();

            runningTaskTime = new TaskTime();
            runningTaskTime.TaskID = runningTask.ID;
            runningTaskTime.StartTime = DateTime.Now;
            return true;
        }

        private void TaskTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            runningTask.EllapsedTime = runningTask.EllapsedTime.Add(new TimeSpan(0, 0, 1));
            Console.WriteLine(runningTask.EllapsedTime.ToString());
            if(callback!= null)
            {
                callback();
            }
        }

        public void StopTask()
        {
            if(taskTimer == null)
                return;

            taskTimer.Stop();
            taskTimer = null;
            runningTask = null;
            runningTaskTime.EndTime = DateTime.Now;

            var result = DBController.Instance.AddNewTaskTime(runningTaskTime);
            if (!result)
            {
                MessageBox.Show("error!!");
            }
        }

        public delegate void RefreshCallback();
        
    }
}
