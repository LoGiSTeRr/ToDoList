using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
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
            tasksListBox.Items.Add(new Task() { Name = textBoxToDo.Text });
            BackGroundPanel.Enabled = false;

            panelEditTask.Visible = true;
            doneButton.Visible = true;
            removeButton.Visible = true;
            editButton.Visible = true;
            tasksListBox.SelectedIndex = tasksListBox.Items.Count - 1;
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
            int index = tasksListBox.SelectedIndex == -1 ? tasksListBox.Items.Count - 1 : tasksListBox.SelectedIndex;
            (tasksListBox.Items[index] as Task).Name = nameBox.Text.Equals(string.Empty) ? "none" : nameBox.Text;
            (tasksListBox.Items[index] as Task).Description = descriptionBox.Text.Equals(string.Empty) ? "none" : descriptionBox.Text;
            switch (priorityBoxPicker.SelectedItem)
            {
                case "Low":
                    (tasksListBox.Items[index] as Task).PriorityType = Priority.Low;
                    break;
                case "Medium":
                    (tasksListBox.Items[index] as Task).PriorityType = Priority.Medium;
                    break;
                case "High":
                    (tasksListBox.Items[index] as Task).PriorityType = Priority.High;
                    break;
            }
            (tasksListBox.Items[index] as Task).date = dateTimePicker.Value;
            panelEditTask.Visible = false;
            BackGroundPanel.Enabled = true;
            tasksListBox.Items.SortByPriority();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int index = tasksListBox.SelectedIndex == -1 ? tasksListBox.Items.Count - 1 : tasksListBox.SelectedIndex;
            panelEditTask.Visible = true;
            BackGroundPanel.Enabled = false;
            nameBox.Text = (tasksListBox.Items[index] as Task).Name;
            descriptionBox.Text = (tasksListBox.Items[index] as Task).Description;
            priorityBoxPicker.Text = (tasksListBox.Items[index] as Task).PriorityType.ToString();
            dateTimePicker.Value = (tasksListBox.Items[index] as Task).date;
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
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int count = tasksListBox.CheckedItems.Count;
            for (int i = 0; i < count; i++)
            {
                tasksListBox.Items.Remove(tasksListBox.CheckedItems[0]);
                if (tasksListBox.Items.Count < 10)
                {
                    BackGroundPanel.Size -= new Size(0, 21);
                    tasksListBox.Size -= new Size(0, 21);
                    doneButton.Location -= new Size(0, 21);
                    removeButton.Location -= new Size(0, 21);
                    editButton.Location -= new Size(0, 21);
                    if (tasksListBox.Items.Count == 0)
                    {
                        doneButton.Visible = false;
                        editButton.Visible = false;
                        removeButton.Visible = false;
                        continue;
                    }
                }
                
            }
        }
    }
}
