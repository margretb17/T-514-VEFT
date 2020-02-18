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
    [Route("/api")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private TechnicalRadiationService _technicalRadiationService = new TechnicalRadiationService();

        /* UNAUTHORIZED ROUTES */

        // http://localhost:5000/api
        // [GET] Sækir allar fréttir
        [Route("")]
        [HttpGet]
        public IActionResult GetAllNews([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 25)
        {
            var envelope = new Envelope<NewsItemDto>(pageNumber, pageSize, _technicalRadiationService.GetAllNews());
            return Ok(envelope);
        }

        // http://localhost:5000/api/1
        // [GET] Sækir frétt með eitthvað ákveðið id
        [Route("{id:int}", Name = "GetNewsById")]
        [HttpGet]
        public IActionResult GetNewsById(int id)
        {
            return Ok(_technicalRadiationService.GetNewsById(id));
        }

        /* AUTHORIZED ROUTES */

        // http://localhost:5000/api
        // [POST] Býr til nýja frétt
        [Route("", Name = "CreateNewNews")]
        [HttpPost]

        public IActionResult CreateNewNews([FromBody] NewsItemInputModel body)
        {
            if (!ModelState.IsValid) { throw new ModelFormatException(ModelState.RetrieveErrorString()); }

            var entity = _technicalRadiationService.CreateNewNews(body);

            return CreatedAtRoute("GetNewsById", new { id = entity.Id }, null);
        }

        // http://localhost:5000/api/1 
        // [PUT]
        [Route("{id:int}", Name = "UpdateNewsItemsById")]
        [HttpPut]
        [Authorization]
        public IActionResult UpdateNewsItemsById([FromBody] NewsItemInputModel newsItem, int id)
        {
            if (!ModelState.IsValid) { throw new ModelFormatException(ModelState.RetrieveErrorString()); }

            _technicalRadiationService.UpdateNewsItemsById(newsItem, id);

            return NoContent();
        }

        // http://localhost:5000/api/1 
        // [DELETE]
        [Route("{id:int}")]
        [HttpDelete]
        [Authorization]
        public IActionResult DeleteNewsById(int id)
        {
            _technicalRadiationService.DeleteNewsById(id);
            return NoContent();
        }
    }
}
