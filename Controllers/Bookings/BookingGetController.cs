using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
[Tags("Booking")]
public class BookingGetController(IBookingRepository bookingRepository, ICheckExistRepository checkExistRepository) : BookingController(bookingRepository, checkExistRepository)
{

    [HttpGet]
    public async Task<ActionResult<List<Booking>>> GetBookingAll()
    {
        return Ok(await _bookingRepository.GetAll());
    }

    [Authorize]
    [HttpGet("Id")]
    public async Task<ActionResult<Booking>> GetBookingById(int id)
    {
        if (!await _checkRepository.CheckExistRoom(id))
        {
            return NotFound("No se encontró ninguna reserva con ese ID.");
        }
        return Ok(await _bookingRepository.GetById(id));
    }


}