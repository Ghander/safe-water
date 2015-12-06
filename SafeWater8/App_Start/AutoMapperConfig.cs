using AutoMapper;
using SafeWater8.Domain.Models;
using SafeWater8.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SafeWater8.App_Start {
    public class AutoMapperConfig {
        public static void RegisterMaps() {
            Mapper.CreateMap<Contaminant, ContaminantDTO>();
            Mapper.CreateMap<ContaminantDTO, Contaminant>();

            Mapper.CreateMap<Address, AddressDTO>();
            Mapper.CreateMap<AddressDTO, Address>();

        }
    }
}