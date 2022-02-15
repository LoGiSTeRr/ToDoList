
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
            this.textBoxToDo = new System.Windows.Forms.TextBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.BackGroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(133, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TODOLIST";
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.BackColor = System.Drawing.SystemColors.Menu;
            this.BackGroundPanel.Controls.Add(this.addTaskButton);
            this.BackGroundPanel.Controls.Add(this.textBoxToDo);
            this.BackGroundPanel.Controls.Add(this.label1);
            this.BackGroundPanel.Location = new System.Drawing.Point(116, 33);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(400, 120);
            this.BackGroundPanel.TabIndex = 1;
            // 
            // textBoxToDo
            // 
            this.textBoxToDo.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.textBoxToDo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxToDo.Location = new System.Drawing.Point(19, 48);
            this.textBoxToDo.Name = "textBoxToDo";
            this.textBoxToDo.Size = new System.Drawing.Size(312, 35);
            this.textBoxToDo.TabIndex = 1;
            this.textBoxToDo.Text = "what needs to be done?";
            this.textBoxToDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.BackGroundPanel);
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.BackGroundPanel.ResumeLayout(false);
            this.BackGroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.TextBox textBoxToDo;
        private System.Windows.Forms.Button addTaskButton;
    }
}

