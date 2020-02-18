using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class NewsItemInputModel
    {
        [Required(ErrorMessage = "Title required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Url required")]
        [Url(ErrorMessage = "Url is not on the right format")]
        public string ImgSource { get; set; }

        [Required(ErrorMessage = "ShortDescription required")]
        [MinLength(0)]
        [MaxLength(50)]
        public string ShortDescription { get; set; }

        [MinLength(50)]
        [MaxLength(255)]
        public string LongDescription { get; set; }

        [Required(ErrorMessage = "Please input a date on the for 'MM DD YYYY'")]
        public DateTime PublishDate { get; set; }

    }

}