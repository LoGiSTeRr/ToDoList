namespace ToDoList
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Priority PriorityType { get; set; } = Priority.Low;
        public System.DateTime date { get; set; } = System.DateTime.Today;
        public bool IsDone { get; set; } = false;
        public override string ToString()
        {
            string r = $"{Name}, p: {PriorityType}, date: {date.ToShortDateString()}";
            if (IsDone)
            {
                r.Insert(0, "[Done]");
            }
            return r;
        }
    }
}
