using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Models
{
    public class TimeSlot
    {
        public DateTime Start { get; }
        public DateTime End { get; }


        public TimeSlot(DateTime start, DateTime end)
        {
            if (start >= end)
                throw new ArgumentException("Start must be before End");


            Start = start;
            End = end;
        }


        public bool Overlaps(TimeSlot other)
        {
            return Start < other.End && other.Start < End;
        }
    }
}
