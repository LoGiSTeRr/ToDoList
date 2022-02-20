using System;
namespace ToDoList
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority PriorityType { get; set; } = Priority.Low;
        public DateTime Date { get; set; } = DateTime.Today;
        public bool IsDone { get; set; } = false;
        public bool IsUrgent { get; set; } = false;
        public override string ToString()
        {
            string r = $"{Name}, p: {PriorityType}, date: {Date.ToShortDateString()}";
            if (IsDone)
            {
                r = r.Insert(0, "[Done]");
            }
            else if (IsUrgent)
            {
                r = r.Insert(0, "!!!");
            }
            return r;
        }
    }
}
