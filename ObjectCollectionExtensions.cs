using System.Windows.Forms;

namespace ToDoList
{
    public static class ObjectCollectionExtensions
    {
        public static void SortByPriority(this ListBox.ObjectCollection list)
        {
            int i, j;
            int N = list.Count;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if ((list[i] as Task).PriorityType < (list[i + 1] as Task).PriorityType)
                    {
                        (list[i], list[i + 1]) = (list[i + 1], list[i]);
                    }
                }
            }
        }
    }
}
