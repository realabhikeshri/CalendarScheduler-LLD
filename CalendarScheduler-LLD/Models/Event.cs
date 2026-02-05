using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScheduler_LLD.Models
{
    public class Event
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Title { get; }
        public User Owner { get; }
        public TimeSlot TimeSlot { get; }
        public List<User> Participants { get; }
        public Recurrence Recurrence { get; }


        public Event(string title, User owner, TimeSlot timeSlot,
        List<User> participants, Recurrence recurrence)
        {
            Title = title;
            Owner = owner;
            TimeSlot = timeSlot;
            Participants = participants;
            Recurrence = recurrence;
        }
    }
}
