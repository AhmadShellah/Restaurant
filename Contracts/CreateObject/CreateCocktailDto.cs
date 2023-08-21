using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.CreateObject
{
    public class CreateCocktailDto : BaseClass
    {
        public string? Name { get; set; }
        public double Price { get; set; }
    }
}
