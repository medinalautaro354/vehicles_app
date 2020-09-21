using BGlobalSolutionsExam.DataTransferObjects.ReadDtos;
using BGlobalSolutionsExam.Dtos;
using BGlobalSolutionsExam.Interactors;
using BGlobalSolutionsExam.Interactors.Persistances;
using BGlobalSolutionsExam.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BGlobalSolutionsExam.Controllers
{
    [Route("vehicles")]
    public class VehicleController : Controller
    {
        private readonly AddVehicleInteractor addVehicleInteractor;
        private readonly VehicleInteractor vehicleInteractor;

        public VehicleController(AddVehicleInteractor addVehicleInteractor, VehicleInteractor vehicleInteractor)
        {
            this.addVehicleInteractor = addVehicleInteractor ?? throw new ArgumentNullException(nameof(addVehicleInteractor));
            this.vehicleInteractor = vehicleInteractor ?? throw new ArgumentNullException(nameof(vehicleInteractor));
        }

        [HttpPost]
        public async Task<IVehicle> Post([FromBody]AddVehicleDto addDto)
        {
            var result = await addVehicleInteractor.Add(addDto);

            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<IVehicleDto>> GetAllFilteredByActive()
        {
            return await vehicleInteractor.GetActives();
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View("Create");
        }

    }
}
