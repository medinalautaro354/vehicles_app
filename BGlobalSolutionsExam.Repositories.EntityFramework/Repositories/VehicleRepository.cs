using BGlobalSolutionsExam.Model.Entities;
using BGlobalSolutionsExam.Repositories.Entities;
using BGlobalSolutionsExam.Repositories.EntityFramework.Model;
using BGlobalSolutionsExam.Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BGlobalSolutionsExam.Repositories.EntityFramework.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly BGlobalSolutionsContext _context;

        public VehicleRepository(BGlobalSolutionsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IVehicle> Add(IVehicleAdd add)
        {
            var entry = await _context.AddAsync(MapToEntity(add));

            await _context.SaveChangesAsync();

            return entry.Entity;
        }

        private Vehicle MapToEntity(IVehicleAdd add) =>
            new Vehicle
            {
                Brand = add.Brand,
                LicensePlate = add.LicensePlate,
                NumberOfDoors = add.NumberOfDoors,
                Owner = add.Owner,
                IsActive = true
            };

        public async Task<IEnumerable<IVehicle>> GetActives()
        {
            var query = _context.Vehicles.Where(f => f.IsActive);
            await query.LoadAsync();
            return query;
        }
    }
}
