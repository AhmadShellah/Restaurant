using System.Data.Entity;

namespace Contracts.Dtos
{
    public class CocktailDto
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string? Name { get; set; }
    }
}
