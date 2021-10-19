using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core
{
    public class Selection : BaseDb
    {
        public DrinkEnum DrinkType { get; set; }
        public int NumberSucre { get; set; } = 0;
        public bool OwnMug { get; set; } = false;

        [ForeignKey(nameof(Badge))]
        public int BadgeId { get; set; }
        public virtual Badge Badge { get; set; }
    }
}
