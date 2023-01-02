using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_calendar
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private TaskData task;
        public DateTime Date { get => date; set => date = value; }
        public TaskData Task { get => task; set => task = value; }
        public DailyPlan(DateTime date, TaskData task)
        {
            InitializeComponent();
            this.Date= date;
            this.Task= task;
            dtpkDate.Value = this.date;
            
        }
        void ShowTaskbyDate(DateTime date)
        {
            fpnlTaskonday.Controls.Clear();
            if (Task != null && Task.Task != null)
            {
                List<Taskitem> tasks = GetJobbyDate(date);
                for (int i = 0; i < tasks.Count; i++)
                { 
                    taskonday taskonday = new taskonday(tasks[i]);
                    taskonday.Edited += Taskonday_Edited;
                    taskonday.Deleted += Taskonday_Deleted;
                    fpnlTaskonday.Controls.Add(taskonday);
                }
            }
        }

        private void Taskonday_Deleted(object sender, EventArgs e)
        {
            taskonday taskonday = sender as taskonday;
            Taskitem taskitem = taskonday.Task;
            fpnlTaskonday.Controls.Remove(taskonday);
            Task.Task.Remove(taskitem);
        }

        private void Taskonday_Edited(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        List<Taskitem> GetJobbyDate(DateTime date)
        {
            return Task.Task.Where(p => p.Date.Year==date.Year && p.Date.Month==date.Month && p.Date.Day==date.Day).ToList();
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowTaskbyDate((sender as DateTimePicker).Value);
        }

        private void mnstrAddJob_Click(object sender, EventArgs e)
        {
            taskonday taskonday = new taskonday(new Taskitem());
            fpnlTaskonday.Controls.Add(taskonday);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }
    }
}
