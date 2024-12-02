namespace Twinkle.Models
{
    public class Schedule
    {
        public int Day { get; set; }  
        public string DayName { get; set; }  
        public List<string> AvailableTimes { get; set; }
    }
}
