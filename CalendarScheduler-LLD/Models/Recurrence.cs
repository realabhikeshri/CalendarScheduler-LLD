using CalendarScheduler_LLD.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Models
{
    public class Recurrence
    {
        public RecurrenceType Type { get; }
        public int Count { get; }


        public Recurrence(RecurrenceType type, int count)
        {
            Type = type;
            Count = count;
        }
    }
}
