using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication.model
{
    public class CalendarTask
    {
        public string TaskName { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public string TaskOccurence { get; set; }

        public override string ToString()
        {
            var name = "name: " + TaskName + "\n";
            var start_date = "Start: " + TaskStartDate.ToShortDateString() + "\n";
            var end_date = "End: " + TaskEndDate.ToShortDateString() + "\n";
            var occurence = "Occures: " + TaskOccurence + "\n";
            return "Task:[\n" + name + start_date + end_date + occurence + "]"; 

        }
    }
}
