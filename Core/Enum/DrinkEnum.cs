using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.Enum
{
    public enum DrinkEnum
    {
        [Description("Café")]
        Coffee,
        [Description("Thé")]
        Tee,
        [Description("Chocolat")]
        Chocolate
    }
}
