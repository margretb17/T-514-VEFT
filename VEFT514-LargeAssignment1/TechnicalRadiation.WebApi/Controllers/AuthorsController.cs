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
    [Route("/api/authors")]
    //[ApiController]
    public class AuthorsController : Controller
    {
        private TechnicalRadiationService _technicalRadiationService = new TechnicalRadiationService();

        /* UNAUTHORIZED ROUTES */

        // http://localhost:5000/api/authors
        // [GET] Sækir alla höfunda
        [Route("")]
        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            return Ok(_technicalRadiationService.GetAllAuthors());
        }

        // http://localhost:5000/api/authors/1
        // [GET] Sækir höfund með eitthvað ákveðið id
        [Route("{id:int}", Name = "GetAuthorById")]
        [HttpGet]
        public IActionResult GetAuthorById(int id)
        {
            return Ok(_technicalRadiationService.GetAuthorById(id));
        }

        // http://localhost:5000/api/authors/1/newsItem
        // [GET] Sækir allar fréttir eftir einhvern ákveðinn höfund
        [Route("{id:int}/newsItems")]
        [HttpGet]
        public IActionResult GetAllNewsByAuthorId(int id)
        {
            return Ok(_technicalRadiationService.GetAllNewsByAuthorId(id));
        }

        /* AUTHORIZED */

        // http://localhost:5000/api/authors
        // [POST] Býr til nýjan höfund
        [Route("", Name = "CreateNewAuthor")]
        [HttpPost]
        [Authorization]
        public IActionResult CreateNewAuthor([FromBody] AuthorInputModel body)
        {
            if (!ModelState.IsValid) { throw new ModelFormatException(ModelState.RetrieveErrorString()); }

            var entity = _technicalRadiationService.CreateNewAuthor(body);

            return CreatedAtRoute("GetAuthorById", new { id = entity.Id }, null);
        }

        // http://localhost:5000/api/authors/1 
        // [PUT]
        [Route("{id:int}", Name = "UpdateAuthorById")]
        [HttpPut]
        [Authorization]
        public IActionResult UpdateAuthorById([FromBody] AuthorInputModel author, int id)
        {
            if (!ModelState.IsValid) { throw new ModelFormatException(ModelState.RetrieveErrorString()); }

            _technicalRadiationService.UpdateAuthorById(author, id);

            return NoContent();
        }

        // http://localhost:5000/api/authors/1 
        // [DELETE]
        [Route("{id:int}")]
        [HttpDelete]
        [Authorization]
        public IActionResult DeleteAuthorById(int id)
        {
            _technicalRadiationService.DeleteAuthorById(id);
            return NoContent();
        }

        [Route("{authorid:int}/newsItems/{newsitemid:int}")]
        [HttpPost]
        [Authorization]
        public IActionResult ConnectNewsIdByAuthorId(int authorid, int newsitemid)
        {
            _technicalRadiationService.ConnectNewsIdByAuthorId(authorid, newsitemid);
            return NoContent();
        }

    }
}


