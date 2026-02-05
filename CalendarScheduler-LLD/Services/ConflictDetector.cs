using CalendarScheduler_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Services
{
    public class ConflictDetector
    {
        public bool HasConflict(Event newEvent, List<Event> existingEvents)
        {
            return existingEvents.Any(e => e.TimeSlot.Overlaps(newEvent.TimeSlot));
        }
    }
}
