using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Bookings;

[ApiController]
[Route("api/[controller]")]
public class BookingController : GeneralController
{
    protected readonly IBookingRepository _bookingRepository;

    public BookingController(IBookingRepository bookingRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : base(mapper,checkExistRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public BookingController(IBookingRepository bookingRepository, ICheckExistRepository checkExistRepository) : base(checkExistRepository)
    {
        _bookingRepository = bookingRepository;
    }
}