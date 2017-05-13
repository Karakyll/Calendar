namespace Calendar
{
    partial class NewTaskForm
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
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.buttonAddNewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHour
            // 
            this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHour.Location = new System.Drawing.Point(12, 36);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(100, 28);
            this.textBoxHour.TabIndex = 0;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask.Location = new System.Drawing.Point(12, 95);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(443, 63);
            this.textBoxTask.TabIndex = 1;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMinute.Location = new System.Drawing.Point(165, 36);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(100, 28);
            this.textBoxMinute.TabIndex = 2;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHour.Location = new System.Drawing.Point(12, 9);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(52, 24);
            this.labelHour.TabIndex = 3;
            this.labelHour.Text = "Hour";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinute.Location = new System.Drawing.Point(161, 9);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(67, 24);
            this.labelMinute.TabIndex = 4;
            this.labelMinute.Text = "Minute";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(11, 67);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(56, 25);
            this.labelTask.TabIndex = 5;
            this.labelTask.Text = "Task";
            // 
            // buttonAddNewTask
            // 
            this.buttonAddNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewTask.Location = new System.Drawing.Point(12, 164);
            this.buttonAddNewTask.Name = "buttonAddNewTask";
            this.buttonAddNewTask.Size = new System.Drawing.Size(443, 57);
            this.buttonAddNewTask.TabIndex = 6;
            this.buttonAddNewTask.Text = "Add new task";
            this.buttonAddNewTask.UseVisualStyleBackColor = true;
            this.buttonAddNewTask.Click += new System.EventHandler(this.buttonAddNewTask_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 233);
            this.Controls.Add(this.buttonAddNewTask);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxTask);
            this.Controls.Add(this.textBoxHour);
            this.MaximumSize = new System.Drawing.Size(485, 280);
            this.MinimumSize = new System.Drawing.Size(485, 280);
            this.Name = "NewTaskForm";
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Button buttonAddNewTask;
    }
}