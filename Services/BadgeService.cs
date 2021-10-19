using AutoMapper;
using Core.DTO;
using Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class BadgeService : IBadgeService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public BadgeService(ApplicationDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public List<BadgeDTO> GetBadges()
        {
            var badges = context.Badges.ToList();
            return mapper.Map<List<BadgeDTO>>(badges);
        }
    }
}
