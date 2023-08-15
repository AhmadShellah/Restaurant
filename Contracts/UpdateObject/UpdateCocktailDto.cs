using Contracts.CreateObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.UpdateObject
{
    public class UpdateCocktailDto : CreateCocktailDto
    {
        public new int Id { get; set; }
    }
}
