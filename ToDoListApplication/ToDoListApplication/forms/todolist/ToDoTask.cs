﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApplication.forms.todolist
{
    public partial class ToDoTask : UserControl
    {
        public ToDoTask()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetTaskName(string value) {
            this.label1.Text = value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
