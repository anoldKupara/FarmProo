using AutoMapper;
using FarmPro.Application.DTOs.Animal;
using FarmPro.Application.DTOs.Feed;
using FarmPro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmPro.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Animal, AnimalDto>().ReverseMap();
            CreateMap<Feed, FeedDto>().ReverseMap();
            CreateMap<Vaccine, VaccineDto>();
            CreateMap<VaccineDto, Vaccine>();
        }
    }
}
