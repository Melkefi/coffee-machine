using Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IDrinkService
    {
        SelectionDTO GetLastSelection(string Badge);
        SelectionDTO AddSelection(SelectionDTO selection);
    }
}
