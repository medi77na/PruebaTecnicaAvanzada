using AutoMapper;
using PruebaTecnica.Dtos;
using PruebaTecnica.Models;

namespace PruebaTecnica.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RoomDto, Room>();
        
    }

}