using AutoMapper;
using GloboTicket.Services.ShoppingBasket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services.ShoppingBasket.Profiles
{
    public class BasketLineProfile : Profile
    {
        public BasketLineProfile()
        {
            CreateMap<BasketLineForCreation, BasketLine>();
            CreateMap<BasketLineForUpdate, BasketLine>();
            CreateMap<BasketLine, BasketLine>().ReverseMap();

        }
    }
}
