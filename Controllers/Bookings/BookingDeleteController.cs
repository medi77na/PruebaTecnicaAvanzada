using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
public class BookingDeleteController(IBookingRepository bookingRepository, ICheckExistRepository checkExistRepository) : BookingController(bookingRepository, checkExistRepository)
{
}