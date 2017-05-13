using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class NewTaskForm : Form
    {
        private DataTable dataTable = new DataTable();
        private DateTime dateTime;
        private bool edit = false;
        private DataGridViewRow row;

        public NewTaskForm(DataTable dataTable, DateTime dateTime)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.dateTime = dateTime;
        }

        public NewTaskForm(DataTable dataTable, DateTime dateTime, DataGridViewRow row)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.dateTime = dateTime;
            this.row = row;
            edit = true;
            this.Text = "Edit task";
            buttonAddNewTask.Text = "Edit task";
            string[] str = row.Cells[0].Value.ToString().Split(':');
            textBoxHour.Text = str[0];
            textBoxMinute.Text = str[1];
            textBoxTask.Text = row.Cells[1].Value.ToString();
        }

        private void buttonAddNewTask_Click(object sender, EventArgs e)
        {
            int hour;
            int minute;
            if (int.TryParse(textBoxHour.Text, out hour) && int.TryParse(textBoxMinute.Text, out minute))
            {
                if (hour < 0 || hour >= 23 || minute < 0 || minute >= 59)
                {
                    MessageBox.Show("Incorrect inputed time.");
                }
                else
                {
                    string str;
                    if (!edit && dataTable.GetTasks().TryGetValue(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hour, minute, 0), out str))
                    {
                        MessageBox.Show("Task for this time alredy exist.");
                    }
                    else
                    {
                        if (edit)
                        {
                            string[] str2 = row.Cells[0].Value.ToString().Split(':');
                            dataTable.DeleteTask(new DateTime(dateTime.Year,
                                dateTime.Month, dateTime.Day,
                                int.Parse(str2[0]), int.Parse(str2[1]), 0));
                        }
                        dataTable.AddTask(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hour, minute, 0), textBoxTask.Text);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect inputed time.");
            }
        }

        private void NewTaskForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
