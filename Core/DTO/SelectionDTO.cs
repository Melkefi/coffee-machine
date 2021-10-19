using Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class SelectionDTO
    {
        public DrinkEnum DrinkType { get; set; }
        public int NumberSucre { get; set; }
        public bool OwnMug { get; set; }
        public string Badge { get; set; }
    }
}
