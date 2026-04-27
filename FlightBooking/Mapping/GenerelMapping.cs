using AutoMapper;
using FlightBooking.Dtos.FlightDtos;
using FlightBooking.Entities;

namespace FlightBooking.Mapping
{
    public class GenerelMapping:Profile
    {
        public GenerelMapping()
        {
            CreateMap<Flight, CreateFlightDto>().ReverseMap();
            CreateMap<Flight, ResultFlightDto>().ReverseMap();
            CreateMap<Flight, UpdateFlightDto>().ReverseMap();
            CreateMap<Flight, GetFlightByIdDto>().ReverseMap();
        }
    }
}
