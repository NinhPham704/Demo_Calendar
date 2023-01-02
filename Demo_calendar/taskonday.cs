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
    public partial class taskonday : UserControl
    {
        private Taskitem task;
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public Taskitem Task { get => task; set => task = value; }
        public taskonday(Taskitem task)
        {
            InitializeComponent();
            cboStatus.DataSource = Taskitem.listStatus;
            this.Task= task;
            ShowInfo();
        }
        void ShowInfo()
        {
            txbTask.Text = Task.Job;
            nmuHoursFrom.Value = Task.FromTime.X;
            nmuMinutesFrom.Value= Task.FromTime.Y;
            nmuHoursTo.Value = Task.ToTime.X;
            nmuMinutesTo.Value= Task.ToTime.Y;
            cboStatus.SelectedItem = Taskitem.listStatus.IndexOf(Task.Status);
            ckbDone.Checked = Taskitem.listStatus.IndexOf(Task.Status) == (int)ETaskItem.DONE?true:false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edited.Invoke(this, new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleted.Invoke(this, new EventArgs());
        }
    }
}
