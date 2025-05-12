namespace EventSchedualingApp
{
    partial class SchedulerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.EventLst = new System.Windows.Forms.ListBox();
            this.EventInfoBox = new System.Windows.Forms.GroupBox();
            this.MinCmb = new System.Windows.Forms.ComboBox();
            this.minutesBeforeLbl = new System.Windows.Forms.Label();
            this.MinutesCmb = new System.Windows.Forms.ComboBox();
            this.ReminderChk = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLbl = new System.Windows.Forms.Label();
            this.HourCmb = new System.Windows.Forms.ComboBox();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.DescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.EventBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EventInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.monthCalendar.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // EventLst
            // 
            this.EventLst.FormattingEnabled = true;
            this.EventLst.ItemHeight = 20;
            this.EventLst.Location = new System.Drawing.Point(18, 306);
            this.EventLst.Name = "EventLst";
            this.EventLst.Size = new System.Drawing.Size(326, 124);
            this.EventLst.TabIndex = 1;
            this.EventLst.SelectedIndexChanged += new System.EventHandler(this.EventLst_SelectedIndexChanged);
            // 
            // EventInfoBox
            // 
            this.EventInfoBox.Controls.Add(this.MinCmb);
            this.EventInfoBox.Controls.Add(this.minutesBeforeLbl);
            this.EventInfoBox.Controls.Add(this.MinutesCmb);
            this.EventInfoBox.Controls.Add(this.ReminderChk);
            this.EventInfoBox.Controls.Add(this.dateTimePicker);
            this.EventInfoBox.Controls.Add(this.DateLbl);
            this.EventInfoBox.Controls.Add(this.HourCmb);
            this.EventInfoBox.Controls.Add(this.TimeLbl);
            this.EventInfoBox.Controls.Add(this.description);
            this.EventInfoBox.Controls.Add(this.NameTxt);
            this.EventInfoBox.Controls.Add(this.DescriptionTxt);
            this.EventInfoBox.Controls.Add(this.NameLbl);
            this.EventInfoBox.Location = new System.Drawing.Point(364, 29);
            this.EventInfoBox.Name = "EventInfoBox";
            this.EventInfoBox.Size = new System.Drawing.Size(484, 302);
            this.EventInfoBox.TabIndex = 2;
            this.EventInfoBox.TabStop = false;
            this.EventInfoBox.Text = "Event Info";
            // 
            // MinCmb
            // 
            this.MinCmb.FormattingEnabled = true;
            this.MinCmb.Location = new System.Drawing.Point(384, 200);
            this.MinCmb.Name = "MinCmb";
            this.MinCmb.Size = new System.Drawing.Size(76, 28);
            this.MinCmb.TabIndex = 5;
            this.MinCmb.Text = "MM";
            this.MinCmb.SelectedIndexChanged += new System.EventHandler(this.MinCmb_SelectedIndexChanged);
            // 
            // minutesBeforeLbl
            // 
            this.minutesBeforeLbl.AutoSize = true;
            this.minutesBeforeLbl.Location = new System.Drawing.Point(330, 252);
            this.minutesBeforeLbl.Name = "minutesBeforeLbl";
            this.minutesBeforeLbl.Size = new System.Drawing.Size(117, 20);
            this.minutesBeforeLbl.TabIndex = 10;
            this.minutesBeforeLbl.Text = "Minutes Before";
            // 
            // MinutesCmb
            // 
            this.MinutesCmb.Enabled = false;
            this.MinutesCmb.FormattingEnabled = true;
            this.MinutesCmb.Location = new System.Drawing.Point(222, 248);
            this.MinutesCmb.Name = "MinutesCmb";
            this.MinutesCmb.Size = new System.Drawing.Size(102, 28);
            this.MinutesCmb.TabIndex = 7;
            // 
            // ReminderChk
            // 
            this.ReminderChk.AutoSize = true;
            this.ReminderChk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReminderChk.Location = new System.Drawing.Point(84, 248);
            this.ReminderChk.Name = "ReminderChk";
            this.ReminderChk.Size = new System.Drawing.Size(100, 24);
            this.ReminderChk.TabIndex = 6;
            this.ReminderChk.Text = "Reminder";
            this.ReminderChk.UseVisualStyleBackColor = true;
            this.ReminderChk.CheckedChanged += new System.EventHandler(this.ReminderChk_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(84, 201);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker.TabIndex = 2;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(30, 203);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(48, 20);
            this.DateLbl.TabIndex = 6;
            this.DateLbl.Text = "Date:";
            // 
            // HourCmb
            // 
            this.HourCmb.FormattingEnabled = true;
            this.HourCmb.Location = new System.Drawing.Point(302, 200);
            this.HourCmb.Name = "HourCmb";
            this.HourCmb.Size = new System.Drawing.Size(76, 28);
            this.HourCmb.TabIndex = 4;
            this.HourCmb.Text = "HH";
            this.HourCmb.SelectedIndexChanged += new System.EventHandler(this.HourCmb_SelectedIndexChanged);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(249, 205);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(47, 20);
            this.TimeLbl.TabIndex = 4;
            this.TimeLbl.Text = "Time:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(19, 91);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(93, 20);
            this.description.TabIndex = 3;
            this.description.Text = "Description:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(125, 40);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(336, 26);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(125, 91);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(336, 88);
            this.DescriptionTxt.TabIndex = 1;
            this.DescriptionTxt.Text = "";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(19, 40);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(100, 20);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Event Name:";
            // 
            // EventBtn
            // 
            this.EventBtn.Enabled = false;
            this.EventBtn.Location = new System.Drawing.Point(421, 362);
            this.EventBtn.Name = "EventBtn";
            this.EventBtn.Size = new System.Drawing.Size(103, 54);
            this.EventBtn.TabIndex = 3;
            this.EventBtn.Text = "Add Event";
            this.EventBtn.UseVisualStyleBackColor = true;
            this.EventBtn.Click += new System.EventHandler(this.EventBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Enabled = false;
            this.EditBtn.Location = new System.Drawing.Point(547, 362);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 54);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit Event";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Enabled = false;
            this.RemoveBtn.Location = new System.Drawing.Point(667, 362);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(103, 54);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove Event";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Event List:";
            // 
            // SchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.EventBtn);
            this.Controls.Add(this.EventInfoBox);
            this.Controls.Add(this.EventLst);
            this.Controls.Add(this.monthCalendar);
            this.Name = "SchedulerForm";
            this.Text = "Event Scheduler";
            this.EventInfoBox.ResumeLayout(false);
            this.EventInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox EventLst;
        private System.Windows.Forms.GroupBox EventInfoBox;
        private System.Windows.Forms.Button EventBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.RichTextBox DescriptionTxt;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.ComboBox HourCmb;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.CheckBox ReminderChk;
        private System.Windows.Forms.Label minutesBeforeLbl;
        private System.Windows.Forms.ComboBox MinutesCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MinCmb;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}

