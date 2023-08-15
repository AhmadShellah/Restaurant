using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Dtos;

namespace Contracts.InterFaces
{
    public interface ICocktailService
    {
        public List<CocktailDto> GetCocktails();
        public void CreateCocktail(int id, string name, double price);
        public void UpdateCocktail(int id, string name, double price);
    }
}
