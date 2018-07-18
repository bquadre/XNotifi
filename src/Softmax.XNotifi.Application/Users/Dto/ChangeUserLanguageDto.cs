using System.ComponentModel.DataAnnotations;

namespace Softmax.XNotifi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}