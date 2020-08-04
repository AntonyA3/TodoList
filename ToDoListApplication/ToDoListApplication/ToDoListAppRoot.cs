using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApplication.model;

namespace ToDoListApplication
{
    public partial class ToDoListAppRoot : Form
    {
        private TodoListAppController todoListAppController;

        private DateTime today;
        public ToDoListAppRoot()
        {
            InitializeComponent();
            this.todo_list_task_editor.TaskAddButton.Click += TaskAddButton_Click;
            this.calendar1.CalendarMonth.GetDayCells().ForEach(c =>
            {
                c.Click += DayCell_Click;
            });

            this.toDoList1.GetTabPane().SelectedIndexChanged += ToDoListAppRoot_SelectedIndexChanged;

            this.today = DateTime.Now;
            this.toDoList1.Load += ToDoList1_Load;
         
        }

        private void ToDoList1_Load(object sender, EventArgs e)
        {
            this.toDoList1.SetTodayTaskList(this.todoListAppController.GetTasksByDate(today));
            

        }

        private void ToDoListAppRoot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DayCell_Click(object sender, EventArgs e)
        {
            this.toDoList1.SetSelectedTasks(todoListAppController.GetTasksByDate(this.calendar1.CalendarMonth.DateSelected));                 
        }

        public void SetController(TodoListAppController controller) {
            this.todoListAppController = controller;
        }

        private void TaskAddButton_Click(object sender, EventArgs e)
        {
            if (this.todoListAppController != null) {
                var taskEditor = this.todo_list_task_editor;
                this.todoListAppController.AddTodoListTask(taskEditor.TaskName, taskEditor.TaskDateTimeStart, taskEditor.TaskDateTimeEnd, taskEditor.TaskOccurence);
                if (taskEditor.TaskDateTimeStart == today) {
                    var task = new CalendarTask() {
                        TaskName = taskEditor.TaskName, 
                        TaskStartDate = taskEditor.TaskDateTimeStart, 
                        TaskEndDate = taskEditor.TaskDateTimeEnd, 
                        TaskOccurence = taskEditor.TaskOccurence
                    };
                    this.toDoList1.AddTodayTask(task);
                }
            
            }
            this.toDoList1.SetTodayTaskList(this.todoListAppController.GetTasksByDate(today));
            this.toDoList1.SetSelectedTasks(todoListAppController.GetTasksByDate(this.calendar1.CalendarMonth.DateSelected));

        }
    }
}
