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
    public partial class CalendarYear : UserControl
    {
        private int year;
        private List<Button> month_buttons;
        public CalendarYear()
        {
            InitializeComponent();
            this.month_buttons = new List<Button>() { 
                this.january_button,
                this.february_button,
                this.march_button,
                this.april_button,
                this.may_button,
                this.june_button,
                this.july_button,
                this.august_button,
                this.september_button,
                this.october_button,
                this.november_button,
                this.december_button
            };
        }


        public Button ToPreviousYearButton { get { return this.to_previous_year_button; } }
        public Button ToNextYearButton { get { return this.to_next_year_button; } }
        public Button ShowYearTextBoxButton { get { return this.year_button; } }

        public List<Button> GetMonthButtons() { return this.month_buttons; }
        
        public int Year {
            get { return this.year; }
            set { if (value > 0 && value < 10000) {
                    this.year = value;
                    this.year_button.Text = this.year.ToString();

                }
            }
        }

        public TextBox YearTextBox { get { return this.year_text_box; } }

        public void IncrementYear() {
            if (this.year < 9999) {
                ++this.year;
                this.year_button.Text = this.year.ToString();
            }
        }

        public void DecrementYear() {
            if (this.year > 1) {
                --this.year;
                this.year_button.Text = this.year.ToString();

            }
        }

        private void year_label_Click(object sender, EventArgs e)
        {

        }
    }
}
