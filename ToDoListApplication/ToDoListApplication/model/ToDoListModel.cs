using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication.model
{
    public class ToDoListModel
    {
        List<CalendarTask> tasks;

        public ToDoListModel() {
            this.tasks = new List<CalendarTask>();
        }

        public List<CalendarTask> GetTasksByDate(DateTime date) {
            return this.tasks.AsEnumerable().Where(t => {
            return t.TaskStartDate.Year == date.Year &&
                t.TaskStartDate.Month == date.Month &&
                t.TaskStartDate.Day == date.Day;
                
            }).ToList();
          
        }

        public void AddTask(CalendarTask task) {
            this.tasks.Add(task);
        }

        public void RemoveTask(CalendarTask task) {
            this.tasks.Remove(task);
        }
    }
}
