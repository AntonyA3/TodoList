using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ToDoListApplication.forms
{

    public partial class Calendar : UserControl
    {
 
        public Calendar()
        {
            InitializeComponent();
           

            this.Controls.Add(calendar_year);
            this.Controls.Add(calendar_month);
            
            

            this.calendar_year.ToNextYearButton.Click += ToNextYearButton_Click;
            this.calendar_year.ToPreviousYearButton.Click += ToPreviousYearButton_Click;
            this.calendar_year.YearTextBox.TextChanged += YearTextBox_TextChanged;
            this.calendar_year.YearTextBox.KeyPress += YearTextBox_KeyPress;
            this.calendar_year.ShowYearTextBoxButton.Click += ShowYearTextBoxButton_Click;
            this.calendar_year.YearTextBox.SendToBack();
            this.calendar_year.ShowYearTextBoxButton.BringToFront();


            this.calendar_year.GetMonthButtons().ForEach(b =>
            {
                b.Click += MonthButton_Click;
            });
            this.calendar_year.BringToFront();
            this.calendar_year.Year = DateTime.Now.Year;


            this.calendar_month.ToYearButton.Click += ToYearButton_Click;
            this.calendar_month.ToNextMonthButton.Click += ToNextMonthButton_Click;
            this.calendar_month.ToPreviousMonthButton.Click += ToPreviousMonthButton_Click;
            this.calendar_month.GetDayCells().ForEach(d =>
            {
                d.Click += DayButton_Click;
            });
            this.calendar_month.SendToBack();



        }


        private void ShowYearTextBoxButton_Click(object sender, EventArgs e)
        {
            this.calendar_year.YearTextBox.Text = this.calendar_year.Year.ToString();
            
            this.calendar_year.ShowYearTextBoxButton.Visible = false;
            this.calendar_year.ShowYearTextBoxButton.SuspendLayout();
            this.calendar_year.YearTextBox.Visible = true;
            this.calendar_year.YearTextBox.ResumeLayout();


        }

        public CalendarMonth CalendarMonth { get { return this.calendar_month; } }
        public CalendarYear CalendarYear { get { return this.calendar_year; } }

        private void YearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((Keys)e.KeyChar == Keys.Enter) {
                if (this.calendar_year.YearTextBox.Text.Length == 0)
                {
                    this.calendar_year.Year = 1;
                }
                else if (int.Parse(this.calendar_year.YearTextBox.Text) < 1)
                {
                    this.calendar_year.Year = 1;

                }
                else if (int.Parse(this.calendar_year.YearTextBox.Text) > 9999)
                {
                    this.calendar_year.Year = 9999;
                }
                else
                {
                    this.calendar_year.Year = int.Parse(this.calendar_year.YearTextBox.Text);
                }
                this.calendar_year.ShowYearTextBoxButton.Visible = true;
                this.calendar_year.ShowYearTextBoxButton.ResumeLayout();
                this.calendar_year.YearTextBox.SuspendLayout();
                this.calendar_year.YearTextBox.Visible = false;
              
            }
            
        }


        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            var regex = "^\\d+$";
            var text = this.calendar_year.YearTextBox.Text;
            if (text.Length > 0) {
                if (!Regex.IsMatch(this.calendar_year.YearTextBox.Text, regex))
                {
                    this.calendar_year.YearTextBox.Text = text.Remove(text.Length - 1);
                }
            }
            
           
        }

        private DateTime selectedDate;
        public DateTime SelectedDate { 
            get {
                return this.selectedDate;
            }
            private set {
                this.selectedDate = value;
            }
        }
        private void DayButton_Click(object sender, EventArgs e)
        {

            var button = (Button)sender;
            var date = (DateTime)button.Tag;
            this.calendar_month.DateSelected = date;
            this.selectedDate = date;
        }

        private void MonthButton_Click(object sender, EventArgs e)
        {
            this.calendar_year.SendToBack();
            this.calendar_month.BringToFront();
            this.calendar_month.Year = this.calendar_year.Year;
            int index = this.calendar_year.GetMonthButtons().FindIndex(b =>
            {
                return b == sender;
            });
            this.calendar_month.Month = index + 1;
            this.calendar_month.UpdateDateLabel();
            this.calendar_month.UpdateDateButtons();



        }

        private void ToPreviousMonthButton_Click(object sender, EventArgs e)
        {
            var month = this.calendar_month.Month;
            var year = this.calendar_month.Year;
            if (month > 1 || year > 1) { 
                if (month == 1)
                {
                    this.calendar_month.Month = 12;
                    this.calendar_month.Year -= 1;
                    this.calendar_year.Year -= 1;
                }
                else {
                    this.calendar_month.Month -= 1;
                }
                this.calendar_month.UpdateDateLabel();
                this.calendar_month.UpdateDateButtons();
            }
            
            
        }

        private void ToNextMonthButton_Click(object sender, EventArgs e)
        {
            var month = this.calendar_month.Month;
            var year = this.calendar_month.Year;
            if (month < 12 || year < 9999) { 
                if (month == 12)
                {
                    this.calendar_month.Month = 1;
                    this.calendar_month.Year += 1;
                    this.calendar_year.Year += 1;
                }
                else
                {
                    this.calendar_month.Month += 1;
                }
                this.calendar_month.UpdateDateLabel();
                this.calendar_month.UpdateDateButtons();
            }
            
        }

        private void ToPreviousYearButton_Click(object sender, EventArgs e)
        {
            this.calendar_year.DecrementYear();
        }

        private void ToNextYearButton_Click(object sender, EventArgs e)
        {
            this.calendar_year.IncrementYear();
           
        }

        private void ToYearButton_Click(object sender, EventArgs e)
        {
            this.calendar_month.SendToBack();

            this.calendar_year.BringToFront();
        }
    }
}
