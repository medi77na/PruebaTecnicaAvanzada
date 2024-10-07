using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
[Tags("Booking")]
public class BookingDeleteController(IBookingRepository bookingRepository, ICheckExistRepository checkExistRepository) : BookingController(bookingRepository, checkExistRepository)
{
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        if (!await _checkRepository.CheckExistBooking(id))
        {
            return NotFound("La reserva no existe");
        }

        await _bookingRepository.Delete(await _bookingRepository.GetById(id));

        return NoContent();
    }
}