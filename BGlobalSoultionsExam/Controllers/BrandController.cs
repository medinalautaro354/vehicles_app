using BGlobalSolutionsExam.Interactors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BGlobalSolutionsExam.Controllers
{   [Route("brands")]
    public class BrandController : Controller
    {
        private readonly BrandInteractor interactor;

        public BrandController(BrandInteractor interactor)
        {
            this.interactor = interactor ?? throw new ArgumentNullException(nameof(interactor));
        }

        [HttpGet]
        public IEnumerable<EnumDto> Getall()
        {
            return interactor.GetAll();
        }
    }
}
