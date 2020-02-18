using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.Exceptions;
using TechnicalRadiation.Models.Extensions;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories;

namespace TechnicalRadiation.Services
{
    public class TechnicalRadiationService
    {
        private TecnicalRadiationRepository _technicalRadiationRepository = new TecnicalRadiationRepository();

        public IEnumerable<NewsItemDto> GetAllNews()
        {
            var news = _technicalRadiationRepository.GetAllNews().ToList();
            news.ForEach(n =>
            {
                n.Links.AddReference("self", $"/api/{n.Id}");
                n.Links.AddReference("edit", $"/api/{n.Id}");
                n.Links.AddReference("delete", $"/api/{n.Id}");
                n.Links.AddListReference("authors", _technicalRadiationRepository.GetAuthorAfterNewsItemId(n.Id).Select(o => new { href = $"/api/authors/{o.Id}"}));
                n.Links.AddListReference("categories", _technicalRadiationRepository.GetCategorieAfterNewsItemId(n.Id).Select(o => new { href = $"/api/categories/{o.Id}" }));
            });
            return news;
        }

        public NewsItemDetailDto GetNewsById(int id)
        {
            if (id < 1) { throw new ArgumentOutOfRangeException("Id should not be lower than 1"); }
            if (!_technicalRadiationRepository.DoesExist(id)) { throw new ResourceNotFoundException($"News item with id {id} was not found."); }
            var news = _technicalRadiationRepository.GetNewsById(id);
            {
                news.Links.AddReference("self", $"/api/{news.Id}");
                news.Links.AddReference("edit", $"/api/{news.Id}");
                news.Links.AddReference("delete", $"/api/{news.Id}");
                news.Links.AddListReference("authors", _technicalRadiationRepository.GetAuthorAfterNewsItemId(news.Id).Select(o => new { href = $"/api/authors/{o.Id}" }));
                news.Links.AddListReference("categories", _technicalRadiationRepository.GetCategorieAfterNewsItemId(news.Id).Select(o => new { href = $"/api/categories/{o.Id}" }));
            };
            return news;
        }

        public NewsItemDetailDto CreateNewNews(NewsItemInputModel news)
        {
            return _technicalRadiationRepository.CreateNewNews(news);
        }
        public void UpdateNewsItemsById(NewsItemInputModel news, int id)
        {
            _technicalRadiationRepository.UpdateNewsItemsById(news, id);
        }

        public void DeleteNewsById(int id)
        {
            if (id < 1) { throw new ArgumentOutOfRangeException("Id should not be lower than 1"); }
            if (!_technicalRadiationRepository.DoesExist(id)) { throw new ResourceNotFoundException($"News item with id {id} was not found."); }
            _technicalRadiationRepository.DeleteNewsById(id);
        }
        public IEnumerable<CategoryDto> GetAllCategories()
        {
            var categories = _technicalRadiationRepository.GetAllCategories().ToList();
            categories.ForEach(c =>
            {
                c.Links.AddReference("self", $"/api/categories/{c.Id}");
                c.Links.AddReference("edit", $"/api/categories/{c.Id}");
                c.Links.AddReference("delete", $"/api/categories/{c.Id}");
            });
            return categories;
        }

        public CategoryDetailDto GetCategoryById(int id)
        {
            if (id < 1) { throw new ArgumentOutOfRangeException("Id should not be lower than 1"); }
            if (!_technicalRadiationRepository.DoesExist(id)) { throw new ResourceNotFoundException($"Category with id {id} was not found."); }
            var categories = _technicalRadiationRepository.GetCategoryById(id);
            {
                categories.Links.AddReference("self", $"/api/categories/{categories.Id}");
                categories.Links.AddReference("edit", $"/api/categories/{categories.Id}");
                categories.Links.AddReference("delete", $"/api/categories/{categories.Id}");
            };
            return categories;
        }

