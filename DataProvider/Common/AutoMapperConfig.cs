using AutoMapper;
using DataAdapter;
using DataProvider.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataProvider.Common
{
    public static class AutoMapperConfig
    {
        private static readonly IMapper _mapper;

        static AutoMapperConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Recipe, RecipeDTO>();
            });
            _mapper = config.CreateMapper();
        }
        public static IMapper Mapper => _mapper;
    }
}