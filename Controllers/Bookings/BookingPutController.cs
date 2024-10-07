using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
[Tags("Booking")]
public class BookingPutController(IBookingRepository bookingRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : BookingController(bookingRepository, mapper, checkExistRepository)
{
    [HttpPut]
    public async Task<ActionResult> UpdateRoom(int id, BookingDto model)
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

        if (!await _checkRepository.CheckExistBooking(id))
        {
            return BadRequest($"Reserva no existente. {model}");

        }

        var booking = await _bookingRepository.GetById(id);

        _mapper.Map(model, booking);

        await _bookingRepository.Update(booking);

        return Ok(booking);
    }
}