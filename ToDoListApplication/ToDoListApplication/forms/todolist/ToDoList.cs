using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApplication.model;
using ToDoListApplication.forms.todolist;

namespace ToDoListApplication.forms
{
    public partial class ToDoList : UserControl
    {
        private List<CalendarTask> todayTask;
        private int todayTaskPage;
        private int todayPageLimit;
        private List<ToDoTask> todayTaskList;

        private List<CalendarTask> selectedDateTask;
        private int selectedDateTaskPage;
        private int selectedDatePageLimit;
        private List<ToDoTask> selectedDateTaskList;


        public ToDoList()
        {
            InitializeComponent();
            this.selectedDateTask = new List<CalendarTask>();
            this.todayTask = new List<CalendarTask>();

            this.todayTaskPage = 0;
            this.todayTaskList = new List<ToDoTask>()
            {
                task_1,
                task_2,
                task_3,
                task_4,
                task_5,
                task_6,
                task_7,
                task_8,
                task_9,
                task_10

            };

            this.selectedDateTaskList = new List<ToDoTask>() {
                task_1_s,
                task_2_s,
                task_3_s,
                task_4_s,
                task_5_S,
                task_6_s,
                task_7_s,
                task_8_s,
                task_9_s,
                task_10_s
            };
            
        }

        public TabPage GetTodayTab() {
            return this.today_tab;
        }
        public TabPage GetSelectedTab() {
            return this.selected_tab;
        }

        public TabControl GetTabPane()
        {
            return this.task1_;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toDoTask7_Load(object sender, EventArgs e)
        {

        }

        public void SetTodayTaskList(List<CalendarTask> lists)
        {
            this.todayTask = lists;
            this.todayTaskPage = 1;
            this.todayPageLimit = Math.Max(1, (int)Math.Ceiling(lists.Count / 10f));

            for (int i = (todayTaskPage - 1) * 10; i < todayTaskPage * 10; i++) {

                if (i < this.todayTask.Count) {
                    this.todayTaskList[i].SetTaskName(this.todayTask[i].TaskName);
                   
                }
            
            }
            this.today_page_label1.Text = this.todayTaskPage + " of " + todayPageLimit;
            this.today_page_label2.Text = this.todayTaskPage + " of " + todayPageLimit;



        }

        public void SetSelectedTasks(List<CalendarTask> lists)
        {
            this.selectedDateTask = lists;
            this.selectedDatePageLimit = Math.Max(1,(int)Math.Ceiling(lists.Count / 10f));
            this.selectedDateTaskPage = this.selectedDatePageLimit;

            for (int i = selectedDateTaskPage * 10; i < selectedDateTaskPage * 10 + 10; i++)
            {
                if (i < this.selectedDateTask.Count)
                {
                    this.selectedDateTaskList[i].SetTaskName(this.selectedDateTask[i].TaskName);
                }
                 
            }

        }

        
        public void AddTodayTask(CalendarTask task)
        {
            this.todayTask.Add(task);
        }

        private void today_page_label2_Click(object sender, EventArgs e)
        {

        }

        private void today_next_button_Click(object sender, EventArgs e)
        {
            if (this.todayTaskPage < todayPageLimit) { 
                this.todayTaskPage += 1;
                this.today_page_label1.Text = this.todayTaskPage + " of " + todayPageLimit;
                this.today_page_label2.Text = this.todayTaskPage + " of " + todayPageLimit;

                TodayTaskOnPage();
                this.today_page_label1.Text = this.todayTaskPage + " of " + todayPageLimit;
                this.today_page_label2.Text = this.todayTaskPage + " of " + todayPageLimit;

            
            }
            

        }

        private void TodayTaskOnPage()
        {
            this.todayTaskList.ForEach(t =>
            {
                t.SetTaskName("");
            });

            for (int i = (todayTaskPage - 1) * 10; i < todayTaskPage * 10; i++)
            {

                if (i < this.todayTask.Count)
                {
                    this.todayTaskList[i % 10].SetTaskName(this.todayTask[i].TaskName);

                }


            }
        }

        private void today_previous_button_Click(object sender, EventArgs e)
        {
            if (todayTaskPage > 1) { 
                this.todayTaskPage -= 1;
                this.today_page_label1.Text = this.todayTaskPage + " of " + todayPageLimit;
                this.today_page_label2.Text = this.todayTaskPage + " of " + todayPageLimit;
                TodayTaskOnPage();
            }
            


        }
        
    }
}
