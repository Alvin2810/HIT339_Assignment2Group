using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_2.Viewmodel
{
    public class ScheduleViewmodel
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public TimeSpan Time { get; set; }
        public string Coach { get; set; }
        public string CoachName { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string Member { get; set; }
    }
}

