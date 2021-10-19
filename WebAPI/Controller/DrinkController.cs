using Core.DTO;
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
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService drinkService;
        public DrinkController(IDrinkService drinkService)
        {
            this.drinkService = drinkService;
        }

        [HttpPost]
        public IActionResult AddSelection([FromBody] SelectionDTO selection)
        {
            return Ok(drinkService.AddSelection(selection));
        }

        [HttpGet("{badge}")]
        public IActionResult GetLastSelection(string badge)
        {
            return Ok(drinkService.GetLastSelection(badge));
        }
    }
}
