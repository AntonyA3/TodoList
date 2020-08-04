namespace ToDoListApplication.forms
{
    partial class ToDoListTaskEditor
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
            this.add_task_button = new System.Windows.Forms.Button();
            this.task_interval_choice_box = new System.Windows.Forms.ComboBox();
            this.task_start_date_selection = new System.Windows.Forms.DateTimePicker();
            this.task_name_text_box = new System.Windows.Forms.TextBox();
            this.task_end_date_selection = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_task_button
            // 
            this.add_task_button.Location = new System.Drawing.Point(186, 163);
            this.add_task_button.Name = "add_task_button";
            this.add_task_button.Size = new System.Drawing.Size(75, 23);
            this.add_task_button.TabIndex = 1;
            this.add_task_button.Text = "Add Task";
            this.add_task_button.UseVisualStyleBackColor = true;
            // 
            // task_interval_choice_box
            // 
            this.task_interval_choice_box.FormattingEnabled = true;
            this.task_interval_choice_box.Items.AddRange(new object[] {
            "Once",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.task_interval_choice_box.Location = new System.Drawing.Point(186, 43);
            this.task_interval_choice_box.Name = "task_interval_choice_box";
            this.task_interval_choice_box.Size = new System.Drawing.Size(122, 21);
            this.task_interval_choice_box.TabIndex = 4;
            this.task_interval_choice_box.SelectedIndexChanged += new System.EventHandler(this.task_interval_choice_box_SelectedIndexChanged);
            // 
            // task_start_date_selection
            // 
            this.task_start_date_selection.Location = new System.Drawing.Point(186, 83);
            this.task_start_date_selection.Name = "task_start_date_selection";
            this.task_start_date_selection.Size = new System.Drawing.Size(177, 20);
            this.task_start_date_selection.TabIndex = 5;
            // 
            // task_name_text_box
            // 
            this.task_name_text_box.Location = new System.Drawing.Point(186, 3);
            this.task_name_text_box.Name = "task_name_text_box";
            this.task_name_text_box.Size = new System.Drawing.Size(121, 20);
            this.task_name_text_box.TabIndex = 6;
            this.task_name_text_box.TextChanged += new System.EventHandler(this.task_name_text_box_TextChanged);
            // 
            // task_end_date_selection
            // 
            this.task_end_date_selection.Location = new System.Drawing.Point(186, 123);
            this.task_end_date_selection.Name = "task_end_date_selection";
            this.task_end_date_selection.Size = new System.Drawing.Size(177, 20);
            this.task_end_date_selection.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.add_task_button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.task_name_text_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.task_end_date_selection, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.task_interval_choice_box, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.task_start_date_selection, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 202);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "end date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Task";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Re-Occurence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "start date";
            // 
            // ToDoListTaskEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ToDoListTaskEditor";
            this.Size = new System.Drawing.Size(458, 239);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_task_button;
        private System.Windows.Forms.ComboBox task_interval_choice_box;
        private System.Windows.Forms.DateTimePicker task_start_date_selection;
        private System.Windows.Forms.TextBox task_name_text_box;
        private System.Windows.Forms.DateTimePicker task_end_date_selection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
