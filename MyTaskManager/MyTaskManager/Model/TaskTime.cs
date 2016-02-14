using System;

namespace MyTaskManager.Model
{
    public class TaskTime
    {

        public int ID { get; set; }

        public string TaskID { get; set; }
        public DateTime StartTime{get; set;}

        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return ID + " " + TaskID + " " + StartTime.ToString() + " " + EndTime.ToString();
        }

    }
}