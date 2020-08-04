namespace ToDoListApplication.forms
{
    partial class Calendar
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendar_year = new ToDoListApplication.forms.CalendarYear();
            this.calendar_month = new ToDoListApplication.forms.CalendarMonth();
            this.SuspendLayout();
            // 
            // calendar_year
            // 
            this.calendar_year.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar_year.Location = new System.Drawing.Point(0, 3);
            this.calendar_year.Name = "calendar_year";
            this.calendar_year.Size = new System.Drawing.Size(633, 462);
            this.calendar_year.TabIndex = 1;
            this.calendar_year.Year = 0;
            // 
            // calendar_month
            // 
            this.calendar_month.DateSelected = new System.DateTime(((long)(0)));
            this.calendar_month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar_month.Location = new System.Drawing.Point(0, 0);
            this.calendar_month.Month = 0;
            this.calendar_month.Name = "calendar_month";
            this.calendar_month.Size = new System.Drawing.Size(633, 465);
            this.calendar_month.TabIndex = 0;
            this.calendar_month.Year = 0;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calendar_year);
            this.Controls.Add(this.calendar_month);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(633, 465);
            this.ResumeLayout(false);

        }

        #endregion

        private CalendarMonth calendar_month;
        private CalendarYear calendar_year;
    }
}
