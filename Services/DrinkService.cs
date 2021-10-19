using Core.DTO;
using Data;
using Services.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Core;
using AutoMapper;

namespace Services
{
    public class DrinkService : IDrinkService
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public DrinkService(ApplicationDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public SelectionDTO GetLastSelection(string badge)
        {
            if (string.IsNullOrEmpty(badge))
            {
                throw new NullReferenceException(nameof(badge));
            }
            var badgeModel = context.Badges.FirstOrDefault(x => x.Value == badge);
            if (badgeModel is null)
            {
                throw new NullReferenceException(nameof(badgeModel));
            }
            var lastSelection = context.Selections
                .Where(x => x.BadgeId == badgeModel.Id)
                .OrderByDescending(x => x._CreatedAt)
                .FirstOrDefault();

            return mapper.Map<SelectionDTO>(lastSelection);
        }

        public SelectionDTO AddSelection(SelectionDTO selection)
        {
            if (selection is null)
            {
                throw new NullReferenceException(nameof(selection));
            }
            if (string.IsNullOrEmpty(selection.Badge))
            {
                throw new NullReferenceException(nameof(Badge));
            }
            var badge = context.Badges.FirstOrDefault(x => x.Value == selection.Badge);
            if (badge is null)
            {
                throw new NullReferenceException(nameof(badge));
            }
            var newSelection = new Selection
            {
                BadgeId = badge.Id,
                NumberSucre = selection.NumberSucre,
                DrinkType = selection.DrinkType,
                OwnMug = selection.OwnMug,
                _CreatedAt = DateTime.Now
            };
            context.Selections.Add(newSelection);
            context.SaveChanges();

            var selectionDTO = mapper.Map<SelectionDTO>(selection);

            return selectionDTO;
        }
    }
}
