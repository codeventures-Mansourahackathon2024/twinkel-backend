using Twinkle.Models;
using System.Collections.Generic;

namespace Twinkle.Data
{
    public class DoctorRepository
    {
        public static List<Doctor> Doctors = new()
        {
            new Doctor
            {
                Id = 1,
                Name = "Dr. Maria Waston",
                Specialization = "Psychological Consultant",
                Description = "Dr. Maria Waston is the top-most Cardiologist specialist in Nanyang Hospital at London. She is available for private consultation.",
                PatientsCount = 250,
                ExperienceYears = 8,
                ReviewsCount = 150,
                ProfileImageUrl = "/images/dr-maria-waston.jpg",
                Schedules = new List<Schedule>
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
                }
            }
        };

        public Doctor GetDoctorById(int id) => Doctors.Find(d => d.Id == id);
    }
}
