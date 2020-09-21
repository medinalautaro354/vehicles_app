using BGlobalSolutionsExam.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BGlobalSolutionsExam.DataTransferObjects.AddDtos
{
    public interface IAddVehicleDto
    {
        string LicensePlate { get; }
        Brand Brand { get; }
        int NumberOfDoors { get; }
        string Owner { get; }
    }
}
