using BGlobalSolutionsExam.DataTransferObjects.ReadDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BGlobalSolutionsExam.DataTransferObjects.Factories.Dtos
{
    class VehicleDto : IVehicleDto
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public int BrandId { get; set; }
        public int NumberOfDoors { get; set; }
        public string Owner { get; set; }
        public bool IsActive { get; set; }
    }
}
