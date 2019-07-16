using System;
using System.Globalization;
using AutoMapper;
using TestDrivenAutoMapping.Common.Models;
using TestDrivenAutoMapping.Common.ViewModels;

namespace TestDrivenAutoMapping.Common.Mappings
{

    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<HumanViewModel, Human>()
                .ForMember(e => e.Job, opts => opts.MapFrom(src => src.JobViewModel))
                .ForMember(e => e.Address, opts => opts.MapFrom(model => model))
                .ForMember(e => e.Id, opts => opts.Ignore())
                .ForMember(e => e.JobId, opts => opts.Ignore())
                .ForMember(e => e.AddressId, opts => opts.Ignore());

            CreateMap<Human, HumanViewModel>()
                .ForMember(e => e.HouseName, opts => opts.MapFrom(src => src.Address.HouseName))
                .ForMember(e => e.JobViewModel, opts => opts.MapFrom(src => src.Job))
                .ForMember(e => e.Jobs, opts => opts.Ignore());

            CreateMap<JobViewModel, Job>()
                .ForMember(e => e.Id, opts => opts.Ignore())
                .ReverseMap();

            CreateMap<Human, Address>()
                .ForMember(e => e.HouseName, opts => opts.MapFrom(src => src.Address.HouseName));

            CreateMap<HumanViewModel, Address>()
                .ForMember(e => e.HouseName, opts => opts.MapFrom(src => src.HouseName));

            CreateMap<string, DateTime>().ConvertUsing(new StringToDateTimeConverter());
            CreateMap<DateTime, string>().ConvertUsing(new DateTimeToStringConverter());
        }

        private class StringToDateTimeConverter : ITypeConverter<string, DateTime>
        {
            public DateTime Convert(string source, DateTime destination, ResolutionContext context)
            {
                return System.Convert.ToDateTime(source);
            }
        }

        private class DateTimeToStringConverter : ITypeConverter<DateTime, string>
        {
            public string Convert(DateTime source, string destination, ResolutionContext context)
            {
                return source.ToString("dd/MMMM/yyyy");
            }
        }
    }

}
  