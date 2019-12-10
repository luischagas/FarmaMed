using AutoMapper;
using FarmaMed.API.ViewModels;
using FarmaMed.DomainModel.MedicamentoAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaMed.API.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            AllowNullCollections = true;
            CreateMap<Sintoma, SintomaViewModel>().ReverseMap();
            CreateMap<Medicamento, MedicamentoViewModel>().ReverseMap();

            CreateMap<Medicamento, MedicamentoViewModel>()
                .ForMember(dest => dest.Sintomas, opt => opt.MapFrom(src => src.MedicamentoSintomas.Select(s => s.Sintoma)));
        }
    }
}
