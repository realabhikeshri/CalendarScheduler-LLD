using CalendarScheduler_LLD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Repositories
{
    public interface IEventRepository
    {
        void Save(Event calendarEvent);
        void Delete(Guid eventId);
        List<Event> GetEventsForUser(User user);
    }
}
