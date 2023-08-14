using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class CocktailDto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string? Name { get; set; }
    }
}
