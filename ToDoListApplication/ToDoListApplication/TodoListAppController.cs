using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApplication.model;

namespace ToDoListApplication
{
    public class TodoListAppController
    {
        ToDoListModel model = new ToDoListModel();
        public void AddTodoListTask(string name, DateTime startTime, DateTime endTime, string taskOccurence) {
            var task = new CalendarTask
            {
                TaskName = name,
                TaskStartDate = startTime,
                TaskEndDate = endTime,
                TaskOccurence = taskOccurence
            };
            model.AddTask(task);

        }

        public List<CalendarTask> GetTasksByDate(DateTime date) {
            return model.GetTasksByDate(date);
        }

    }
}
