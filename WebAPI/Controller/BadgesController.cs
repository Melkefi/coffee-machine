using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        private readonly IBadgeService badgeService;
        public BadgesController(IBadgeService badgeService)
        {
            this.badgeService = badgeService;
        }

        [HttpGet]
        public IActionResult GetBadges()
        {
            return Ok(badgeService.GetBadges());
        }
    }
}
