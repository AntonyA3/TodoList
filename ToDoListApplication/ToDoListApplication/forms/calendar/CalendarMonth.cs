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

namespace ToDoListApplication.forms
{
    public partial class CalendarMonth : UserControl
    {
        private int year;
        private int month;
        private List<Button> day_cells;
        public CalendarMonth()
        {
            InitializeComponent();

            this.day_cells = new List<Button>()
            {
                day_1,
                day_2,
                day_3,
                day_4,
                day_5,
                day_6,
                day_7,
                day_8,
                day_9,
                day_10,
                day_11,
                day_12,
                day_13,
                day_14,
                day_15,
                day_16,
                day_17,
                day_18,
                day_19,
                day_20,
                day_21,
                day_22,
                day_23,
                day_24,
                day_25,
                day_26,
                day_27,
                day_28,
                day_29,
                day_30,
                day_31,
                day_32,
                day_33,
                day_34,
                day_35,
                day_36,
                day_37,
                day_38,
                day_39,
                day_40,
                day_41,
                day_42
            };
            
            

        }

        public Button ToYearButton { get { return this.to_year_button; } }
        public Button ToPreviousMonthButton { get { return this.to_previous_month_button; } }
        public Button ToNextMonthButton { get { return this.to_next_month_button; } }

        public int Year {
            get {

                return this.year;
            }
            set {
                this.year = value;


            }
        }

        public int Month
        {
            get {
                return this.month;
            }
            set {
                this.month = value;

            }
        }

        private DateTime dateSelected;
        public DateTime DateSelected{ 
            get {
                return this.dateSelected;
            }
            set {
                this.dateSelected = value;
            }
        }

        public void UpdateDateLabel() {
            this.to_year_button.Text = this.year + " - " + MonthShortDate(this.month);
           
        }

        private string MonthShortDate(int month) {
            var dates = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
            return dates[month - 1];
        }
        public void UpdateDateButtons()
        {
            int dotw =(int)new DateTime(this.year, this.month, 1).DayOfWeek;
            
            if (dotw == 0) {
                dotw = 7;
            }
            var dateOffset = new DateTime(this.year, this.month, 1).AddDays(-dotw);
            
            this.day_cells.ForEach(d =>
            {
                
                if (dateOffset.Year < 9999 || dateOffset.Month < 12 || dateOffset.Day < 31)
                {
                    dateOffset = dateOffset.AddDays(1);
                    d.Text = dateOffset.Day.ToString();
                    d.Tag = dateOffset;

                    if (dateOffset.Month != this.month)
                    {
                        d.Enabled = false;
                    }
                    else
                    {
                        d.Enabled = true;
                    }

                }
                else {

                    d.Text = "";
                }

            });
            

        }

        public List<Button> GetDayCells() {
            return this.day_cells;
        }
        private void CalendarMonth_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
