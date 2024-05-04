using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson36
{
    internal class MyTask
    {
        private string? taskName;
        private DateTime taskDateTime;
        private string? priority;
        public MyTask(string? taskName, DateTime taskDateTime, string? priority)
        {
            this.taskName = taskName;
            this.taskDateTime = taskDateTime;
            this.priority = priority;
        }
        public string getTaskName() => taskName!;
        public DateTime getTaskDateTime() => taskDateTime;
        public string getPriority() => priority!;
        public void setTaskName(string name) => this.taskName = name;
        public void setTaskDateTime(DateTime dt) => this.taskDateTime = dt;
        public void setPriority(string p) => this.priority = p;
    }
}
