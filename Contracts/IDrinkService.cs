using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Contracts.Class1;

namespace Contracts
{
    public interface IDrinkService
    {
        public List<DrinksDto> GetDrinks();
    }
}
