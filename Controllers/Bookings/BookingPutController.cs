using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
public class BookingPutController(IBookingRepository bookingRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : BookingController(bookingRepository, mapper,checkExistRepository)
{
    


}