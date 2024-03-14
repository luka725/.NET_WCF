using AutoMapper;
using FoundamentalClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfFoundamentalService.DataContracts;

namespace WcfFoundamentalService.Common
{
    public static class AutoMapperConfig
    {
        private static readonly IMapper _mapper;

        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Person, PersonDTO>();
                cfg.CreateMap<PersonDTO, Person>();
            });
            _mapper = config.CreateMapper();
        }
        public static IMapper Mapper => _mapper;
    }
}