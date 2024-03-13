using AutoMapper;
using ClassLibraryDatabase;
using DatabaseService.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseService.Common
{
    public static class AutoMapperConfig
    {
        private static readonly IMapper _mapper;
        
        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            _mapper = config.CreateMapper();
        }
        public static IMapper Mapper => _mapper;
    }
}