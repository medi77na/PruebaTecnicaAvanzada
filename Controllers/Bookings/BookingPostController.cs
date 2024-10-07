using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
[Tags("Booking")]
public class BookingPostController(IBookingRepository bookingRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : BookingController(bookingRepository, mapper, checkExistRepository)
{
    [Authorize]
    [HttpPost]
    public async Task<ActionResult> CreateBooking(BookingDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        if (!await _checkRepository.CheckExistRoom(model.RoomId))
        {
            return BadRequest($"Habitación no existente. {model}");
        }

        if (!await _checkRepository.CheckExistGuest(model.GuestId))
        {
            return BadRequest($"Huesped no existente. {model}");
        }

        if (!await _checkRepository.CheckExistEmployee(model.EmployeeId))
        {
            return BadRequest($"Empleado no existente. {model}");
        }

        var booking = _mapper.Map<Booking>(model);

        await _bookingRepository.Add(booking);

        return Ok(booking);
    }
}