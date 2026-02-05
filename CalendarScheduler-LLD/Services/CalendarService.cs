using CalendarScheduler_LLD.Models;
using CalendarScheduler_LLD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly IEventRepository _repository;
        private readonly ConflictDetector _conflictDetector;


        public CalendarService(IEventRepository repository)
        {
            _repository = repository;
            _conflictDetector = new ConflictDetector();
        }


        public void CreateEvent(Event calendarEvent)
        {
            var existingEvents = _repository.GetEventsForUser(calendarEvent.Owner);


            if (_conflictDetector.HasConflict(calendarEvent, existingEvents))
                throw new InvalidOperationException("Event conflicts with existing schedule");


            _repository.Save(calendarEvent);
        }


        public List<Event> GetUserEvents(User user)
        {
            return _repository.GetEventsForUser(user);
        }
    }
}
