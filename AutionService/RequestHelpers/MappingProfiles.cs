using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutionService.DTOs;
using AutionService.Entities;
using AutoMapper;

namespace AutionService.RequestHelpers
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
            CreateMap<Item, AuctionDto>();

            CreateMap<CreateAuctionDto, Auction>()
                .ForMember(dest => dest.Item, opt => opt.MapFrom(src => src));
            CreateMap<CreateAuctionDto, Item>();

            // CreateMap<UpdateAuctionDto, Auction>();            
        }
    }
}