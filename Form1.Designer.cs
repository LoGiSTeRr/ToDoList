
namespace ToDoList
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BackGroundPanel = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.tasksListBox = new System.Windows.Forms.CheckedListBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.textBoxToDo = new System.Windows.Forms.TextBox();
            this.panelEditTask = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.priorityBoxPicker = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urgentCheckBox = new System.Windows.Forms.CheckBox();
            this.BackGroundPanel.SuspendLayout();
            this.panelEditTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(140, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TODOLIST";
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.BackGroundPanel.Controls.Add(this.editButton);
            this.BackGroundPanel.Controls.Add(this.doneButton);
            this.BackGroundPanel.Controls.Add(this.removeButton);
            this.BackGroundPanel.Controls.Add(this.tasksListBox);
            this.BackGroundPanel.Controls.Add(this.addTaskButton);
            this.BackGroundPanel.Controls.Add(this.textBoxToDo);
            this.BackGroundPanel.Controls.Add(this.label1);
            this.BackGroundPanel.Location = new System.Drawing.Point(116, 33);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(400, 165);
            this.BackGroundPanel.TabIndex = 1;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(19, 121);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(81, 35);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.OliveDrab;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.doneButton.ForeColor = System.Drawing.Color.White;
            this.doneButton.Location = new System.Drawing.Point(207, 121);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(81, 35);
            this.doneButton.TabIndex = 5;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Visible = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.DarkRed;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(294, 121);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(81, 35);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // tasksListBox
            // 
            this.tasksListBox.AllowDrop = true;
            this.tasksListBox.CheckOnClick = true;
            this.tasksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.HorizontalScrollbar = true;
            this.tasksListBox.Location = new System.Drawing.Point(22, 90);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(356, 4);
            this.tasksListBox.TabIndex = 3;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.SteelBlue;
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.addTaskButton.ForeColor = System.Drawing.Color.White;
            this.addTaskButton.Location = new System.Drawing.Point(337, 48);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(38, 35);
            this.addTaskButton.TabIndex = 2;
            this.addTaskButton.Text = "+";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // textBoxToDo
            // 
            this.textBoxToDo.Font = new System.Drawing.Font("Consolas", 15F);
            this.textBoxToDo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxToDo.Location = new System.Drawing.Point(19, 48);
            this.textBoxToDo.Name = "textBoxToDo";
            this.textBoxToDo.Size = new System.Drawing.Size(312, 31);
            this.textBoxToDo.TabIndex = 1;
            this.textBoxToDo.Text = "what needs to be done?";
            this.textBoxToDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxToDo.Click += new System.EventHandler(this.textBoxToDo_Click);
            this.textBoxToDo.Leave += new System.EventHandler(this.textBoxToDo_Leave);
            // 
            // panelEditTask
            // 
            this.panelEditTask.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelEditTask.Controls.Add(this.urgentCheckBox);
            this.panelEditTask.Controls.Add(this.saveButton);
            this.panelEditTask.Controls.Add(this.dateTimePicker);
            this.panelEditTask.Controls.Add(this.label6);
            this.panelEditTask.Controls.Add(this.priorityBoxPicker);
            this.panelEditTask.Controls.Add(this.label5);
            this.panelEditTask.Controls.Add(this.descriptionBox);
            this.panelEditTask.Controls.Add(this.nameBox);
            this.panelEditTask.Controls.Add(this.label4);
            this.panelEditTask.Controls.Add(this.label3);
            this.panelEditTask.Controls.Add(this.label2);
            this.panelEditTask.Location = new System.Drawing.Point(28, 204);
            this.panelEditTask.Name = "panelEditTask";
            this.panelEditTask.Size = new System.Drawing.Size(570, 210);
            this.panelEditTask.TabIndex = 2;
            this.panelEditTask.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.OliveDrab;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(461, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 35);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(318, 102);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 13.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(314, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date:";
            // 
            // priorityBoxPicker
            // 
            this.priorityBoxPicker.Font = new System.Drawing.Font("Consolas", 10F);
            this.priorityBoxPicker.FormattingEnabled = true;
            this.priorityBoxPicker.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.priorityBoxPicker.Location = new System.Drawing.Point(421, 55);
            this.priorityBoxPicker.Name = "priorityBoxPicker";
            this.priorityBoxPicker.Size = new System.Drawing.Size(121, 23);
            this.priorityBoxPicker.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(315, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Priority:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.descriptionBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.descriptionBox.Location = new System.Drawing.Point(16, 102);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(293, 91);
            this.descriptionBox.TabIndex = 10;
            this.descriptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.nameBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nameBox.Location = new System.Drawing.Point(78, 54);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(231, 23);
            this.nameBox.TabIndex = 7;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Task Settings";
            // 
            // urgentCheckBox
            // 
            this.urgentCheckBox.AutoSize = true;
            this.urgentCheckBox.Font = new System.Drawing.Font("Consolas", 13.25F, System.Drawing.FontStyle.Bold);
            this.urgentCheckBox.Location = new System.Drawing.Point(320, 163);
            this.urgentCheckBox.Name = "urgentCheckBox";
            this.urgentCheckBox.Size = new System.Drawing.Size(99, 26);
            this.urgentCheckBox.TabIndex = 16;
            this.urgentCheckBox.Text = "Urgent?";
            this.urgentCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panelEditTask);
            this.Controls.Add(this.BackGroundPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackGroundPanel.ResumeLayout(false);
            this.BackGroundPanel.PerformLayout();
            this.panelEditTask.ResumeLayout(false);
            this.panelEditTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.TextBox textBoxToDo;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.CheckedListBox tasksListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panelEditTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox priorityBoxPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox urgentCheckBox;
    }
}

