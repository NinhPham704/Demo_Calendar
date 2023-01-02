using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Demo_calendar
{
    public class DateTable
    {
        #region properties
        private Panel panel;
        private DateTimePicker dateTimePicker;
        private List<List<Button>> matrixbtn;
        private TaskData task;
        private List<string> daysofweek = new List<string> { "Monday", "Tuesday", "Wednesday","Thursday","Friday","Saturday","Sunday" };
        public Panel Panel { get => panel; set => panel = value; }
        public DateTimePicker DateTimePicker { get => dateTimePicker; set => dateTimePicker = value; }
        public List<List<Button>> MatrixBtn { get => matrixbtn; set => matrixbtn = value; }
        public TaskData Task { get => task; set => task = value; }

        #endregion
        #region Initialize
        public DateTable(Panel panel, DateTimePicker dateTimePicker, TaskData task)
        {
            this.Panel = panel;
            this.DateTimePicker= dateTimePicker;
            this.Task= task;
        }
        #endregion
        #region methods
        public void drawDateTable(Panel panel)
        {
            matrixbtn = new List<List<Button>>();
            Button old_btn = new Button()
            { 
                Height = 0,
                Width = 0,
                Location = new Point(105,0)
            };
            panel.Controls.Add(old_btn);
            for (int i = 0; i < Const.WeekOfMonth; i++)
            {
                matrixbtn.Add(new List<Button>());
                for (int j = 0; j < Const.DayOfWeek; j++)
                {
                    Button btn = new Button()
                    {
                        Height = Const.HEIGHT_CELL_DAY,
                        Width = Const.With_Cell_DAY,
                        Location = new Point(old_btn.Location.X+j*(Const.With_Cell_DAY+15),i*(Const.HEIGHT_CELL_DAY+5))
                    };
                    btn.Click += Btn_Click;
                    panel.Controls.Add(btn);
                    matrixbtn[i].Add(btn);
                }
            }
            SetDefaultDay();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan dailyPlan = new DailyPlan(new DateTime(dateTimePicker.Value.Year,dateTimePicker.Value.Month,Convert.ToInt32((sender as Button).Text)),Task);
            dailyPlan.ShowDialog();
        }

        public void SetDefaultDay()
        {
            dateTimePicker.Value = DateTime.Now;
        }
        public void AddDayToMatrix(DateTime date)
        {
            ClearMatrix();
            ResetColor();
            int row = 0;
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            for (int i = 1; i <= DateTime.DaysInMonth(date.Year,date.Month); i++)
            {
                int column = daysofweek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = matrixbtn[row][column];
                btn.Text = i.ToString();

                //if (IsEqualDate(DateTime.Now, useDate))
                //    btn.BackColor = Color.DeepPink;

                if (IsEqualDate(date, useDate))
                    btn.BackColor = Color.DeepPink;

                useDate= useDate.AddDays(1);

                if(column==6)
                    row++;
            }
        }
        public void ClearMatrix()
        {
            for (int i = 0; i < Const.WeekOfMonth; i++)
            {
                for (int j = 0; j < Const.DayOfWeek; j++)
                {
                    matrixbtn[i][j].Text = "";
                }
            }
        }
        public bool IsEqualDate(DateTime date1,DateTime date2)
        {
            return date1.Year == date2.Year && date1.Month==date2.Month && date1.Day==date2.Day;
        }
        public void ResetColor()
        {
            for (int i = 0; i < Const.WeekOfMonth; i++)
            {
                for (int j = 0; j < Const.DayOfWeek; j++)
                {
                    matrixbtn[i][j].BackColor = Color.White;
                }
            }
        }
        #endregion
    }
}
