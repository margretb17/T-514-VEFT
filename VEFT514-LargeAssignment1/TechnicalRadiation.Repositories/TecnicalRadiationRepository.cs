using System;
using System.Collections.Generic;
using System.Linq;
using TechnicalRadiation.Models.Dtos;
using TechnicalRadiation.Models.Entities;
using TechnicalRadiation.Models.Exceptions;
using TechnicalRadiation.Models.InputModels;
using TechnicalRadiation.Repositories.Data;

namespace TechnicalRadiation.Repositories
{
    public class TecnicalRadiationRepository
    {
        public IEnumerable<NewsItemDto> GetAllNews()
        {
            return DataProvider.NewsItems.OrderByDescending(n => n.PublishDate).Select(r => new NewsItemDto
            {
                Id = r.Id,
                Title = r.Title,
                ImgSource = r.ImgSource,
                ShortDescription = r.ShortDescription
            });
        }

        public NewsItemDetailDto GetNewsById(int Id)
        {
            var entity = DataProvider.NewsItems.FirstOrDefault(r => r.Id == Id);
            if (entity == null) { return null; /* Throw exception */}
            return new NewsItemDetailDto
            {
                Id = entity.Id,
                Title = entity.Title,
                ImgSource = entity.ImgSource,
                ShortDescription = entity.ShortDescription,
                LongDescription = entity.LongDescription,
                PublishDate = entity.PublishDate
            };
        }

        public bool DoesExist(int id) => DataProvider.NewsItems.Any(g => g.Id == id);
        public NewsItemDetailDto CreateNewNews(NewsItemInputModel newsItem)
        {
            var nextId = DataProvider.NewsItems.OrderByDescending(r => r.Id).FirstOrDefault().Id + 1;
            var entity = new NewsItem
            {
                Id = nextId,
                Title = newsItem.Title,
                ImgSource = newsItem.ImgSource,
                ShortDescription = newsItem.ShortDescription,
                LongDescription = newsItem.LongDescription,
                PublishDate = newsItem.PublishDate,
                ModifiedBy = "NewsAdmin",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };
            DataProvider.NewsItems.Add(entity);
            return new NewsItemDetailDto
            {
                Id = entity.Id,
                Title = entity.Title,
                ImgSource = entity.ImgSource,
                ShortDescription = entity.ShortDescription,
                LongDescription = entity.LongDescription,
                PublishDate = entity.PublishDate
            };
        }
        public void UpdateNewsItemsById(NewsItemInputModel newsItem, int id)
        {
            var entity = DataProvider.NewsItems.FirstOrDefault(r => r.Id == id);
            if (entity == null) { throw new ModelFormatException(); }

            entity.Title = newsItem.Title;
            entity.ImgSource = newsItem.ImgSource;
            entity.ShortDescription = newsItem.ShortDescription;
            entity.LongDescription = newsItem.LongDescription;
            entity.PublishDate = newsItem.PublishDate;
            entity.ModifiedBy = "NewsAdmin";
            entity.CreatedDate = entity.CreatedDate;
            entity.ModifiedDate = DateTime.Now;
        }

        public void DeleteNewsById(int id)
        {
            var entity = DataProvider.NewsItems.FirstOrDefault(r => r.Id == id);
            DataProvider.NewsItems.Remove(entity);
        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            return DataProvider.Categories.Select(r => new CategoryDto
            {
                Id = r.Id,
                Name = r.Name,
                Slug = r.Slug
            });
        }
        public CategoryDetailDto GetCategoryById(int Id)
        {
            var entity = DataProvider.Categories.FirstOrDefault(r => r.Id == Id);
            var slug = entity.Name.ToLower().Replace(' ', '-');
            entity.Slug = slug;
            if (entity == null) { return null; /* throw some exception */ }
            return new CategoryDetailDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Slug = entity.Slug
            };
        }
        public IEnumerable<AuthorDto> GetAllAuthors()
        {
            return DataProvider.Authors.Select(r => new AuthorDto
            {
                Id = r.Id,
                Name = r.Name
            });
        }
        public AuthorDetailDto GetAuthorById(int Id)
        {
            var entity = DataProvider.Authors.FirstOrDefault(r => r.Id == Id);
            if (entity == null) { return null; /* throw some exception */ }
            return new AuthorDetailDto
            {
                Id = entity.Id,
                Name = entity.Name,
                ProfileImgSource = entity.ProfileImgSource,
                Bio = entity.Bio
            };
        }

