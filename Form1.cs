using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private BindingList<Task> tasks;
        public Form1()
        {
            InitializeComponent();
        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (textBoxToDo.Text == "what needs to be done?")
            {
                return;
            }
            tasks.Add(new Task() { Name = textBoxToDo.Text });
            BackGroundPanel.Enabled = false;

            panelEditTask.Visible = true;
            doneButton.Visible = true;
            removeButton.Visible = true;
            editButton.Visible = true;
            tasksListBox.SelectedIndex = tasks.Count - 1;
            nameBox.Text = textBoxToDo.Text;
            descriptionBox.Text = string.Empty;
            priorityBoxPicker.Text = Priority.Low.ToString();
            dateTimePicker.Value = DateTime.Today;
            textBoxToDo.Text = "what needs to be done?";
            if (BackGroundPanel.Size.Height == 165 + 21 * 10)
            {
                return;
            }
            BackGroundPanel.Size += new Size(0, 21);
            tasksListBox.Size += new Size(0, 21);
            doneButton.Location += new Size(0, 21);
            removeButton.Location += new Size(0, 21);
            editButton.Location += new Size(0, 21);

        }

        private void textBoxToDo_Click(object sender, EventArgs e)
        {
            if (textBoxToDo.Text == "what needs to be done?")
            {
                textBoxToDo.Text = string.Empty;
            }
        }

        private void textBoxToDo_Leave(object sender, EventArgs e)
        {
            if (textBoxToDo.Text == string.Empty)
            {
                textBoxToDo.Text = "what needs to be done?";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int index = tasksListBox.SelectedIndex == -1 ? tasks.Count - 1 : tasksListBox.SelectedIndex;
            tasks[index].Name = nameBox.Text.Equals(string.Empty) ? "none" : nameBox.Text;
            tasks[index].Description = descriptionBox.Text.Equals(string.Empty) ? "none" : descriptionBox.Text;
            switch (priorityBoxPicker.SelectedItem)
            {
                case "Low":
                    tasks[index].PriorityType = Priority.Low;
                    break;
                case "Medium":
                    tasks[index].PriorityType = Priority.Medium;
                    break;
                case "High":
                    tasks[index].PriorityType = Priority.High;
                    break;
            }
            tasks[index].Date = dateTimePicker.Value;
            panelEditTask.Visible = false;
            BackGroundPanel.Enabled = true;
            tasks.SortByPriority();


            string output = JsonConvert.SerializeObject(tasks);
            File.WriteAllText("savedTasks.json", output);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int index = tasksListBox.SelectedIndex == -1 ? tasksListBox.Items.Count - 1 : tasksListBox.SelectedIndex;
            panelEditTask.Visible = true;
            BackGroundPanel.Enabled = false;
            nameBox.Text = tasks[index].Name;
            descriptionBox.Text = tasks[index].Description;
            priorityBoxPicker.Text = tasks[index].PriorityType.ToString();
            dateTimePicker.Value = tasks[index].Date;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tasksListBox.CheckedItems.Count; i++)
            {
                if ((tasksListBox.CheckedItems[i] as Task).IsDone)
                {
                    (tasksListBox.CheckedItems[i] as Task).IsDone = false;
                    continue;
                }
                (tasksListBox.CheckedItems[i] as Task).IsDone = true;
            }
            string output = JsonConvert.SerializeObject(tasks);
            File.WriteAllText("savedTasks.json", output);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            List<Task> temp = new List<Task>();
            for (int i = 0; i < tasksListBox.CheckedItems.Count; i++)
            {
                temp.Add(tasksListBox.CheckedItems[i] as Task);
            }
            for (int i = 0; i < temp.Count; i++)
            {
                tasks.Remove(temp[i]);
                if (tasksListBox.Items.Count < 10)
                {
                    BackGroundPanel.Size -= new Size(0, 21);
                    tasksListBox.Size -= new Size(0, 21);
                    doneButton.Location -= new Size(0, 21);
                    removeButton.Location -= new Size(0, 21);
                    editButton.Location -= new Size(0, 21);
                    if (tasks.Count == 0)
                    {
                        doneButton.Visible = false;
                        editButton.Visible = false;
                        removeButton.Visible = false;
                        break;
                    }
                }
            }
            string output = JsonConvert.SerializeObject(tasks);
            File.WriteAllText("savedTasks.json", output);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tasks = JsonConvert.DeserializeObject<BindingList<Task>>(File.ReadAllText("savedTasks.json")) ?? new BindingList<Task>();
            tasksListBox.DataSource = tasks;
            if (tasks.Count != 0)
            {
                doneButton.Visible = true;
                removeButton.Visible = true;
                editButton.Visible = true;
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                if (BackGroundPanel.Size.Height == 165 + 21 * 10)
                {
                    return;
                }
                BackGroundPanel.Size += new Size(0, 21);
                tasksListBox.Size += new Size(0, 21);
                doneButton.Location += new Size(0, 21);
                removeButton.Location += new Size(0, 21);
                editButton.Location += new Size(0, 21);
            }
        }
    }
}
