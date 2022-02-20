using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace ToDoList
{
    public static class MyExtensions
    {
        public static void SortByPriority(this BindingList<Task> list)
        {
            int i, j;
            int N = list.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (list[i].PriorityType < list[i + 1].PriorityType)
                    {
                        (list[i], list[i + 1]) = (list[i + 1], list[i]);
                    }
                }
            }
        }
    }
}