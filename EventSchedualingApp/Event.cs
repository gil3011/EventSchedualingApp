using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSchedualingApp
{
    class Event
    {
        //תכונות
        private string name;
        private DateTime date;
        private string description;
        private int reminder;
        //
        public Event(string name, DateTime date, string hour, string minutes, string description, int reminder)
        {
            this.Name = name;
            this.Description = description;
            this.Reminder = reminder;
            Date = new DateTime(date.Year, date.Month, date.Day, int.Parse(hour), int.Parse(minutes), 0);

        }
        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
        public int Reminder { get => reminder; set => reminder = value; }
        public override string ToString()
        {
            return $"{Name} at {Date.Hour}:{Date.Minute.ToString("D2")}";
        }
    }
}