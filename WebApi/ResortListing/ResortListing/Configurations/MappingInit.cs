using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ResortListing.Data;
using ResortListing.DTO;

namespace ResortListing.Configurations
{
    public class MappingInit: Profile
    {
        public MappingInit()
        {
            CreateMap<ApplicationUser, UserDto>().ReverseMap();
        }
    }
}
