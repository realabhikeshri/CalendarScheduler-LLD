using CalendarScheduler_LLD.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Repositories
{
    public class InMemoryEventRepository : IEventRepository
    {
        private readonly ConcurrentDictionary<Guid, Event> _events = new();


        public void Save(Event calendarEvent)
        {
            _events[calendarEvent.Id] = calendarEvent;
        }


        public void Delete(Guid eventId)
        {
            _events.TryRemove(eventId, out _);
        }


        public List<Event> GetEventsForUser(User user)
        {
            return _events.Values
            .Where(e => e.Owner.Id == user.Id || e.Participants.Any(p => p.Id == user.Id))
            .ToList();
        }
    }
}
