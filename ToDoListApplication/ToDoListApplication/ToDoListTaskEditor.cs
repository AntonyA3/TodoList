using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApplication.forms
{
    public partial class ToDoListTaskEditor : UserControl
    {
        
        public ToDoListTaskEditor()
        {
            InitializeComponent();
            this.add_task_button.Enabled = false;
            this.add_task_button.Click += Add_task_button_Click;
            this.task_interval_choice_box.SelectedIndex = 0;
            this.task_end_date_selection.Enabled = false;
        }

        public string TaskName { get; set; }
        public DateTime TaskDateTimeStart { get; set; }
        public DateTime TaskDateTimeEnd { get; set; }
        public string TaskOccurence { get; set; }



        public Button TaskAddButton { get { return this.add_task_button; } }
        private void Add_task_button_Click(object sender, EventArgs e)
        {
            this.TaskName = this.task_name_text_box.Text;
            this.TaskDateTimeStart = this.task_start_date_selection.Value;
            this.TaskDateTimeEnd = this.task_end_date_selection.Value;
            this.TaskOccurence = (string)this.task_interval_choice_box.SelectedItem;

            this.task_name_text_box.Text = "";
            this.add_task_button.Enabled = false;
            
        }

        private void task_interval_choice_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(this.task_interval_choice_box.SelectedIndex == 0))
            {
                this.task_end_date_selection.Enabled = true;
            }
            else {
                this.task_end_date_selection.Enabled = false;
            }
        }

        private void task_name_text_box_TextChanged(object sender, EventArgs e)
        {
            if (this.task_name_text_box.TextLength < 1)
            {
                this.add_task_button.Enabled = false;
            }
            else {
                this.add_task_button.Enabled = true;
            }
        }
    }
}
