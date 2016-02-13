using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyTaskManager.Model
{
    public class Task
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan EllapsedTime { get; set; }

        public string ID { get; set; }

        public Task(){}

        public Task(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreationDate = DateTime.Now;

            this.EllapsedTime = new TimeSpan();
            ID = Guid.NewGuid().ToString();
        }

        public Task(string title)
        {
            this.Title = title;
            this.Description = "";
            this.CreationDate = DateTime.Now;
            this.EllapsedTime = new TimeSpan();
            ID = Guid.NewGuid().ToString();
        }
    }
}
