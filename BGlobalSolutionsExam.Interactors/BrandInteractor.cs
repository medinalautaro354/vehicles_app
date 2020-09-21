using BGlobalSolutionsExam.Model.Entities;
using System;
using System.Collections.Generic;

namespace BGlobalSolutionsExam.Interactors
{
    public class EnumDto
    {
        public int Id { get; set; }
        public string Name { get; set; } 
    }

    public class BrandInteractor
    {
        public IEnumerable<EnumDto> GetAll()
        {
            var brands = new Queue<EnumDto>();

            foreach (var brand in Enum.GetValues(typeof(Brand)))
            {
                brands.Enqueue(new EnumDto { Id = (int)brand, Name = brand.ToString()});
            }

            return brands;
        }
    }
}
