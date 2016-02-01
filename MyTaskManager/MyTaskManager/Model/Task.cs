using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskManager.Model
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan EllapsedTime { get; set; }

        public string ID { get; }

        public Task(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            ID = Guid.NewGuid().ToString();
        }

        public Task(string title)
        {
            this.Title = title;
            ID = Guid.NewGuid().ToString();
        }
    }
}
