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
    public partial class CalendarForm : Form
    {
        DataTable dataTable = new DataTable();

        public CalendarForm(DataTable dataTable)
        {
            InitializeComponent();
            this.dataTable = dataTable;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataGridView1.Rows.Clear();
            string str;

            DateTime selectedDate = monthCalendar1.SelectionRange.Start.Date;
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minute = 0; minute <= 59; minute++)
                {
                    DateTime itDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, hour, minute, 0);
                    if (dataTable.GetTasks().TryGetValue(itDateTime, out str))
                    {
                        dataGridView1.Rows.Add(string.Format(itDateTime.Hour + ":" + itDateTime.Minute), dataTable.GetTasks()[itDateTime]);
                    }
                }
            }
            
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            var column2 = new DataGridViewColumn();
            column1.HeaderText = "Time";
            column2.HeaderText = "Task";
            column1.CellTemplate = new DataGridViewTextBoxCell();
            column2.CellTemplate = new DataGridViewTextBoxCell();
            column1.Width = 70;
            column2.Width = 362;
            column1.ReadOnly = true;
            column2.ReadOnly = true;
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            monthCalendar1_DateChanged(sender, null);
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            var form = new NewTaskForm(dataTable, monthCalendar1.SelectionRange.Start);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            monthCalendar1_DateChanged(sender, null);
        }

        private void CalendarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataTable.Serialize();
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string [] str;
                str = dataGridView1[0, row.Index].Value.ToString().Split(':');
                dataTable.DeleteTask(new DateTime(monthCalendar1.SelectionRange.Start.Year,
                    monthCalendar1.SelectionRange.Start.Month, monthCalendar1.SelectionRange.Start.Day,
                    int.Parse(str[0]), int.Parse(str[1]), 0));
            }
            monthCalendar1_DateChanged(sender, null);
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var form = new NewTaskForm(dataTable, monthCalendar1.SelectionRange.Start, row);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
            monthCalendar1_DateChanged(sender, null);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editTaskButton_Click(sender, null);
        }
    }
}
