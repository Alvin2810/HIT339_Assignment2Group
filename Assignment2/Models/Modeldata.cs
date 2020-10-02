using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Schedules
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public TimeSpan Time { get; set; }
        public string Coach { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
    }

    public class MemberEnrol
    {
        public int Id { get; set; }

        public int ScheduleId { get; set; }

        public string Member { get; set; }
    }
}
