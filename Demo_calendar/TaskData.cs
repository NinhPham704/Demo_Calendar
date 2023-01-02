using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_calendar
{
    [Serializable]
    public class TaskData
    {
        private List<Taskitem> task;

        public List<Taskitem> Task { get => task; set => task = value; }
    }
}
