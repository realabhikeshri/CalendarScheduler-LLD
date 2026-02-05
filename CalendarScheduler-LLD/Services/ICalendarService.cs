using CalendarScheduler_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Services
{
    public interface ICalendarService
    {
        void CreateEvent(Event calendarEvent);
        List<Event> GetUserEvents(User user);
    }
}
