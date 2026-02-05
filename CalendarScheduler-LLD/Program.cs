using CalendarScheduler_LLD.Enums;
using CalendarScheduler_LLD.Models;
using CalendarScheduler_LLD.Repositories;
using CalendarScheduler_LLD.Services;

var repo = new InMemoryEventRepository();
var calendarService = new CalendarService(repo);


var alice = new User("Alice");
var bob = new User("Bob");


var meeting = new Event(
"Design Discussion",
alice,
new TimeSlot(DateTime.Now.AddHours(1), DateTime.Now.AddHours(2)),
new List<User> { bob },
new Recurrence(RecurrenceType.None, 0)
);


calendarService.CreateEvent(meeting);


Console.WriteLine("Event scheduled successfully!");