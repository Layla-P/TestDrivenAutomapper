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
            CreateMap<HumanViewModel, Human>();
            CreateMap<Human, HumanViewModel>();

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
  