        public List<NewsItemDto> GetAllNewsByAuthorId(int id)
        {
            var resultList = new List<NewsItemDto>();
            var listOfNewsItemsIds = DataProvider.NewsItemsAuthors.Where(x => x.AuthorId == id);

            foreach (var auth in listOfNewsItemsIds)
            {
                var entityDto = DataProvider.NewsItems.FirstOrDefault(r => r.Id == auth.NewsItemId);
                if (entityDto != null)
                {
                    var entity = new NewsItemDto()
                    {
                        Id = entityDto.Id,
                        Title = entityDto.Title,
                        ImgSource = entityDto.ImgSource,
                        ShortDescription = entityDto.ShortDescription
                    };
                    resultList.Add(entity);
                }
            };
            return resultList;
        }
        public AuthorDetailDto CreateNewAuthor(AuthorInputModel author)
        {
            var nextId = DataProvider.Authors.OrderByDescending(r => r.Id).FirstOrDefault().Id + 1;
            var entity = new Author
            {
                Id = nextId,
                Name = author.Name,
                ProfileImgSource = author.ProfileImgSource,
                Bio = author.Bio,
                ModifiedBy = "Admin",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };
            DataProvider.Authors.Add(entity);
            return new AuthorDetailDto
            {
                Id = entity.Id,
                Name = entity.Name,
                ProfileImgSource = entity.ProfileImgSource,
                Bio = entity.Bio
            };
        }

        public void UpdateAuthorById(AuthorInputModel author, int id)
        {
            var entity = DataProvider.Authors.FirstOrDefault(r => r.Id == id);
            if (entity == null) { throw new ModelFormatException(); }

            entity.Name = author.Name;
            entity.ProfileImgSource = author.ProfileImgSource;
            entity.Bio = author.Bio;
            //entity.ModifiedBy = "Admin";
            entity.CreatedDate = entity.CreatedDate;
            entity.ModifiedDate = DateTime.Now;
        }

        public void DeleteAuthorById(int id)
        {
            var entity = DataProvider.Authors.FirstOrDefault(r => r.Id == id);
            DataProvider.Authors.Remove(entity);
        }

        public void ConnectNewsIdByAuthorId(int authorid, int newsitemid)
        {
            var entity = new NewsItemAuthors
            {
                AuthorId = authorid,
                NewsItemId = newsitemid
            };
            DataProvider.NewsItemsAuthors.Add(entity);
        }

        public CategoryDetailDto CreateNewCategory(CategoryInputModel category)
        {
            var nextId = DataProvider.Categories.OrderByDescending(r => r.Id).FirstOrDefault().Id + 1;
            var entity = new Category
            {
                Id = nextId,
                Name = category.Name,
                ModifiedBy = "Admin",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            };
            DataProvider.Categories.Add(entity);
            return new CategoryDetailDto
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
        public void UpdateCategoryById(CategoryInputModel category, int id)
        {
            var entity = DataProvider.Categories.FirstOrDefault(r => r.Id == id);
            if (entity == null) { throw new ModelFormatException(); }

            entity.Name = category.Name;
            entity.ModifiedBy = "Admin";
            entity.CreatedDate = entity.CreatedDate;
            entity.ModifiedDate = DateTime.Now;
        }

        public void DeleteCategoryById(int id)
        {
            var entity = DataProvider.Categories.FirstOrDefault(r => r.Id == id);
            DataProvider.Categories.Remove(entity);
        }

        public void ConnectNewsIdByCategoryId(int categoryid, int newsitemid)
        {
            var entity = new NewsItemCategories
            {
                CategoryId = categoryid,
                NewsItemId = newsitemid
            };
            DataProvider.NewsItemsCategories.Add(entity);
        }
        public IEnumerable<AuthorDto> GetAuthorAfterNewsItemId(int id)
        {
            var entity = (from c in DataProvider.Authors
                          join n in DataProvider.NewsItemsAuthors on c.Id equals n.AuthorId
                          where n.NewsItemId == id
                          select new AuthorDto()
                          {
                              Id = c.Id,
                              Name = c.Name
                          }).ToList();

            return entity;
        }

        public IEnumerable<CategoryDto> GetCategorieAfterNewsItemId(int id)
        {
            var entity = (from c in DataProvider.Categories
                          join n in DataProvider.NewsItemsCategories on c.Id equals n.CategoryId
                          where n.NewsItemId == id
                          select new CategoryDto()
                          {
                              Id = c.Id,
                              Name = c.Name
                          }).ToList();

            return entity;
        }
    }
}