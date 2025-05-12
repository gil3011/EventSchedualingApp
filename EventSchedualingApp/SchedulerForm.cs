using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSchedualingApp
{
    public partial class SchedulerForm : Form
    {
        readonly List<Event> events = new List<Event>();
        readonly List<Event> filteredEvents = new List<Event>();
        Event selected = null;
        //c'tor
        public SchedulerForm()
        {
            InitializeComponent();

            for (int i = 0; i < 24; i++)
            {
                if (i < 10)
                {
                    HourCmb.Items.Add($"0{i}");
                }
                else
                {
                    HourCmb.Items.Add($"{i}");
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if (i < 2)
                {
                    MinCmb.Items.Add($"0{i * 5}");
                }
                else
                {
                    MinCmb.Items.Add($"{i * 5}");
                }
            }
            for (int i = 1; i < 5; i++)
            {
                MinutesCmb.Items.Add((int)i * 15);
            }
            MinutesCmb.SelectedIndex = 0;
        }

        //events
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ClearInputs();
            UpdateList();
        }
        private void EventBtn_Click(object sender, EventArgs e)
        {
            int reminder = 0;
            if (ReminderChk.Checked) { reminder = int.Parse(MinutesCmb.Text); }
            Event eventToAdd = new Event(NameTxt.Text, dateTimePicker.Value, HourCmb.Text, MinCmb.Text, DescriptionTxt.Text, reminder);
            events.Add(eventToAdd);
            EventLst.Items.Add(eventToAdd);
            filteredEvents.Add(eventToAdd);
            ClearInputs();
        }
        private void EventLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventLst.SelectedIndex == -1)
            {
                ClearInputs();
                return;
            }
            selected = filteredEvents[EventLst.SelectedIndex];
            EditBtn.Enabled = true;
            RemoveBtn.Enabled = true;
            NameTxt.Text = selected.Name;
            DescriptionTxt.Text = selected.Description;
            HourCmb.Text = selected.Date.Hour.ToString("D2");
            MinCmb.Text = selected.Date.Minute.ToString("D2");
            if (selected.Reminder == 0)
            {
                ReminderChk.Checked = false;
            }
            else
            {
                ReminderChk.Checked = true;
                MinutesCmb.Text = selected.Reminder.ToString();
            }
        }
        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            selected.Name = NameTxt.Text;
            selected.Description = DescriptionTxt.Text;
            DateTime temp = dateTimePicker.Value;
            temp = new DateTime(temp.Year, temp.Month, temp.Day, int.Parse(HourCmb.Text), int.Parse(MinCmb.Text), 0);
            selected.Date = temp;
            int reminder = 0;
            if (ReminderChk.Checked) { reminder = int.Parse(MinutesCmb.Text); }
            selected.Reminder = reminder;
            EventLst.SelectedIndex = -1;
            UpdateList();
        }
        private void ReminderChk_CheckedChanged(object sender, EventArgs e)
        {
            if (ReminderChk.Checked)
            {
                MinutesCmb.Enabled = true;
            }
            else
            {
                MinutesCmb.Enabled = false;
            }
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to delete this event?", "Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                events.Remove(selected);
                UpdateList();
                ClearInputs();
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            foreach (Event eventItem in events)
            {
                if (eventItem.Date.Date == now.Date && eventItem.Reminder != 0 && eventItem.Date > now)
                {
                    if (now.AddMinutes(eventItem.Reminder) >= eventItem.Date)
                    {
                        int temp = eventItem.Reminder;
                        eventItem.Reminder = 0;
                        DialogResult result = DialogResult.No;
                        if (temp > 15)
                        {
                            result = MessageBox.Show($"Event about to start:\n{eventItem}\nDo you want another reminder in 15 minutes?", "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Event about to start:\n{eventItem}", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (result == DialogResult.Yes)
                        {
                            eventItem.Reminder = temp - 15;
                        }
                        UpdateList();
                    }
                }
            }
        }
        private void HourCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }
        private void MinCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }

        //functions
        private void CheckInputs()
        {
            if (NameTxt.Text == "" || MinCmb.Text == "" || MinCmb.Text == "MM" || HourCmb.Text == "" || HourCmb.Text == "HH" || selected != null) { EventBtn.Enabled = false; }
            else { EventBtn.Enabled = true; }
        }
        private void ClearInputs()
        {
            NameTxt.Text = "";
            DescriptionTxt.Text = "";
            HourCmb.Text = "HH";
            MinCmb.Text = "MM";
            MinutesCmb.SelectedIndex = 0;
            ReminderChk.Checked = false;
            MinutesCmb.Enabled = false;
            selected = null;
            RemoveBtn.Enabled = false;
            EditBtn.Enabled = false;
        }
        private void UpdateList()
        {
            DateTime dateTime = monthCalendar.SelectionStart;
            dateTimePicker.Value = dateTime;
            EventLst.Items.Clear();
            filteredEvents.Clear();
            foreach (Event eventItem in events)
            {
                if (eventItem.Date.Date.Equals(dateTime.Date))
                {
                    EventLst.Items.Add(eventItem.ToString());
                    filteredEvents.Add(eventItem);
                }
            }
            
        }
    }
}
