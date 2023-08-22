using AutoMapper;
using Contracts;
using Contracts.CreateObject;
using Contracts.Dtos;
using Contracts.InterFaces;
using Contracts.UpdateObject;
using Domain;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CocktailService : ICocktailService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CocktailService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<CocktailDto>> GetCocktails()
        {
            var list = _context.Cocktail.ToList();

            var mappedList = _mapper.Map<List<Cocktail>, List<CocktailDto>>(list);

            await _context.SaveChangesAsync();

            return mappedList;

        }

        public async Task<bool> CreateCocktail(CreateCocktailDto createCocktailDto)
        {
                var mappedCocktail = _mapper.Map<CreateCocktailDto,Cocktail>(createCocktailDto);

                mappedCocktail.CreatedBy = 1;
                mappedCocktail.CreatedDate = DateTime.Now;
                mappedCocktail.UpdateBy = null;
                mappedCocktail.UpdateDate = null;
                mappedCocktail.Deleted = false;
                mappedCocktail.DeletedBy = 0;
                mappedCocktail.DeletedDate = null;

                _context.Cocktail.Add(mappedCocktail);
                await _context.SaveChangesAsync();
                return true;
        }

        public async Task<bool> UpdateCocktail(UpdateCocktailDto updateCocktailDto)
        {
            var matchingCocktail = _context.Cocktail.Find(updateCocktailDto.Id);
            if(matchingCocktail != null)
            {
                var mapping = _mapper.Map(updateCocktailDto, matchingCocktail);

                mapping.UpdateDate = DateTime.Now;
                mapping.UpdateBy = 1;
                _context.Update(mapping);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }

        }


        public async Task<CocktailDto> GetCocktailById(int id)
        {
            var matchingCocktail = _context.Cocktail.Find(id);

            var mappedMatchingCocktail = _mapper.Map<Cocktail,CocktailDto>(matchingCocktail);

            await _context.SaveChangesAsync();

            return mappedMatchingCocktail;
        }

        public async Task<bool> DeleteCocktail(int id)
        {
            var list = _context.Cocktail.ToList();
            var matchingCocktail = list.FirstOrDefault(cocktail => cocktail.Id == id);
            matchingCocktail.Deleted = true;
            matchingCocktail.DeletedBy = 1;
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
