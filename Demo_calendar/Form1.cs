using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Demo_calendar
{
    public partial class Form1 : Form
    {
        DateTable dateTable;
        private TaskData task;
        private string filepath = "data.xml";

        public TaskData Task { get => task; set => task = value; }

        public Form1()
        {
            InitializeComponent();
            try
            {
               Task = DeserializefromXML(filepath) as TaskData;
            }
            catch
            {
                SetDefaultTask();
            }
            dateTable= new DateTable(pnDate,dtpDate,Task);
            dateTable.drawDateTable(pnDate);
        }
        void SetDefaultTask()
        {
            Task = new TaskData();
            Task.Task = new List<Taskitem>();
            Task.Task.Add(new Taskitem(){
                Date = DateTime.Now,
                Job = "Đang test chức năng",
                FromTime = new Point(12,30),
                ToTime = new Point(13,30),
                Status = Taskitem.listStatus[(int)ETaskItem.COMING]
            });
            Task.Task.Add(new Taskitem()
            {
                Date = DateTime.Now,
                Job = "Đang test chức năng",
                FromTime = new Point(12, 30),
                ToTime = new Point(13, 30),
                Status = Taskitem.listStatus[(int)ETaskItem.COMING]
            });
            Task.Task.Add(new Taskitem()
            {
                Date = DateTime.Now,
                Job = "Đang test chức năng",
                FromTime = new Point(12, 30),
                ToTime = new Point(13, 30),
                Status = Taskitem.listStatus[(int)ETaskItem.COMING]
            });
            Task.Task.Add(new Taskitem()
            {
                Date = DateTime.Now,
                Job = "Đang test chức năng",
                FromTime = new Point(12, 30),
                ToTime = new Point(13, 30),
                Status = Taskitem.listStatus[(int)ETaskItem.COMING]
            });
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dateTable.AddDayToMatrix((sender as DateTimePicker).Value);
        }
        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
        }
        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
        }
        private void SerializetoXML(object data, string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(TaskData));

            sr.Serialize(fs, data);

            fs.Close();
        }
        private object DeserializefromXML(string filepath)
        {
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(TaskData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch
            {   
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializetoXML(Task, filepath);
        }
    }
}
