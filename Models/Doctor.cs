namespace Twinkle.Models
{
    public class Doctor
    {
        public int Id { get; set; }  
        public string Name { get; set; } 
        public string Specialization { get; set; }  
        public string Description { get; set; }  
        public int PatientsCount { get; set; }  
        public int ExperienceYears { get; set; }  
        public int ReviewsCount { get; set; }  
        public string ProfileImageUrl { get; set; }  
        public List<Schedule> Schedules { get; set; }
    }

}
