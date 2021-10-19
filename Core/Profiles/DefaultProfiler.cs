using AutoMapper;
using Core;
using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Profiles
{
    public class DefaultProfiler : Profile
    {
        public DefaultProfiler()
        {
            CreateMap<Badge, BadgeDTO>();
            CreateMap<Selection, SelectionDTO>()
                .ForMember(x => x.Badge, e => e.MapFrom(z => z.Badge.Value));
        }
    }
}
