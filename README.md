# 📅 Calendar Scheduler – Machine Coding (LLD)

A **production-quality Calendar Scheduler** implemented in **C#**

This project demonstrates clean object-oriented design, SOLID principles, extensibility, and real-world constraints like conflict detection and multi-user calendars.

---

## 🚀 Features

* Create, view, and delete calendar events
* Multi-user calendar support
* Event conflict detection (time overlap)
* Meeting participants
* Recurring events (Daily / Weekly)
* Thread-safe in-memory storage
* Search events by user

---

## 🧱 Folder Structure

```
CalendarScheduler/
│
├── Models/
│   ├── User.cs
│   ├── Event.cs
│   ├── TimeSlot.cs
│   └── Recurrence.cs
│
├── Repositories/
│   ├── IEventRepository.cs
│   └── InMemoryEventRepository.cs
│
├── Services/
│   ├── ICalendarService.cs
│   ├── CalendarService.cs
│   └── ConflictDetector.cs
│
├── Program.cs
└── README.md
```

---

## 🧠 Design Overview

### Core Entities

* **User** – owns a calendar
* **Event** – meeting or reminder
* **TimeSlot** – start and end time abstraction
* **Recurrence** – supports repeating events

### Design Principles Used

* **Single Responsibility Principle (SRP)**
* **Open/Closed Principle (OCP)**
* **Repository Pattern** for storage abstraction
* **Thread safety** using concurrent collections

---

## ⚙️ How It Works

1. A user creates an event with a time slot and participants
2. System checks for conflicts with existing events
3. If no overlap exists, the event is persisted
4. Events can be queried per user

---

## ▶️ Running the Application

1. Clone the repository
2. Open the solution in **Visual Studio / Rider**
3. Build and run the project
4. `Program.cs` contains sample usage

```bash
dotnet run
```

---

## 🧪 Edge Cases Handled

* Overlapping meetings
* Invalid time ranges
* Multi-participant scheduling conflicts
* Concurrent event creation

---

---

## 📈 Possible Enhancements

* Persistent storage (SQL / MongoDB)
* Event reminders & notifications
* Availability-based scheduling
* Time zone support
* API layer (REST / gRPC)

---

---
## 👨‍💻 Author

**Abhishek Keshri**



