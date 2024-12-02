using Twinkle.Models;

namespace Twinkle.Data
{
    public class ScheduleRepository
    {
        private readonly List<Schedule> _schedules = new()
        {
            new Schedule
            {
                Day = 8,
                DayName = "Monday",
                AvailableTimes = new List<string> { "08:00 AM", "10:00 PM", "08:00 PM" }
            },
            new Schedule
            {
                Day = 9,
                DayName = "Tuesday",
                AvailableTimes = new List<string> { "05:00 AM", "11:00 PM" }
            }
        };

        public IEnumerable<Schedule> GetSchedules() => _schedules;

        public Schedule GetScheduleByDay(int day) => _schedules.FirstOrDefault(s => s.Day == day);
    }
}
