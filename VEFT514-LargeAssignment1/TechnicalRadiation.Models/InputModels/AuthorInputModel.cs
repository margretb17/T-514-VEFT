using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models.InputModels
{
    public class AuthorInputModel
    {
        [Required(ErrorMessage = "Name required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url required")]
        [Url(ErrorMessage = "Url is not on the right format")] 
        public string ProfileImgSource { get; set; }

        [MaxLength(255)]
        public string Bio { get; set; }
    }
}