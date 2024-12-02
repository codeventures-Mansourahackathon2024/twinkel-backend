using Microsoft.AspNetCore.Mvc;
using Twinkle.Data;
using Twinkle.Models;

namespace Twinkle.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchedulesController : ControllerBase
    {
        private readonly ScheduleRepository _repository = new ScheduleRepository();

        [HttpGet]
        public IActionResult GetSchedules()
        {
            var schedules = _repository.GetSchedules();
            return Ok(schedules);
        }

        [HttpGet("{day}")]
        public IActionResult GetScheduleByDay(int day)
        {
            var schedule = _repository.GetScheduleByDay(day);
            if (schedule == null)
            {
                return NotFound(new { message = "Schedule not found for the specified day" });
            }
            return Ok(schedule);
        }
    }
}
