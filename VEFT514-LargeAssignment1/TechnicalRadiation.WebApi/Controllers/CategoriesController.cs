using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Services;
using TechnicalRadiation.Models;
using TechnicalRadiation.Models.Exceptions;
using TechnicalRadiation.WebApi.Extensions;
using TechnicalRadiation.WebApi.Attributes;

namespace TechnicalRadiation.WebApi.Controllers
{
    //*****Categories******//
    [Route("api")]
    public class CategoriesController : Controller
    {
        private TechnicalRadiationService _technicalRadiationService = new TechnicalRadiationService();

        // http://localhost:5000/api/categories        [GET]
        // Sækir alla flokka
        [Route("categories")]
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok(_technicalRadiationService.GetAllCategories());
        }

        // http://localhost:5000/api/categories/1        [GET]
        // Sækir flokk með eitthvað ákveðið id
        [Route("categories/{id:int}", Name = "GetCategoryById")]
        [HttpGet]
        public IActionResult GetCategoryById(int id)
        {
            return Ok(_technicalRadiationService.GetCategoryById(id));
        }

        /* AUTHORIZED ROUTES */

        [Route("categories", Name = "GetAllCategories")]
        [HttpPost]
        [Authorization]
        public IActionResult CreateNewCategory([FromBody] CategoryInputModel body)
        {
            if (!ModelState.IsValid) { throw new ModelFormatException(ModelState.RetrieveErrorString()); }

            var entity = _technicalRadiationService.CreateNewCategory(body);

            return CreatedAtRoute("GetAllCategories", new { id = entity.Id }, null);
        }

        // http://localhost:5000/api/1 
        // [PUT]
        [Route("categories/{id:int}", Name = "UpdateCategoryById")]
        [HttpPut]
        [Authorization]
        public IActionResult UpdateCategoryById([FromBody] CategoryInputModel category, int id)
        {
            if (!ModelState.IsValid) { throw new ModelFormatException(ModelState.RetrieveErrorString()); }

            _technicalRadiationService.UpdateCategoryById(category, id);

            return NoContent();
        }

        // http://localhost:5000/api/authors/1 
        // [DELETE]
        [Route("categories/{id:int}")]
        [HttpDelete]
        [Authorization]
        public IActionResult DeleteCategoryById(int id)
        {
            _technicalRadiationService.DeleteCategoryById(id);
            return NoContent();
        }

        [Route("categories/{categoryid:int}/newsItems/{newsitemid:int}")]
        [HttpPost]
        [Authorization]
        public IActionResult ConnectNewsIdByCategoryId(int categoryid, int newsitemid)
        {
            _technicalRadiationService.ConnectNewsIdByAuthorId(categoryid, newsitemid);
            return NoContent();
        }
    }
}