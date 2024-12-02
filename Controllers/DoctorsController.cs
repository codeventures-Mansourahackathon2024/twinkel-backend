using Microsoft.AspNetCore.Mvc;
using Twinkle.Data;

[ApiController]
[Route("api/[controller]")]
public class DoctorsController : ControllerBase
{
    private readonly DoctorRepository _repository = new DoctorRepository();

    [HttpGet("{id}")]
    public IActionResult GetDoctorById(int id)
    {
        var doctor = _repository.GetDoctorById(id);
        if (doctor == null)
        {
            return NotFound(new { message = "Doctor not found" });
        }
        return Ok(doctor);
    }
}