        public IEnumerable<AuthorDto> GetAllAuthors()
        {
            var authors = _technicalRadiationRepository.GetAllAuthors().ToList();
            authors.ForEach(a =>
            {
                a.Links.AddReference("self", $"/api/authors/{a.Id}");
                a.Links.AddReference("edit", $"/api/authors/{a.Id}");
                a.Links.AddReference("delete", $"/api/authors/{a.Id}");
                a.Links.AddListReference("newsItems", _technicalRadiationRepository.GetAllNewsByAuthorId(a.Id).Select(o => new { href = $"/api/authors/{o.Id}/newsItems" }));
                a.Links.AddListReference("NnewsItemsDetailed", _technicalRadiationRepository.GetCategorieAfterNewsItemId(a.Id).Select(o => new { href = $"/api/{o.Id}" }));
            });
            return authors;
        }

        public AuthorDetailDto GetAuthorById(int id)
        {
            if (id < 1) { throw new ArgumentOutOfRangeException("Id should not be lower than 1"); }
            if (!_technicalRadiationRepository.DoesExist(id)) { throw new ResourceNotFoundException($"Author with id {id} was not found."); }
            var author = _technicalRadiationRepository.GetAuthorById(id);
            {
                author.Links.AddReference("self", $"/api/authors/{author.Id}");
                author.Links.AddReference("edit", $"/api/authors/{author.Id}");
                author.Links.AddReference("delete", $"/api/authors/{author.Id}");
                author.Links.AddListReference("newsItems", _technicalRadiationRepository.GetAllNewsByAuthorId(author.Id).Select(o => new { href = $"/api/authors/{o.Id}/newsItems" }));
                author.Links.AddListReference("NnewsItemsDetailed", _technicalRadiationRepository.GetCategorieAfterNewsItemId(author.Id).Select(o => new { href = $"/api/{o.Id}" }));
            };
            return author;
        }

        public List<NewsItemDto> GetAllNewsByAuthorId(int id)
        {
            return _technicalRadiationRepository.GetAllNewsByAuthorId(id);
        }

        public AuthorDetailDto CreateNewAuthor(AuthorInputModel author)
        {
            return _technicalRadiationRepository.CreateNewAuthor(author);
        }

        public void UpdateAuthorById(AuthorInputModel author, int id)
        {
            _technicalRadiationRepository.UpdateAuthorById(author, id);
        }


         public void DeleteAuthorById(int id)
        {
            if (id < 1) { throw new ArgumentOutOfRangeException("Id should not be lower than 1"); }
            if (!_technicalRadiationRepository.DoesExist(id)) { throw new ResourceNotFoundException($"Author with id {id} was not found."); }
            _technicalRadiationRepository.DeleteAuthorById(id);
        }

        public CategoryDetailDto CreateNewCategory(CategoryInputModel category)
        {
            return _technicalRadiationRepository.CreateNewCategory(category);
        }

        public void UpdateCategoryById(CategoryInputModel category, int id)
        {
            _technicalRadiationRepository.UpdateCategoryById(category, id);
        }

        public void DeleteCategoryById(int id)
        {
            if (id < 1) { throw new ArgumentOutOfRangeException("Id should not be lower than 1"); }
            if (!_technicalRadiationRepository.DoesExist(id)) { throw new ResourceNotFoundException($"Category with id {id} was not found."); }
            _technicalRadiationRepository.DeleteCategoryById(id);
        }


        public void ConnectNewsIdByAuthorId(int authorid, int newsitemid)
        {
            _technicalRadiationRepository.ConnectNewsIdByAuthorId(authorid, newsitemid);
        }

        public void ConnectNewsIdByCategoryId(int categoryid, int newsitemid)
        {
            _technicalRadiationRepository.ConnectNewsIdByCategoryId(categoryid, newsitemid);
        }

        public IEnumerable<AuthorDto> GetAuthorAfterNewsItemId(int id)
        {
            return _technicalRadiationRepository.GetAuthorAfterNewsItemId(id);
        }

        public IEnumerable<CategoryDto> GetCategorieAfterNewsItemId(int id)
        {
            return _technicalRadiationRepository.GetCategorieAfterNewsItemId(id);
        }
    }
}