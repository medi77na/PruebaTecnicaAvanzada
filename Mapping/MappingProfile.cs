using AutoMapper;
using PruebaTecnica.Dtos;
using PruebaTecnica.Models;

namespace PruebaTecnica.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RoomDto, Room>();
        CreateMap<BookingDto, Booking>();
        CreateMap<EmployeeDto, Employee>();
        CreateMap<GuestDto, Guest>();
        CreateMap<RoomType, RoomType>();
    }

}